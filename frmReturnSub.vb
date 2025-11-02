Public Class frmReturnSub

    Private Sub frmReturnSub_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_returnlist ", dgvReturnLists)

        For Each col As DataGridViewColumn In dgvReturnLists.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub dgvReturnList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReturnLists.CellClick
        If e.RowIndex >= 0 Then
            dgvReturnLists.Tag = dgvReturnLists.Rows(e.RowIndex).Cells("ReturnID").Value
            '    frmBorrow.cbItemList.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString
            '    frmBorrow.txtItemDesc.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemDescription").Value.ToString
            '    frmAddItem.cbCategory.Text = dgvItemList.Rows(e.RowIndex).Cells("Category").Value.ToString()
            '    frmAddItem.cbLocation.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemLocation").Value.ToString()
            '    frmAddItem.nupQuantity.Value = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
            '    Dim qty As Object = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
            '    If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
            '        frmAddItem.nupQuantity.Value = CInt(qty)
            '    Else
            '        frmAddItem.nupQuantity.Value = 0
            '    End If

        End If
    End Sub
End Class