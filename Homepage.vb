Public Class Homepage

    Private Sub LoadForm(form As Form)
        pnlItem.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        pnlItem.Controls.Add(form)
        form.Show()
        lblTsUser.Text = Login.txtUsername.Text + Login.txtPword.Text

        If Login.role = "Student" Then
            msStudent.Visible = False
            msDashboard.Visible = False
        End If
    End Sub

    Private Sub Homepage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        DisableForm(Me)
        LoadForm(New frmDashboard())
        lblTsUser.Text = Login.txtUsername.Text + " " + Login.txtPword.Text
    End Sub

    Private Sub btnDashBoard_Click_1(sender As System.Object, e As System.EventArgs)
        LoadForm(New frmDashboard())
    End Sub

    Private Sub UserListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        LoadForm(New frmUserList())
    End Sub

    Private Sub BoroToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BoroToolStripMenuItem.Click
        LoadForm(New frmBorrowerList())

    End Sub
    Private Sub MEnuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles msStudent.Click
        LoadForm(New frmStudentlist())
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles msDashboard.Click
        LoadForm(New frmDashboard())
    End Sub

    Private Sub ItemToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles msItem.Click
        LoadForm(New frmListItem())
    End Sub

    Private Sub BorrowedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles msBorrow.Click
        LoadForm(New frmBorrowerCartList())
    End Sub

    Private Sub ReturnToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles msReturn.Click
        LoadForm(New frmReturnList())
    End Sub

    Private Sub ReturnToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles ReturnToolStripMenuItem1.Click
        LoadForm(New frmReturnSub())
    End Sub

    Private Sub DamageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DamageToolStripMenuItem.Click

    End Sub

    Private Sub GoodToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GoodToolStripMenuItem.Click
        LoadForm(New frmGoodItem())
    End Sub

    Private Sub DamageAccountibilityToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DamageAccountibilityToolStripMenuItem.Click
        LoadForm(New frmDamageItemAction())
    End Sub

    Private Sub DamageItemToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DamageItemToolStripMenuItem.Click
        LoadForm(New frmDamageItem())
    End Sub

    Private Sub lblTsUser_Click(sender As System.Object, e As System.EventArgs) Handles lblTsUser.Click

    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentListToolStripMenuItem.Click
        LoadForm(New frmStudentlist())
    End Sub

    Private Sub ltsExit_Click(sender As System.Object, e As System.EventArgs) Handles ltsExit.Click
        MsgExit("Do you want to exit?", Me, Me, Me)
    End Sub

    Private Sub ltsLogout_Click(sender As System.Object, e As System.EventArgs) Handles ltsLogout.Click
        MsgLogout("Do you want to Logut?", Login, Me)

    End Sub

    Private Sub pnlItem_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlItem.Paint

    End Sub
End Class