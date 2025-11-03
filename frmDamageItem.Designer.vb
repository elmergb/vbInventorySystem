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
        Me.dgvDamageItems = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DamageLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateReported = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDamageItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDamageItems
        '
        Me.dgvDamageItems.AllowUserToAddRows = False
        Me.dgvDamageItems.AllowUserToDeleteRows = False
        Me.dgvDamageItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDamageItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDamageItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Item, Me.Description, Me.Category, Me.DamageLocation, Me.Quantity, Me.dateReported})
        Me.dgvDamageItems.Location = New System.Drawing.Point(24, 70)
        Me.dgvDamageItems.Name = "dgvDamageItems"
        Me.dgvDamageItems.ReadOnly = True
        Me.dgvDamageItems.RowHeadersVisible = False
        Me.dgvDamageItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDamageItems.Size = New System.Drawing.Size(1210, 415)
        Me.dgvDamageItems.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "DamageID"
        Me.ID.HeaderText = "Damage ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Item
        '
        Me.Item.DataPropertyName = "ItemName"
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1259, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "   Damage Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDamageItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 589)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDamageItems)
        Me.Name = "frmDamageItem"
        Me.Text = "frmDamageItem"
        CType(Me.dgvDamageItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDamageItems As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DamageLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateReported As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
