<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDamageItemAY
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDamageAction = New System.Windows.Forms.DataGridView()
        Me.BorrowerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDamaged = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRequested = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCompleted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DamageID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReported = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DamageRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityReturned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDamageAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 76)
        Me.Panel1.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Dubai", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(16, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 57)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Damage Item"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvDamageAction
        '
        Me.dgvDamageAction.AllowUserToAddRows = False
        Me.dgvDamageAction.AllowUserToDeleteRows = False
        Me.dgvDamageAction.AllowUserToResizeColumns = False
        Me.dgvDamageAction.AllowUserToResizeRows = False
        Me.dgvDamageAction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDamageAction.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDamageAction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDamageAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDamageAction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BorrowerName, Me.StudentNo, Me.ItemName, Me.ItemDescription, Me.QuantityDamaged, Me.ActionID, Me.ActionType, Me.Status, Me.AmountPaid, Me.Notes, Me.DateRequested, Me.DateCompleted, Me.DamageID, Me.DateReported, Me.DamageRemarks, Me.ReturnID, Me.bID, Me.QuantityReturned, Me.ReturnRemarks, Me.borrowQty, Me.borrowDateTime, Me.Contact, Me.Purpose})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDamageAction.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDamageAction.Location = New System.Drawing.Point(33, 151)
        Me.dgvDamageAction.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDamageAction.Name = "dgvDamageAction"
        Me.dgvDamageAction.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDamageAction.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDamageAction.RowHeadersVisible = False
        Me.dgvDamageAction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDamageAction.Size = New System.Drawing.Size(1878, 514)
        Me.dgvDamageAction.TabIndex = 19
        '
        'BorrowerName
        '
        Me.BorrowerName.DataPropertyName = "StudentName"
        Me.BorrowerName.HeaderText = "Borrower Name"
        Me.BorrowerName.Name = "BorrowerName"
        Me.BorrowerName.ReadOnly = True
        '
        'StudentNo
        '
        Me.StudentNo.DataPropertyName = "StudentNo"
        Me.StudentNo.HeaderText = "Student No"
        Me.StudentNo.Name = "StudentNo"
        Me.StudentNo.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.DataPropertyName = "ItemName"
        Me.ItemName.HeaderText = "Item"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'ItemDescription
        '
        Me.ItemDescription.DataPropertyName = "ItemDescription"
        Me.ItemDescription.HeaderText = "Description"
        Me.ItemDescription.Name = "ItemDescription"
        Me.ItemDescription.ReadOnly = True
        '
        'QuantityDamaged
        '
        Me.QuantityDamaged.DataPropertyName = "QuantityDamaged"
        Me.QuantityDamaged.HeaderText = "Quantity Damage"
        Me.QuantityDamaged.Name = "QuantityDamaged"
        Me.QuantityDamaged.ReadOnly = True
        '
        'ActionID
        '
        Me.ActionID.DataPropertyName = "ActionID"
        Me.ActionID.HeaderText = "Action ID"
        Me.ActionID.Name = "ActionID"
        Me.ActionID.ReadOnly = True
        Me.ActionID.Visible = False
        '
        'ActionType
        '
        Me.ActionType.DataPropertyName = "ActionType"
        Me.ActionType.HeaderText = "Action Type"
        Me.ActionType.Name = "ActionType"
        Me.ActionType.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "ActionStatus"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'AmountPaid
        '
        Me.AmountPaid.DataPropertyName = "AmountPaid"
        Me.AmountPaid.HeaderText = "Amount Paid"
        Me.AmountPaid.Name = "AmountPaid"
        Me.AmountPaid.ReadOnly = True
        Me.AmountPaid.Visible = False
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "Remarks"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.Visible = False
        '
        'DateRequested
        '
        Me.DateRequested.DataPropertyName = "DateRequested"
        Me.DateRequested.HeaderText = "Date Requested"
        Me.DateRequested.Name = "DateRequested"
        Me.DateRequested.ReadOnly = True
        '
        'DateCompleted
        '
        Me.DateCompleted.DataPropertyName = "DateCompleted"
        Me.DateCompleted.HeaderText = "Date Completed"
        Me.DateCompleted.Name = "DateCompleted"
        Me.DateCompleted.ReadOnly = True
        Me.DateCompleted.Visible = False
        '
        'DamageID
        '
        Me.DamageID.DataPropertyName = "DamageID"
        Me.DamageID.HeaderText = "DamageID"
        Me.DamageID.Name = "DamageID"
        Me.DamageID.ReadOnly = True
        Me.DamageID.Visible = False
        '
        'DateReported
        '
        Me.DateReported.DataPropertyName = "DateReported"
        Me.DateReported.HeaderText = "Date Reported"
        Me.DateReported.Name = "DateReported"
        Me.DateReported.ReadOnly = True
        Me.DateReported.Visible = False
        '
        'DamageRemarks
        '
        Me.DamageRemarks.DataPropertyName = "DamageRemarks"
        Me.DamageRemarks.HeaderText = "Damage Remarks"
        Me.DamageRemarks.Name = "DamageRemarks"
        Me.DamageRemarks.ReadOnly = True
        Me.DamageRemarks.Visible = False
        '
        'ReturnID
        '
        Me.ReturnID.DataPropertyName = "ReturnID"
        Me.ReturnID.HeaderText = "Return ID"
        Me.ReturnID.Name = "ReturnID"
        Me.ReturnID.ReadOnly = True
        Me.ReturnID.Visible = False
        '
        'bID
        '
        Me.bID.DataPropertyName = "bID"
        Me.bID.HeaderText = "bID"
        Me.bID.Name = "bID"
        Me.bID.ReadOnly = True
        Me.bID.Visible = False
        '
        'QuantityReturned
        '
        Me.QuantityReturned.DataPropertyName = "QuantityReturned"
        Me.QuantityReturned.HeaderText = "Quantity Returned"
        Me.QuantityReturned.Name = "QuantityReturned"
        Me.QuantityReturned.ReadOnly = True
        Me.QuantityReturned.Visible = False
        '
        'ReturnRemarks
        '
        Me.ReturnRemarks.DataPropertyName = "ReturnRemarks"
        Me.ReturnRemarks.HeaderText = "Return Remarks"
        Me.ReturnRemarks.Name = "ReturnRemarks"
        Me.ReturnRemarks.ReadOnly = True
        Me.ReturnRemarks.Visible = False
        '
        'borrowQty
        '
        Me.borrowQty.DataPropertyName = "borrowQty"
        Me.borrowQty.HeaderText = "Borrow Quantity"
        Me.borrowQty.Name = "borrowQty"
        Me.borrowQty.ReadOnly = True
        Me.borrowQty.Visible = False
        '
        'borrowDateTime
        '
        Me.borrowDateTime.DataPropertyName = "borrowDateTime"
        Me.borrowDateTime.HeaderText = "Borrow Date Time"
        Me.borrowDateTime.Name = "borrowDateTime"
        Me.borrowDateTime.ReadOnly = True
        Me.borrowDateTime.Visible = False
        '
        'Contact
        '
        Me.Contact.DataPropertyName = "Contact"
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        Me.Contact.ReadOnly = True
        Me.Contact.Visible = False
        '
        'Purpose
        '
        Me.Purpose.DataPropertyName = "Purpose"
        Me.Purpose.HeaderText = "Purpose"
        Me.Purpose.Name = "Purpose"
        Me.Purpose.ReadOnly = True
        Me.Purpose.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.main.My.Resources.Resources.editing2
        Me.btnUpdate.Location = New System.Drawing.Point(95, 673)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(140, 61)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmDamageItemAY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 747)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvDamageAction)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDamageItemAY"
        Me.Text = "frmDamageItemAction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDamageAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvDamageAction As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents BorrowerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDamaged As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActionID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActionType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateRequested As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCompleted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DamageID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateReported As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DamageRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityReturned As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents borrowQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents borrowDateTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Purpose As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
