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
        If Not System.Text.RegularExpressions.Regex.IsMatch(contact, "^\d{11}$") Then
            MessageBox.Show("Contact number must be exactly 11 digits.", "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContact.Focus()
            Exit Sub
        End If
        Try
            If IsEditMode Then

                Dim updateCmd As New Odbc.OdbcCommand("UPDATE tblcartlist SET QuantityBorrowed = ?, Contact = ?, Purpose = ? WHERE tempID = ?", con)
                With updateCmd.Parameters
                    .AddWithValue("?", CInt(nupQuantity.Value))
                    .AddWithValue("?", txtContact.Text.Trim())
                    .AddWithValue("?", txtPurpose.Text.Trim())
                    .AddWithValue("?", CartID)
                End With
                updateCmd.ExecuteNonQuery()
                MsgBox("Cart item updated successfully!", vbInformation)
                Me.Close()

            Else

                Try
                    Dim isValid As Boolean = True
                    Dim availableQty As Integer = 0


                    Dim totalqty As New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con)
                    totalqty.Parameters.AddWithValue("?", CInt(cbItemList.SelectedValue))
                    Dim availqtyObj = totalqty.ExecuteScalar()
                    If availqtyObj IsNot Nothing Then
                        availableQty = CInt(availqtyObj)
                    End If


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

                    Dim sID As Integer = -1, yID As Integer = -1, cID As Integer = -1
                    Dim studentCmd As New Odbc.OdbcCommand("SELECT sID, yID, cID FROM tblstudentlist WHERE TRIM(studentNo) = ?", con)
                    studentCmd.Parameters.AddWithValue("?", Trim(txtStudentNo.Text))
                    Dim rdr As Odbc.OdbcDataReader = studentCmd.ExecuteReader()
                    If rdr.Read() Then
                        sID = rdr("sID")
                        yID = rdr("yID")
                        cID = rdr("cID")
                    Else
                        MsgBox("Student not found. Please check the Student No.", vbCritical)
                        rdr.Close()
                        Exit Sub
                    End If
                    rdr.Close()


                    Dim tID As Integer = -1
                    Dim teacherCmd As New Odbc.OdbcCommand("SELECT tID FROM vw_teacher WHERE TRIM(teacher_fullname) = ?", con)
                    teacherCmd.Parameters.AddWithValue("?", Trim(txtTeacher.Text))
                    Dim resultT = teacherCmd.ExecuteScalar()
                    If resultT IsNot Nothing Then
                        tID = CInt(resultT)
                    Else
                        MsgBox("Teacher not found in the database!", vbCritical)
                        Exit Sub
                    End If


                    Dim settingID As Integer = -1
                    Dim settingCmd As New Odbc.OdbcCommand("SELECT settingID FROM tblsettings ORDER BY settingID ASC LIMIT 1", con)
                    Dim resultS = settingCmd.ExecuteScalar()
                    If resultS IsNot Nothing Then
                        settingID = CInt(resultS)
                    Else
                        MsgBox("No settings found. Please add school year and semester.", vbCritical)
                        Exit Sub
                    End If

                    Dim itemID As Integer = -1
                    Dim itemCmd As New Odbc.OdbcCommand("SELECT ItemID, ItemQuantity FROM tblitemlist WHERE ItemName = ?", con)
                    itemCmd.Parameters.AddWithValue("?", Trim(cbItemList.Text))
                    Dim itemRdr As Odbc.OdbcDataReader = itemCmd.ExecuteReader()
                    Dim availQty2 As Integer = 0
                    If itemRdr.Read() Then
                        itemID = itemRdr("ItemID")
                        availQty2 = itemRdr("ItemQuantity")
                    Else
                        MsgBox("Item not found in the item list!", vbCritical)
                        itemRdr.Close()
                        Exit Sub
                    End If
                    itemRdr.Close()
                    If nupQuantity.Value > availQty2 Then
                        MsgBox("Not enough stock! Only " & availQty2 & " available.", vbInformation)
                        Exit Sub
                    End If

                    Dim insertCmd As New Odbc.OdbcCommand("INSERT INTO tblcartlist (ItemID, BorrowerName, QuantityBorrowed, Contact, Purpose, borrowDateTime, Remarks, sID, tID, settingID, yID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con)
                    With insertCmd.Parameters
                        .AddWithValue("?", itemID)
                        .AddWithValue("?", txtBorrowerName.Text)
                        .AddWithValue("?", CInt(nupQuantity.Value))
                        .AddWithValue("?", txtContact.Text)
                        .AddWithValue("?", txtPurpose.Text)
                        .AddWithValue("?", dtpBorrowed.Value)
                        .AddWithValue("?", cbBorrowRemarks.Text)
                        .AddWithValue("?", sID)
                        .AddWithValue("?", tID)
                        .AddWithValue("?", settingID)
                        .AddWithValue("?", yID)
                    End With

                    insertCmd.ExecuteNonQuery()
                    'new ad this line
                   

                    MsgBox("Item added to cart successfully!", vbInformation)

                    Call listLoader()
                    cbItemList.SelectedIndex = -1
                    nupQuantity.Value = 0
                    txtContact.Clear()
                    txtPurpose.Clear()
                    cbBorrowRemarks.SelectedIndex = -1
                    RaiseEvent ItemAdded(Me, EventArgs.Empty)
                    Me.Close()

                Catch ex2 As Exception
                    MsgBox("Error inserting cart item: " & ex2.Message, vbCritical)
                End Try
            End If

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


End Class