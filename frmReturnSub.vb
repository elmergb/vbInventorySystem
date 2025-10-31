Public Class frmReturnSub

    Private Sub frmReturnSub_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_transaction ", dgvReturnLists)

        For Each col As DataGridViewColumn In dgvReturnLists.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub dgvReturnList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReturnLists.CellClick
        'If e.RowIndex >= 0 Then
        '    dgvItemList.Tag = dgvItemList.Rows(e.RowIndex).Cells("Item").Value
        '    frmBorrow.cbItemList.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString
        '    frmBorrow.txtItemDesc.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemDescription").Value.ToString
        '    frmAddItem.cbCategory.Text = dgvItemList.Rows(e.RowIndex).Cells("Category").Value.ToString()
        '    frmAddItem.cbLocation.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemLocation").Value.ToString()
        '    frmAddItem.nupQuantity.Value = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
        '    Dim qty As Object = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
        '    If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
        '        frmAddItem.nupQuantity.Value = CInt(qty)
        '    Else
        '        frmAddItem.nupQuantity.Value = 0
        '    End If

        'End If
        Try
            If e.RowIndex >= 0 Then
                dgvReturnLists.Tag = dgvReturnLists.Item(0, e.RowIndex).Value


                ' 0 ReturnID | 1 BorrowID | 2 ItemID | 3 ItemName | 4 BorrowerName |
                ' 5 Purpose | 6 QuantityBorrowed | 7 QuantityReturned | 8 DateReturned | 9 Remarks

                frmReturnEntry.cbItemListR.Text = dgvReturnLists.Item(4, e.RowIndex).Value.ToString() ' ItemName
                frmReturnEntry.txtBorrowerNameR.Text = dgvReturnLists.Item(3, e.RowIndex).Value.ToString() ' Borrower Name
                frmReturnEntry.txtPurposeR.Text = dgvReturnLists.Item(5, e.RowIndex).Value.ToString() ' Purpose

                ' Use QuantityReturned for nup control
                Dim qty As Object = dgvReturnLists.Item(7, e.RowIndex).Value
                If Not IsDBNull(qty) AndAlso IsNumeric(qty) Then
                    frmReturnEntry.nupQuantityR.Value = CInt(qty)
                Else
                    frmReturnEntry.nupQuantityR.Value = 0
                End If

                ' Handle possible NULL dates safely
                Dim dateVal As Object = dgvReturnLists.Item(8, e.RowIndex).Value
                If Not IsDBNull(dateVal) Then
                    frmReturnEntry.dtpBorrowedR.Value = CDate(dateVal)
                End If

                frmReturnEntry.cbItemListR.Text = dgvReturnLists.Item(9, e.RowIndex).Value.ToString()

                ' Store IDs
                frmReturnEntry.ItemID = CInt(dgvReturnLists.Item(2, e.RowIndex).Value)
                frmReturnEntry.BorrowID = CInt(dgvReturnLists.Item(1, e.RowIndex).Value)
            End If
        Catch ex As Exception
            MsgBox("Error loading selected record: " & ex.Message, vbCritical)
        End Try
    End Sub
End Class