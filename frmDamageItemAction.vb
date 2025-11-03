Public Class frmDamageItemAction

    Private Sub frmDamageItemAction_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT ActionID, StudentName, StudentNo, ItemName, ItemDescription, QuantityDamaged, ActionType, ActionStatus, AmountPaid, Notes, DateRequested, DateCompleted  FROM vw_damage_details WHERE ActionStatus = 'Pending'", dgvDamageAction)
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
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

    Private Sub dgvDamageAction_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDamageAction.CellClick
        If e.RowIndex >= 0 Then
            dgvDamageAction.Tag = dgvDamageAction.Rows(e.RowIndex).Cells("ActionID").Value
        End If
    End Sub

End Class