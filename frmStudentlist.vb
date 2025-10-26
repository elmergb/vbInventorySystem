Public Class frmStudentlist

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub frmStudentlist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_students", dgvStudentList)
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
        Dim cmd As New Odbc.OdbcCommand
        If Val(dgvStudentList.Tag) = 0 Then
            MsgBox("Select a record")
        ElseIf MsgBox("You want to Delete this record?", vbYesNo + vbInformation) = vbYes Then
            Try
                cmd = New Odbc.OdbcCommand("DELETE FROM tblstudentlist WHERE sID=" & Val(dgvStudentList.Tag), con)
                cmd.ExecuteNonQuery()
                MsgBox("Successfully deleted a record", vbInformation)
                Call data_loader("SELECT * FROM vw_students", dgvStudentList)
                dgvStudentList.Tag = 0
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class