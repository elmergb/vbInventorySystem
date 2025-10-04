Public Class frmBorrowerList

    Private Sub frmBorrowerList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_borrowing", dgvBorrowerList)
    End Sub

    Private Sub dgvBorrowerList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrowerList.CellClick
        If e.RowIndex >= 0 Then
            dgvBorrowerList.Tag = dgvBorrowerList.Item(0, e.RowIndex).Value
            Dim itemValue As Object = dgvBorrowerList.Item(1, e.RowIndex).Value
            If itemValue IsNot Nothing AndAlso Not IsDBNull(itemValue) Then
                Try
                    frmBorrow.cbItemList.SelectedValue = Convert.ToInt32(itemValue)
                Catch
                    frmBorrow.cbItemList.Text = itemValue.ToString()
                End Try
            Else
                frmBorrow.cbItemList.SelectedIndex = -1
            End If
            frmBorrow.txtBorrowerName.Text = dgvBorrowerList.Item(2, e.RowIndex).Value
            frmBorrow.nupQuantity.Value = dgvBorrowerList.Item(3, e.RowIndex).Value
            frmBorrow.txtContact.Text = dgvBorrowerList.Item(4, e.RowIndex).Value
            frmBorrow.txtPurpose.Text = dgvBorrowerList.Item(5, e.RowIndex).Value
            frmBorrow.dtpBorrowed.Value = dgvBorrowerList.Item(6, e.RowIndex).Value
            frmBorrow.txtRemarks.Text = dgvBorrowerList.Item(7, e.RowIndex).Value
        End If
    End Sub
End Class