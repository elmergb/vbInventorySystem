Public Class frmReturnList

    Private Sub frmReturnList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_transaction", dgvReturnList)
        Dim sb As New System.Text.StringBuilder()
        If dgvReturnList.Columns.Count = 0 Then
            MsgBox("Columns count = 0 (no columns yet)")
        Else

            For Each col As DataGridViewColumn In dgvReturnList.Columns
                sb.AppendLine(col.Index & " - " & col.HeaderText & " (Name: " & col.Name & ")")
            Next

            ' ✅ Correct MsgBox syntax: first argument = text, second (optional) = style, third = caption
            MsgBox(sb.ToString(), MsgBoxStyle.Information, "DataGridView Columns")
        End If
    End Sub

    Private Sub dgvReturnList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReturnList.CellContentClick

    End Sub

    Private Sub dgvReturnList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReturnList.CellClick
        If e.RowIndex >= 0 Then
            dgvReturnList.Tag = dgvReturnList.Item(0, e.RowIndex).Value
            frmReturnEntry.txtBorrowerNameR.Text = dgvReturnList.Item(1, e.RowIndex).Value
            frmReturnEntry.nupQuantityR.Value = dgvReturnList.Item(3, e.RowIndex).Value
            frmBorrow.dtpBorrowed.Value = CDate(dgvReturnList.Item(5, e.RowIndex).Value)
            frmReturnEntry.txtRemarksR.Text = dgvReturnList.Item(6, e.RowIndex).Value

        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If Val(dgvReturnList.Tag) = 0 Then
            MsgBox("Select a record to return", vbInformation)
        Else
            frmReturnEntry.ItemID = Val(dgvReturnList.Tag)
            frmReturnEntry.BorrowID = Val(dgvReturnList.Tag)
            frmReturnEntry.ShowDialog()
        End If
    End Sub
End Class