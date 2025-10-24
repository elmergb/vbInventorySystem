Public Class frmBorrowerList

    Private Sub frmBorrowerList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call vbConnection()
        Call data_loader("SELECT * FROM vw_borrowing WHERE Status <> 'Returned'", dgvBorrowerList)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")

        'Dim sb As New System.Text.StringBuilder()
        'If dgvBorrowerList.Columns.Count = 0 Then
        '    MsgBox("Columns count = 0 (no columns yet)")
        'Else

        '    For Each col As DataGridViewColumn In dgvBorrowerList.Columns
        '        sb.AppendLine(col.Index & " - " & col.HeaderText & " (Name: " & col.Name & ")")
        '    Next

        '     ✅ Correct MsgBox syntax: first argument = text, second (optional) = style, third = caption
        '    MsgBox(sb.ToString(), MsgBoxStyle.Information, "DataGridView Columns")
        'End If
    End Sub

    Private Sub dgvBorrowerList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrowerList.CellClick

        If e.RowIndex >= 0 Then
            dgvBorrowerList.Tag = dgvBorrowerList.Item(0, e.RowIndex).Value
            frmBorrow.cbItemList.SelectedValue = dgvBorrowerList.Item(1, e.RowIndex).Value
            frmBorrow.txtBorrowerName.Text = dgvBorrowerList.Item(2, e.RowIndex).Value
            frmBorrow.nupQuantity.Value = dgvBorrowerList.Item(4, e.RowIndex).Value
            frmBorrow.txtContact.Text = dgvBorrowerList.Item(5, e.RowIndex).Value
            frmBorrow.txtPurpose.Text = dgvBorrowerList.Item(6, e.RowIndex).Value
            frmBorrow.dtpBorrowed.Value = CDate(dgvBorrowerList.Item(7, e.RowIndex).Value)
            frmBorrow.cbBorrowRemarks.Text = dgvBorrowerList.Item(8, e.RowIndex).Value
        End If

    End Sub
    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        If dgvBorrowerList.CurrentRow Is Nothing Then
            MsgBox("Select a record to return", vbInformation)
        Else
            ' Use the correct column indexes based on your DataGridView:
            ' 0 - BorrowID
            ' 1 - ItemID
            ' 2 - Borrower Name
            ' 3 - Item Name
            ' 4 - Quantity Borrowed
            ' 5 - Contact
            ' 6 - Purpose
            ' 7 - Date Borrowed
            ' 8 - Remarks

            frmReturnEntry.BorrowID = CInt(dgvBorrowerList.Item(0, dgvBorrowerList.CurrentRow.Index).Value) ' BorrowID
            frmReturnEntry.ItemID = CInt(dgvBorrowerList.Item(1, dgvBorrowerList.CurrentRow.Index).Value)   ' ItemID

            frmReturnEntry.cbItemListR.SelectedValue = frmReturnEntry.ItemID
            frmReturnEntry.txtBorrowerNameR.Text = dgvBorrowerList.Item(2, dgvBorrowerList.CurrentRow.Index).Value.ToString()
            frmReturnEntry.txtPurposeR.Text = dgvBorrowerList.Item(6, dgvBorrowerList.CurrentRow.Index).Value.ToString()
            frmReturnEntry.nupQuantityR.Value = If(IsNumeric(dgvBorrowerList.Item(4, dgvBorrowerList.CurrentRow.Index).Value), CInt(dgvBorrowerList.Item(4, dgvBorrowerList.CurrentRow.Index).Value), 0)
            frmReturnEntry.cbReturnRemarks.Text = dgvBorrowerList.Item(8, dgvBorrowerList.CurrentRow.Index).Value.ToString()

            frmReturnEntry.ShowDialog()

        End If
    End Sub


    Private Sub dgvBorrowerList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrowerList.CellContentClick

    End Sub

    Private Sub EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EToolStripMenuItem.Click
        If MsgBox("Are you sure to exit?", vbYesNo + vbQuestion) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub UIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UIToolStripMenuItem.Click

    End Sub
End Class