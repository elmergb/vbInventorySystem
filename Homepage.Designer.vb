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
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ltsLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ltsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTsManage = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.UIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTsTransaction = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BorrowItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTsReports = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTsUser = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTsTime = New System.Windows.Forms.ToolStripLabel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnBorrowPage = New System.Windows.Forms.Button()
        Me.btnDashBoard = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnReturnList = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.pnlItem = New System.Windows.Forms.Panel()
        Me.BoroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ts
        '
        Me.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripDropDownButton1, Me.lblTsManage, Me.ToolStripDropDownButton2, Me.lblTsTransaction, Me.ToolStripDropDownButton3, Me.lblTsReports, Me.ToolStripDropDownButton4, Me.ToolStripLabel2, Me.lblTsUser, Me.ToolStripLabel4, Me.lblTsTime})
        Me.ts.Location = New System.Drawing.Point(0, 0)
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(1154, 25)
        Me.ts.TabIndex = 21
        Me.ts.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel1.Text = "Menu"
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
        'lblTsManage
        '
        Me.lblTsManage.Name = "lblTsManage"
        Me.lblTsManage.Size = New System.Drawing.Size(50, 22)
        Me.lblTsManage.Text = "Manage"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UIToolStripMenuItem, Me.BorrowesToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        '
        'UIToolStripMenuItem
        '
        Me.UIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DamageToolStripMenuItem})
        Me.UIToolStripMenuItem.Name = "UIToolStripMenuItem"
        Me.UIToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UIToolStripMenuItem.Text = "Items"
        '
        'DamageToolStripMenuItem
        '
        Me.DamageToolStripMenuItem.Name = "DamageToolStripMenuItem"
        Me.DamageToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.DamageToolStripMenuItem.Text = "Damage"
        '
        'BorrowesToolStripMenuItem
        '
        Me.BorrowesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoroToolStripMenuItem})
        Me.BorrowesToolStripMenuItem.Name = "BorrowesToolStripMenuItem"
        Me.BorrowesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BorrowesToolStripMenuItem.Text = "Borrowers"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.StudentListToolStripMenuItem.Text = "Student list"
        '
        'lblTsTransaction
        '
        Me.lblTsTransaction.Name = "lblTsTransaction"
        Me.lblTsTransaction.Size = New System.Drawing.Size(67, 22)
        Me.lblTsTransaction.Text = "Transaction"
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
        'lblTsReports
        '
        Me.lblTsReports.Name = "lblTsReports"
        Me.lblTsReports.Size = New System.Drawing.Size(47, 22)
        Me.lblTsReports.Text = "Reports"
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
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMain.Controls.Add(Me.btnBorrowPage)
        Me.pnlMain.Controls.Add(Me.btnDashBoard)
        Me.pnlMain.Controls.Add(Me.btnAddItem)
        Me.pnlMain.Controls.Add(Me.btnReturnList)
        Me.pnlMain.Controls.Add(Me.btnUser)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMain.Location = New System.Drawing.Point(0, 25)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1154, 64)
        Me.pnlMain.TabIndex = 22
        '
        'btnBorrowPage
        '
        Me.btnBorrowPage.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrowPage.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnBorrowPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnBorrowPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnBorrowPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowPage.Image = Global.main.My.Resources.Resources.borrowing
        Me.btnBorrowPage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrowPage.Location = New System.Drawing.Point(356, -1)
        Me.btnBorrowPage.Name = "btnBorrowPage"
        Me.btnBorrowPage.Size = New System.Drawing.Size(122, 64)
        Me.btnBorrowPage.TabIndex = 4
        Me.btnBorrowPage.Text = "Borrowed"
        Me.btnBorrowPage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrowPage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnBorrowPage.UseVisualStyleBackColor = False
        '
        'btnDashBoard
        '
        Me.btnDashBoard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashBoard.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnDashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashBoard.Image = Global.main.My.Resources.Resources._9055226_bxs_dashboard_icon
        Me.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDashBoard.Location = New System.Drawing.Point(128, -1)
        Me.btnDashBoard.Name = "btnDashBoard"
        Me.btnDashBoard.Size = New System.Drawing.Size(113, 64)
        Me.btnDashBoard.TabIndex = 6
        Me.btnDashBoard.Text = "Dashboard"
        Me.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnDashBoard.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.Transparent
        Me.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Image = Global.main.My.Resources.Resources.inventory
        Me.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddItem.Location = New System.Drawing.Point(238, -1)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(119, 64)
        Me.btnAddItem.TabIndex = 2
        Me.btnAddItem.Text = "Item"
        Me.btnAddItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnReturnList
        '
        Me.btnReturnList.BackColor = System.Drawing.Color.Transparent
        Me.btnReturnList.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnReturnList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnReturnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnReturnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnList.Location = New System.Drawing.Point(475, -1)
        Me.btnReturnList.Name = "btnReturnList"
        Me.btnReturnList.Size = New System.Drawing.Size(139, 64)
        Me.btnReturnList.TabIndex = 5
        Me.btnReturnList.Text = "Return"
        Me.btnReturnList.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReturnList.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.Transparent
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Image = Global.main.My.Resources.Resources._1564534_customer_man_user_account_profile_icon
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUser.Location = New System.Drawing.Point(26, -1)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(105, 64)
        Me.btnUser.TabIndex = 3
        Me.btnUser.Text = "User"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'pnlItem
        '
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlItem.Location = New System.Drawing.Point(0, 89)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(1154, 584)
        Me.pnlItem.TabIndex = 23
        '
        'BoroToolStripMenuItem
        '
        Me.BoroToolStripMenuItem.Name = "BoroToolStripMenuItem"
        Me.BoroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BoroToolStripMenuItem.Text = "Borrow"
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 673)
        Me.Controls.Add(Me.pnlItem)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.ts)
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Homepage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ts.ResumeLayout(False)
        Me.ts.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
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
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents btnBorrowPage As System.Windows.Forms.Button
    Friend WithEvents btnDashBoard As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnReturnList As System.Windows.Forms.Button
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents pnlItem As System.Windows.Forms.Panel
    Friend WithEvents BoroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
