<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentlist
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvStudentList = New System.Windows.Forms.DataGridView()
        Me.sID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1390, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "   Student List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvStudentList
        '
        Me.dgvStudentList.AllowUserToAddRows = False
        Me.dgvStudentList.AllowUserToDeleteRows = False
        Me.dgvStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudentList.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudentList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sID, Me.studentNo, Me.fname, Me.mi, Me.lname, Me.course, Me.section, Me.Role, Me.yDesc, Me.isActive, Me.UserName, Me.pword})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudentList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudentList.Location = New System.Drawing.Point(4, 113)
        Me.dgvStudentList.Name = "dgvStudentList"
        Me.dgvStudentList.ReadOnly = True
        Me.dgvStudentList.RowHeadersVisible = False
        Me.dgvStudentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudentList.Size = New System.Drawing.Size(1379, 473)
        Me.dgvStudentList.TabIndex = 1
        '
        'sID
        '
        Me.sID.DataPropertyName = "sID"
        Me.sID.HeaderText = "sID"
        Me.sID.Name = "sID"
        Me.sID.ReadOnly = True
        Me.sID.Visible = False
        '
        'studentNo
        '
        Me.studentNo.DataPropertyName = "studentNo"
        Me.studentNo.HeaderText = "Student No."
        Me.studentNo.Name = "studentNo"
        Me.studentNo.ReadOnly = True
        '
        'fname
        '
        Me.fname.DataPropertyName = "fname"
        Me.fname.HeaderText = "First Name"
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        '
        'mi
        '
        Me.mi.DataPropertyName = "mi"
        Me.mi.HeaderText = "Middle Initial"
        Me.mi.Name = "mi"
        Me.mi.ReadOnly = True
        '
        'lname
        '
        Me.lname.DataPropertyName = "lname"
        Me.lname.HeaderText = "Last Name"
        Me.lname.Name = "lname"
        Me.lname.ReadOnly = True
        '
        'course
        '
        Me.course.DataPropertyName = "cCode"
        Me.course.HeaderText = "Course"
        Me.course.Name = "course"
        Me.course.ReadOnly = True
        '
        'section
        '
        Me.section.DataPropertyName = "section"
        Me.section.HeaderText = "Section"
        Me.section.Name = "section"
        Me.section.ReadOnly = True
        '
        'Role
        '
        Me.Role.DataPropertyName = "Role"
        Me.Role.HeaderText = "Role"
        Me.Role.Name = "Role"
        Me.Role.ReadOnly = True
        '
        'yDesc
        '
        Me.yDesc.DataPropertyName = "yDesc"
        Me.yDesc.HeaderText = "Year Level"
        Me.yDesc.Name = "yDesc"
        Me.yDesc.ReadOnly = True
        '
        'isActive
        '
        Me.isActive.DataPropertyName = "isActive"
        Me.isActive.HeaderText = "Status"
        Me.isActive.Name = "isActive"
        Me.isActive.ReadOnly = True
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "Username"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'pword
        '
        Me.pword.DataPropertyName = "pword"
        Me.pword.HeaderText = "password"
        Me.pword.Name = "pword"
        Me.pword.ReadOnly = True
        Me.pword.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(25, 592)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(106, 592)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(187, 592)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmStudentlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1390, 627)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvStudentList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStudentlist"
        Me.Text = "frmStudentlist"
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvStudentList As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents sID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents studentNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents course As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents section As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Role As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isActive As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pword As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
