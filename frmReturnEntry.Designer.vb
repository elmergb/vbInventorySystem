<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReturnEntry
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
        Me.dtpBorrowedR = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nupQuantityR = New System.Windows.Forms.NumericUpDown()
        Me.btnReturnLog = New System.Windows.Forms.Button()
        Me.cbReturnRemarks = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbItemListR = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblStudentNo = New System.Windows.Forms.Label()
        Me.lblBorrowerName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblteacher = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.lblItemDesc = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.nupQuantityR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpBorrowedR
        '
        Me.dtpBorrowedR.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dtpBorrowedR.Enabled = False
        Me.dtpBorrowedR.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBorrowedR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBorrowedR.Location = New System.Drawing.Point(421, 39)
        Me.dtpBorrowedR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpBorrowedR.Name = "dtpBorrowedR"
        Me.dtpBorrowedR.Size = New System.Drawing.Size(187, 22)
        Me.dtpBorrowedR.TabIndex = 28
        Me.dtpBorrowedR.Value = New Date(2025, 11, 4, 8, 26, 0, 0)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(309, 80)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Remarks:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 39)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 25)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Date / Time Return: "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 118)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Purpose:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Quantity:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Item:"
        '
        'nupQuantityR
        '
        Me.nupQuantityR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupQuantityR.Location = New System.Drawing.Point(89, 158)
        Me.nupQuantityR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nupQuantityR.Name = "nupQuantityR"
        Me.nupQuantityR.Size = New System.Drawing.Size(160, 26)
        Me.nupQuantityR.TabIndex = 17
        '
        'btnReturnLog
        '
        Me.btnReturnLog.Location = New System.Drawing.Point(22, 497)
        Me.btnReturnLog.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnReturnLog.Name = "btnReturnLog"
        Me.btnReturnLog.Size = New System.Drawing.Size(84, 48)
        Me.btnReturnLog.TabIndex = 30
        Me.btnReturnLog.Text = "Return"
        Me.btnReturnLog.UseVisualStyleBackColor = True
        '
        'cbReturnRemarks
        '
        Me.cbReturnRemarks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReturnRemarks.FormattingEnabled = True
        Me.cbReturnRemarks.Location = New System.Drawing.Point(386, 77)
        Me.cbReturnRemarks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbReturnRemarks.Name = "cbReturnRemarks"
        Me.cbReturnRemarks.Size = New System.Drawing.Size(187, 26)
        Me.cbReturnRemarks.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(661, 55)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Return Entry"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 33)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbItemListR
        '
        Me.cbItemListR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbItemListR.FormattingEnabled = True
        Me.cbItemListR.Location = New System.Drawing.Point(58, 33)
        Me.cbItemListR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbItemListR.Name = "cbItemListR"
        Me.cbItemListR.Size = New System.Drawing.Size(185, 26)
        Me.cbItemListR.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 23)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Student No:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 110)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 25)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Course:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 86)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 25)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Semester:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 33)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 25)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Teacher:"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 80)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 25)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Description:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 85)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 25)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Section:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 111)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 25)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "School Year:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 60)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 25)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Contact:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 135)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 25)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Year Level:"
        '
        'lblStudentNo
        '
        Me.lblStudentNo.AutoSize = True
        Me.lblStudentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNo.Location = New System.Drawing.Point(108, 31)
        Me.lblStudentNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentNo.Name = "lblStudentNo"
        Me.lblStudentNo.Size = New System.Drawing.Size(90, 20)
        Me.lblStudentNo.TabIndex = 53
        Me.lblStudentNo.Text = "Student No"
        '
        'lblBorrowerName
        '
        Me.lblBorrowerName.AutoSize = True
        Me.lblBorrowerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerName.Location = New System.Drawing.Point(75, 60)
        Me.lblBorrowerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBorrowerName.Name = "lblBorrowerName"
        Me.lblBorrowerName.Size = New System.Drawing.Size(73, 20)
        Me.lblBorrowerName.TabIndex = 54
        Me.lblBorrowerName.Text = "Borrower"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblYearLevel)
        Me.GroupBox1.Controls.Add(Me.lblCourse)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lblSection)
        Me.GroupBox1.Controls.Add(Me.lblStudentNo)
        Me.GroupBox1.Controls.Add(Me.lblBorrowerName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 184)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower Info"
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevel.Location = New System.Drawing.Point(92, 135)
        Me.lblYearLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(84, 20)
        Me.lblYearLevel.TabIndex = 57
        Me.lblYearLevel.Text = "Year Level"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(73, 110)
        Me.lblCourse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(60, 20)
        Me.lblCourse.TabIndex = 56
        Me.lblCourse.Text = "Course"
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(73, 85)
        Me.lblSection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(63, 20)
        Me.lblSection.TabIndex = 55
        Me.lblSection.Text = "Section"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSchoolYear)
        Me.GroupBox2.Controls.Add(Me.lblSemester)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblContact)
        Me.GroupBox2.Controls.Add(Me.lblteacher)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(301, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 184)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction Info"
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYear.Location = New System.Drawing.Point(111, 110)
        Me.lblSchoolYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(96, 20)
        Me.lblSchoolYear.TabIndex = 61
        Me.lblSchoolYear.Text = "School Year"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(87, 86)
        Me.lblSemester.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(78, 20)
        Me.lblSemester.TabIndex = 60
        Me.lblSemester.Text = "Semester"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(81, 60)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(65, 20)
        Me.lblContact.TabIndex = 59
        Me.lblContact.Text = "Contact"
        '
        'lblteacher
        '
        Me.lblteacher.AutoSize = True
        Me.lblteacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblteacher.Location = New System.Drawing.Point(81, 33)
        Me.lblteacher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblteacher.Name = "lblteacher"
        Me.lblteacher.Size = New System.Drawing.Size(67, 20)
        Me.lblteacher.TabIndex = 58
        Me.lblteacher.Text = "Teacher"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpBorrowedR)
        Me.GroupBox3.Controls.Add(Me.cbItemListR)
        Me.GroupBox3.Controls.Add(Me.nupQuantityR)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblPurpose)
        Me.GroupBox3.Controls.Add(Me.lblItemDesc)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbReturnRemarks)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 277)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(622, 203)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item Details"
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurpose.Location = New System.Drawing.Point(92, 117)
        Me.lblPurpose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(68, 20)
        Me.lblPurpose.TabIndex = 63
        Me.lblPurpose.Text = "Purpose"
        '
        'lblItemDesc
        '
        Me.lblItemDesc.AutoSize = True
        Me.lblItemDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDesc.Location = New System.Drawing.Point(108, 80)
        Me.lblItemDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemDesc.Name = "lblItemDesc"
        Me.lblItemDesc.Size = New System.Drawing.Size(125, 20)
        Me.lblItemDesc.TabIndex = 62
        Me.lblItemDesc.Text = "Item Description"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label17.Location = New System.Drawing.Point(-1, 55)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(662, 536)
        Me.Label17.TabIndex = 62
        '
        'frmReturnEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 587)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnReturnLog)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmReturnEntry"
        Me.Text = "frmReturnEntry"
        CType(Me.nupQuantityR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpBorrowedR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nupQuantityR As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnReturnLog As System.Windows.Forms.Button
    Friend WithEvents cbReturnRemarks As ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbItemListR As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblStudentNo As System.Windows.Forms.Label
    Friend WithEvents lblBorrowerName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSchoolYear As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents lblteacher As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPurpose As System.Windows.Forms.Label
    Friend WithEvents lblItemDesc As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
