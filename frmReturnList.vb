Public Class frmReturnList

    Private Sub frmReturnList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        Call data_loader("SELECT * FROM vw_borrowing WHERE Status <> 'Returned'", dgvReturn)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")

    End Sub


    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        If dgvReturn.CurrentRow Is Nothing Then
            MsgBox("Select a record to return", vbInformation)
            Exit Sub
        End If

        ' Get the current selected row
        Dim row As DataGridViewRow = dgvReturn.CurrentRow

        ' Assign values to frmReturnEntry
        With frmReturnEntry
            ' Main IDs
            .BorrowID = CInt(row.Cells("borrowID").Value)
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
            .cbReturnRemarks.Text = row.Cells("RemarksItem").Value.ToString()

            ' Finally show the Return Entry form
            .ShowDialog()
        End With
    End Sub
    Private Sub dgvBorrowerList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReturn.CellClick
        If e.RowIndex >= 0 Then
            ' Store the selected record’s ID or key
            dgvReturn.Tag = dgvReturn.Rows(e.RowIndex).Cells("borrowID").Value

            ' Transfer values from the DataGridView to frmBorrow controls
            frmBorrow.cbItemList.Text = dgvReturn.Rows(e.RowIndex).Cells("ItemName").Value.ToString()
            frmBorrow.txtItemDesc.Text = dgvReturn.Rows(e.RowIndex).Cells("ItemDesc").Value.ToString()
            frmBorrow.txtBorrowerName.Text = dgvReturn.Rows(e.RowIndex).Cells("borrowerName").Value.ToString()

            ' Handle Quantity (convert safely to integer)
            Dim qty As Object = dgvReturn.Rows(e.RowIndex).Cells("qtyBorrowed").Value
            If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
                frmBorrow.nupQuantity.Value = CInt(qty)
            Else
                frmBorrow.nupQuantity.Value = 0
            End If

            frmBorrow.txtContact.Text = dgvReturn.Rows(e.RowIndex).Cells("contact").Value.ToString()
            frmBorrow.txtPurpose.Text = dgvReturn.Rows(e.RowIndex).Cells("purpose").Value.ToString()

            ' Handle Date safely
            Dim dateBorrowed As Object = dgvReturn.Rows(e.RowIndex).Cells("dateborrowed").Value
            If dateBorrowed IsNot Nothing AndAlso Not IsDBNull(dateBorrowed) Then
                frmBorrow.dtpBorrowed.Value = CDate(dateBorrowed)
            End If

            frmBorrow.cbBorrowRemarks.Text = dgvReturn.Rows(e.RowIndex).Cells("RemarksItem").Value.ToString()
        End If
    End Sub
    Private Sub txtSearch_GotFocus(sender As Object, e As System.EventArgs) Handles txtSearch.GotFocus
        If Trim(txtSearch.Text) = "Search by Name/Item" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearch.TextChanged
        SearchBorrowinglist(txtSearch.Text, dgvReturn)
    End Sub

End Class