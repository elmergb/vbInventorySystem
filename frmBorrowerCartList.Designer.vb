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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtYearLevel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSchoolYear = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbSemester = New System.Windows.Forms.ComboBox()
        Me.cbTeacher = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.dgvBorrowerCart.Location = New System.Drawing.Point(16, 313)
        Me.dgvBorrowerCart.Name = "dgvBorrowerCart"
        Me.dgvBorrowerCart.ReadOnly = True
        Me.dgvBorrowerCart.RowHeadersVisible = False
        Me.dgvBorrowerCart.Size = New System.Drawing.Size(1262, 397)
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1386, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "  Borrowing"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Location = New System.Drawing.Point(112, 71)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(155, 20)
        Me.txtStudentNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Student No. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First Name:"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(112, 117)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.ReadOnly = True
        Me.txtfname.Size = New System.Drawing.Size(155, 20)
        Me.txtfname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Middle Initial:"
        '
        'txtmi
        '
        Me.txtmi.Location = New System.Drawing.Point(112, 159)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.ReadOnly = True
        Me.txtmi.Size = New System.Drawing.Size(155, 20)
        Me.txtmi.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Last Name:"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(112, 204)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.ReadOnly = True
        Me.txtlname.Size = New System.Drawing.Size(155, 20)
        Me.txtlname.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(310, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Year Level:"
        '
        'txtYearLevel
        '
        Me.txtYearLevel.Location = New System.Drawing.Point(410, 160)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.ReadOnly = True
        Me.txtYearLevel.Size = New System.Drawing.Size(155, 20)
        Me.txtYearLevel.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(310, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Section:"
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(410, 117)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(155, 20)
        Me.txtSection.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(310, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Course:"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(410, 71)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(155, 20)
        Me.txtCourse.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(621, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(621, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "School Year:"
        '
        'txtSchoolYear
        '
        Me.txtSchoolYear.Location = New System.Drawing.Point(721, 72)
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.Size = New System.Drawing.Size(155, 20)
        Me.txtSchoolYear.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(310, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Semester:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm tt"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(721, 114)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(155, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'cbSemester
        '
        Me.cbSemester.FormattingEnabled = True
        Me.cbSemester.Location = New System.Drawing.Point(410, 205)
        Me.cbSemester.Name = "cbSemester"
        Me.cbSemester.Size = New System.Drawing.Size(155, 21)
        Me.cbSemester.TabIndex = 24
        '
        'cbTeacher
        '
        Me.cbTeacher.FormattingEnabled = True
        Me.cbTeacher.Location = New System.Drawing.Point(721, 160)
        Me.cbTeacher.Name = "cbTeacher"
        Me.cbTeacher.Size = New System.Drawing.Size(155, 21)
        Me.cbTeacher.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(621, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 19)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Teacher:"
        '
        'frmBorrowerCartList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 916)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbTeacher)
        Me.Controls.Add(Me.cbSemester)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSchoolYear)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtYearLevel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStudentNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBorrowerCart)
        Me.Name = "frmBorrowerCartList"
        Me.Text = "frmBorrowerCartList"
        CType(Me.dgvBorrowerCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudentNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmi As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtYearLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSchoolYear As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbSemester As System.Windows.Forms.ComboBox
    Friend WithEvents cbTeacher As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
