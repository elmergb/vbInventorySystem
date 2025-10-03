Public Class frmListItem
    Private Sub frmListItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM tblitemlist", dgvItemList)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dgvItemList.Tag = 0
        frmAddItem.ShowDialog()
        'If Val(dgvItemList.Tag) = 0 Then
        '    MsgBox("Select a record ")
        'End If
    End Sub

    Private Sub dgvItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellClick
        If e.RowIndex >= 0 Then
            dgvItemList.Tag = dgvItemList.Item(0, e.RowIndex).Value
            frmAddItem.txtNameOFItem.Text = dgvItemList.Item(1, e.RowIndex).Value
            frmAddItem.cbCategory.Text = dgvItemList.Item(2, e.RowIndex).Value
            frmAddItem.cbLocation.Text = dgvItemList.Item(3, e.RowIndex).Value
            frmAddItem.nupQuantity.Value = dgvItemList.Item(4, e.RowIndex).Value
            frmAddItem.txtRemarks.Text = dgvItemList.Item(5, e.RowIndex).Value
        End If
    End Sub


End Class