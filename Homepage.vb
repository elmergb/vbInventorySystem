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
End Class