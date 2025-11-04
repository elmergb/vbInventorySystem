<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDamageItem
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
        Me.dgvDamageItems = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Items = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DamageLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateReported = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDamageItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDamageItems
        '
        Me.dgvDamageItems.AllowUserToAddRows = False
        Me.dgvDamageItems.AllowUserToDeleteRows = False
        Me.dgvDamageItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDamageItems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDamageItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDamageItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDamageItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Items, Me.Description, Me.Category, Me.DamageLocation, Me.Quantity, Me.dateReported})
        Me.dgvDamageItems.GridColor = System.Drawing.SystemColors.Control
        Me.dgvDamageItems.Location = New System.Drawing.Point(25, 123)
        Me.dgvDamageItems.Name = "dgvDamageItems"
        Me.dgvDamageItems.ReadOnly = True
        Me.dgvDamageItems.RowHeadersVisible = False
        Me.dgvDamageItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDamageItems.Size = New System.Drawing.Size(1016, 445)
        Me.dgvDamageItems.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1259, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "   Damage Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ID
        '
        Me.ID.DataPropertyName = "DamageID"
        Me.ID.HeaderText = "Damage ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Items
        '
        Me.Items.DataPropertyName = "ItemName"
        Me.Items.HeaderText = "Item"
        Me.Items.Name = "Items"
        Me.Items.ReadOnly = True
        '
        'Description
        '
        Me.Description.DataPropertyName = "ItemDescription"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Category
        '
        Me.Category.DataPropertyName = "ItemCategory"
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'DamageLocation
        '
        Me.DamageLocation.DataPropertyName = "ItemLocation"
        Me.DamageLocation.HeaderText = "Location"
        Me.DamageLocation.Name = "DamageLocation"
        Me.DamageLocation.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "QuantityDamaged"
        Me.Quantity.HeaderText = "Quantity Damage"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'dateReported
        '
        Me.dateReported.DataPropertyName = "DateReported"
        Me.dateReported.HeaderText = "Date Reported"
        Me.dateReported.Name = "dateReported"
        Me.dateReported.ReadOnly = True
        '
        'frmDamageItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 634)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDamageItems)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDamageItem"
        Me.Text = "frmDamageItem"
        CType(Me.dgvDamageItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDamageItems As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Items As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DamageLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateReported As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
