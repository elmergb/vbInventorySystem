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
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.nupQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnLogSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbItemList = New System.Windows.Forms.ComboBox()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.dtpBorrowed = New System.Windows.Forms.DateTimePicker()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(16, 292)
        Me.txtContact.Multiline = True
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(174, 30)
        Me.txtContact.TabIndex = 0
        '
        'nupQuantity
        '
        Me.nupQuantity.Location = New System.Drawing.Point(16, 230)
        Me.nupQuantity.Name = "nupQuantity"
        Me.nupQuantity.Size = New System.Drawing.Size(137, 20)
        Me.nupQuantity.TabIndex = 1
        '
        'btnLogSave
        '
        Me.btnLogSave.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogSave.Location = New System.Drawing.Point(380, 430)
        Me.btnLogSave.Name = "btnLogSave"
        Me.btnLogSave.Size = New System.Drawing.Size(102, 51)
        Me.btnLogSave.TabIndex = 2
        Me.btnLogSave.Text = "Log Borrow"
        Me.btnLogSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Borrower Name"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Purpose"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(304, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Time Borrowed"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(304, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Remarks/Notes"
        '
        'cbItemList
        '
        Me.cbItemList.FormattingEnabled = True
        Me.cbItemList.Location = New System.Drawing.Point(16, 97)
        Me.cbItemList.Name = "cbItemList"
        Me.cbItemList.Size = New System.Drawing.Size(161, 21)
        Me.cbItemList.TabIndex = 10
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Location = New System.Drawing.Point(16, 159)
        Me.txtBorrowerName.Multiline = True
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(174, 30)
        Me.txtBorrowerName.TabIndex = 11
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(308, 97)
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(174, 30)
        Me.txtPurpose.TabIndex = 12
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(308, 240)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(187, 30)
        Me.txtRemarks.TabIndex = 14
        '
        'dtpBorrowed
        '
        Me.dtpBorrowed.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dtpBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBorrowed.Location = New System.Drawing.Point(308, 169)
        Me.dtpBorrowed.Name = "dtpBorrowed"
        Me.dtpBorrowed.Size = New System.Drawing.Size(200, 20)
        Me.dtpBorrowed.TabIndex = 15
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 510)
        Me.Controls.Add(Me.dtpBorrowed)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.txtBorrowerName)
        Me.Controls.Add(Me.cbItemList)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogSave)
        Me.Controls.Add(Me.nupQuantity)
        Me.Controls.Add(Me.txtContact)
        Me.Name = "frmBorrow"
        Me.Text = "frmBorrow"
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents nupQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnLogSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbItemList As System.Windows.Forms.ComboBox
    Friend WithEvents txtBorrowerName As System.Windows.Forms.TextBox
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents dtpBorrowed As System.Windows.Forms.DateTimePicker
End Class
