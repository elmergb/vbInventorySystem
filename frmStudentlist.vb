Public Class frmStudentlist

    Private Sub frmStudentlist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_user", dgvStudentList)
        'If e.RowIndex >= 0 Then
        '    dgvItemList.Tag = dgvItemList.Rows(e.RowIndex).Cells("Item").Value

        '    frmAddItem.txtNameOFItem.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString
        '    frmAddItem.cbCategory.Text = dgvItemList.Rows(e.RowIndex).Cells("Category").Value.ToString()
        '    frmAddItem.cbLocation.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemLocation").Value.ToString()
        '    frmAddItem.nupQuantity.Value = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
        '    Dim qty As Object = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
        '    If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
        '        frmAddItem.nupQuantity.Value = CInt(qty)
        '    Else
        '        frmAddItem.nupQuantity.Value = 0
        '    End If
        '    frmAddItem.cbRemarks.Text = dgvItemList.Rows(e.RowIndex).Cells("Remarks").Value.ToString()
        With dgvStudentList
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersHeight = 25
            .RowTemplate.Height = 25
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.LightGray
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub dgvStudentList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudentList.CellClick
        'If e.RowIndex >= 0 Then
        '    dgvStudentList.Tag = dgvStudentList.Item(0, e.RowIndex).Value
        '    frmStudentCanBorrow()
        'End If

        If e.RowIndex >= 0 Then
            dgvStudentList.Tag = dgvStudentList.Rows(e.RowIndex).Cells("sID").Value
            frmStudentCanBorrow.txtStudentNumber.Text = dgvStudentList.Rows(e.RowIndex).Cells("StudentNo").Value.ToString()
            frmStudentCanBorrow.txtfname.Text = dgvStudentList.Rows(e.RowIndex).Cells("fname").Value.ToString()
            frmStudentCanBorrow.txtmi.Text = dgvStudentList.Rows(e.RowIndex).Cells("mi").Value.ToString()
            frmStudentCanBorrow.txtlname.Text = dgvStudentList.Rows(e.RowIndex).Cells("lname").Value.ToString()
            frmStudentCanBorrow.cbCourses.SelectedValue = dgvStudentList.Rows(e.RowIndex).Cells("course").Value.ToString()
            frmStudentCanBorrow.txtSection.Text = dgvStudentList.Rows(e.RowIndex).Cells("section").Value.ToString()
            frmStudentCanBorrow.cbYear.SelectedValue = dgvStudentList.Rows(e.RowIndex).Cells("yDesc").Value.ToString()
            frmStudentCanBorrow.cbRole.SelectedValue = dgvStudentList.Rows(e.RowIndex).Cells("Role").Value.ToString()
            frmStudentCanBorrow.txtuname.Text = dgvStudentList.Rows(e.RowIndex).Cells("UserName").Value.ToString()
            frmStudentCanBorrow.txtPword.Text = dgvStudentList.Rows(e.RowIndex).Cells("pword").Value.ToString()
            frmStudentCanBorrow.ckbisActive.Checked = CBool(dgvStudentList.Rows(e.RowIndex).Cells("isActive").Value)

        End If
    End Sub


    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If Val(dgvStudentList.Tag) = 0 Then
            MsgBox("Select a record to Edit!")
        Else
            frmStudentCanBorrow.studentID = Val(dgvStudentList.Tag)
            frmStudentCanBorrow.Show()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        frmStudentCanBorrow.studentID = 0
        frmStudentCanBorrow.Show()

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If dgvStudentList.CurrentRow Is Nothing Then
            MsgBox("Please select a student to delete.", vbInformation)
            Exit Sub
        End If


        Dim row As DataGridViewRow = dgvStudentList.CurrentRow
        Dim studNo As String = row.Cells("StudentNo").Value.ToString()
        Dim role As String = row.Cells("Role").Value.ToString()


        If role.Trim().ToLower() = "admin" Then
            MsgBox("You cannot delete an Admin account.", vbExclamation)
            Exit Sub
        End If


        If MsgBox("Are you sure you want to deactivate this account?", vbYesNo + vbQuestion) = vbYes Then
            Try


                Dim query As String = "UPDATE tblstudent SET isActive = 0 WHERE studNo = ?"
                Using cmd As New Odbc.OdbcCommand(query, con)
                    cmd.Parameters.AddWithValue("@studNo", studNo)
                    cmd.ExecuteNonQuery()
                End Using


                MsgBox("Student has been deactivated successfully.", vbInformation)


                Call data_loader("SELECT * FROM vw_students", dgvStudentList)

            Catch ex As Exception
                MsgBox("Error deactivating record: " & ex.Message, vbCritical)
            End Try
        End If

    End Sub
End Class