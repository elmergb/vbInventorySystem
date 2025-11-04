<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.ts = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTsManage = New System.Windows.Forms.ToolStripLabel()
        Me.lblTsTransaction = New System.Windows.Forms.ToolStripLabel()
        Me.lblTsReports = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTsUser = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTsTime = New System.Windows.Forms.ToolStripLabel()
        Me.pnlItem = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.msReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.msDashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msBorrow = New System.Windows.Forms.ToolStripMenuItem()
        Me.msStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ltsLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ltsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.UIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamageAccountibilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamageItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BorrowItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ts.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ts
        '
        Me.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripDropDownButton1, Me.lblTsManage, Me.ToolStripDropDownButton2, Me.lblTsTransaction, Me.ToolStripDropDownButton3, Me.lblTsReports, Me.ToolStripDropDownButton4, Me.lblTsUser, Me.ToolStripLabel4, Me.lblTsTime, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ts.Location = New System.Drawing.Point(0, 0)
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(1154, 25)
        Me.ts.TabIndex = 21
        Me.ts.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel1.Text = "Account"
        '
        'lblTsManage
        '
        Me.lblTsManage.Name = "lblTsManage"
        Me.lblTsManage.Size = New System.Drawing.Size(50, 22)
        Me.lblTsManage.Text = "Manage"
        '
        'lblTsTransaction
        '
        Me.lblTsTransaction.Name = "lblTsTransaction"
        Me.lblTsTransaction.Size = New System.Drawing.Size(67, 22)
        Me.lblTsTransaction.Text = "Transaction"
        '
        'lblTsReports
        '
        Me.lblTsReports.Name = "lblTsReports"
        Me.lblTsReports.Size = New System.Drawing.Size(47, 22)
        Me.lblTsReports.Text = "Reports"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel2.Text = "  Log in As:"
        '
        'lblTsUser
        '
        Me.lblTsUser.Name = "lblTsUser"
        Me.lblTsUser.Size = New System.Drawing.Size(30, 22)
        Me.lblTsUser.Text = "User"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel4.Text = "  Time:"
        '
        'lblTsTime
        '
        Me.lblTsTime.Name = "lblTsTime"
        Me.lblTsTime.Size = New System.Drawing.Size(33, 22)
        Me.lblTsTime.Text = "Time"
        '
        'pnlItem
        '
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlItem.Location = New System.Drawing.Point(0, 102)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(1154, 571)
        Me.pnlItem.TabIndex = 23
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msDashboard, Me.msItem, Me.msBorrow, Me.msReturn, Me.msStudent})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 25)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1154, 77)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'msReturn
        '
        Me.msReturn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msReturn.Name = "msReturn"
        Me.msReturn.Size = New System.Drawing.Size(85, 73)
        Me.msReturn.Text = "Return"
        '
        'msDashboard
        '
        Me.msDashboard.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msDashboard.Image = Global.main.My.Resources.Resources._9055226_bxs_dashboard_icon
        Me.msDashboard.Name = "msDashboard"
        Me.msDashboard.Size = New System.Drawing.Size(137, 73)
        Me.msDashboard.Text = "Dashboard"
        '
        'msItem
        '
        Me.msItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msItem.Image = CType(resources.GetObject("msItem.Image"), System.Drawing.Image)
        Me.msItem.Name = "msItem"
        Me.msItem.Size = New System.Drawing.Size(88, 73)
        Me.msItem.Text = "Items"
        '
        'msBorrow
        '
        Me.msBorrow.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msBorrow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.msBorrow.Name = "msBorrow"
        Me.msBorrow.Size = New System.Drawing.Size(91, 73)
        Me.msBorrow.Text = "Borrow"
        '
        'msStudent
        '
        Me.msStudent.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msStudent.Image = Global.main.My.Resources.Resources._1564534_customer_man_user_account_profile_icon1
        Me.msStudent.Name = "msStudent"
        Me.msStudent.Size = New System.Drawing.Size(111, 73)
        Me.msStudent.Text = "Student"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ltsLogout, Me.ltsExit})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "a"
        '
        'ltsLogout
        '
        Me.ltsLogout.Name = "ltsLogout"
        Me.ltsLogout.Size = New System.Drawing.Size(115, 22)
        Me.ltsLogout.Text = "Log out"
        '
        'ltsExit
        '
        Me.ltsExit.Name = "ltsExit"
        Me.ltsExit.Size = New System.Drawing.Size(115, 22)
        Me.ltsExit.Text = "Exit"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UIToolStripMenuItem, Me.BorrowesToolStripMenuItem, Me.UsersToolStripMenuItem, Me.ReturnToolStripMenuItem1})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        '
        'UIToolStripMenuItem
        '
        Me.UIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DamageToolStripMenuItem, Me.GoodToolStripMenuItem})
        Me.UIToolStripMenuItem.Name = "UIToolStripMenuItem"
        Me.UIToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.UIToolStripMenuItem.Text = "Items"
        '
        'DamageToolStripMenuItem
        '
        Me.DamageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DamageAccountibilityToolStripMenuItem, Me.DamageItemToolStripMenuItem})
        Me.DamageToolStripMenuItem.Name = "DamageToolStripMenuItem"
        Me.DamageToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.DamageToolStripMenuItem.Text = "Damage"
        '
        'DamageAccountibilityToolStripMenuItem
        '
        Me.DamageAccountibilityToolStripMenuItem.Name = "DamageAccountibilityToolStripMenuItem"
        Me.DamageAccountibilityToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DamageAccountibilityToolStripMenuItem.Text = "Damage Accountibility"
        '
        'DamageItemToolStripMenuItem
        '
        Me.DamageItemToolStripMenuItem.Name = "DamageItemToolStripMenuItem"
        Me.DamageItemToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DamageItemToolStripMenuItem.Text = "Damage Item"
        '
        'GoodToolStripMenuItem
        '
        Me.GoodToolStripMenuItem.Name = "GoodToolStripMenuItem"
        Me.GoodToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.GoodToolStripMenuItem.Text = "Good"
        '
        'BorrowesToolStripMenuItem
        '
        Me.BorrowesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoroToolStripMenuItem})
        Me.BorrowesToolStripMenuItem.Name = "BorrowesToolStripMenuItem"
        Me.BorrowesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.BorrowesToolStripMenuItem.Text = "Borrowers"
        '
        'BoroToolStripMenuItem
        '
        Me.BoroToolStripMenuItem.Name = "BoroToolStripMenuItem"
        Me.BoroToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.BoroToolStripMenuItem.Text = "Borrow"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.StudentListToolStripMenuItem.Text = "Student list"
        '
        'ReturnToolStripMenuItem1
        '
        Me.ReturnToolStripMenuItem1.Name = "ReturnToolStripMenuItem1"
        Me.ReturnToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.ReturnToolStripMenuItem1.Text = "Return"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowItemToolStripMenuItem, Me.ReturnItemToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton3.Text = "ToolStripDropDownButton3"
        '
        'BorrowItemToolStripMenuItem
        '
        Me.BorrowItemToolStripMenuItem.Name = "BorrowItemToolStripMenuItem"
        Me.BorrowItemToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.BorrowItemToolStripMenuItem.Text = "Borrow Item"
        '
        'ReturnItemToolStripMenuItem
        '
        Me.ReturnItemToolStripMenuItem.Name = "ReturnItemToolStripMenuItem"
        Me.ReturnItemToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ReturnItemToolStripMenuItem.Text = "Return Item"
        '
        'ToolStripDropDownButton4
        '
        Me.ToolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryReportToolStripMenuItem, Me.BorrowHistoryToolStripMenuItem})
        Me.ToolStripDropDownButton4.Image = CType(resources.GetObject("ToolStripDropDownButton4.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4"
        Me.ToolStripDropDownButton4.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton4.Text = "ToolStripDropDownButton4"
        '
        'InventoryReportToolStripMenuItem
        '
        Me.InventoryReportToolStripMenuItem.Name = "InventoryReportToolStripMenuItem"
        Me.InventoryReportToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.InventoryReportToolStripMenuItem.Text = "Inventory Report"
        '
        'BorrowHistoryToolStripMenuItem
        '
        Me.BorrowHistoryToolStripMenuItem.Name = "BorrowHistoryToolStripMenuItem"
        Me.BorrowHistoryToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BorrowHistoryToolStripMenuItem.Text = "Borrow History"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(0, 22)
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 673)
        Me.Controls.Add(Me.pnlItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ts)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Homepage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ts.ResumeLayout(False)
        Me.ts.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ts As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ltsLogout As ToolStripMenuItem
    Friend WithEvents ltsExit As ToolStripMenuItem
    Friend WithEvents lblTsManage As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents UIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DamageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTsTransaction As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents BorrowItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTsReports As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton4 As ToolStripDropDownButton
    Friend WithEvents InventoryReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblTsUser As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents lblTsTime As ToolStripLabel
    Friend WithEvents StudentListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlItem As System.Windows.Forms.Panel
    Friend WithEvents BoroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents msStudent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msDashboard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msBorrow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DamageAccountibilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DamageItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
End Class
