Public Class frmUserList


    Private Sub frmUserList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM tbluser", dgvUserList)

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        dgvUserList.Tag = 0
        frmUserAdd.UserID = 0
        frmUserAdd.ShowDialog()

    End Sub

    Private Sub dgvUserList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUserList.CellClick
        If e.RowIndex >= 0 Then
            dgvUserList.Tag = dgvUserList.Item(0, e.RowIndex).Value
            frmUserAdd.txtfname.Text = dgvUserList.Item(1, e.RowIndex).Value
            frmUserAdd.txtmi.Text = dgvUserList.Item(2, e.RowIndex).Value
            frmUserAdd.txtlname.Text = dgvUserList.Item(3, e.RowIndex).Value
            frmUserAdd.txtusername.Text = dgvUserList.Item(4, e.RowIndex).Value
            frmUserAdd.txtpword.Text = dgvUserList.Item(5, e.RowIndex).Value
        End If
    End Sub



    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click

        If (dgvUserList.Tag) = 0 Then
            MsgBox("Select a record to edit", vbInformation)
        Else
            frmUserAdd.UserID = Val(dgvUserList.Tag)
            Call frmUserAdd.ShowDialog()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim cmd As New Odbc.OdbcCommand
        If Val(dgvUserList.Tag) = 0 Then
            MsgBox("Select a record")
        ElseIf MsgBox("You want to Delete this record?", vbYesNo + vbInformation) = vbYes Then
            Try
                cmd = New Odbc.OdbcCommand("DELETE FROM tbluser WHERE UserID=" & Val(dgvUserList.Tag), con)
                cmd.ExecuteNonQuery()
                MsgBox("Successfully deleted a record", vbInformation)
                Call data_loader("SELECT * FROM tbluser", dgvUserList)
                dgvUserList.Tag = 0
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnBorrow_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrow.Click
        frmBorrow.Show()
    End Sub
End Class