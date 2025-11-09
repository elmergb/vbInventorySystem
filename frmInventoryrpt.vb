Public Class frmInventoryrpt

    Private Sub frmInventoryrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'frmInventory.DataTable' table. You can move, or remove it, as needed.
        Me.DataTableTableAdapter.Fill(Me.frmInventory.DataTable)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class