﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserAdd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(409, 165)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 46)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtmi
        '
        Me.txtmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmi.Location = New System.Drawing.Point(125, 128)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(186, 26)
        Me.txtmi.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Middle Name:"
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(125, 176)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(186, 26)
        Me.txtlname.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name:"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(125, 226)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(186, 26)
        Me.txtusername.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Username:"
        '
        'txtpword
        '
        Me.txtpword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpword.Location = New System.Drawing.Point(125, 281)
        Me.txtpword.Multiline = True
        Me.txtpword.Name = "txtpword"
        Me.txtpword.Size = New System.Drawing.Size(186, 26)
        Me.txtpword.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password:"
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(125, 76)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(186, 26)
        Me.txtfname.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Registration:"
        '
        'frmUserAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(519, 592)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtpword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmUserAdd"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.Text = "frmUserAdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtmi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label6 As Label
End Class
