Public Class frmDamageItemAction

    Private Sub frmDamageItemAction_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT ActionID, StudentName, StudentNo, ItemName, ItemDescription, QuantityDamaged, ActionType, ActionStatus, AmountPaid, Notes, DateRequested, DateCompleted  FROM vw_damage_details WHERE ActionStatus = 'Pending'", dgvDamageAction)
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        ' Check if a row is selected
        If dgvDamageAction.CurrentRow Is Nothing Then
            MsgBox("Please select a record to update.", vbInformation)
        Else
            Dim frm As New frmDamageActionEntry()
            frm.actionID = Val(dgvDamageAction.Tag)
            frm.ShowDialog()
        End If

    End Sub

    Private Sub dgvDamageAction_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDamageAction.CellClick
            If e.RowIndex >= 0 Then
            ' ✅ Change ReturnID → ActionID
            dgvDamageAction.Tag = dgvDamageAction.Rows(e.RowIndex).Cells("ActionID").Value

            ' ✅ Existing data loading (same as your original)
            frmDamageActionEntry.lblStudent.Text = dgvDamageAction.Rows(e.RowIndex).Cells("BorrowerName").Value.ToString
            frmDamageActionEntry.lblItemName.Text = dgvDamageAction.Rows(e.RowIndex).Cells("ItemName").Value.ToString
            frmDamageActionEntry.lblStudentNo.Text = dgvDamageAction.Rows(e.RowIndex).Cells("StudentNo").Value.ToString
            frmDamageActionEntry.cbActionType.Text = dgvDamageAction.Rows(e.RowIndex).Cells("ActionType").Value.ToString
            frmDamageActionEntry.txtAmount.Text = dgvDamageAction.Rows(e.RowIndex).Cells("AmountPaid").Value.ToString

            ' ✅ Fixed typo: "Nores" → "Notes"
            frmDamageActionEntry.txtRemarks.Text = dgvDamageAction.Rows(e.RowIndex).Cells("Notes").Value.ToString

            ' ✅ Added DateCompleted
            If Not IsDBNull(dgvDamageAction.Rows(e.RowIndex).Cells("DateCompleted").Value) Then
                frmDamageActionEntry.dtpDateTime.Value = dgvDamageAction.Rows(e.RowIndex).Cells("DateCompleted").Value
            End If
        End If

    End Sub

End Class