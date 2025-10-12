Public Class frmReturnList

    Private Sub frmReturnList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_transaction", dgvReturnList)
    End Sub

    Private Sub dgvReturnList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReturnList.CellContentClick

    End Sub
End Class