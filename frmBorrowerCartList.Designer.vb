<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowerCartList
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
        Me.dgvBorrowerCart = New System.Windows.Forms.DataGridView()
        Me.BorrowID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvBorrowerCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBorrowerCart
        '
        Me.dgvBorrowerCart.AllowUserToAddRows = False
        Me.dgvBorrowerCart.AllowUserToDeleteRows = False
        Me.dgvBorrowerCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBorrowerCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowerCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BorrowID, Me.ItemID, Me.Column2, Me.ItemName, Me.QuantityBorrowed, Me.Contact, Me.Purpose, Me.DateBorrowed, Me.Remarks})
        Me.dgvBorrowerCart.Location = New System.Drawing.Point(25, 132)
        Me.dgvBorrowerCart.Name = "dgvBorrowerCart"
        Me.dgvBorrowerCart.ReadOnly = True
        Me.dgvBorrowerCart.RowHeadersVisible = False
        Me.dgvBorrowerCart.Size = New System.Drawing.Size(1262, 452)
        Me.dgvBorrowerCart.TabIndex = 0
        '
        'BorrowID
        '
        Me.BorrowID.DataPropertyName = "BorrowID"
        Me.BorrowID.HeaderText = "BorrowID"
        Me.BorrowID.Name = "BorrowID"
        Me.BorrowID.ReadOnly = True
        Me.BorrowID.Visible = False
        '
        'ItemID
        '
        Me.ItemID.DataPropertyName = "ItemID"
        Me.ItemID.HeaderText = "ItemID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        Me.ItemID.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "BorrowerName"
        Me.Column2.HeaderText = "Borrower Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.DataPropertyName = "ItemName"
        Me.ItemName.HeaderText = "item name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'QuantityBorrowed
        '
        Me.QuantityBorrowed.DataPropertyName = "QuantityBorrowed"
        Me.QuantityBorrowed.HeaderText = "Quantity Borrowed"
        Me.QuantityBorrowed.Name = "QuantityBorrowed"
        Me.QuantityBorrowed.ReadOnly = True
        '
        'Contact
        '
        Me.Contact.DataPropertyName = "Contact"
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        Me.Contact.ReadOnly = True
        '
        'Purpose
        '
        Me.Purpose.DataPropertyName = "Purpose"
        Me.Purpose.HeaderText = "Purpose"
        Me.Purpose.Name = "Purpose"
        Me.Purpose.ReadOnly = True
        '
        'DateBorrowed
        '
        Me.DateBorrowed.DataPropertyName = "DateBorrowed"
        Me.DateBorrowed.HeaderText = "DateBorrowed"
        Me.DateBorrowed.Name = "DateBorrowed"
        Me.DateBorrowed.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'frmBorrowerCartList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 596)
        Me.Controls.Add(Me.dgvBorrowerCart)
        Me.Name = "frmBorrowerCartList"
        Me.Text = "frmBorrowerCartList"
        CType(Me.dgvBorrowerCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBorrowerCart As DataGridView
    Friend WithEvents BorrowID As DataGridViewTextBoxColumn
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents QuantityBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents Purpose As DataGridViewTextBoxColumn
    Friend WithEvents DateBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
End Class
