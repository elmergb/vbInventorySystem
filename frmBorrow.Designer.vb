<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrow
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.nupQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbBorrowRemarks = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpBorrowed = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.cbItemList = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStudentNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSemester = New System.Windows.Forms.TextBox()
        Me.txtYearLevel = New System.Windows.Forms.TextBox()
        Me.txtSchoolYear = New System.Windows.Forms.TextBox()
        Me.txtTeacher = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtSection = New System.Windows.Forms.TextBox()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(574, 59)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Borrow"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Items:"
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(334, 98)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(202, 20)
        Me.txtPurpose.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 531)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Borrower Name"
        Me.Label3.Visible = False
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Location = New System.Drawing.Point(243, 559)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(202, 20)
        Me.txtBorrowerName.TabIndex = 11
        Me.txtBorrowerName.Visible = False
        '
        'nupQuantity
        '
        Me.nupQuantity.Location = New System.Drawing.Point(54, 234)
        Me.nupQuantity.Name = "nupQuantity"
        Me.nupQuantity.Size = New System.Drawing.Size(99, 20)
        Me.nupQuantity.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(331, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact Number:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(331, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Purpose:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(336, 234)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(202, 20)
        Me.txtContact.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(332, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Remarks:"
        '
        'cbBorrowRemarks
        '
        Me.cbBorrowRemarks.FormattingEnabled = True
        Me.cbBorrowRemarks.Location = New System.Drawing.Point(335, 163)
        Me.cbBorrowRemarks.Name = "cbBorrowRemarks"
        Me.cbBorrowRemarks.Size = New System.Drawing.Size(201, 22)
        Me.cbBorrowRemarks.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(351, 443)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Time and Date"
        Me.Label6.Visible = False
        '
        'dtpBorrowed
        '
        Me.dtpBorrowed.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dtpBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBorrowed.Location = New System.Drawing.Point(355, 471)
        Me.dtpBorrowed.Name = "dtpBorrowed"
        Me.dtpBorrowed.Size = New System.Drawing.Size(192, 20)
        Me.dtpBorrowed.TabIndex = 15
        Me.dtpBorrowed.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(395, 296)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 45)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(53, 163)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(188, 20)
        Me.txtItemDesc.TabIndex = 22
        '
        'cbItemList
        '
        Me.cbItemList.FormattingEnabled = True
        Me.cbItemList.Location = New System.Drawing.Point(54, 98)
        Me.cbItemList.Name = "cbItemList"
        Me.cbItemList.Size = New System.Drawing.Size(187, 22)
        Me.cbItemList.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(7, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 36)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 25)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Item Description:"
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Location = New System.Drawing.Point(54, 446)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(202, 20)
        Me.txtStudentNo.TabIndex = 25
        Me.txtStudentNo.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(241, 593)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 25)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Student No"
        Me.Label10.Visible = False
        '
        'txtSemester
        '
        Me.txtSemester.Location = New System.Drawing.Point(408, 559)
        Me.txtSemester.Name = "txtSemester"
        Me.txtSemester.Size = New System.Drawing.Size(202, 20)
        Me.txtSemester.TabIndex = 27
        Me.txtSemester.Visible = False
        '
        'txtYearLevel
        '
        Me.txtYearLevel.Location = New System.Drawing.Point(406, 531)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.Size = New System.Drawing.Size(202, 20)
        Me.txtYearLevel.TabIndex = 28
        Me.txtYearLevel.Visible = False
        '
        'txtSchoolYear
        '
        Me.txtSchoolYear.Location = New System.Drawing.Point(55, 572)
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.Size = New System.Drawing.Size(200, 20)
        Me.txtSchoolYear.TabIndex = 29
        Me.txtSchoolYear.Visible = False
        '
        'txtTeacher
        '
        Me.txtTeacher.Location = New System.Drawing.Point(408, 502)
        Me.txtTeacher.Name = "txtTeacher"
        Me.txtTeacher.Size = New System.Drawing.Size(200, 20)
        Me.txtTeacher.TabIndex = 30
        Me.txtTeacher.Visible = False
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(57, 474)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(200, 20)
        Me.txtCourse.TabIndex = 31
        Me.txtCourse.Visible = False
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(57, 502)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(200, 20)
        Me.txtSection.TabIndex = 32
        Me.txtSection.Visible = False
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtTeacher)
        Me.Controls.Add(Me.txtSchoolYear)
        Me.Controls.Add(Me.txtYearLevel)
        Me.Controls.Add(Me.txtSemester)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtStudentNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbItemList)
        Me.Controls.Add(Me.dtpBorrowed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.cbBorrowRemarks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBorrowerName)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.nupQuantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBorrow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents nupQuantity As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbBorrowRemarks As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpBorrowed As DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents cbItemList As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtStudentNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSemester As System.Windows.Forms.TextBox
    Friend WithEvents txtYearLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtSchoolYear As System.Windows.Forms.TextBox
    Friend WithEvents txtTeacher As System.Windows.Forms.TextBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
End Class
