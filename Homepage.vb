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

    End Sub

    Private Sub btnBorrowPage_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrowPage.Click
        LoadForm(New frmBorrowerList)
    End Sub
End Class