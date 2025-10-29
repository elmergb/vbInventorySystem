Public Class frmBorrowerList

    Private Sub frmBorrowerList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call vbConnection()
        Call data_loader("SELECT * FROM vw_borrowing WHERE Status <> 'Returned'", dgvBorrowerList)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")
        'Dim colNames As String = ""
        'For Each col As DataGridViewColumn In dgvBorrowerList.Columns
        '    colNames &= col.Index & " - " & col.Name & vbCrLf
        'Next
        'MsgBox(colNames, MsgBoxStyle.Information, "Column Arrangement")

    End Sub

    Private Sub dgvBorrowerList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrowerList.CellClick
        If e.RowIndex >= 0 Then
            ' Store the selected record’s ID or key
            dgvBorrowerList.Tag = dgvBorrowerList.Rows(e.RowIndex).Cells("bID").Value

            ' Transfer values from the DataGridView to frmBorrow controls
            frmBorrow.cbItemList.Text = dgvBorrowerList.Rows(e.RowIndex).Cells("ItemName").Value.ToString()
            frmBorrow.txtItemDesc.Text = dgvBorrowerList.Rows(e.RowIndex).Cells("ItemDesc").Value.ToString()
            frmBorrow.txtBorrowerName.Text = dgvBorrowerList.Rows(e.RowIndex).Cells("BorrowerName").Value.ToString()

            ' Handle Quantity (convert safely to integer)
            Dim qty As Object = dgvBorrowerList.Rows(e.RowIndex).Cells("qtyBorrowed").Value
            If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
                frmBorrow.nupQuantity.Value = CInt(qty)
            Else
                frmBorrow.nupQuantity.Value = 0
            End If

            frmBorrow.txtContact.Text = dgvBorrowerList.Rows(e.RowIndex).Cells("contact").Value.ToString()
            frmBorrow.txtPurpose.Text = dgvBorrowerList.Rows(e.RowIndex).Cells("purpose").Value.ToString()

            ' Handle Date safely
            Dim dateBorrowed As Object = dgvBorrowerList.Rows(e.RowIndex).Cells("dateborrowed").Value
            If dateBorrowed IsNot Nothing AndAlso Not IsDBNull(dateBorrowed) Then
                frmBorrow.dtpBorrowed.Value = CDate(dateBorrowed)
            End If

            frmBorrow.cbBorrowRemarks.Text = dgvBorrowerList.Rows(e.RowIndex).Cells("remarks").Value.ToString()
        End If

    End Sub
    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        If dgvBorrowerList.CurrentRow Is Nothing Then
            MsgBox("Select a record to return", vbInformation)
            Exit Sub
        End If

        ' Get the current selected row
        Dim row As DataGridViewRow = dgvBorrowerList.CurrentRow

        ' Assign values to frmReturnEntry
        With frmReturnEntry
            ' Main IDs
            .BorrowID = CInt(row.Cells("bID").Value)
            .ItemID = CInt(row.Cells("ItemID").Value)

            ' Fill data
            .cbItemListR.SelectedValue = .ItemID
            .txtItemDescR.Text = row.Cells("ItemDesc").Value.ToString()
            .txtBorrowerNameR.Text = row.Cells("BorrowerName").Value.ToString()
            .txtPurposeR.Text = row.Cells("purpose").Value.ToString()

            ' Handle numeric and null safely
            Dim qtyObj As Object = row.Cells("qtyBorrowed").Value
            If qtyObj IsNot Nothing AndAlso IsNumeric(qtyObj) Then
                .nupQuantityR.Value = CInt(qtyObj)
            Else
                .nupQuantityR.Value = 0
            End If

            ' Remarks
            .cbReturnRemarks.Text = row.Cells("remarks").Value.ToString()

            ' Finally show the Return Entry form
            .ShowDialog()
        End With
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

    Private Sub dgvBorrowerList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvBorrowerList.CellFormatting
        If dgvBorrowerList.Columns(e.ColumnIndex).Name = "Status" Then
            If e.Value IsNot Nothing Then
                Dim statusText As String = e.Value.ToString().ToLower()

                Select Case statusText
                    Case "Available"
                        e.CellStyle.BackColor = Color.LightGreen
                        e.CellStyle.ForeColor = Color.Black

                    Case "Damaged"
                        e.CellStyle.BackColor = Color.LightCoral
                        e.CellStyle.ForeColor = Color.White

                    Case "Borrowed"
                        e.CellStyle.BackColor = Color.LightYellow
                        e.CellStyle.ForeColor = Color.Black

                    Case Else
                        e.CellStyle.BackColor = Color.White
                        e.CellStyle.ForeColor = Color.Black
                End Select
            End If
        End If
    End Sub

End Class