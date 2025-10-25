<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReturnList
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturnList))
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.dgvReturnList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ts = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTsManage = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.UIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvReturnList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(1269, 327)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(99, 66)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'dgvReturnList
        '
        Me.dgvReturnList.AllowUserToAddRows = False
        Me.dgvReturnList.AllowUserToDeleteRows = False
        Me.dgvReturnList.AllowUserToResizeColumns = False
        Me.dgvReturnList.AllowUserToResizeRows = False
        Me.dgvReturnList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturnList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReturnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturnList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgvReturnList.EnableHeadersVisualStyles = False
        Me.dgvReturnList.Location = New System.Drawing.Point(21, 144)
        Me.dgvReturnList.Name = "dgvReturnList"
        Me.dgvReturnList.ReadOnly = True
        Me.dgvReturnList.RowHeadersVisible = False
        Me.dgvReturnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturnList.Size = New System.Drawing.Size(1223, 603)
        Me.dgvReturnList.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ReturnID"
        Me.Column1.HeaderText = "Return ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "BorrowID"
        Me.Column2.HeaderText = "Borrow ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "ItemID"
        Me.Column3.HeaderText = "Item ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ItemName"
        Me.Column4.HeaderText = "Item Name"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "BorrowerName"
        Me.Column5.HeaderText = "Borrower Name"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Purpose"
        Me.Column6.HeaderText = "Purpose"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "QuantityBorrowed"
        Me.Column7.HeaderText = "Quantity Borrowed"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "QuantityReturned"
        Me.Column8.HeaderText = "Quantity Returned"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "DateReturned"
        Me.Column9.HeaderText = "Date Returned"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "Remarks"
        Me.Column10.HeaderText = "Remarks"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'ts
        '
        Me.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripDropDownButton1, Me.lblTsManage, Me.ToolStripDropDownButton2, Me.lblTsTransaction, Me.ToolStripDropDownButton3, Me.lblTsReports, Me.ToolStripDropDownButton4, Me.ToolStripLabel2, Me.lblTsUser, Me.ToolStripLabel4, Me.lblTsTime})
        Me.ts.Location = New System.Drawing.Point(0, 0)
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(1476, 25)
        Me.ts.TabIndex = 16
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
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoToolStripMenuItem, Me.EToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'LoToolStripMenuItem
        '
        Me.LoToolStripMenuItem.Name = "LoToolStripMenuItem"
        Me.LoToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LoToolStripMenuItem.Text = "Log out"
        '
        'EToolStripMenuItem
        '
        Me.EToolStripMenuItem.Name = "EToolStripMenuItem"
        Me.EToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.EToolStripMenuItem.Text = "Exit"
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
        Me.UIToolStripMenuItem.Name = "UIToolStripMenuItem"
        Me.UIToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.UIToolStripMenuItem.Text = "Items"
        '
        'BorrowesToolStripMenuItem
        '
        Me.BorrowesToolStripMenuItem.Name = "BorrowesToolStripMenuItem"
        Me.BorrowesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.BorrowesToolStripMenuItem.Text = "Borrowers"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1476, 62)
        Me.Panel1.TabIndex = 17
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtSearch.Location = New System.Drawing.Point(788, 110)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(427, 28)
        Me.txtSearch.TabIndex = 19
        Me.txtSearch.Text = "Search Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(728, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Search: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Dubai", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(-18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 45)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "     Returning List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmReturnList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1476, 664)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ts)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.dgvReturnList)
        Me.Name = "frmReturnList"
        Me.Text = "frmReturnList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvReturnList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts.ResumeLayout(False)
        Me.ts.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReturn As Button
    Friend WithEvents dgvReturnList As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents ts As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents LoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTsManage As ToolStripLabel
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents UIToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
