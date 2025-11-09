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
        Me.lblTsManage = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.UIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamageAccountibilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionRepotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ltsLogout = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.lblTime = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
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
        Me.ts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lblTsManage, Me.ToolStripDropDownButton2, Me.ToolStripSeparator1, Me.ToolStripDropDownButton4, Me.ToolStripLabel3, Me.ToolStripDropDownButton1})
        Me.ts.Location = New System.Drawing.Point(0, 0)
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(1539, 46)
        Me.ts.TabIndex = 21
        Me.ts.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 43)
        '
        'lblTsManage
        '
        Me.lblTsManage.Name = "lblTsManage"
        Me.lblTsManage.Size = New System.Drawing.Size(0, 43)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UIToolStripMenuItem, Me.BorrowesToolStripMenuItem, Me.UsersToolStripMenuItem, Me.ReturnToolStripMenuItem1})
        Me.ToolStripDropDownButton2.Image = Global.main.My.Resources.Resources.profile1
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(96, 43)
        Me.ToolStripDropDownButton2.Text = "Manage"
        '
        'UIToolStripMenuItem
        '
        Me.UIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DamageToolStripMenuItem})
        Me.UIToolStripMenuItem.Name = "UIToolStripMenuItem"
        Me.UIToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.UIToolStripMenuItem.Text = "Items"
        '
        'DamageToolStripMenuItem
        '
        Me.DamageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DamageAccountibilityToolStripMenuItem})
        Me.DamageToolStripMenuItem.Name = "DamageToolStripMenuItem"
        Me.DamageToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.DamageToolStripMenuItem.Text = "Damage"
        '
        'DamageAccountibilityToolStripMenuItem
        '
        Me.DamageAccountibilityToolStripMenuItem.Name = "DamageAccountibilityToolStripMenuItem"
        Me.DamageAccountibilityToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.DamageAccountibilityToolStripMenuItem.Text = "Damage Accountibility"
        '
        'BorrowesToolStripMenuItem
        '
        Me.BorrowesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoroToolStripMenuItem})
        Me.BorrowesToolStripMenuItem.Name = "BorrowesToolStripMenuItem"
        Me.BorrowesToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.BorrowesToolStripMenuItem.Text = "Borrowers"
        '
        'BoroToolStripMenuItem
        '
        Me.BoroToolStripMenuItem.Name = "BoroToolStripMenuItem"
        Me.BoroToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.BoroToolStripMenuItem.Text = "Borrow"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem, Me.TeacherToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.StudentListToolStripMenuItem.Text = "Student list"
        '
        'TeacherToolStripMenuItem
        '
        Me.TeacherToolStripMenuItem.Name = "TeacherToolStripMenuItem"
        Me.TeacherToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.TeacherToolStripMenuItem.Text = "Teacher"
        '
        'ReturnToolStripMenuItem1
        '
        Me.ReturnToolStripMenuItem1.Name = "ReturnToolStripMenuItem1"
        Me.ReturnToolStripMenuItem1.Size = New System.Drawing.Size(153, 24)
        Me.ReturnToolStripMenuItem1.Text = "Return"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 46)
        '
        'ToolStripDropDownButton4
        '
        Me.ToolStripDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryReportToolStripMenuItem, Me.TransactionRepotToolStripMenuItem})
        Me.ToolStripDropDownButton4.Image = Global.main.My.Resources.Resources.report
        Me.ToolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4"
        Me.ToolStripDropDownButton4.Size = New System.Drawing.Size(86, 43)
        Me.ToolStripDropDownButton4.Text = "Report"
        '
        'InventoryReportToolStripMenuItem
        '
        Me.InventoryReportToolStripMenuItem.Name = "InventoryReportToolStripMenuItem"
        Me.InventoryReportToolStripMenuItem.Size = New System.Drawing.Size(215, 24)
        Me.InventoryReportToolStripMenuItem.Text = "Inventory Report"
        '
        'TransactionRepotToolStripMenuItem
        '
        Me.TransactionRepotToolStripMenuItem.Name = "TransactionRepotToolStripMenuItem"
        Me.TransactionRepotToolStripMenuItem.Size = New System.Drawing.Size(215, 24)
        Me.TransactionRepotToolStripMenuItem.Text = "Transaction Report"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(0, 43)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ltsLogout})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(90, 43)
        Me.ToolStripDropDownButton1.Text = "Account"
        '
        'ltsLogout
        '
        Me.ltsLogout.Name = "ltsLogout"
        Me.ltsLogout.Size = New System.Drawing.Size(152, 22)
        Me.ltsLogout.Text = "Log out"
        '
        'pnlItem
        '
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlItem.Location = New System.Drawing.Point(0, 100)
        Me.pnlItem.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(1539, 728)
        Me.pnlItem.TabIndex = 23
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msDashboard, Me.msItem, Me.msBorrow, Me.msReturn, Me.msStudent})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 46)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1539, 54)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'msDashboard
        '
        Me.msDashboard.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msDashboard.Image = Global.main.My.Resources.Resources._9055226_bxs_dashboard_icon
        Me.msDashboard.Name = "msDashboard"
        Me.msDashboard.Size = New System.Drawing.Size(167, 50)
        Me.msDashboard.Text = "Dashboard"
        '
        'msItem
        '
        Me.msItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msItem.Image = CType(resources.GetObject("msItem.Image"), System.Drawing.Image)
        Me.msItem.Name = "msItem"
        Me.msItem.Size = New System.Drawing.Size(106, 50)
        Me.msItem.Text = "Items"
        '
        'msBorrow
        '
        Me.msBorrow.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msBorrow.Image = Global.main.My.Resources.Resources.book
        Me.msBorrow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.msBorrow.Name = "msBorrow"
        Me.msBorrow.Size = New System.Drawing.Size(135, 50)
        Me.msBorrow.Text = "Borrow"
        '
        'msReturn
        '
        Me.msReturn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msReturn.Image = Global.main.My.Resources.Resources._return
        Me.msReturn.Name = "msReturn"
        Me.msReturn.Size = New System.Drawing.Size(120, 50)
        Me.msReturn.Text = "Return"
        '
        'msStudent
        '
        Me.msStudent.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msStudent.Image = Global.main.My.Resources.Resources._1564534_customer_man_user_account_profile_icon1
        Me.msStudent.Name = "msStudent"
        Me.msStudent.Size = New System.Drawing.Size(131, 50)
        Me.msStudent.Text = "Student"
        '
        'Timer1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.lblUser, Me.lblTime, Me.ToolStripLabel5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 803)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1539, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(97, 22)
        Me.ToolStripLabel2.Text = "Logged in as:"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(115, 22)
        Me.lblUser.Text = "ToolStripLabel4"
        '
        'lblTime
        '
        Me.lblTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(115, 22)
        Me.lblTime.Text = "ToolStripLabel4"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel5.Text = "Date | Time: "
        Me.ToolStripLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1539, 828)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ts)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CSTA | PROPERTY INVENTORY"
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
    Friend WithEvents lblTsManage As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents UIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DamageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton4 As ToolStripDropDownButton
    Friend WithEvents InventoryReportToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents DamageAccountibilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TeacherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ltsLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TransactionRepotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
