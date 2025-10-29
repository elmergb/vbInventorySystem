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
        Me.txtBorrowerNameR = New System.Windows.Forms.TextBox()
        Me.cbItemListR = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nupQuantityR = New System.Windows.Forms.NumericUpDown()
        Me.txtPurposeR = New System.Windows.Forms.TextBox()
        Me.btnReturnLog = New System.Windows.Forms.Button()
        Me.cbReturnRemarks = New System.Windows.Forms.ComboBox()
        Me.txtItemDescR = New System.Windows.Forms.TextBox()
        CType(Me.nupQuantityR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpBorrowedR
        '
        Me.dtpBorrowedR.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dtpBorrowedR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBorrowedR.Location = New System.Drawing.Point(376, 118)
        Me.dtpBorrowedR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtpBorrowedR.Name = "dtpBorrowedR"
        Me.dtpBorrowedR.Size = New System.Drawing.Size(233, 20)
        Me.dtpBorrowedR.TabIndex = 28
        '
        'txtBorrowerNameR
        '
        Me.txtBorrowerNameR.Location = New System.Drawing.Point(56, 118)
        Me.txtBorrowerNameR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBorrowerNameR.Multiline = True
        Me.txtBorrowerNameR.Name = "txtBorrowerNameR"
        Me.txtBorrowerNameR.Size = New System.Drawing.Size(202, 32)
        Me.txtBorrowerNameR.TabIndex = 26
        '
        'cbItemListR
        '
        Me.cbItemListR.FormattingEnabled = True
        Me.cbItemListR.Location = New System.Drawing.Point(56, 278)
        Me.cbItemListR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbItemListR.Name = "cbItemListR"
        Me.cbItemListR.Size = New System.Drawing.Size(187, 22)
        Me.cbItemListR.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(371, 164)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Remarks/Notes"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(371, 90)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 25)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Time Returned"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 171)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Purpose"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Borrower Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 313)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 250)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Item"
        '
        'nupQuantityR
        '
        Me.nupQuantityR.Location = New System.Drawing.Point(56, 341)
        Me.nupQuantityR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nupQuantityR.Name = "nupQuantityR"
        Me.nupQuantityR.Size = New System.Drawing.Size(160, 20)
        Me.nupQuantityR.TabIndex = 17
        '
        'txtPurposeR
        '
        Me.txtPurposeR.Location = New System.Drawing.Point(56, 202)
        Me.txtPurposeR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPurposeR.Multiline = True
        Me.txtPurposeR.Name = "txtPurposeR"
        Me.txtPurposeR.Size = New System.Drawing.Size(202, 32)
        Me.txtPurposeR.TabIndex = 29
        '
        'btnReturnLog
        '
        Me.btnReturnLog.Location = New System.Drawing.Point(441, 321)
        Me.btnReturnLog.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnReturnLog.Name = "btnReturnLog"
        Me.btnReturnLog.Size = New System.Drawing.Size(89, 59)
        Me.btnReturnLog.TabIndex = 30
        Me.btnReturnLog.Text = "Return"
        Me.btnReturnLog.UseVisualStyleBackColor = True
        '
        'cbReturnRemarks
        '
        Me.cbReturnRemarks.FormattingEnabled = True
        Me.cbReturnRemarks.Location = New System.Drawing.Point(376, 212)
        Me.cbReturnRemarks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbReturnRemarks.Name = "cbReturnRemarks"
        Me.cbReturnRemarks.Size = New System.Drawing.Size(187, 22)
        Me.cbReturnRemarks.TabIndex = 31
        '
        'txtItemDescR
        '
        Me.txtItemDescR.Location = New System.Drawing.Point(376, 255)
        Me.txtItemDescR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtItemDescR.Multiline = True
        Me.txtItemDescR.Name = "txtItemDescR"
        Me.txtItemDescR.Size = New System.Drawing.Size(202, 32)
        Me.txtItemDescR.TabIndex = 32
        '
        'frmReturnEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 472)
        Me.Controls.Add(Me.txtItemDescR)
        Me.Controls.Add(Me.cbReturnRemarks)
        Me.Controls.Add(Me.btnReturnLog)
        Me.Controls.Add(Me.txtPurposeR)
        Me.Controls.Add(Me.dtpBorrowedR)
        Me.Controls.Add(Me.txtBorrowerNameR)
        Me.Controls.Add(Me.cbItemListR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nupQuantityR)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmReturnEntry"
        Me.Text = "frmReturnEntry"
        CType(Me.nupQuantityR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpBorrowedR As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBorrowerNameR As System.Windows.Forms.TextBox
    Friend WithEvents cbItemListR As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nupQuantityR As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPurposeR As System.Windows.Forms.TextBox
    Friend WithEvents btnReturnLog As System.Windows.Forms.Button
    Friend WithEvents cbReturnRemarks As ComboBox
    Friend WithEvents txtItemDescR As System.Windows.Forms.TextBox
End Class
