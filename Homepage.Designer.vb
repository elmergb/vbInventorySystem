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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.ts = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ltsLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTsManage = New System.Windows.Forms.ToolStripLabel()
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
        Me.TeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTsReports = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.pnlItem = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.msDashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.msItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msBorrow = New System.Windows.Forms.ToolStripMenuItem()
        Me.msReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.msStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblUser = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripLabel()
        Me.ts.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ts
        '
        Me.ts.AutoSize = False
        Me.ts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripDropDownButton1, Me.lblTsManage, Me.ToolStripDropDownButton2, Me.lblTsReports, Me.ToolStripDropDownButton4, Me.ToolStripLabel3})
        Me.ts.Location = New System.Drawing.Point(0, 0)
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(1154, 49)
        Me.ts.TabIndex = 21
        Me.ts.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(56, 46)
        Me.ToolStripLabel1.Text = "Account"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ltsLogout})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 46)
        Me.ToolStripDropDownButton1.Text = "a"
        '
        'ltsLogout
        '
        Me.ltsLogout.Name = "ltsLogout"
        Me.ltsLogout.Size = New System.Drawing.Size(115, 22)
        Me.ltsLogout.Text = "Log out"
        '
        'lblTsManage
        '
        Me.lblTsManage.Name = "lblTsManage"
        Me.lblTsManage.Size = New System.Drawing.Size(54, 46)
        Me.lblTsManage.Text = "Manage"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UIToolStripMenuItem, Me.BorrowesToolStripMenuItem, Me.UsersToolStripMenuItem, Me.ReturnToolStripMenuItem1})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 46)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        '
        'UIToolStripMenuItem
        '
        Me.UIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DamageToolStripMenuItem, Me.GoodToolStripMenuItem})
        Me.UIToolStripMenuItem.Name = "UIToolStripMenuItem"
        Me.UIToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.UIToolStripMenuItem.Text = "Items"
        '
        'DamageToolStripMenuItem
        '
        Me.DamageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DamageAccountibilityToolStripMenuItem, Me.DamageItemToolStripMenuItem})
        Me.DamageToolStripMenuItem.Name = "DamageToolStripMenuItem"
        Me.DamageToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.DamageToolStripMenuItem.Text = "Damage"
        '
        'DamageAccountibilityToolStripMenuItem
        '
        Me.DamageAccountibilityToolStripMenuItem.Name = "DamageAccountibilityToolStripMenuItem"
        Me.DamageAccountibilityToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.DamageAccountibilityToolStripMenuItem.Text = "Damage Accountibility"
        '
        'DamageItemToolStripMenuItem
        '
        Me.DamageItemToolStripMenuItem.Name = "DamageItemToolStripMenuItem"
        Me.DamageItemToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.DamageItemToolStripMenuItem.Text = "Damage Item"
        '
        'GoodToolStripMenuItem
        '
        Me.GoodToolStripMenuItem.Name = "GoodToolStripMenuItem"
        Me.GoodToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.GoodToolStripMenuItem.Text = "Good"
        '
        'BorrowesToolStripMenuItem
        '
        Me.BorrowesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoroToolStripMenuItem})
        Me.BorrowesToolStripMenuItem.Name = "BorrowesToolStripMenuItem"
        Me.BorrowesToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.BorrowesToolStripMenuItem.Text = "Borrowers"
        '
        'BoroToolStripMenuItem
        '
        Me.BoroToolStripMenuItem.Name = "BoroToolStripMenuItem"
        Me.BoroToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BoroToolStripMenuItem.Text = "Borrow"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem, Me.TeacherToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.StudentListToolStripMenuItem.Text = "Student list"
        '
        'TeacherToolStripMenuItem
        '
        Me.TeacherToolStripMenuItem.Name = "TeacherToolStripMenuItem"
        Me.TeacherToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.TeacherToolStripMenuItem.Text = "Teacher"
        '
        'ReturnToolStripMenuItem1
        '
        Me.ReturnToolStripMenuItem1.Name = "ReturnToolStripMenuItem1"
        Me.ReturnToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.ReturnToolStripMenuItem1.Text = "Return"
        '
        'lblTsReports
        '
        Me.lblTsReports.Name = "lblTsReports"
        Me.lblTsReports.Size = New System.Drawing.Size(53, 46)
        Me.lblTsReports.Text = "Reports"
        '
        'ToolStripDropDownButton4
        '
        Me.ToolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryReportToolStripMenuItem, Me.BorrowHistoryToolStripMenuItem})
        Me.ToolStripDropDownButton4.Image = CType(resources.GetObject("ToolStripDropDownButton4.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4"
        Me.ToolStripDropDownButton4.Size = New System.Drawing.Size(29, 46)
        Me.ToolStripDropDownButton4.Text = "ToolStripDropDownButton4"
        '
        'InventoryReportToolStripMenuItem
        '
        Me.InventoryReportToolStripMenuItem.Name = "InventoryReportToolStripMenuItem"
        Me.InventoryReportToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.InventoryReportToolStripMenuItem.Text = "Inventory Report"
        '
        'BorrowHistoryToolStripMenuItem
        '
        Me.BorrowHistoryToolStripMenuItem.Name = "BorrowHistoryToolStripMenuItem"
        Me.BorrowHistoryToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BorrowHistoryToolStripMenuItem.Text = "Borrow History"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(0, 46)
        '
        'pnlItem
        '
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlItem.Location = New System.Drawing.Point(0, 126)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(1154, 547)
        Me.pnlItem.TabIndex = 23
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msDashboard, Me.msItem, Me.msBorrow, Me.msReturn, Me.msStudent})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 49)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1154, 77)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'msReturn
        '
        Me.msReturn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msReturn.Name = "msReturn"
        Me.msReturn.Size = New System.Drawing.Size(85, 73)
        Me.msReturn.Text = "Return"
        '
        'msStudent
        '
        Me.msStudent.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msStudent.Image = Global.main.My.Resources.Resources._1564534_customer_man_user_account_profile_icon1
        Me.msStudent.Name = "msStudent"
        Me.msStudent.Size = New System.Drawing.Size(111, 73)
        Me.msStudent.Text = "Student"
        '
        'Timer1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.lblUser, Me.ToolStripLabel5, Me.lblTime})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 648)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1154, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel2.Text = "Login As:"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(90, 22)
        Me.lblUser.Text = "ToolStripLabel4"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel5.Text = "Time:"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(90, 22)
        Me.lblTime.Text = "ToolStripLabel4"
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 673)
        Me.Controls.Add(Me.ToolStrip1)
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
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ts As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ltsLogout As ToolStripMenuItem
    Friend WithEvents lblTsManage As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents UIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DamageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTsReports As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton4 As ToolStripDropDownButton
    Friend WithEvents InventoryReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowHistoryToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents TeacherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripLabel
End Class
