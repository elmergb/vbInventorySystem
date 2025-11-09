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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvReturnLists = New System.Windows.Forms.DataGridView()
        Me.ReturnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qrtReturned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDamage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remaining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCondition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeReturned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DamageRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dgvReturnLists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvReturnLists
        '
        Me.dgvReturnLists.AllowUserToAddRows = False
        Me.dgvReturnLists.AllowUserToDeleteRows = False
        Me.dgvReturnLists.AllowUserToResizeColumns = False
        Me.dgvReturnLists.AllowUserToResizeRows = False
        Me.dgvReturnLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReturnLists.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturnLists.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReturnLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturnLists.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReturnID, Me.BorrowID, Me.StudentNo, Me.BorrowerName, Me.ItemName, Me.ItemDesc, Me.qtyBorrowed, Me.qrtReturned, Me.QuantityDamage, Me.Remaining, Me.ReturnStatus, Me.ItemCondition, Me.DateBorrowed, Me.DateTimeReturned, Me.TeacherName, Me.Contact, Me.purpose, Me.CourseCode, Me.YearLevel, Me.Semester, Me.SchoolYear, Me.ReturnRemarks, Me.DamageRemarks})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReturnLists.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReturnLists.EnableHeadersVisualStyles = False
        Me.dgvReturnLists.Location = New System.Drawing.Point(13, 163)
        Me.dgvReturnLists.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvReturnLists.Name = "dgvReturnLists"
        Me.dgvReturnLists.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturnLists.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReturnLists.RowHeadersVisible = False
        Me.dgvReturnLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturnLists.Size = New System.Drawing.Size(1911, 482)
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
        Me.BorrowID.DataPropertyName = "bID"
        Me.BorrowID.HeaderText = "Borrow ID"
        Me.BorrowID.Name = "BorrowID"
        Me.BorrowID.ReadOnly = True
        Me.BorrowID.Visible = False
        '
        'StudentNo
        '
        Me.StudentNo.DataPropertyName = "Student No"
        Me.StudentNo.HeaderText = "Student No"
        Me.StudentNo.Name = "StudentNo"
        Me.StudentNo.ReadOnly = True
        Me.StudentNo.Visible = False
        '
        'BorrowerName
        '
        Me.BorrowerName.DataPropertyName = "StudentName"
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
        'qrtReturned
        '
        Me.qrtReturned.DataPropertyName = "QuantityReturned"
        Me.qrtReturned.HeaderText = "Quantity Returned"
        Me.qrtReturned.Name = "qrtReturned"
        Me.qrtReturned.ReadOnly = True
        '
        'QuantityDamage
        '
        Me.QuantityDamage.DataPropertyName = "QuantityDamaged"
        Me.QuantityDamage.HeaderText = "Quantity Damaged"
        Me.QuantityDamage.Name = "QuantityDamage"
        Me.QuantityDamage.ReadOnly = True
        '
        'Remaining
        '
        Me.Remaining.DataPropertyName = "Remaining"
        Me.Remaining.HeaderText = "Remaining"
        Me.Remaining.Name = "Remaining"
        Me.Remaining.ReadOnly = True
        Me.Remaining.Visible = False
        '
        'ReturnStatus
        '
        Me.ReturnStatus.DataPropertyName = "ReturnStatus"
        Me.ReturnStatus.HeaderText = "Return Status "
        Me.ReturnStatus.Name = "ReturnStatus"
        Me.ReturnStatus.ReadOnly = True
        Me.ReturnStatus.Visible = False
        '
        'ItemCondition
        '
        Me.ItemCondition.DataPropertyName = "ItemCondition"
        Me.ItemCondition.HeaderText = "Item Condition"
        Me.ItemCondition.Name = "ItemCondition"
        Me.ItemCondition.ReadOnly = True
        '
        'DateBorrowed
        '
        Me.DateBorrowed.DataPropertyName = "DateBorrowed"
        Me.DateBorrowed.HeaderText = "Date Borrowed"
        Me.DateBorrowed.Name = "DateBorrowed"
        Me.DateBorrowed.ReadOnly = True
        '
        'DateTimeReturned
        '
        Me.DateTimeReturned.DataPropertyName = "DateTimeReturned"
        Me.DateTimeReturned.HeaderText = "DateReturned"
        Me.DateTimeReturned.Name = "DateTimeReturned"
        Me.DateTimeReturned.ReadOnly = True
        '
        'TeacherName
        '
        Me.TeacherName.DataPropertyName = "TeacherName"
        Me.TeacherName.HeaderText = "Teacher Name"
        Me.TeacherName.Name = "TeacherName"
        Me.TeacherName.ReadOnly = True
        Me.TeacherName.Visible = False
        '
        'Contact
        '
        Me.Contact.DataPropertyName = "Contact"
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        Me.Contact.ReadOnly = True
        Me.Contact.Visible = False
        '
        'purpose
        '
        Me.purpose.DataPropertyName = "Purpose"
        Me.purpose.HeaderText = "Purpose"
        Me.purpose.Name = "purpose"
        Me.purpose.ReadOnly = True
        Me.purpose.Visible = False
        '
        'CourseCode
        '
        Me.CourseCode.DataPropertyName = "CourseCode"
        Me.CourseCode.HeaderText = "Course"
        Me.CourseCode.Name = "CourseCode"
        Me.CourseCode.ReadOnly = True
        Me.CourseCode.Visible = False
        '
        'YearLevel
        '
        Me.YearLevel.DataPropertyName = "YearLevel"
        Me.YearLevel.HeaderText = "Year Level"
        Me.YearLevel.Name = "YearLevel"
        Me.YearLevel.ReadOnly = True
        Me.YearLevel.Visible = False
        '
        'Semester
        '
        Me.Semester.DataPropertyName = "Semester"
        Me.Semester.HeaderText = "Semester"
        Me.Semester.Name = "Semester"
        Me.Semester.ReadOnly = True
        Me.Semester.Visible = False
        '
        'SchoolYear
        '
        Me.SchoolYear.DataPropertyName = "SchoolYear"
        Me.SchoolYear.HeaderText = "SchoolYear"
        Me.SchoolYear.Name = "SchoolYear"
        Me.SchoolYear.ReadOnly = True
        Me.SchoolYear.Visible = False
        '
        'ReturnRemarks
        '
        Me.ReturnRemarks.DataPropertyName = "ReturnRemarks"
        Me.ReturnRemarks.HeaderText = "Return Remarks"
        Me.ReturnRemarks.Name = "ReturnRemarks"
        Me.ReturnRemarks.ReadOnly = True
        '
        'DamageRemarks
        '
        Me.DamageRemarks.DataPropertyName = "DamageRemarks"
        Me.DamageRemarks.HeaderText = "DamageRemarks"
        Me.DamageRemarks.Name = "DamageRemarks"
        Me.DamageRemarks.ReadOnly = True
        Me.DamageRemarks.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 76)
        Me.Panel1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Dubai", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(-24, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 57)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "     Return List"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1462, 121)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(419, 25)
        Me.txtSearch.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1217, 121)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(229, 24)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Search Borrower/ Item:"
        '
        'frmReturnSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 745)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvReturnLists)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReturnSub"
        Me.Text = "frmReturnSub"
        CType(Me.dgvReturnLists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvReturnLists As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ReturnID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qtyBorrowed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qrtReturned As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDamage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remaining As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemCondition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateBorrowed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimeReturned As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeacherName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents purpose As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearLevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Semester As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DamageRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
