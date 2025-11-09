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
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbRemarks = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nupQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNameOFItem = New System.Windows.Forms.TextBox()
        Me.nupDamaged = New System.Windows.Forms.NumericUpDown()
        Me.lblDamage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupDamaged, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtItemDesc)
        Me.GroupBox1.Controls.Add(Me.cbCategory)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbRemarks)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nupQuantity)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbLocation)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNameOFItem)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(689, 390)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipment"
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc.Location = New System.Drawing.Point(11, 162)
        Me.txtItemDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemDesc.Multiline = True
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(260, 37)
        Me.txtItemDesc.TabIndex = 13
        '
        'cbCategory
        '
        Me.cbCategory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"Utensils", "Appliances", "Utility", "Tableware", "Baking Tool", "Ingredients", "Bar tool", "Glassware", "Beverage", "Cookware"})
        Me.cbCategory.Location = New System.Drawing.Point(11, 238)
        Me.cbCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(260, 31)
        Me.cbCategory.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 34)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Description:"
        '
        'cbRemarks
        '
        Me.cbRemarks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRemarks.FormattingEnabled = True
        Me.cbRemarks.Items.AddRange(New Object() {"PB101", "Bar", "Bakery"})
        Me.cbRemarks.Location = New System.Drawing.Point(360, 73)
        Me.cbRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.cbRemarks.Name = "cbRemarks"
        Me.cbRemarks.Size = New System.Drawing.Size(260, 31)
        Me.cbRemarks.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(354, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 34)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Remarks:"
        '
        'nupQuantity
        '
        Me.nupQuantity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupQuantity.Location = New System.Drawing.Point(360, 169)
        Me.nupQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.nupQuantity.Name = "nupQuantity"
        Me.nupQuantity.Size = New System.Drawing.Size(206, 30)
        Me.nupQuantity.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 34)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantity:"
        '
        'cbLocation
        '
        Me.cbLocation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.Items.AddRange(New Object() {"PB101", "Kitchen Laboratory", "Bread & Pastry Laboratory", "Bar Laboratory", "", ""})
        Me.cbLocation.Location = New System.Drawing.Point(11, 311)
        Me.cbLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(260, 31)
        Me.cbLocation.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 286)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Location:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 34)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Category:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Item Name:"
        '
        'txtNameOFItem
        '
        Me.txtNameOFItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameOFItem.Location = New System.Drawing.Point(11, 73)
        Me.txtNameOFItem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNameOFItem.Multiline = True
        Me.txtNameOFItem.Name = "txtNameOFItem"
        Me.txtNameOFItem.Size = New System.Drawing.Size(260, 37)
        Me.txtNameOFItem.TabIndex = 1
        '
        'nupDamaged
        '
        Me.nupDamaged.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupDamaged.Location = New System.Drawing.Point(283, 667)
        Me.nupDamaged.Margin = New System.Windows.Forms.Padding(4)
        Me.nupDamaged.Name = "nupDamaged"
        Me.nupDamaged.Size = New System.Drawing.Size(206, 30)
        Me.nupDamaged.TabIndex = 16
        Me.nupDamaged.Visible = False
        '
        'lblDamage
        '
        Me.lblDamage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDamage.Location = New System.Drawing.Point(277, 617)
        Me.lblDamage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDamage.Name = "lblDamage"
        Me.lblDamage.Size = New System.Drawing.Size(172, 34)
        Me.lblDamage.TabIndex = 15
        Me.lblDamage.Text = "Quantity Damage:"
        Me.lblDamage.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(582, 478)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 54)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSchoolYear.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSchoolYear.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYear.ForeColor = System.Drawing.Color.White
        Me.lblSchoolYear.Location = New System.Drawing.Point(0, 0)
        Me.lblSchoolYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(727, 76)
        Me.lblSchoolYear.TabIndex = 47
        Me.lblSchoolYear.Text = "Items"
        Me.lblSchoolYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSchoolYear.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.main.My.Resources.Resources._326554_cancel_icon
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(154, 478)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 54)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.main.My.Resources.Resources.diskette
        Me.btnSave.Location = New System.Drawing.Point(38, 478)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 54)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 559)
        Me.Controls.Add(Me.nupDamaged)
        Me.Controls.Add(Me.lblDamage)
        Me.Controls.Add(Me.lblSchoolYear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddEquipment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupDamaged, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbRemarks As ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents nupDamaged As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDamage As System.Windows.Forms.Label
    Friend WithEvents lblSchoolYear As System.Windows.Forms.Label
End Class
