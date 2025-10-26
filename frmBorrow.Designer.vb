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
        Me.cbItemList = New System.Windows.Forms.ComboBox()
        Me.dtpBorrowed = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(908, 55)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = " Borrow"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item"
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(277, 91)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(174, 20)
        Me.txtPurpose.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Borrower Name"
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Location = New System.Drawing.Point(45, 152)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(174, 20)
        Me.txtBorrowerName.TabIndex = 11
        '
        'nupQuantity
        '
        Me.nupQuantity.Location = New System.Drawing.Point(45, 217)
        Me.nupQuantity.Name = "nupQuantity"
        Me.nupQuantity.Size = New System.Drawing.Size(137, 20)
        Me.nupQuantity.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(283, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Purpose"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(45, 277)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(174, 20)
        Me.txtContact.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(283, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Remarks/Notes"
        '
        'cbBorrowRemarks
        '
        Me.cbBorrowRemarks.FormattingEnabled = True
        Me.cbBorrowRemarks.Location = New System.Drawing.Point(287, 224)
        Me.cbBorrowRemarks.Name = "cbBorrowRemarks"
        Me.cbBorrowRemarks.Size = New System.Drawing.Size(164, 21)
        Me.cbBorrowRemarks.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(283, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Time and Date"
        '
        'cbItemList
        '
        Me.cbItemList.FormattingEnabled = True
        Me.cbItemList.Location = New System.Drawing.Point(46, 91)
        Me.cbItemList.Name = "cbItemList"
        Me.cbItemList.Size = New System.Drawing.Size(161, 21)
        Me.cbItemList.TabIndex = 10
        '
        'dtpBorrowed
        '
        Me.dtpBorrowed.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dtpBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBorrowed.Location = New System.Drawing.Point(286, 153)
        Me.dtpBorrowed.Name = "dtpBorrowed"
        Me.dtpBorrowed.Size = New System.Drawing.Size(165, 20)
        Me.dtpBorrowed.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(348, 351)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 42)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 631)
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
        Me.Name = "frmBorrow"
        Me.Text = "frmBorrow"
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
    Friend WithEvents cbItemList As ComboBox
    Friend WithEvents dtpBorrowed As DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
