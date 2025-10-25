<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.nupQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnLogSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbItemList = New System.Windows.Forms.ComboBox()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.cbBorrowRemarks = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpBorrowed = New System.Windows.Forms.DateTimePicker()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(65, 286)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(174, 20)
        Me.txtContact.TabIndex = 0
        '
        'nupQuantity
        '
        Me.nupQuantity.Location = New System.Drawing.Point(65, 226)
        Me.nupQuantity.Name = "nupQuantity"
        Me.nupQuantity.Size = New System.Drawing.Size(137, 20)
        Me.nupQuantity.TabIndex = 1
        '
        'btnLogSave
        '
        Me.btnLogSave.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogSave.Location = New System.Drawing.Point(161, 562)
        Me.btnLogSave.Name = "btnLogSave"
        Me.btnLogSave.Size = New System.Drawing.Size(153, 38)
        Me.btnLogSave.TabIndex = 2
        Me.btnLogSave.Text = "Log Borrow"
        Me.btnLogSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Borrower Name"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(303, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Purpose"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(303, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Time and Date"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(303, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Remarks/Notes"
        '
        'cbItemList
        '
        Me.cbItemList.FormattingEnabled = True
        Me.cbItemList.Location = New System.Drawing.Point(66, 100)
        Me.cbItemList.Name = "cbItemList"
        Me.cbItemList.Size = New System.Drawing.Size(161, 21)
        Me.cbItemList.TabIndex = 10
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Location = New System.Drawing.Point(65, 161)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(174, 20)
        Me.txtBorrowerName.TabIndex = 11
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(297, 100)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(174, 20)
        Me.txtPurpose.TabIndex = 12
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(36, 562)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(119, 38)
        Me.btnAddItem.TabIndex = 16
        Me.btnAddItem.Text = "Add"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1374, 55)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = " Borrow"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCart
        '
        Me.btnCart.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCart.Location = New System.Drawing.Point(320, 562)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(132, 38)
        Me.btnCart.TabIndex = 19
        Me.btnCart.Text = "Cart"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'cbBorrowRemarks
        '
        Me.cbBorrowRemarks.FormattingEnabled = True
        Me.cbBorrowRemarks.Location = New System.Drawing.Point(307, 233)
        Me.cbBorrowRemarks.Name = "cbBorrowRemarks"
        Me.cbBorrowRemarks.Size = New System.Drawing.Size(164, 21)
        Me.cbBorrowRemarks.TabIndex = 20
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(-3, 53)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnCart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpBorrowed)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbItemList)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbBorrowRemarks)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtContact)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nupQuantity)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBorrowerName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnLogSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddItem)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPurpose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvCart)
        Me.SplitContainer1.Size = New System.Drawing.Size(1377, 614)
        Me.SplitContainer1.SplitterDistance = 495
        Me.SplitContainer1.TabIndex = 21
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AllowUserToDeleteRows = False
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCart.Location = New System.Drawing.Point(0, 0)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.ReadOnly = True
        Me.dgvCart.Size = New System.Drawing.Size(878, 614)
        Me.dgvCart.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(878, 36)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Cart List"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpBorrowed
        '
        Me.dtpBorrowed.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dtpBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBorrowed.Location = New System.Drawing.Point(306, 162)
        Me.dtpBorrowed.Name = "dtpBorrowed"
        Me.dtpBorrowed.Size = New System.Drawing.Size(165, 20)
        Me.dtpBorrowed.TabIndex = 15
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(172, 12)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(310, 37)
        Me.txtSearch.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(73, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Search Item:"
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1374, 665)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmBorrow"
        Me.Text = "frmBorrow"
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents nupQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnLogSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbItemList As System.Windows.Forms.ComboBox
    Friend WithEvents txtBorrowerName As System.Windows.Forms.TextBox
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCart As Button
    Friend WithEvents cbBorrowRemarks As ComboBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dtpBorrowed As DateTimePicker
    Friend WithEvents Label10 As Label
End Class
