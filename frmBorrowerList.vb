Public Class frmBorrowerList

    Private Sub frmBorrowerList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call vbConnection()
        Call data_loader("SELECT * FROM vw_borrowing", dgvBorrowerList)
        Dim sb As New System.Text.StringBuilder()


        If dgvBorrowerList.Columns.Count = 0 Then
            MsgBox("Columns count = 0 (no columns yet)")
        Else

            For Each col As DataGridViewColumn In dgvBorrowerList.Columns
                sb.AppendLine(col.Index & " - " & col.HeaderText & " (Name: " & col.Name & ")")
            Next

            ' ✅ Correct MsgBox syntax: first argument = text, second (optional) = style, third = caption
            MsgBox(sb.ToString(), MsgBoxStyle.Information, "DataGridView Columns")
        End If
    End Sub

    Private Sub dgvBorrowerList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrowerList.CellClick


        If e.RowIndex >= 0 Then
            dgvBorrowerList.Tag = dgvBorrowerList.Item(1, e.RowIndex).Value
            frmBorrow.cbItemList.SelectedValue = dgvBorrowerList.Item(0, e.RowIndex).Value
            frmBorrow.txtBorrowerName.Text = dgvBorrowerList.Item(2, e.RowIndex).Value
            frmBorrow.nupQuantity.Value = dgvBorrowerList.Item(4, e.RowIndex).Value
            frmBorrow.txtContact.Text = dgvBorrowerList.Item(5, e.RowIndex).Value
            frmBorrow.txtPurpose.Text = dgvBorrowerList.Item(6, e.RowIndex).Value
            frmBorrow.dtpBorrowed.Value = CDate(dgvBorrowerList.Item(7, e.RowIndex).Value)
            frmBorrow.txtRemarks.Text = dgvBorrowerList.Item(8, e.RowIndex).Value


        End If
    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        'If Val(dgvBorrowerList.Tag) = 0 Then
        '    MsgBox("Select a record to return!")
        'Else
        '    frmReturnEntry.ShowDialog()
        'End If
        If dgvBorrowerList.CurrentRow Is Nothing Then
            MsgBox("Please select a record to return.", vbInformation)
            Exit Sub
        End If

        Dim borrowID As Integer = Val(dgvBorrowerList.Item(1, dgvBorrowerList.CurrentRow.Index).Value)
        Dim itemID As Integer = Val(dgvBorrowerList.Item(0, dgvBorrowerList.CurrentRow.Index).Value)
        Dim qtyBorrowed As Integer = Val(dgvBorrowerList.Item(4, dgvBorrowerList.CurrentRow.Index).Value)

        Dim frm As New frmReturnEntry()

        frm.ShowDialog()
    End Sub

    Private Sub dgvBorrowerList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrowerList.CellContentClick

    End Sub
End Class