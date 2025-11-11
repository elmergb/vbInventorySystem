Public Class frmBorrowDE
    Public SelectedItemID As Integer
    Public IsEditMode As Boolean = False
    Public Event ItemAdded As EventHandler

    Public CartID As Integer  ' if you have a key for each cart row

    Private Sub frmBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim qty As Integer = CInt(nupQuantity.Value)
        Call cb_loader("SELECT * FROM tblitemlist", cbItemList, "ItemName", "ItemID")

        If SelectedItemID > 0 Then
            cbItemList.SelectedValue = SelectedItemID
        End If
        cbBorrowRemarks.Items.Clear()
        cbBorrowRemarks.Items.Add("Good")

    End Sub

    Private Sub btnCart_Click(ByVal sender As Object, ByVal e As EventArgs)
        frmCartListView.ShowDialog()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim contact As String = txtContact.Text.Trim()

        ' Validate contact number
        If Not System.Text.RegularExpressions.Regex.IsMatch(contact, "^\d{11}$") Then
            MessageBox.Show("Contact number must be exactly 11 digits.", "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContact.Focus()
            Exit Sub
        End If

        Try
            If IsEditMode Then
                ' --- Edit existing cart item ---
                ' We'll update quantity and handle reserved units accordingly
                Dim getOldQtyCmd As New Odbc.OdbcCommand("SELECT QuantityBorrowed, ItemID FROM tblcartlist WHERE tempID = ?", con)
                getOldQtyCmd.Parameters.AddWithValue("?", CartID)

                Dim oldQty As Integer = 0
                Dim itemID As Integer = 0
                Using rdr As Odbc.OdbcDataReader = getOldQtyCmd.ExecuteReader()
                    If rdr.Read() Then
                        oldQty = Convert.ToInt32(rdr("QuantityBorrowed"))
                        itemID = Convert.ToInt32(rdr("ItemID"))
                    End If
                End Using

                Dim newQty As Integer = CInt(nupQuantity.Value)
                Dim diff As Integer = newQty - oldQty

                ' Begin transaction to adjust stock and reservations atomically
                Using trans As Odbc.OdbcTransaction = con.BeginTransaction()
                    Try
                        If diff <> 0 Then
                            If diff > 0 Then
                                ' Need to reserve additional units
                                ' Check itemlist stock first
                                Using checkQtyCmd As New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con, trans)
                                    checkQtyCmd.Parameters.AddWithValue("?", itemID)
                                    Dim availableQty As Integer = Convert.ToInt32(checkQtyCmd.ExecuteScalar())
                                    If availableQty < diff Then
                                        MsgBox("Not enough stock available to increase quantity.", vbExclamation)
                                        trans.Rollback()
                                        Exit Sub
                                    End If
                                End Using

                                ' Reserve `diff` additional units (SELECT ... FOR UPDATE, LIMIT diff)
                                Dim sqlReserve As String = "SELECT UnitID, SerialNo FROM tblitemunits " &
                                                           "WHERE ItemID = ? AND ItemStatus = 'Available' " &
                                                           "ORDER BY UnitID ASC LIMIT " & diff.ToString() & " FOR UPDATE"
                                Using cmdReserve As New Odbc.OdbcCommand(sqlReserve, con, trans)
                                    cmdReserve.Parameters.AddWithValue("?", itemID)
                                    Dim listReserve As New List(Of Tuple(Of Integer, String))
                                    Using rdrRes As Odbc.OdbcDataReader = cmdReserve.ExecuteReader()
                                        While rdrRes.Read()
                                            listReserve.Add(Tuple.Create(CInt(rdrRes("UnitID")), rdrRes("SerialNo").ToString()))
                                        End While
                                    End Using

                                    If listReserve.Count < diff Then
                                        MsgBox("Not enough available units to reserve. Operation cancelled.", vbExclamation)
                                        trans.Rollback()
                                        Exit Sub
                                    End If

                                    ' Insert reserves into tblcartserials and mark units Reserved
                                    For Each t In listReserve
                                        Using insCmd As New Odbc.OdbcCommand("INSERT INTO tblcartserials (CartID, UnitID, SerialNo) VALUES (?, ?, ?)", con, trans)
                                            insCmd.Parameters.AddWithValue("?", CartID)
                                            insCmd.Parameters.AddWithValue("?", t.Item1)
                                            insCmd.Parameters.AddWithValue("?", t.Item2)
                                            insCmd.ExecuteNonQuery()
                                        End Using
                                        Using updUnit As New Odbc.OdbcCommand("UPDATE tblitemunits SET ItemStatus='Reserved' WHERE UnitID = ?", con, trans)
                                            updUnit.Parameters.AddWithValue("?", t.Item1)
                                            updUnit.ExecuteNonQuery()
                                        End Using
                                    Next
                                End Using

                                ' Decrease itemlist quantity
                                Using updList As New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ItemQuantity - ? WHERE ItemID = ?", con, trans)
                                    updList.Parameters.AddWithValue("?", diff)
                                    updList.Parameters.AddWithValue("?", itemID)
                                    updList.ExecuteNonQuery()
                                End Using

                            Else
                                ' diff < 0 → release some reserved units back to Available
                                Dim toRelease As Integer = Math.Abs(diff)
                                ' select the last reserved units for this cart (so we remove newest ones)
                                Using cmdGetReserved As New Odbc.OdbcCommand("SELECT CartSerialID, UnitID FROM tblcartserials WHERE CartID = ? ORDER BY CartSerialID DESC LIMIT " & toRelease.ToString(), con, trans)
                                    cmdGetReserved.Parameters.AddWithValue("?", CartID)
                                    Dim releaseList As New List(Of Integer)
                                    Using rdrRel As Odbc.OdbcDataReader = cmdGetReserved.ExecuteReader()
                                        While rdrRel.Read()
                                            releaseList.Add(CInt(rdrRel("UnitID")))
                                        End While
                                    End Using

                                    ' Delete those cartserials rows
                                    Using delCmd As New Odbc.OdbcCommand("DELETE FROM tblcartserials WHERE CartID = ? AND UnitID = ?", con, trans)
                                        For Each uid In releaseList
                                            delCmd.Parameters.Clear()
                                            delCmd.Parameters.AddWithValue("?", CartID)
                                            delCmd.Parameters.AddWithValue("?", uid)
                                            delCmd.ExecuteNonQuery()
                                            ' mark unit available
                                            Using updUnit As New Odbc.OdbcCommand("UPDATE tblitemunits SET ItemStatus='Available' WHERE UnitID = ?", con, trans)
                                                updUnit.Parameters.AddWithValue("?", uid)
                                                updUnit.ExecuteNonQuery()
                                            End Using
                                        Next
                                    End Using
                                End Using

                                ' Restore itemlist quantity
                                Using updList As New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ItemQuantity + ? WHERE ItemID = ?", con, trans)
                                    updList.Parameters.AddWithValue("?", toRelease)
                                    updList.Parameters.AddWithValue("?", itemID)
                                    updList.ExecuteNonQuery()
                                End Using
                            End If
                        End If

                        ' Update cart row (quantity/contact/purpose)
                        Using updateCartCmd As New Odbc.OdbcCommand("UPDATE tblcartlist SET QuantityBorrowed = ?, Contact = ?, Purpose = ? WHERE tempID = ?", con, trans)
                            updateCartCmd.Parameters.AddWithValue("?", newQty)
                            updateCartCmd.Parameters.AddWithValue("?", txtContact.Text.Trim())
                            updateCartCmd.Parameters.AddWithValue("?", txtPurpose.Text.Trim())
                            updateCartCmd.Parameters.AddWithValue("?", CartID)
                            updateCartCmd.ExecuteNonQuery()
                        End Using

                        trans.Commit()
                        MsgBox("Cart item updated successfully!", vbInformation)
                        Me.Close()
                    Catch exTrans As Exception
                        trans.Rollback()
                        MsgBox("Error updating cart item: " & exTrans.Message, MsgBoxStyle.Critical)
                    End Try
                End Using

            Else
                ' --- Add new cart item ---
                Dim availableQty As Integer = 0
                Using totalQtyCmd As New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con)
                    totalQtyCmd.Parameters.AddWithValue("?", CInt(cbItemList.SelectedValue))
                    Dim availQtyObj = totalQtyCmd.ExecuteScalar()
                    If availQtyObj IsNot Nothing Then availableQty = CInt(availQtyObj)
                End Using

                ' Validation
                If nupQuantity.Value = 0 Then
                    MsgBox("Invalid quantity", vbExclamation)
                    Exit Sub
                End If
                If txtPurpose.Text.Trim() = "" Or txtContact.Text.Trim() = "" Then
                    MsgBox("Please fill in Contact and Purpose", vbExclamation)
                    Exit Sub
                End If
                If nupQuantity.Value > availableQty Then
                    MsgBox("Not enough stock! Only " & availableQty & " left", vbInformation)
                    Exit Sub
                End If

                ' Get student info
                Dim sID As Integer = -1, yID As Integer = -1, cID As Integer = -1
                Using studentCmd As New Odbc.OdbcCommand("SELECT sID, yID, cID FROM tblstudentlist WHERE TRIM(studentNo) = ?", con)
                    studentCmd.Parameters.AddWithValue("?", Trim(txtStudentNo.Text))
                    Using rdr As Odbc.OdbcDataReader = studentCmd.ExecuteReader()
                        If rdr.Read() Then
                            sID = rdr("sID")
                            yID = rdr("yID")
                            cID = rdr("cID")
                        Else
                            MsgBox("Student not found. Please check the Student No.", vbCritical)
                            Exit Sub
                        End If
                    End Using
                End Using

                ' Get teacher ID
                Dim tID As Integer = -1
                Using teacherCmd As New Odbc.OdbcCommand("SELECT tID FROM vw_teacher WHERE TRIM(teacher_fullname) = ?", con)
                    teacherCmd.Parameters.AddWithValue("?", Trim(txtTeacher.Text))
                    Dim resultT = teacherCmd.ExecuteScalar()
                    If resultT IsNot Nothing Then
                        tID = CInt(resultT)
                    Else
                        MsgBox("Teacher not found in the database!", vbCritical)
                        Exit Sub
                    End If
                End Using

                ' Get setting ID
                Dim settingID As Integer = -1
                Using settingCmd As New Odbc.OdbcCommand("SELECT settingID FROM tblsettings ORDER BY settingID ASC LIMIT 1", con)
                    Dim resultS = settingCmd.ExecuteScalar()
                    If resultS IsNot Nothing Then
                        settingID = CInt(resultS)
                    Else
                        MsgBox("No settings found. Please add school year and semester.", vbCritical)
                        Exit Sub
                    End If
                End Using

                ' Get item ID and available quantity (again)
                Dim itemID As Integer = -1
                Dim availQty2 As Integer = 0
                Using itemCmd As New Odbc.OdbcCommand("SELECT ItemID, ItemQuantity FROM tblitemlist WHERE ItemName = ?", con)
                    itemCmd.Parameters.AddWithValue("?", Trim(cbItemList.Text))
                    Using itemRdr As Odbc.OdbcDataReader = itemCmd.ExecuteReader()
                        If itemRdr.Read() Then
                            itemID = itemRdr("ItemID")
                            availQty2 = itemRdr("ItemQuantity")
                        Else
                            MsgBox("Item not found in the item list!", vbCritical)
                            Exit Sub
                        End If
                    End Using
                End Using
                If nupQuantity.Value > availQty2 Then
                    MsgBox("Not enough stock! Only " & availQty2 & " available.", vbInformation)
                    Exit Sub
                End If

                ' Insert into cart and reserve serials in a transaction
                Using trans As Odbc.OdbcTransaction = con.BeginTransaction()
                    Try
                        Dim borrowQty As Integer = CInt(nupQuantity.Value)

                        ' 1) Insert cart row
                        Using insertCmd As New Odbc.OdbcCommand("INSERT INTO tblcartlist (ItemID, BorrowerName, QuantityBorrowed, Contact, Purpose, borrowDateTime, Remarks, sID, tID, settingID, yID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con, trans)
                            insertCmd.Parameters.AddWithValue("?", itemID)
                            insertCmd.Parameters.AddWithValue("?", txtBorrowerName.Text)
                            insertCmd.Parameters.AddWithValue("?", borrowQty)
                            insertCmd.Parameters.AddWithValue("?", txtContact.Text)
                            insertCmd.Parameters.AddWithValue("?", txtPurpose.Text)
                            insertCmd.Parameters.AddWithValue("?", dtpBorrowed.Value)
                            insertCmd.Parameters.AddWithValue("?", cbBorrowRemarks.Text)
                            insertCmd.Parameters.AddWithValue("?", sID)
                            insertCmd.Parameters.AddWithValue("?", tID)
                            insertCmd.Parameters.AddWithValue("?", settingID)
                            insertCmd.Parameters.AddWithValue("?", yID)
                            insertCmd.ExecuteNonQuery()
                        End Using

                        ' get cartID
                        Dim cartID As Integer = Convert.ToInt32(New Odbc.OdbcCommand("SELECT LAST_INSERT_ID()", con, trans).ExecuteScalar())

                        ' 2) Select available serials and reserve them (LIMIT cannot be parameterized -> concat)
                        Dim sqlSerial As String = "SELECT UnitID, SerialNo FROM tblitemunits " &
                                                  "WHERE ItemID = ? AND ItemStatus = 'Available' " &
                                                  "ORDER BY UnitID ASC LIMIT " & borrowQty.ToString() & " FOR UPDATE"
                        Using cmdSerial As New Odbc.OdbcCommand(sqlSerial, con, trans)
                            cmdSerial.Parameters.AddWithValue("?", itemID)
                            Dim reservedSerials As New List(Of Tuple(Of Integer, String))
                            Using rdrSerial As Odbc.OdbcDataReader = cmdSerial.ExecuteReader()
                                While rdrSerial.Read()
                                    reservedSerials.Add(Tuple.Create(CInt(rdrSerial("UnitID")), rdrSerial("SerialNo").ToString()))
                                End While
                            End Using

                            If reservedSerials.Count < borrowQty Then
                                MsgBox("Not enough available units to reserve. Operation cancelled.", vbExclamation)
                                trans.Rollback()
                                Exit Sub
                            End If

                            ' 3) Insert into tblcartserials and mark units Reserved
                            For Each t In reservedSerials
                                Using insCartSerial As New Odbc.OdbcCommand("INSERT INTO tblcartserials (CartID, UnitID, SerialNo) VALUES (?, ?, ?)", con, trans)
                                    insCartSerial.Parameters.AddWithValue("?", cartID)
                                    insCartSerial.Parameters.AddWithValue("?", t.Item1)
                                    insCartSerial.Parameters.AddWithValue("?", t.Item2)
                                    insCartSerial.ExecuteNonQuery()
                                End Using

                                Using updUnit As New Odbc.OdbcCommand("UPDATE tblitemunits SET ItemStatus='Reserved' WHERE UnitID = ?", con, trans)
                                    updUnit.Parameters.AddWithValue("?", t.Item1)
                                    updUnit.ExecuteNonQuery()
                                End Using
                            Next
                        End Using

                        ' 4) Decrease itemlist quantity
                        Using updList As New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ItemQuantity - ? WHERE ItemID = ?", con, trans)
                            updList.Parameters.AddWithValue("?", borrowQty)
                            updList.Parameters.AddWithValue("?", itemID)
                            updList.ExecuteNonQuery()
                        End Using

                        trans.Commit()
                        MsgBox("Item added to cart and serials reserved successfully!", vbInformation)

                        ' Refresh UI
                        
                    Catch exTrans As Exception
                        trans.Rollback()
                        MsgBox("Error reserving serials / adding to cart: " & exTrans.Message, vbCritical)
                    End Try
                End Using
            End If
            listLoader()
            cbItemList.SelectedIndex = -1
            nupQuantity.Value = 0
            txtContact.Clear()
            txtPurpose.Clear()
            cbBorrowRemarks.SelectedIndex = -1
            RaiseEvent ItemAdded(Me, EventArgs.Empty)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtContact_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtContact.TextChanged

    End Sub
End Class