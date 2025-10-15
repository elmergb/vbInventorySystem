<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.frmDBdgvItem = New System.Windows.Forms.DataGridView()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frmDBdgvReturn = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frmDBdgvBorrow = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblItemTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalBorrowed = New System.Windows.Forms.Label()
        Me.lblTotalReturned = New System.Windows.Forms.Label()
        Me.lblTotalDamaged = New System.Windows.Forms.Label()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.frmDBdgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmDBdgvReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmDBdgvBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 359)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Damage Items "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Recent Transactions"
        '
        'ToolTip1
        '
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Image = Global.main.My.Resources.Resources.borrowing
        Me.lbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl1.Location = New System.Drawing.Point(3, 11)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Padding = New System.Windows.Forms.Padding(5)
        Me.lbl1.Size = New System.Drawing.Size(129, 42)
        Me.lbl1.TabIndex = 17
        Me.lbl1.Text = "     Total Items:"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.frmDBdgvItem)
        Me.Panel4.Controls.Add(Me.frmDBdgvReturn)
        Me.Panel4.Controls.Add(Me.frmDBdgvBorrow)
        Me.Panel4.Location = New System.Drawing.Point(539, 342)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(619, 546)
        Me.Panel4.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Recent Borrow"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Recent Returns"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 399)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Recent Added Items"
        '
        'frmDBdgvItem
        '
        Me.frmDBdgvItem.AllowUserToAddRows = False
        Me.frmDBdgvItem.AllowUserToDeleteRows = False
        Me.frmDBdgvItem.AllowUserToResizeColumns = False
        Me.frmDBdgvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.frmDBdgvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.frmDBdgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.frmDBdgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.frmDBdgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column12, Me.Column11, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17})
        Me.frmDBdgvItem.Enabled = False
        Me.frmDBdgvItem.Location = New System.Drawing.Point(17, 415)
        Me.frmDBdgvItem.Name = "frmDBdgvItem"
        Me.frmDBdgvItem.ReadOnly = True
        Me.frmDBdgvItem.RowHeadersVisible = False
        Me.frmDBdgvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.frmDBdgvItem.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.frmDBdgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.frmDBdgvItem.Size = New System.Drawing.Size(586, 131)
        Me.frmDBdgvItem.TabIndex = 6
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "ItemID"
        Me.Column12.HeaderText = "ItemID"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "ItemName"
        Me.Column11.HeaderText = "Item "
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "ItemCategory"
        Me.Column13.HeaderText = "Category"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "ItemLocation"
        Me.Column14.HeaderText = "Location"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.DataPropertyName = "ItemQuantity"
        Me.Column15.HeaderText = "Quantity"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.DataPropertyName = "ItemStatus"
        Me.Column16.HeaderText = "Status"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'Column17
        '
        Me.Column17.DataPropertyName = "ItemRemarks"
        Me.Column17.HeaderText = "Remarks"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'frmDBdgvReturn
        '
        Me.frmDBdgvReturn.AllowUserToAddRows = False
        Me.frmDBdgvReturn.AllowUserToDeleteRows = False
        Me.frmDBdgvReturn.AllowUserToResizeColumns = False
        Me.frmDBdgvReturn.AllowUserToResizeRows = False
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.frmDBdgvReturn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.frmDBdgvReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.frmDBdgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.frmDBdgvReturn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.frmDBdgvReturn.Enabled = False
        Me.frmDBdgvReturn.Location = New System.Drawing.Point(13, 233)
        Me.frmDBdgvReturn.Name = "frmDBdgvReturn"
        Me.frmDBdgvReturn.ReadOnly = True
        Me.frmDBdgvReturn.RowHeadersVisible = False
        Me.frmDBdgvReturn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.frmDBdgvReturn.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.frmDBdgvReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.frmDBdgvReturn.Size = New System.Drawing.Size(590, 131)
        Me.frmDBdgvReturn.TabIndex = 5
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "ItemName"
        Me.Column6.FillWeight = 70.0!
        Me.Column6.HeaderText = "Item"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "BorrowerName"
        Me.Column7.FillWeight = 80.0!
        Me.Column7.HeaderText = "Borrower"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "QuantityBorrowed"
        Me.Column8.HeaderText = "Quantity Borrowed"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "QuantityReturned"
        Me.Column9.HeaderText = "Quantity Return"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "DateReturned"
        Me.Column10.FillWeight = 120.0!
        Me.Column10.HeaderText = "Date Return"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'frmDBdgvBorrow
        '
        Me.frmDBdgvBorrow.AllowUserToAddRows = False
        Me.frmDBdgvBorrow.AllowUserToDeleteRows = False
        Me.frmDBdgvBorrow.AllowUserToResizeColumns = False
        Me.frmDBdgvBorrow.AllowUserToResizeRows = False
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.frmDBdgvBorrow.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.frmDBdgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.frmDBdgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.frmDBdgvBorrow.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.frmDBdgvBorrow.Enabled = False
        Me.frmDBdgvBorrow.Location = New System.Drawing.Point(13, 62)
        Me.frmDBdgvBorrow.Name = "frmDBdgvBorrow"
        Me.frmDBdgvBorrow.ReadOnly = True
        Me.frmDBdgvBorrow.RowHeadersVisible = False
        Me.frmDBdgvBorrow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.frmDBdgvBorrow.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.frmDBdgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.frmDBdgvBorrow.Size = New System.Drawing.Size(590, 131)
        Me.frmDBdgvBorrow.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "BorrowerName"
        Me.Column1.HeaderText = "Borrower Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ItemName"
        Me.Column2.FillWeight = 80.0!
        Me.Column2.HeaderText = "Item Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "QuantityBorrowed"
        Me.Column3.HeaderText = "Quantity Borrowed"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Purpose"
        Me.Column4.FillWeight = 70.0!
        Me.Column4.HeaderText = "Purpose"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "DateBorrowed"
        Me.Column5.FillWeight = 120.0!
        Me.Column5.HeaderText = "Date Borrowed"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1190, 56)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "     Dashboard"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(351, 779)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(131, 45)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel5, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.tsDate, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(5, 5)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1188, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(65, 17)
        Me.ToolStripStatusLabel1.Text = "  Log in As:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel3.Text = "  Time:"
        '
        'tsDate
        '
        Me.tsDate.Name = "tsDate"
        Me.tsDate.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(146, 17)
        Me.ToolStripStatusLabel4.Text = "         ToolStripStatusLabel4"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl2.Image = Global.main.My.Resources.Resources.inventory
        Me.lbl2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl2.Location = New System.Drawing.Point(3, 53)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Padding = New System.Windows.Forms.Padding(7)
        Me.lbl2.Size = New System.Drawing.Size(176, 40)
        Me.lbl2.TabIndex = 16
        Me.lbl2.Text = "       Total Borrowed:"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblTotalDamaged)
        Me.Panel5.Controls.Add(Me.lblTotalReturned)
        Me.Panel5.Controls.Add(Me.lblTotalBorrowed)
        Me.Panel5.Controls.Add(Me.lblItemTotal)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.lbl1)
        Me.Panel5.Controls.Add(Me.lbl2)
        Me.Panel5.Location = New System.Drawing.Point(26, 112)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(238, 216)
        Me.Panel5.TabIndex = 13
        '
        'lblItemTotal
        '
        Me.lblItemTotal.AutoSize = True
        Me.lblItemTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemTotal.Location = New System.Drawing.Point(117, 18)
        Me.lblItemTotal.Name = "lblItemTotal"
        Me.lblItemTotal.Size = New System.Drawing.Size(20, 24)
        Me.lblItemTotal.TabIndex = 15
        Me.lblItemTotal.Text = "0"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Image = Global.main.My.Resources.Resources.inventory
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(7, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(7)
        Me.Label5.Size = New System.Drawing.Size(176, 40)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "       Total Returned:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Image = Global.main.My.Resources.Resources.inventory
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(7, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(7)
        Me.Label3.Size = New System.Drawing.Size(176, 40)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "       Total Damage:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalBorrowed
        '
        Me.lblTotalBorrowed.AutoSize = True
        Me.lblTotalBorrowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBorrowed.Location = New System.Drawing.Point(157, 59)
        Me.lblTotalBorrowed.Name = "lblTotalBorrowed"
        Me.lblTotalBorrowed.Size = New System.Drawing.Size(20, 24)
        Me.lblTotalBorrowed.TabIndex = 20
        Me.lblTotalBorrowed.Text = "0"
        '
        'lblTotalReturned
        '
        Me.lblTotalReturned.AutoSize = True
        Me.lblTotalReturned.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalReturned.Location = New System.Drawing.Point(157, 108)
        Me.lblTotalReturned.Name = "lblTotalReturned"
        Me.lblTotalReturned.Size = New System.Drawing.Size(20, 24)
        Me.lblTotalReturned.TabIndex = 21
        Me.lblTotalReturned.Text = "0"
        '
        'lblTotalDamaged
        '
        Me.lblTotalDamaged.AutoSize = True
        Me.lblTotalDamaged.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDamaged.Location = New System.Drawing.Point(157, 161)
        Me.lblTotalDamaged.Name = "lblTotalDamaged"
        Me.lblTotalDamaged.Size = New System.Drawing.Size(20, 24)
        Me.lblTotalDamaged.TabIndex = 22
        Me.lblTotalDamaged.Text = "0"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel5.Text = "Menu"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1201, 552)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDashboard"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "frmDashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.frmDBdgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmDBdgvReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmDBdgvBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents frmDBdgvReturn As DataGridView
    Friend WithEvents frmDBdgvBorrow As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button8 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents tsDate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents frmDBdgvItem As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
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
    Friend WithEvents lbl1 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents lbl2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblItemTotal As Label
    Friend WithEvents lblTotalReturned As Label
    Friend WithEvents lblTotalBorrowed As Label
    Friend WithEvents lblTotalDamaged As Label
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
End Class
