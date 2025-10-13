<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnList
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.dgvReturnList = New System.Windows.Forms.DataGridView()
        CType(Me.dgvReturnList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(928, 160)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(86, 51)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'dgvReturnList
        '
        Me.dgvReturnList.AllowUserToAddRows = False
        Me.dgvReturnList.AllowUserToDeleteRows = False
        Me.dgvReturnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReturnList.Location = New System.Drawing.Point(30, 40)
        Me.dgvReturnList.Name = "dgvReturnList"
        Me.dgvReturnList.ReadOnly = True
        Me.dgvReturnList.RowHeadersVisible = False
        Me.dgvReturnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReturnList.Size = New System.Drawing.Size(877, 489)
        Me.dgvReturnList.TabIndex = 0
        '
        'frmReturnList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 591)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.dgvReturnList)
        Me.Name = "frmReturnList"
        Me.Text = "frmReturnList"
        CType(Me.dgvReturnList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReturn As Button
    Friend WithEvents dgvReturnList As DataGridView
End Class
