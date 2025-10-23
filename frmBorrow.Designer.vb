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
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCart = New System.Windows.Forms.Button()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(17, 341)
        Me.txtContact.Multiline = True
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(174, 30)
        Me.txtContact.TabIndex = 0
        '
        'nupQuantity
        '
        Me.nupQuantity.Location = New System.Drawing.Point(17, 279)
        Me.nupQuantity.Name = "nupQuantity"
        Me.nupQuantity.Size = New System.Drawing.Size(137, 20)
        Me.nupQuantity.TabIndex = 1
        '
        'btnLogSave
        '
        Me.btnLogSave.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogSave.Location = New System.Drawing.Point(360, 426)
        Me.btnLogSave.Name = "btnLogSave"
        Me.btnLogSave.Size = New System.Drawing.Size(115, 50)
        Me.btnLogSave.TabIndex = 2
        Me.btnLogSave.Text = "Log Borrow"
        Me.btnLogSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Borrower Name"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(255, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Purpose"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(255, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Time Borrowed"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(255, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Remarks/Notes"
        '
        'cbItemList
        '
        Me.cbItemList.FormattingEnabled = True
        Me.cbItemList.Location = New System.Drawing.Point(17, 146)
        Me.cbItemList.Name = "cbItemList"
        Me.cbItemList.Size = New System.Drawing.Size(161, 21)
        Me.cbItemList.TabIndex = 10
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Location = New System.Drawing.Point(17, 208)
        Me.txtBorrowerName.Multiline = True
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(174, 30)
        Me.txtBorrowerName.TabIndex = 11
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(259, 153)
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(174, 30)
        Me.txtPurpose.TabIndex = 12
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(259, 296)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(187, 30)
        Me.txtRemarks.TabIndex = 14
        '
        'dtpBorrowed
        '
        Me.dtpBorrowed.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dtpBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBorrowed.Location = New System.Drawing.Point(259, 225)
        Me.dtpBorrowed.Name = "dtpBorrowed"
        Me.dtpBorrowed.Size = New System.Drawing.Size(200, 20)
        Me.dtpBorrowed.TabIndex = 15
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(259, 432)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(78, 38)
        Me.btnAddItem.TabIndex = 16
        Me.btnAddItem.Text = "Add"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(486, 55)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = " Borrow"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCart
        '
        Me.btnCart.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCart.Location = New System.Drawing.Point(407, 13)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(68, 34)
        Me.btnCart.TabIndex = 19
        Me.btnCart.Text = "Cart"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'frmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 510)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAddItem)
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
    Friend WithEvents btnAddItem As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCart As Button
End Class
