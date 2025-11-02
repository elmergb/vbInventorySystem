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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvReturn = New System.Windows.Forms.DataGridView()
        Me.bID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyReturned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remaining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sections = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateborrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(1287, 166)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(99, 66)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.Label1.Size = New System.Drawing.Size(225, 45)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "     Borrower's List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtSearch.Location = New System.Drawing.Point(932, 74)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(400, 28)
        Me.txtSearch.TabIndex = 19
        Me.txtSearch.Text = "Search by Name/Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(872, 78)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReturn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bID, Me.ItemID, Me.studentNo, Me.borrowerName, Me.ItemName, Me.ItemDesc, Me.qtyBorrowed, Me.qtyReturned, Me.Remaining, Me.Status, Me.TeacherName, Me.CourseCode, Me.YearLevel, Me.Sections, Me.Semester, Me.dateborrowed, Me.SchoolYear, Me.purpose, Me.contact, Me.RemarksItem})
        Me.dgvReturn.Location = New System.Drawing.Point(8, 140)
        Me.dgvReturn.Name = "dgvReturn"
        Me.dgvReturn.ReadOnly = True
        Me.dgvReturn.RowHeadersVisible = False
        Me.dgvReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturn.Size = New System.Drawing.Size(1273, 371)
        Me.dgvReturn.TabIndex = 21
        '
        'bID
        '
        Me.bID.DataPropertyName = "BorrowID"
        Me.bID.FillWeight = 50.0!
        Me.bID.HeaderText = "BorrowID"
        Me.bID.Name = "bID"
        Me.bID.ReadOnly = True
        Me.bID.Visible = False
        '
        'ItemID
        '
        Me.ItemID.DataPropertyName = "ItemID"
        Me.ItemID.HeaderText = "ItemID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        Me.ItemID.Visible = False
        '
        'studentNo
        '
        Me.studentNo.DataPropertyName = "StudentNo"
        Me.studentNo.HeaderText = "Student No."
        Me.studentNo.Name = "studentNo"
        Me.studentNo.ReadOnly = True
        '
        'borrowerName
        '
        Me.borrowerName.DataPropertyName = "StudentName"
        Me.borrowerName.HeaderText = "Borrower Name"
        Me.borrowerName.Name = "borrowerName"
        Me.borrowerName.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.DataPropertyName = "ItemName"
        Me.ItemName.HeaderText = "Item"
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
        Me.qtyBorrowed.FillWeight = 60.0!
        Me.qtyBorrowed.HeaderText = "Quantity Borrowed"
        Me.qtyBorrowed.Name = "qtyBorrowed"
        Me.qtyBorrowed.ReadOnly = True
        '
        'qtyReturned
        '
        Me.qtyReturned.DataPropertyName = "QuantityReturned"
        Me.qtyReturned.HeaderText = "Quantity Returned"
        Me.qtyReturned.Name = "qtyReturned"
        Me.qtyReturned.ReadOnly = True
        '
        'Remaining
        '
        Me.Remaining.DataPropertyName = "Remaining"
        Me.Remaining.HeaderText = "Remaining"
        Me.Remaining.Name = "Remaining"
        Me.Remaining.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'TeacherName
        '
        Me.TeacherName.DataPropertyName = "TeacherName"
        Me.TeacherName.HeaderText = "Teacher Name"
        Me.TeacherName.Name = "TeacherName"
        Me.TeacherName.ReadOnly = True
        Me.TeacherName.Visible = False
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
        'Sections
        '
        Me.Sections.DataPropertyName = "Section"
        Me.Sections.HeaderText = "Section"
        Me.Sections.Name = "Sections"
        Me.Sections.ReadOnly = True
        Me.Sections.Visible = False
        '
        'Semester
        '
        Me.Semester.DataPropertyName = "Semester"
        Me.Semester.HeaderText = "Semester"
        Me.Semester.Name = "Semester"
        Me.Semester.ReadOnly = True
        Me.Semester.Visible = False
        '
        'dateborrowed
        '
        Me.dateborrowed.DataPropertyName = "DateBorrowed"
        Me.dateborrowed.HeaderText = "Date Borrowed"
        Me.dateborrowed.Name = "dateborrowed"
        Me.dateborrowed.ReadOnly = True
        '
        'SchoolYear
        '
        Me.SchoolYear.DataPropertyName = "SchoolYear"
        Me.SchoolYear.HeaderText = "School Year"
        Me.SchoolYear.Name = "SchoolYear"
        Me.SchoolYear.ReadOnly = True
        Me.SchoolYear.Visible = False
        '
        'purpose
        '
        Me.purpose.DataPropertyName = "Purpose"
        Me.purpose.HeaderText = "Purpose"
        Me.purpose.Name = "purpose"
        Me.purpose.ReadOnly = True
        '
        'contact
        '
        Me.contact.DataPropertyName = "Contact"
        Me.contact.HeaderText = "Contact"
        Me.contact.Name = "contact"
        Me.contact.ReadOnly = True
        '
        'RemarksItem
        '
        Me.RemarksItem.DataPropertyName = "Remarks"
        Me.RemarksItem.HeaderText = "Remarks"
        Me.RemarksItem.Name = "RemarksItem"
        Me.RemarksItem.ReadOnly = True
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
    Friend WithEvents ItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents studentNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents borrowerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qtyBorrowed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qtyReturned As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remaining As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeacherName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearLevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sections As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Semester As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateborrowed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents purpose As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarksItem As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
