<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGoodItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvItemList = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameOfItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Damaged = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvItemList
        '
        Me.dgvItemList.AllowUserToAddRows = False
        Me.dgvItemList.AllowUserToDeleteRows = False
        Me.dgvItemList.AllowUserToResizeColumns = False
        Me.dgvItemList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvItemList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemList.BackgroundColor = System.Drawing.Color.White
        Me.dgvItemList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.NameOfItem, Me.ItemDesc, Me.Category, Me.ItemLocation, Me.Quantity, Me.Status, Me.Remarks, Me.Damaged})
        Me.dgvItemList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvItemList.Location = New System.Drawing.Point(29, 151)
        Me.dgvItemList.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvItemList.Name = "dgvItemList"
        Me.dgvItemList.ReadOnly = True
        Me.dgvItemList.RowHeadersVisible = False
        Me.dgvItemList.RowHeadersWidth = 50
        Me.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemList.Size = New System.Drawing.Size(1186, 548)
        Me.dgvItemList.TabIndex = 1
        '
        'Item
        '
        Me.Item.DataPropertyName = "ItemID"
        Me.Item.FillWeight = 60.0!
        Me.Item.HeaderText = "Item ID"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Visible = False
        '
        'NameOfItem
        '
        Me.NameOfItem.DataPropertyName = "Name"
        Me.NameOfItem.HeaderText = "Name"
        Me.NameOfItem.Name = "NameOfItem"
        Me.NameOfItem.ReadOnly = True
        '
        'ItemDesc
        '
        Me.ItemDesc.DataPropertyName = "ItemDescription"
        Me.ItemDesc.HeaderText = "Description"
        Me.ItemDesc.Name = "ItemDesc"
        Me.ItemDesc.ReadOnly = True
        '
        'Category
        '
        Me.Category.DataPropertyName = "ItemCategory"
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'ItemLocation
        '
        Me.ItemLocation.DataPropertyName = "ItemLocation"
        Me.ItemLocation.HeaderText = "Location"
        Me.ItemLocation.Name = "ItemLocation"
        Me.ItemLocation.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "ItemStatus"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "ItemRemarks"
        Me.Remarks.FillWeight = 150.0!
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'Damaged
        '
        Me.Damaged.DataPropertyName = "ItemDamage"
        Me.Damaged.HeaderText = "Quantity Damage"
        Me.Damaged.Name = "Damaged"
        Me.Damaged.ReadOnly = True
        Me.Damaged.Visible = False
        '
        'frmGoodItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1613, 764)
        Me.Controls.Add(Me.dgvItemList)
        Me.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGoodItem"
        Me.Text = "frmGoodItem"
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvItemList As System.Windows.Forms.DataGridView
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameOfItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Damaged As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
