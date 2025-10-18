Public Class frmBorrowerCartList
    Private Sub frmBorrowerCartList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call vbConnection()
        'Call data_loader("SELECT * FROM vw_borrowing WHERE Status <> 'Returned'", dgvBorrowerList)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")
    End Sub
End Class