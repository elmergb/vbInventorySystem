Public Class frmDamageItem

    Private Sub frmDamageItem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_damageitems WHERE QuantityDamaged > 0", dgvDamageItems)
    End Sub

End Class