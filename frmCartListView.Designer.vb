<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartListView
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
        Me.lvCart = New System.Windows.Forms.ListView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvCart
        '
        Me.lvCart.HideSelection = False
        Me.lvCart.Location = New System.Drawing.Point(1, 1)
        Me.lvCart.Name = "lvCart"
        Me.lvCart.Size = New System.Drawing.Size(280, 348)
        Me.lvCart.TabIndex = 0
        Me.lvCart.UseCompatibleStateImageBehavior = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(246, 364)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 45)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmCartListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 448)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lvCart)
        Me.Name = "frmCartListView"
        Me.Text = "frmCartListView"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvCart As ListView
    Friend WithEvents btnDelete As Button
End Class
