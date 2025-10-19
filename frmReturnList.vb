Public Class frmReturnList

    Private Sub frmReturnList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_transaction ", dgvReturnList)
        'Dim sb As New System.Text.StringBuilder()
        'If dgvReturnList.Columns.Count = 0 Then
        '    MsgBox("Columns count = 0 (no columns yet)")
        'Else

        '    For Each col As DataGridViewColumn In dgvReturnList.Columns
        '        sb.AppendLine(col.Index & " - " & col.HeaderText & " (Name: " & col.Name & ")")
        '    Next

        '    
        '    MsgBox(sb.ToString(), MsgBoxStyle.Information, "DataGridView Columns")
        'End If
    End Sub



    Private Sub dgvReturnList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReturnList.CellClick
        Try
            If e.RowIndex >= 0 Then
                ' Optional: store ReturnID
                dgvReturnList.Tag = dgvReturnList.Item(0, e.RowIndex).Value

                ' Match column order:
                ' 0 ReturnID | 1 BorrowID | 2 ItemID | 3 ItemName | 4 BorrowerName |
                ' 5 Purpose | 6 QuantityBorrowed | 7 QuantityReturned | 8 DateReturned | 9 Remarks

                frmReturnEntry.cbItemListR.Text = dgvReturnList.Item(3, e.RowIndex).Value.ToString() ' ItemName
                frmReturnEntry.txtBorrowerNameR.Text = dgvReturnList.Item(4, e.RowIndex).Value.ToString() ' Borrower Name
                frmReturnEntry.txtPurposeR.Text = dgvReturnList.Item(5, e.RowIndex).Value.ToString() ' Purpose

                ' Use QuantityReturned for nup control
                Dim qty As Object = dgvReturnList.Item(7, e.RowIndex).Value
                If Not IsDBNull(qty) AndAlso IsNumeric(qty) Then
                    frmReturnEntry.nupQuantityR.Value = CInt(qty)
                Else
                    frmReturnEntry.nupQuantityR.Value = 0
                End If

                ' Handle possible NULL dates safely
                Dim dateVal As Object = dgvReturnList.Item(8, e.RowIndex).Value
                If Not IsDBNull(dateVal) Then
                    frmReturnEntry.dtpBorrowedR.Value = CDate(dateVal)
                End If

                frmReturnEntry.txtRemarksR.Text = dgvReturnList.Item(9, e.RowIndex).Value.ToString()

                ' Store IDs
                frmReturnEntry.ItemID = CInt(dgvReturnList.Item(2, e.RowIndex).Value)
                frmReturnEntry.BorrowID = CInt(dgvReturnList.Item(1, e.RowIndex).Value)
            End If
        Catch ex As Exception
            MsgBox("Error loading selected record: " & ex.Message, vbCritical)
        End Try
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