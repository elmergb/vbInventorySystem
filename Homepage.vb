Public Class Homepage

    Private Sub LoadForm(form As Form)
        pnlItem.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        pnlItem.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Homepage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        DisableForm(Me)
        LoadForm(New frmDashboard())

    End Sub
    'Private Sub btnDashBoard_MouseEnter(sender As Object, e As EventArgs)
    '    btnDashBoard.ForeColor = Color.FromArgb(128, 64, 0)
    'End Sub

    'Private Sub btnDashBoard_MouseLeave(sender As Object, e As EventArgs)
    '    btnDashBoard.ForeColor = Color.Black
    'End Sub
    'Private Sub btnAddItem_MouseEnter(sender As Object, e As EventArgs)
    '    btnAddItem.ForeColor = Color.FromArgb(128, 64, 0)
    'End Sub

    'Private Sub btnAddItem_MouseLeave(sender As Object, e As EventArgs)
    '    btnAddItem.ForeColor = Color.Black
    'End Sub

    'Private Sub btnBorrowPage_MouseEnter(sender As Object, e As EventArgs)
    '    btnBorrowPage.ForeColor = Color.FromArgb(128, 64, 0)
    'End Sub

    'Private Sub btnBorrowPage_MouseLeave(sender As Object, e As EventArgs)
    '    btnBorrowPage.ForeColor = Color.Black
    'End Sub

    'Private Sub btnReturnList_MouseLeave(sender As Object, e As EventArgs)
    '    btnReturnList.ForeColor = Color.Black
    'End Sub

    'Private Sub btnReturnList_MouseEnter(sender As Object, e As EventArgs)
    '    btnReturnList.ForeColor = Color.FromArgb(128, 64, 0)
    'End Sub

    'Private Sub btnUser_MouseEnter(sender As Object, e As EventArgs)
    '    btnUser.ForeColor = Color.FromArgb(128, 64, 0)
    'End Sub

    'Private Sub btnUser_MouseLeave(sender As Object, e As EventArgs)
    '    btnUser.ForeColor = Color.Black
    'End Sub
    Private Sub StudentListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentListToolStripMenuItem.Click
        LoadForm(New frmStudentlist())
    End Sub
    Private Sub btnUser_Click_1(sender As System.Object, e As System.EventArgs) Handles btnUser.Click
        LoadForm(New frmUserList())
    End Sub

    Private Sub btnAddItem_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAddItem.Click
        LoadForm(New frmListItem())
    End Sub

    Private Sub btnDashBoard_Click_1(sender As System.Object, e As System.EventArgs) Handles btnDashBoard.Click
        'LoadForm(New frmDashboard())
    End Sub

    Private Sub btnReturnList_Click_1(sender As System.Object, e As System.EventArgs) Handles btnReturnList.Click
        LoadForm(New frmReturnList())
    End Sub

    Private Sub btnBorrowPage_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBorrowPage.Click
        LoadForm(New frmBorrowerCartList())
    End Sub


    Private Sub ToolStripDropDownButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripDropDownButton2.Click

    End Sub

    Private Sub UserListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        LoadForm(New frmUserList())
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub BoroToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BoroToolStripMenuItem.Click
        LoadForm(New frmBorrowerList())

    End Sub
End Class