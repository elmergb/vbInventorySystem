Public Class frmListItem
    Public BorrowID As Integer
    Public ItemID As Integer
    Private Sub frmListItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM tblitemlist", dgvItemList)
        dgvItemList.AutoGenerateColumns = False
        dgvItemList.Tag = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dgvItemList.Tag = 0
        frmAddItem.ShowDialog()
        frmAddItem.ItemID = 0
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
            frmAddItem.txtRemarks.Text = dgvItemList.Item(6, e.RowIndex).Value
        End If
    End Sub


    Private Sub btnBorrow_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrow.Click
        If frmBorrowerList.dgvBorrowerList.CurrentRow IsNot Nothing Then
            Dim f As New frmReturnEntry
            f.BorrowID = CInt(frmBorrowerList.dgvBorrowerList.Item("BorrowID", frmBorrowerList.dgvBorrowerList.CurrentRow.Index).Value)
            f.ItemID = CInt(frmBorrowerList.dgvBorrowerList.Item("ItemID", frmBorrowerList.dgvBorrowerList.CurrentRow.Index).Value)
            f.ShowDialog()
        Else
            MsgBox("Please select a record first!", vbInformation)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If (dgvItemList.Tag) = 0 Then
            MsgBox("Select a record to edit!", vbInformation)
        Else
            frmAddItem.ItemID = Val(dgvItemList.Tag)
            frmAddItem.ShowDialog()
        End If
    End Sub

    Private Sub dgvItemList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub
End Class