Public Class Homepage

    Private Sub btnAddItem_Click(sender As System.Object, e As System.EventArgs) Handles btnAddItem.Click
        LoadForm(New frmListItem())
    End Sub

    Private Sub LoadForm(form As Form)
        pnlItem.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        pnlItem.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub btnUser_Click(sender As System.Object, e As System.EventArgs) Handles btnUser.Click
        LoadForm(New frmUserList())

    End Sub

    Private Sub pnlItem_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlItem.Paint

    End Sub

    Private Sub Homepage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        LoadForm(New frmDashboard())
    End Sub

    Private Sub btnBorrowPage_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrowPage.Click
        LoadForm(New frmBorrowerList())
    End Sub

    Private Sub btnReturnList_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnList.Click
        LoadForm(New frmReturnList())
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        LoadForm(New frmDashboard())
    End Sub

    Private Sub btnDashBoard_MouseEnter(sender As Object, e As EventArgs) Handles btnDashBoard.MouseEnter
        btnDashBoard.ForeColor = Color.FromArgb(128, 64, 0)
    End Sub

    Private Sub btnDashBoard_MouseLeave(sender As Object, e As EventArgs) Handles btnDashBoard.MouseLeave
        btnDashBoard.ForeColor = Color.Black
    End Sub
End Class