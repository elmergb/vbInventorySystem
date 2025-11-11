Public Class frmBorrowingDE

    Private Sub frmBorrowerCartList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call vbConnection()
        cbSort.Items.Clear()
        cbSort.Items.AddRange({"Name", "Description", "Category", "Location"})
        cbSort.SelectedIndex = 0
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")
        Call data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Items", dgvItemList)
        cb_loader("SELECT * FROM vw_teacher", cbTeacher, "teacher_fullname", "tID")
        For Each col As DataGridViewColumn In dgvItemList.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
            With dgvItemList
                .EnableHeadersVisualStyles = False
                .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .ColumnHeadersHeight = 35
                .RowTemplate.Height = 35
                .AllowUserToAddRows = False
                .RowHeadersVisible = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .CellBorderStyle = DataGridViewCellBorderStyle.Single
                .GridColor = Color.LightGray
                .BorderStyle = BorderStyle.None
            End With
        Next

        'new 

        Try
            ' Check if there are items in the cart
            Dim cmdCheck As New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblcartlist", con)
            Dim cartCount As Integer = CInt(cmdCheck.ExecuteScalar())

            If cartCount > 0 Then
                ' Ask user
                If MsgBox("You still have items in your cart. Do you want to borrow them now?",
                          vbYesNo + vbQuestion, "Warning") = vbYes Then

                    ' ✅ Borrow now
                    Dim transaction As Odbc.OdbcTransaction = con.BeginTransaction()
                    Try
                        ' Select all cart items
                        Dim cmdSelect As New Odbc.OdbcCommand("SELECT * FROM tblcartlist", con, transaction)
                        Dim reader As Odbc.OdbcDataReader = cmdSelect.ExecuteReader()

                        Dim cartIDs As New List(Of Integer) ' to update serials

                        While reader.Read()
                            ' Insert into borrowing table
                            Dim insertCmd As New Odbc.OdbcCommand("INSERT INTO tblborrowing (ItemID, borrowQty, borrowDateTime, sID, tID, semester, settingID, remarks, Contact, Purpose, yID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con, transaction)
                            With insertCmd.Parameters
                                .AddWithValue("@ItemID", reader("ItemID"))
                                .AddWithValue("@borrowQty", reader("QuantityBorrowed"))
                                .AddWithValue("@borrowDateTime", reader("borrowDateTime"))
                                .AddWithValue("@sID", reader("sID"))
                                .AddWithValue("@tID", reader("tID"))
                                .AddWithValue("@semester", txtSemester.Text)
                                .AddWithValue("@settingID", reader("settingID"))
                                .AddWithValue("@remarks", reader("Remarks"))
                                .AddWithValue("@Contact", reader("Contact"))
                                .AddWithValue("@Purpose", reader("Purpose"))
                                .AddWithValue("@yID", reader("yID"))
                                insertCmd.ExecuteNonQuery()
                            End With

                            cartIDs.Add(CInt(reader("tempID")))
                        End While
                        reader.Close()

                        ' ✅ Update reserved units to Borrowed
                        For Each cartID In cartIDs
                            Using cmdUpdateUnits As New Odbc.OdbcCommand("UPDATE tblitemunits SET ItemStatus='Borrowed' WHERE UnitID IN (SELECT UnitID FROM tblcartserials WHERE CartID=?)", con, transaction)
                                cmdUpdateUnits.Parameters.AddWithValue("?", cartID)
                                cmdUpdateUnits.ExecuteNonQuery()
                            End Using
                        Next

                        ' Delete cartserials for these carts
                        For Each cartID In cartIDs
                            Using cmdDelSerials As New Odbc.OdbcCommand("DELETE FROM tblcartserials WHERE CartID=?", con, transaction)
                                cmdDelSerials.Parameters.AddWithValue("?", cartID)
                                cmdDelSerials.ExecuteNonQuery()
                            End Using
                        Next

                        ' Delete cart rows
                        Dim cmdDelete As New Odbc.OdbcCommand("DELETE FROM tblcartlist", con, transaction)
                        cmdDelete.ExecuteNonQuery()

                        transaction.Commit()
                        MsgBox("All items borrowed successfully! Status updated to 'Borrowed'.", vbInformation)

                    Catch exTrans As Exception
                        transaction.Rollback()
                        MsgBox("Error borrowing items: " & exTrans.Message, vbCritical)
                    End Try

                Else
                    ' User clicked NO → Restore quantities and clear cart
                    Dim transaction As Odbc.OdbcTransaction = con.BeginTransaction()
                    Try
                        ' 1) Restore item quantities
                        Dim cmdSelect As New Odbc.OdbcCommand("SELECT ItemID, QuantityBorrowed, tempID FROM tblcartlist", con, transaction)
                        Dim reader As Odbc.OdbcDataReader = cmdSelect.ExecuteReader()

                        Dim cartIDs As New List(Of Integer)

                        While reader.Read()
                            ' Restore quantity in tblitemlist
                            Using updateCmd As New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ItemQuantity + ? WHERE ItemID = ?", con, transaction)
                                updateCmd.Parameters.AddWithValue("?", reader("QuantityBorrowed"))
                                updateCmd.Parameters.AddWithValue("?", reader("ItemID"))
                                updateCmd.ExecuteNonQuery()
                            End Using

                            ' Save cartID to release units later
                            cartIDs.Add(CInt(reader("tempID")))
                        End While
                        reader.Close()

                        ' 2) Release reserved units back to Available
                        For Each cartID In cartIDs
                            Using cmdUpdateUnits As New Odbc.OdbcCommand("UPDATE tblitemunits SET ItemStatus='Available' WHERE UnitID IN (SELECT UnitID FROM tblcartserials WHERE CartID=?)", con, transaction)
                                cmdUpdateUnits.Parameters.AddWithValue("?", cartID)
                                cmdUpdateUnits.ExecuteNonQuery()
                            End Using
                        Next

                        ' 3) Delete cartserials for these carts
                        For Each cartID In cartIDs
                            Using cmdDelSerials As New Odbc.OdbcCommand("DELETE FROM tblcartserials WHERE CartID=?", con, transaction)
                                cmdDelSerials.Parameters.AddWithValue("?", cartID)
                                cmdDelSerials.ExecuteNonQuery()
                            End Using
                        Next

                        ' 4) Delete cart rows
                        Dim cmdDelete As New Odbc.OdbcCommand("DELETE FROM tblcartlist", con, transaction)
                        cmdDelete.ExecuteNonQuery()

                        transaction.Commit()
                        MsgBox("Cart cleared and quantities restored. All items are now available.", vbInformation)

                    Catch exRest As Exception
                        transaction.Rollback()
                        MsgBox("Error clearing cart: " & exRest.Message)
                    End Try
                End If
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ' Refresh the item list view
            Call data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Items", dgvItemList)
            frmCartListView.lvCart.Clear()
        End Try

       
    End Sub
  

    Private Sub dgvItemList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItemList.CellClick
        'medyo confusing pa 
        If e.RowIndex >= 0 Then
            dgvItemList.Tag = dgvItemList.Rows(e.RowIndex).Cells("Item").Value
            frmBorrowDE.cbItemList.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString
            frmBorrowDE.txtItemDesc.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemDescription").Value.ToString
            frmAddItem.cbCategory.Text = dgvItemList.Rows(e.RowIndex).Cells("Category").Value.ToString()
            frmAddItem.cbLocation.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemLocation").Value.ToString()
            frmAddItem.nupQuantity.Value = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
            Dim qty As Object = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
            If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
                frmAddItem.nupQuantity.Value = CInt(qty)
            Else
                frmAddItem.nupQuantity.Value = 0
            End If

        End If
        'If e.RowIndex >= 0 Then
        '    dgvItemList.Tag = dgvItemList.Rows(e.RowIndex).Cells("Item").Value

        '    frmAddItem.txtNameOFItem.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString
        '    frmAddItem.txtItemDesc.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemDescription").Value.ToString
        '    frmAddItem.cbCategory.Text = dgvItemList.Rows(e.RowIndex).Cells("Category").Value.ToString()
        '    frmAddItem.cbLocation.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemLocation").Value.ToString()
        '    frmAddItem.nupQuantity.Value = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
        '    Dim qty As Object = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
        '    If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
        '        frmAddItem.nupQuantity.Value = CInt(qty)
        '    Else
        '        frmAddItem.nupQuantity.Value = 0
        '    End If

        'End If
    End Sub
    Private Sub ClearStudentInfo()
        txtfname.Clear()
        txtmi.Clear()
        txtlname.Clear()
        txtCourse.Clear()
        txtSection.Clear()
        txtYearLevel.Clear()
        txtSemester.Clear()
        txtSchoolYear.Clear()
    End Sub
    Private Sub PerformSearch()
        Dim searchValue As String = txtSearch.Text.Trim()
        Dim searchField As String = ""

        ' Determine which column to search based on ComboBox selection
        Select Case cbSort.Text
            Case "Name"
                searchField = "Name"
            Case "Description"
                searchField = "ItemDescription"
            Case "Category"
                searchField = "ItemCategory"
            Case "Location"
                searchField = "ItemLocation"
            Case Else
                Exit Sub
        End Select

        ' ✅ Add a space before WHERE + corrected column names
        Dim query As String = "SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity " &
                              "FROM vw_Items WHERE " & searchField & " LIKE ?"

        Try
            Using cmd As New Odbc.OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", "%" & searchValue & "%")

                Dim da As New Odbc.OdbcDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvItemList.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error during search: " & ex.Message)
        End Try
    End Sub

    Public Sub LoadStudentData(ByVal studentNo As String)
       Try
            Dim query As String = "SELECT fname, mi, lname, cCode, section, yDesc FROM vw_students WHERE StudentNo = ?"
            Using cmd As New Odbc.OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", studentNo)
                Using reader As Odbc.OdbcDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtfname.Text = reader("fname").ToString()
                        txtmi.Text = reader("mi").ToString()
                        txtlname.Text = reader("lname").ToString()
                        txtCourse.Text = reader("cCode").ToString()
                        txtSection.Text = reader("section").ToString()
                        txtYearLevel.Text = reader("yDesc").ToString()
                    Else
                        MessageBox.Show("Student not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearStudentInfo()
                        Exit Sub
                    End If
                End Using
            End Using

            ' Load current semester and school year
            Dim semYearCmd As New Odbc.OdbcCommand("SELECT currentSemester, currentSchoolYear FROM tblsettings LIMIT 1", con)
            Using semReader As Odbc.OdbcDataReader = semYearCmd.ExecuteReader()
                If semReader.Read() Then
                    txtSemester.Text = semReader("currentSemester").ToString()
                    txtSchoolYear.Text = semReader("currentSchoolYear").ToString()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message)
            ClearStudentInfo()
        End Try
    End Sub

    Private Sub txtStudentNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStudentNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadStudentData(txtStudentNo.Text)

        End If
    End Sub

    Private Sub btnBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrow.Click
        Try
            frmBorrowDE.nupQuantity.Value = 0
            If txtStudentNo.Text.Trim() = " " Or txtStudentNo.Text.Trim() = "" Then
                MsgBox("Insert Student No. First")
                Exit Sub
            End If
            If (dgvItemList.Tag) = 0 Then
                MsgBox("Select an item to borrow!", vbInformation, "Select Item")
            Else
                frmBorrowDE.cbBorrowRemarks.Text = "Good"
                frmBorrowDE.txtYearLevel.Text = txtYearLevel.Text
                frmBorrowDE.txtSchoolYear.Text = txtSchoolYear.Text
                frmBorrowDE.txtSemester.Text = txtSemester.Text
                frmBorrowDE.txtTeacher.Text = cbTeacher.Text
                frmBorrowDE.txtStudentNo.Text = txtStudentNo.Text
                frmBorrowDE.SelectedItemID = Val(dgvItemList.Tag)
                frmBorrowDE.ShowDialog()
                Call data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Items", dgvItemList)
            End If

        Catch ex As Exception
            Call data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Items", dgvItemList)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtStudentNo.Text) Then
            MsgBox("Please select a student before saving.", vbExclamation)
            Exit Sub
        End If

        Dim cmdCheck As New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblcartlist", con)
        Dim itemCount As Integer = CInt(cmdCheck.ExecuteScalar())
        If itemCount = 0 Then
            MsgBox("No items found in the cart to save.", vbExclamation)
            Exit Sub
        End If

        Using trans As Odbc.OdbcTransaction = con.BeginTransaction()
            Try
                ' Iterate through cart rows
                Using cmdSelect As New Odbc.OdbcCommand("SELECT * FROM tblcartlist", con, trans)
                    Using reader As Odbc.OdbcDataReader = cmdSelect.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                Dim cartID As Integer = CInt(reader("tempID"))
                                Dim itemID As Integer = CInt(reader("ItemID"))
                                Dim qty As Integer = CInt(reader("QuantityBorrowed"))

                                ' 1) Insert into tblborrowing
                                Using insertBorrow As New Odbc.OdbcCommand("INSERT INTO tblborrowing (ItemID, borrowQty, borrowDateTime, sID, tID, semester, settingID, remarks, Contact, Purpose, yID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con, trans)

                                    insertBorrow.Parameters.AddWithValue("?", itemID)
                                    insertBorrow.Parameters.AddWithValue("?", qty)
                                    insertBorrow.Parameters.AddWithValue("?", reader("borrowDateTime"))
                                    insertBorrow.Parameters.AddWithValue("?", reader("sID"))
                                    insertBorrow.Parameters.AddWithValue("?", reader("tID"))
                                    insertBorrow.Parameters.AddWithValue("?", "semester")
                                    insertBorrow.Parameters.AddWithValue("?", reader("settingID"))
                                    insertBorrow.Parameters.AddWithValue("?", reader("Remarks"))
                                    insertBorrow.Parameters.AddWithValue("?", reader("Contact"))
                                    insertBorrow.Parameters.AddWithValue("?", reader("Purpose"))
                                    insertBorrow.Parameters.AddWithValue("?", reader("yID"))
                                    insertBorrow.ExecuteNonQuery()
                                End Using

                                Dim borrowID As Integer = Convert.ToInt32(New Odbc.OdbcCommand("SELECT LAST_INSERT_ID()", con, trans).ExecuteScalar())

                                ' 2) Get reserved serials for this cart
                                Dim reservedUnits As New List(Of Tuple(Of Integer, String))
                                Using cmdGetSerials As New Odbc.OdbcCommand("SELECT UnitID, SerialNo FROM tblcartserials WHERE CartID = ? ORDER BY CartSerialID ASC", con, trans)
                                    cmdGetSerials.Parameters.AddWithValue("?", cartID)
                                    Using rdrS As Odbc.OdbcDataReader = cmdGetSerials.ExecuteReader()
                                        While rdrS.Read()
                                            reservedUnits.Add(Tuple.Create(CInt(rdrS("UnitID")), rdrS("SerialNo").ToString()))
                                        End While
                                    End Using
                                End Using

                                ' 3) Fallback: if no reserved serials, grab available ones
                                If reservedUnits.Count = 0 Then
                                    Dim sqlSerials As String = "SELECT UnitID, SerialNo FROM(tblitemunits) WHERE ItemID = ? AND ItemStatus = 'Available' ORDER BY CAST(SUBSTRING_INDEX(SerialNo, '-', -1) AS UNSIGNED) ASC LIMIT " & qty.ToString() & " FOR UPDATE"
                                    Using cmdSerials As New Odbc.OdbcCommand(sqlSerials, con, trans)
                                        cmdSerials.Parameters.AddWithValue("?", itemID)
                                        Using rdrS As Odbc.OdbcDataReader = cmdSerials.ExecuteReader()
                                            While rdrS.Read()
                                                reservedUnits.Add(Tuple.Create(CInt(rdrS("UnitID")), rdrS("SerialNo").ToString()))
                                            End While
                                        End Using
                                    End Using
                                End If

                                ' 4) Move reserved -> borrowed
                            For Each t In reservedUnits
                                Dim unitId As Integer = t.Item1
                                Dim sNo As String = t.Item2

                                    ' Record borrowed unit
                                    Using insBorrowedUnit As New Odbc.OdbcCommand("INSERT INTO tblborrowedunits (bID, UnitID, SerialNo) VALUES (?, ?, ?)", con, trans)
                                        insBorrowedUnit.Parameters.AddWithValue("?", borrowID)
                                        insBorrowedUnit.Parameters.AddWithValue("?", unitId)
                                        insBorrowedUnit.Parameters.AddWithValue("?", sNo)
                                        insBorrowedUnit.ExecuteNonQuery()
                                    End Using

                                    ' Update the unit’s status AND set bID
                                    Using updateUnit As New Odbc.OdbcCommand("UPDATE tblitemunits SET ItemStatus = 'Borrowed', bID = ? WHERE UnitID = ?", con, trans)
                                        updateUnit.Parameters.AddWithValue("?", borrowID)
                                        updateUnit.Parameters.AddWithValue("?", unitId)
                                        updateUnit.ExecuteNonQuery()
                                    End Using
                            Next

                                ' 5) Delete reserved serials for this cart
                                Using delCartSerials As New Odbc.OdbcCommand("DELETE FROM tblcartserials WHERE CartID = ?", con, trans)
                                    delCartSerials.Parameters.AddWithValue("?", cartID)
                                    delCartSerials.ExecuteNonQuery()
                                End Using
                            End While
                        End If
                    End Using
                End Using

                ' 6) Clear cart
            Using delCart As New Odbc.OdbcCommand("DELETE FROM tblcartlist", con, trans)
                delCart.ExecuteNonQuery()
                End Using

            trans.Commit()
            MsgBox("Borrowing finalized successfully!", vbInformation)

        Catch ex As Exception
            trans.Rollback()
            MsgBox("Error finalizing borrow: " & ex.Message, vbCritical)
            End Try
        End Using
        ' Refresh UI and clear fields
        txtStudentNo.Clear()
        txtYearLevel.Clear()
        txtmi.Clear()
        txtSchoolYear.Clear()
        txtSemester.Clear()
        txtSearch.Clear()
        cbTeacher.SelectedValue = -1
        txtfname.Clear()
        txtlname.Clear()
        txtCourse.Clear()
        txtSection.Clear()
        frmCartListView.lvCart.Clear()
        Call data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Items", dgvItemList)
    End Sub

    Private Sub OnItemAdded(ByVal sender As Object, ByVal e As EventArgs)
        Call data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Items", dgvItemList)
    End Sub

    Private Sub btnCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCart.Click
        ' Dim cartForm As New frmCartListView()
        'para sa mamaya sa view details
        ' Pass all student details to the cart form
        'cartForm.StudentNo = txtStudentNo.Text
        'cartForm.FirstName = txtfname.Text
        'cartForm.MiddleInitial = txtmi.Text
        'cartForm.LastName = txtlname.Text
        'cartForm.Course = txtCourse.Text
        'cartForm.Section = txtSection.Text
        'cartForm.YearLevel = txtYearLevel.Text
        'cartForm.Semester = txtSemester.Text
        'cartForm.SchoolYear = txtSchoolYear.Text
        'cartForm.Teacher = cbTeacher.Text
        'cartForm.DateBorrowed = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        frmCartListView.ShowDialog()
    End Sub


    Private Sub btnReferesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Items", dgvItemList)
    End Sub

    Private Sub lblSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbSort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSort.SelectedIndexChanged
        PerformSearch()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        PerformSearch()
    End Sub

    Private Sub txtStudentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentNo.TextChanged
        ClearStudentInfo()

    End Sub

    Private Sub txtStudentNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStudentNo.Validated
        If txtStudentNo.Text.Trim() <> "" Then
            GetBorrowerName(txtStudentNo.Text.Trim(), txtCourse.Text.Trim(), txtSection.Text.Trim(), txtSchoolYear.Text.Trim())
        End If
    End Sub

    Private Sub dgvItemList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub
End Class