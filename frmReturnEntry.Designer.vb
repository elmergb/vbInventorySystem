<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnEntry
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
        Me.dtpBorrowedR = New System.Windows.Forms.DateTimePicker()
        Me.txtRemarksR = New System.Windows.Forms.TextBox()
        Me.txtBorrowerNameR = New System.Windows.Forms.TextBox()
        Me.cbItemListR = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nupQuantityR = New System.Windows.Forms.NumericUpDown()
        Me.txtContactR = New System.Windows.Forms.TextBox()
        Me.txtPurposeR = New System.Windows.Forms.TextBox()
        Me.btnReturnLog = New System.Windows.Forms.Button()
        CType(Me.nupQuantityR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpBorrowedR
        '
        Me.dtpBorrowedR.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dtpBorrowedR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBorrowedR.Location = New System.Drawing.Point(353, 179)
        Me.dtpBorrowedR.Name = "dtpBorrowedR"
        Me.dtpBorrowedR.Size = New System.Drawing.Size(200, 20)
        Me.dtpBorrowedR.TabIndex = 28
        '
        'txtRemarksR
        '
        Me.txtRemarksR.Location = New System.Drawing.Point(353, 250)
        Me.txtRemarksR.Multiline = True
        Me.txtRemarksR.Name = "txtRemarksR"
        Me.txtRemarksR.Size = New System.Drawing.Size(187, 30)
        Me.txtRemarksR.TabIndex = 27
        '
        'txtBorrowerNameR
        '
        Me.txtBorrowerNameR.Location = New System.Drawing.Point(61, 169)
        Me.txtBorrowerNameR.Multiline = True
        Me.txtBorrowerNameR.Name = "txtBorrowerNameR"
        Me.txtBorrowerNameR.Size = New System.Drawing.Size(174, 30)
        Me.txtBorrowerNameR.TabIndex = 26
        '
        'cbItemListR
        '
        Me.cbItemListR.FormattingEnabled = True
        Me.cbItemListR.Location = New System.Drawing.Point(61, 107)
        Me.cbItemListR.Name = "cbItemListR"
        Me.cbItemListR.Size = New System.Drawing.Size(161, 21)
        Me.cbItemListR.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(349, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 23)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Remarks/Notes"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(349, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Time Borrowed"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(349, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Purpose"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Contact"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Borrower Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Item"
        '
        'nupQuantityR
        '
        Me.nupQuantityR.Location = New System.Drawing.Point(61, 240)
        Me.nupQuantityR.Name = "nupQuantityR"
        Me.nupQuantityR.Size = New System.Drawing.Size(137, 20)
        Me.nupQuantityR.TabIndex = 17
        '
        'txtContactR
        '
        Me.txtContactR.Location = New System.Drawing.Point(61, 302)
        Me.txtContactR.Multiline = True
        Me.txtContactR.Name = "txtContactR"
        Me.txtContactR.Size = New System.Drawing.Size(174, 30)
        Me.txtContactR.TabIndex = 16
        '
        'txtPurposeR
        '
        Me.txtPurposeR.Location = New System.Drawing.Point(353, 110)
        Me.txtPurposeR.Multiline = True
        Me.txtPurposeR.Name = "txtPurposeR"
        Me.txtPurposeR.Size = New System.Drawing.Size(174, 30)
        Me.txtPurposeR.TabIndex = 29
        '
        'btnReturnLog
        '
        Me.btnReturnLog.Location = New System.Drawing.Point(544, 408)
        Me.btnReturnLog.Name = "btnReturnLog"
        Me.btnReturnLog.Size = New System.Drawing.Size(76, 55)
        Me.btnReturnLog.TabIndex = 30
        Me.btnReturnLog.Text = "Return"
        Me.btnReturnLog.UseVisualStyleBackColor = True
        '
        'frmReturnEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 527)
        Me.Controls.Add(Me.btnReturnLog)
        Me.Controls.Add(Me.txtPurposeR)
        Me.Controls.Add(Me.dtpBorrowedR)
        Me.Controls.Add(Me.txtRemarksR)
        Me.Controls.Add(Me.txtBorrowerNameR)
        Me.Controls.Add(Me.cbItemListR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nupQuantityR)
        Me.Controls.Add(Me.txtContactR)
        Me.Name = "frmReturnEntry"
        Me.Text = "frmReturnEntry"
        CType(Me.nupQuantityR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpBorrowedR As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRemarksR As System.Windows.Forms.TextBox
    Friend WithEvents txtBorrowerNameR As System.Windows.Forms.TextBox
    Friend WithEvents cbItemListR As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nupQuantityR As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtContactR As System.Windows.Forms.TextBox
    Friend WithEvents txtPurposeR As System.Windows.Forms.TextBox
    Friend WithEvents btnReturnLog As System.Windows.Forms.Button
End Class
