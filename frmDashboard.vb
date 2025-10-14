Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class