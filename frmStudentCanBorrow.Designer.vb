<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentCanBorrow
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStudentNumber = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCourses = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.txtPword = New System.Windows.Forms.TextBox()
        Me.lbluname = New System.Windows.Forms.Label()
        Me.lblpword = New System.Windows.Forms.Label()
        Me.ckbisActive = New System.Windows.Forms.CheckBox()
        Me.cbRole = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(19, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 29)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Student Number:"
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNumber.Location = New System.Drawing.Point(24, 123)
        Me.txtStudentNumber.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(200, 26)
        Me.txtStudentNumber.TabIndex = 24
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(24, 183)
        Me.txtfname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(200, 26)
        Me.txtfname.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(273, 216)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 29)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Year Level:"
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(24, 293)
        Me.txtlname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(200, 26)
        Me.txtlname.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 271)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 29)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Last Name:"
        '
        'txtmi
        '
        Me.txtmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmi.Location = New System.Drawing.Point(24, 238)
        Me.txtmi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(200, 26)
        Me.txtmi.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 216)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 29)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Middle Initial:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 156)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "First Name:"
        '
        'cbCourses
        '
        Me.cbCourses.FormattingEnabled = True
        Me.cbCourses.Location = New System.Drawing.Point(274, 123)
        Me.cbCourses.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbCourses.Name = "cbCourses"
        Me.cbCourses.Size = New System.Drawing.Size(201, 23)
        Me.cbCourses.TabIndex = 26
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Location = New System.Drawing.Point(274, 242)
        Me.cbYear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(201, 23)
        Me.cbYear.TabIndex = 27
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(431, 395)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 52)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(270, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 29)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Course:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(270, 156)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 29)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Section:"
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.Location = New System.Drawing.Point(274, 183)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(201, 26)
        Me.txtSection.TabIndex = 30
        '
        'txtuname
        '
        Me.txtuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.Location = New System.Drawing.Point(23, 351)
        Me.txtuname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(201, 26)
        Me.txtuname.TabIndex = 31
        '
        'txtPword
        '
        Me.txtPword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPword.Location = New System.Drawing.Point(274, 351)
        Me.txtPword.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPword.Name = "txtPword"
        Me.txtPword.Size = New System.Drawing.Size(200, 26)
        Me.txtPword.TabIndex = 32
        '
        'lbluname
        '
        Me.lbluname.BackColor = System.Drawing.Color.Transparent
        Me.lbluname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluname.ForeColor = System.Drawing.Color.Black
        Me.lbluname.Location = New System.Drawing.Point(23, 329)
        Me.lbluname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(102, 29)
        Me.lbluname.TabIndex = 33
        Me.lbluname.Text = "Username:"
        '
        'lblpword
        '
        Me.lblpword.BackColor = System.Drawing.Color.Transparent
        Me.lblpword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpword.ForeColor = System.Drawing.Color.Black
        Me.lblpword.Location = New System.Drawing.Point(273, 329)
        Me.lblpword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpword.Name = "lblpword"
        Me.lblpword.Size = New System.Drawing.Size(102, 29)
        Me.lblpword.TabIndex = 34
        Me.lblpword.Text = "Password:"
        '
        'ckbisActive
        '
        Me.ckbisActive.AutoSize = True
        Me.ckbisActive.Location = New System.Drawing.Point(89, 384)
        Me.ckbisActive.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ckbisActive.Name = "ckbisActive"
        Me.ckbisActive.Size = New System.Drawing.Size(15, 14)
        Me.ckbisActive.TabIndex = 35
        Me.ckbisActive.UseVisualStyleBackColor = True
        '
        'cbRole
        '
        Me.cbRole.FormattingEnabled = True
        Me.cbRole.Location = New System.Drawing.Point(274, 297)
        Me.cbRole.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(201, 23)
        Me.cbRole.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(273, 271)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Role:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(23, 380)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 29)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Active:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 71)
        Me.Panel1.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(176, 19)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 32)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Registration"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStudentCanBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 468)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtStudentNumber)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbRole)
        Me.Controls.Add(Me.ckbisActive)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.txtPword)
        Me.Controls.Add(Me.lblpword)
        Me.Controls.Add(Me.lbluname)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.cbCourses)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmStudentCanBorrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudentCanBorrow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txtStudentNumber As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCourses As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents txtPword As System.Windows.Forms.TextBox
    Friend WithEvents lbluname As System.Windows.Forms.Label
    Friend WithEvents lblpword As System.Windows.Forms.Label
    Friend WithEvents ckbisActive As System.Windows.Forms.CheckBox
    Friend WithEvents cbRole As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
