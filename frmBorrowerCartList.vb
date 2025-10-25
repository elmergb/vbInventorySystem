Public Class frmBorrowerCartList
    Private Sub frmBorrowerCartList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call vbConnection()
        Call data_loader("SELECT * FROM vw_cartlist", dgvBorrowerCart)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")

    End Sub

    Private Sub dgvBorrowerCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowerCart.CellContentClick

    End Sub
End Class