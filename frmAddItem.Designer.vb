<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddItem
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nupDamaged = New System.Windows.Forms.NumericUpDown()
        Me.lblDamage = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.cbRemarks = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nupQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.txtNameOFItem = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nupDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nupDamaged)
        Me.GroupBox1.Controls.Add(Me.lblDamage)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtItemDesc)
        Me.GroupBox1.Controls.Add(Me.cbRemarks)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nupQuantity)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbLocation)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbCategory)
        Me.GroupBox1.Controls.Add(Me.txtNameOFItem)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(590, 317)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipment"
        '
        'nupDamaged
        '
        Me.nupDamaged.Location = New System.Drawing.Point(308, 204)
        Me.nupDamaged.Name = "nupDamaged"
        Me.nupDamaged.Size = New System.Drawing.Size(176, 20)
        Me.nupDamaged.TabIndex = 16
        '
        'lblDamage
        '
        Me.lblDamage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDamage.Location = New System.Drawing.Point(304, 174)
        Me.lblDamage.Name = "lblDamage"
        Me.lblDamage.Size = New System.Drawing.Size(148, 28)
        Me.lblDamage.TabIndex = 15
        Me.lblDamage.Text = "Quantity Damage:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 28)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Description:"
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc.Location = New System.Drawing.Point(11, 137)
        Me.txtItemDesc.Multiline = True
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(223, 31)
        Me.txtItemDesc.TabIndex = 13
        '
        'cbRemarks
        '
        Me.cbRemarks.FormattingEnabled = True
        Me.cbRemarks.Items.AddRange(New Object() {"PB101", "Bar", "Bakery"})
        Me.cbRemarks.Location = New System.Drawing.Point(308, 59)
        Me.cbRemarks.Name = "cbRemarks"
        Me.cbRemarks.Size = New System.Drawing.Size(223, 22)
        Me.cbRemarks.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 28)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Remarks:"
        '
        'nupQuantity
        '
        Me.nupQuantity.Location = New System.Drawing.Point(308, 137)
        Me.nupQuantity.Name = "nupQuantity"
        Me.nupQuantity.Size = New System.Drawing.Size(176, 20)
        Me.nupQuantity.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantity:"
        '
        'cbLocation
        '
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.Items.AddRange(New Object() {"PB101", "Bar", "Bakery"})
        Me.cbLocation.Location = New System.Drawing.Point(6, 272)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(223, 22)
        Me.cbLocation.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Location:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Category:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Item Name:"
        '
        'cbCategory
        '
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"Kitchen", "Baking", "Liquor"})
        Me.cbCategory.Location = New System.Drawing.Point(6, 203)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(223, 22)
        Me.cbCategory.TabIndex = 2
        '
        'txtNameOFItem
        '
        Me.txtNameOFItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameOFItem.Location = New System.Drawing.Point(10, 59)
        Me.txtNameOFItem.Multiline = True
        Me.txtNameOFItem.Name = "txtNameOFItem"
        Me.txtNameOFItem.Size = New System.Drawing.Size(223, 31)
        Me.txtNameOFItem.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(62, 388)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 44)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(162, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 44)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(499, 388)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 44)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSchoolYear.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSchoolYear.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYear.ForeColor = System.Drawing.Color.White
        Me.lblSchoolYear.Location = New System.Drawing.Point(0, 0)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(623, 62)
        Me.lblSchoolYear.TabIndex = 47
        Me.lblSchoolYear.Text = "ITEMS"
        Me.lblSchoolYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 470)
        Me.Controls.Add(Me.lblSchoolYear)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmAddItem"
        Me.Text = "frmAddEquipment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nupDamaged, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nupQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtNameOFItem As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbRemarks As ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents nupDamaged As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDamage As System.Windows.Forms.Label
    Friend WithEvents lblSchoolYear As System.Windows.Forms.Label
End Class
