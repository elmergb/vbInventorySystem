Public Class frmDamageItemAY

    Private Sub frmDamageItemAction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT ActionID, StudentName, StudentNo, ItemName, ItemDescription, QuantityDamaged, ActionType, ActionStatus, AmountPaid, Notes, DateRequested, DateCompleted  FROM vw_damage_details WHERE ActionStatus = 'Pending'", dgvDamageAction)
        With dgvDamageAction
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersHeight = 35
            .RowTemplate.Height = 35
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.LightGray
            .BorderStyle = BorderStyle.None
        End With

        For Each col As DataGridViewColumn In dgvDamageAction.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If dgvDamageAction.CurrentRow Is Nothing Then
            MsgBox("Please select a record to update.", vbInformation)
            Exit Sub
        End If

        Dim row As DataGridViewRow = dgvDamageAction.CurrentRow
        Dim frm As New frmDamageActionEntry()

        ' Pass values from the selected row to the form
        frm.actionID = Val(row.Cells("ActionID").Value)
        frm.lblStudent.Text = row.Cells("BorrowerName").Value.ToString()
        frm.lblItemName.Text = row.Cells("ItemName").Value.ToString()
        frm.lblqtyDamage.Text = row.Cells("QuantityDamaged").Value.ToString()
        frm.lblStudentNo.Text = row.Cells("StudentNo").Value.ToString()
        frm.cbActionType.Text = row.Cells("ActionType").Value.ToString()
        frm.txtAmount.Text = row.Cells("AmountPaid").Value.ToString()
        frm.txtRemarks.Text = row.Cells("Notes").Value.ToString()

        ' Handle date properly
        If Not IsDBNull(row.Cells("DateCompleted").Value) Then
            frm.dtpDateTime.Value = CDate(row.Cells("DateCompleted").Value)
        End If

        frm.ShowDialog()

    End Sub

    Private Sub dgvDamageAction_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDamageAction.CellClick
        If e.RowIndex >= 0 Then
            dgvDamageAction.Tag = dgvDamageAction.Rows(e.RowIndex).Cells("ActionID").Value
        End If
    End Sub

End Class