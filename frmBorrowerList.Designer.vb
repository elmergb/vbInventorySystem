<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowerList
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
        Me.dgvBorrowerList = New System.Windows.Forms.DataGridView()
        CType(Me.dgvBorrowerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBorrowerList
        '
        Me.dgvBorrowerList.AllowUserToAddRows = False
        Me.dgvBorrowerList.AllowUserToDeleteRows = False
        Me.dgvBorrowerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowerList.Location = New System.Drawing.Point(24, 37)
        Me.dgvBorrowerList.Name = "dgvBorrowerList"
        Me.dgvBorrowerList.ReadOnly = True
        Me.dgvBorrowerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrowerList.Size = New System.Drawing.Size(866, 483)
        Me.dgvBorrowerList.TabIndex = 0
        '
        'frmBorrowerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 560)
        Me.Controls.Add(Me.dgvBorrowerList)
        Me.Name = "frmBorrowerList"
        Me.Text = "frmBorrowerList"
        CType(Me.dgvBorrowerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBorrowerList As System.Windows.Forms.DataGridView
End Class
