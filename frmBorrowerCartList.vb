Public Class frmBorrowerCartList
    Private Sub frmBorrowerCartList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call vbConnection()
        'Call data_loader("SELECT * FROM vw_cartlist", dgvBorrowerCart)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")
        Call data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Item", dgvItemList)
        cb_loader("SELECT * FROM vw_teacher", cbTeacher, "teacher_fullname", "tID")

    End Sub

    Private Sub dgvItemList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItemList.CellClick
        'medyo confusing pa 
        If e.RowIndex >= 0 Then
            dgvItemList.Tag = dgvItemList.Rows(e.RowIndex).Cells("Item").Value
            frmBorrow.cbItemList.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString
            frmBorrow.txtItemDesc.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemDescription").Value.ToString
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

    Public Sub LoadStudentData(studentNo As String)
        Dim isFound As Boolean = True
        Try
            Dim query As String = "SELECT fname, mi, lname, cCode, section, yDesc FROM vw_students WHERE StudentNo = ?"
            Dim cmd As New Odbc.OdbcCommand(query, con)
            cmd.Parameters.AddWithValue("?", studentNo)
            Dim reader As Odbc.OdbcDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Fill the form fields
                txtfname.Text = reader("fname").ToString()
                txtmi.Text = reader("mi").ToString()
                txtlname.Text = reader("lname").ToString()
                txtCourse.Text = reader("cCode").ToString()
                txtSection.Text = reader("section").ToString()
                txtYearLevel.Text = reader("yDesc").ToString()
                isFound = True
            Else
                isFound = False
                MessageBox.Show("Student not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            reader.Close()

            If isFound = True Then
                Dim semYearCmd As New Odbc.OdbcCommand("SELECT currentSemester, currentSchoolYear FROM tblsettings lIMIT 1 ", con)
                Dim semReader As Odbc.OdbcDataReader = semYearCmd.ExecuteReader()
                If semReader.Read() Then
                    txtSemester.Text = semReader("currentSemester").ToString()
                    txtSchoolYear.Text = semReader("currentSchoolYear").ToString()
                End If
                semReader.Close()
                isFound = True
            Else
                isFound = False
                Exit Sub
            End If


        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message)
        End Try
    End Sub

    Private Sub txtStudentNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtStudentNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Call the function to load student data
            LoadStudentData(txtStudentNo.Text)

        End If
    End Sub

    Private Sub btnBorrow_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrow.Click
        If txtStudentNo.Text.Trim() = " " Or txtStudentNo.Text.Trim() = "" Then
            MsgBox("Insert Student No. First")
            Exit Sub
        End If
        If (dgvItemList.Tag) = 0 Then
            MsgBox("Select an item to borrow!", vbInformation, "Select Item")
        Else
            frmBorrow.SelectedItemID = Val(dgvItemList.Tag)
            frmBorrow.ShowDialog()
        End If

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim transaction As Odbc.OdbcTransaction = con.BeginTransaction()
        Dim cmd As Odbc.OdbcCommand
        Try
            cmd = New Odbc.OdbcCommand("SELECT * FROM tblcartlist", con, transaction)
            Dim reader As Odbc.OdbcDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Insert into tblborrow
                cmd = New Odbc.OdbcCommand("INSERT INTO tblborrow (ItemID, BorrowerName, QuantityBorrowed, Contact, Purpose, DateBorrowed, Remarks) VALUES (?, ?, ?, ?, ?, ?, ?)", con, transaction)
                With cmd.Parameters
                    .AddWithValue("?", reader("ItemID"))
                    .AddWithValue("?", reader("BorrowerName"))
                    .AddWithValue("?", reader("QuantityBorrowed"))
                    .AddWithValue("?", reader("Contact"))
                    .AddWithValue("?", reader("Purpose"))
                    .AddWithValue("?", reader("DateBorrowed"))
                    .AddWithValue("?", reader("Remarks"))
                    cmd.ExecuteNonQuery()

                End With
                
                ' Update item quantity
                cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ItemQuantity - ? WHERE ItemID = ?", con, transaction)
                cmd.Parameters.AddWithValue("?", reader("QuantityBorrowed"))
                cmd.Parameters.AddWithValue("?", reader("ItemID"))
                cmd.ExecuteNonQuery()
            End While

            reader.Close()

            ' Clear the cart
            Dim clearCmd As New Odbc.OdbcCommand("DELETE FROM tblcartlist", con, transaction)
            clearCmd.ExecuteNonQuery()


            transaction.Commit()

            MessageBox.Show("Borrowing finalized successfully!")
        Catch ex As Exception
            transaction.Rollback()
            MsgBox("Error occurred: " & ex.Message)
        Finally
            GC.Collect()
        End Try
    End Sub

 
    Private Sub btnCart_Click(sender As System.Object, e As System.EventArgs) Handles btnCart.Click
        Dim cartForm As New frmCartListView()
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

    Private Sub txtStudentNo_Leave(sender As Object, e As System.EventArgs) Handles txtStudentNo.Leave
        If txtStudentNo.Text.Trim() <> "" Then
            GetBorrowerName(txtStudentNo.Text.Trim())
        End If
    End Sub
End Class