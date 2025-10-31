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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvReturn = New System.Windows.Forms.DataGridView()
        Me.bID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateborrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvReturn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1476, 62)
        Me.Panel1.TabIndex = 17
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
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtSearch.Location = New System.Drawing.Point(785, 82)
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
        Me.Label2.Location = New System.Drawing.Point(725, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Search: "
        '
        'dgvReturn
        '
        Me.dgvReturn.AllowUserToAddRows = False
        Me.dgvReturn.AllowUserToDeleteRows = False
        Me.dgvReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bID, Me.itemID, Me.borrowerName, Me.ItemName, Me.ItemDesc, Me.qtyBorrowed, Me.contact, Me.purpose, Me.dateborrowed, Me.Remarks})
        Me.dgvReturn.Location = New System.Drawing.Point(53, 129)
        Me.dgvReturn.Name = "dgvReturn"
        Me.dgvReturn.ReadOnly = True
        Me.dgvReturn.RowHeadersVisible = False
        Me.dgvReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturn.Size = New System.Drawing.Size(1145, 502)
        Me.dgvReturn.TabIndex = 21
        '
        'bID
        '
        Me.bID.DataPropertyName = "BorrowID"
        Me.bID.HeaderText = "BorrowID"
        Me.bID.Name = "bID"
        Me.bID.ReadOnly = True
        Me.bID.Visible = False
        '
        'itemID
        '
        Me.itemID.DataPropertyName = "ItemID"
        Me.itemID.HeaderText = "ItemID"
        Me.itemID.Name = "itemID"
        Me.itemID.ReadOnly = True
        Me.itemID.Visible = False
        '
        'borrowerName
        '
        Me.borrowerName.DataPropertyName = "BorrowerName"
        Me.borrowerName.HeaderText = "Borrower Name"
        Me.borrowerName.Name = "borrowerName"
        Me.borrowerName.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.DataPropertyName = "ItemName"
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'ItemDesc
        '
        Me.ItemDesc.DataPropertyName = "ItemDescription"
        Me.ItemDesc.HeaderText = "Description"
        Me.ItemDesc.Name = "ItemDesc"
        Me.ItemDesc.ReadOnly = True
        '
        'qtyBorrowed
        '
        Me.qtyBorrowed.DataPropertyName = "QuantityBorrowed"
        Me.qtyBorrowed.HeaderText = "Quantity Borrowed"
        Me.qtyBorrowed.Name = "qtyBorrowed"
        Me.qtyBorrowed.ReadOnly = True
        '
        'contact
        '
        Me.contact.DataPropertyName = "Contact"
        Me.contact.HeaderText = "Contact"
        Me.contact.Name = "contact"
        Me.contact.ReadOnly = True
        '
        'purpose
        '
        Me.purpose.DataPropertyName = "Purpose"
        Me.purpose.HeaderText = "Purpose"
        Me.purpose.Name = "purpose"
        Me.purpose.ReadOnly = True
        '
        'dateborrowed
        '
        Me.dateborrowed.DataPropertyName = "DateBorrowed"
        Me.dateborrowed.HeaderText = "Date Borrowed"
        Me.dateborrowed.Name = "dateborrowed"
        Me.dateborrowed.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'frmReturnList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1476, 664)
        Me.Controls.Add(Me.dgvReturn)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "frmReturnList"
        Me.Text = "frmReturnList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReturn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvReturn As System.Windows.Forms.DataGridView
    Friend WithEvents bID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents borrowerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qtyBorrowed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents purpose As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateborrowed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
