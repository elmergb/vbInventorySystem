Public Class frmGoodItem

    Private Sub frmGoodItem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_Item WHERE TRIM(itemRemarks)= 'good' OR TRIM(itemRemarks)= 'Good' ", dgvItemList)
    End Sub
End Class