<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDamageActionEntry
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbActionType = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.lblStudentNo = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblqtyDamage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name:"
        '
        'cbActionType
        '
        Me.cbActionType.FormattingEnabled = True
        Me.cbActionType.Location = New System.Drawing.Point(104, 227)
        Me.cbActionType.Name = "cbActionType"
        Me.cbActionType.Size = New System.Drawing.Size(121, 21)
        Me.cbActionType.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(115, 268)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(148, 20)
        Me.txtAmount.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Student No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Item Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Action:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Amount:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(115, 305)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(148, 20)
        Me.txtRemarks.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Remarks:"
        '
        'dtpDateTime
        '
        Me.dtpDateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dtpDateTime.Location = New System.Drawing.Point(454, 93)
        Me.dtpDateTime.Name = "dtpDateTime"
        Me.dtpDateTime.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateTime.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(356, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Date/Time: "
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(439, 370)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 38)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent.Location = New System.Drawing.Point(159, 94)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(104, 19)
        Me.lblStudent.TabIndex = 12
        Me.lblStudent.Text = "Student Name"
        '
        'lblStudentNo
        '
        Me.lblStudentNo.AutoSize = True
        Me.lblStudentNo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentNo.Location = New System.Drawing.Point(159, 133)
        Me.lblStudentNo.Name = "lblStudentNo"
        Me.lblStudentNo.Size = New System.Drawing.Size(84, 19)
        Me.lblStudentNo.TabIndex = 13
        Me.lblStudentNo.Text = "Student No"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(159, 168)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(83, 19)
        Me.lblItemName.TabIndex = 14
        Me.lblItemName.Text = "Item Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Quantity Damage:"
        '
        'lblqtyDamage
        '
        Me.lblqtyDamage.AutoSize = True
        Me.lblqtyDamage.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqtyDamage.Location = New System.Drawing.Point(198, 196)
        Me.lblqtyDamage.Name = "lblqtyDamage"
        Me.lblqtyDamage.Size = New System.Drawing.Size(30, 19)
        Me.lblqtyDamage.TabIndex = 16
        Me.lblqtyDamage.Text = "qty"
        '
        'frmDamageActionEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 529)
        Me.Controls.Add(Me.lblqtyDamage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.lblStudentNo)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpDateTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cbActionType)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDamageActionEntry"
        Me.Text = "frmDamageActionEntry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbActionType As System.Windows.Forms.ComboBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblStudent As System.Windows.Forms.Label
    Friend WithEvents lblStudentNo As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblqtyDamage As System.Windows.Forms.Label
End Class
