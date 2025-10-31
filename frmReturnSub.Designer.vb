<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnSub
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
        Me.dgvReturnLists = New System.Windows.Forms.DataGridView()
        Me.ReturnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qrtReturned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataReturned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvReturnLists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReturnLists
        '
        Me.dgvReturnLists.AllowUserToAddRows = False
        Me.dgvReturnLists.AllowUserToDeleteRows = False
        Me.dgvReturnLists.AllowUserToResizeColumns = False
        Me.dgvReturnLists.AllowUserToResizeRows = False
        Me.dgvReturnLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturnLists.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReturnLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturnLists.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReturnID, Me.BorrowID, Me.ItemID, Me.BorrowerName, Me.ItemName, Me.purpose, Me.qtyBorrowed, Me.qrtReturned, Me.dataReturned, Me.remarks})
        Me.dgvReturnLists.EnableHeadersVisualStyles = False
        Me.dgvReturnLists.Location = New System.Drawing.Point(25, 110)
        Me.dgvReturnLists.Name = "dgvReturnLists"
        Me.dgvReturnLists.ReadOnly = True
        Me.dgvReturnLists.RowHeadersVisible = False
        Me.dgvReturnLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturnLists.Size = New System.Drawing.Size(1062, 392)
        Me.dgvReturnLists.TabIndex = 1
        '
        'ReturnID
        '
        Me.ReturnID.DataPropertyName = "ReturnID"
        Me.ReturnID.HeaderText = "Return ID"
        Me.ReturnID.Name = "ReturnID"
        Me.ReturnID.ReadOnly = True
        Me.ReturnID.Visible = False
        '
        'BorrowID
        '
        Me.BorrowID.DataPropertyName = "BorrowID"
        Me.BorrowID.HeaderText = "Borrow ID"
        Me.BorrowID.Name = "BorrowID"
        Me.BorrowID.ReadOnly = True
        Me.BorrowID.Visible = False
        '
        'ItemID
        '
        Me.ItemID.DataPropertyName = "ItemID"
        Me.ItemID.HeaderText = "Item ID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        Me.ItemID.Visible = False
        '
        'BorrowerName
        '
        Me.BorrowerName.DataPropertyName = "BorrowerName"
        Me.BorrowerName.HeaderText = "Borrower Name"
        Me.BorrowerName.Name = "BorrowerName"
        Me.BorrowerName.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.DataPropertyName = "ItemName"
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'purpose
        '
        Me.purpose.DataPropertyName = "Purpose"
        Me.purpose.HeaderText = "Purpose"
        Me.purpose.Name = "purpose"
        Me.purpose.ReadOnly = True
        '
        'qtyBorrowed
        '
        Me.qtyBorrowed.DataPropertyName = "QuantityBorrowed"
        Me.qtyBorrowed.HeaderText = "Quantity Borrowed"
        Me.qtyBorrowed.Name = "qtyBorrowed"
        Me.qtyBorrowed.ReadOnly = True
        '
        'qrtReturned
        '
        Me.qrtReturned.DataPropertyName = "QuantityReturned"
        Me.qrtReturned.HeaderText = "Quantity Returned"
        Me.qrtReturned.Name = "qrtReturned"
        Me.qrtReturned.ReadOnly = True
        '
        'dataReturned
        '
        Me.dataReturned.DataPropertyName = "DateReturned"
        Me.dataReturned.HeaderText = "Date Returned"
        Me.dataReturned.Name = "dataReturned"
        Me.dataReturned.ReadOnly = True
        '
        'remarks
        '
        Me.remarks.DataPropertyName = "Remarks"
        Me.remarks.HeaderText = "Remarks"
        Me.remarks.Name = "remarks"
        Me.remarks.ReadOnly = True
        '
        'frmReturnSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 605)
        Me.Controls.Add(Me.dgvReturnLists)
        Me.Name = "frmReturnSub"
        Me.Text = "frmReturnSub"
        CType(Me.dgvReturnLists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvReturnLists As System.Windows.Forms.DataGridView
    Friend WithEvents ReturnID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents purpose As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qtyBorrowed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qrtReturned As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataReturned As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents remarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
