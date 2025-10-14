Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call data_loader("SELECT BorrowerName, ItemName, QuantityBorrowed, Purpose, DateBorrowed FROM vw_borrowing ORDER BY DateBorrowed DESC LIMIT 5 ", frmDBdgvBorrow)
        ToolStripStatusLabel2.Text = Login.txtUsername.Text
        tsDate.Text = Date.Now.ToString(("yyyy-MM-dd HH:mm:ss"))
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
    End Sub

    Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub frmDBdgvBorrow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles frmDBdgvBorrow.CellContentClick

    End Sub
End Class