Public Class Homepage

    Private Sub LoadForm(form As Form)
        pnlItem.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        pnlItem.Controls.Add(form)
        form.Show()

    End Sub

    Private Sub Homepage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        DisableForm(Me)
        LoadForm(New frmDashboard())

        lblUser.Text = frmLogin.txtUsername.Text
        Timer1.Start()
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
        LoadForm(New frmBorrowingDE())
    End Sub

    Private Sub ReturnToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles msReturn.Click
        LoadForm(New frmReturnList())
    End Sub

    Private Sub ReturnToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles ReturnToolStripMenuItem1.Click
        LoadForm(New frmReturnSub())
    End Sub

    Private Sub DamageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DamageToolStripMenuItem.Click

    End Sub

    Private Sub GoodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadForm(New frmGoodItem())
    End Sub

    Private Sub DamageAccountibilityToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DamageAccountibilityToolStripMenuItem.Click
        LoadForm(New frmDamageItemAY())
    End Sub


    Private Sub lblTsUser_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StudentListToolStripMenuItem.Click
        LoadForm(New frmStudentlist())
    End Sub

    Private Sub ltsExit_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ltsLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MsgExit("Do you want to Logout?", Me, Me, Me)

    End Sub

    Private Sub pnlItem_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlItem.Paint

    End Sub

    Private Sub TeacherToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TeacherToolStripMenuItem.Click
        LoadForm(New frmTeacherlist())

    End Sub



    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm")
    End Sub

    Private Sub ToolStripLabel2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripLabel2.Click

    End Sub

    Private Sub lblUser_Click(sender As System.Object, e As System.EventArgs) Handles lblUser.Click

    End Sub

    Private Sub InventoryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryReportToolStripMenuItem.Click
        LoadForm(New frmInventoryrpt)
    End Sub

    Private Sub TransactionRepotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionRepotToolStripMenuItem.Click
        LoadForm(New frmTransactrpt())
    End Sub

    Private Sub ltsLogout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltsLogout.Click
        If MsgBox("Are you sure to Logout?", vbYesNo + vbQuestion) = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub lblTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTime.Click

    End Sub

    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub
End Class