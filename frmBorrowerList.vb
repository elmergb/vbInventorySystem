Public Class frmBorrowerList

    Private Sub frmBorrowerList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call vbConnection()
        Call data_loader("SELECT * FROM vw_borrowed_items WHERE Status <> 'Returned'", dgvBorrowerList)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")
        'Dim colNames As String = ""
        'For Each col As DataGridViewColumn In dgvBorrowerList.Columns
        '    colNames &= col.Index & " - " & col.Name & vbCrLf
        'Next
        'MsgBox(colNames, MsgBoxStyle.Information, "Column Arrangement")
        With dgvBorrowerList
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
    End Sub

    Private Sub dgvBorrowerList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
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

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        'Dim cmd As Odbc.OdbcCommand
        'If dgvBorrowerList.Tag = 0 Then
        '    MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
        'ElseIf MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion, "Confirm Delete") = vbYes Then
        '    Try
        '        ' Step 1: Copy the record to tbldeleteditem (Recycle Bin)
        '        cmd = New Odbc.OdbcCommand("INSERT INTO tblborrower_bin (bBinID, BorrowerID, fname, mi, lname, StudentNo) SELECT ItemID, ItemName, ItemDescription, ItemCategory, ItemQuantity, NOW()  FROM tblitemlist  WHERE ItemID = " & Val(dgvItemList.Tag), con)
        '        cmd.ExecuteNonQuery()

        '        ' Step 2: Delete the record from main table
        '        cmd = New Odbc.OdbcCommand("DELETE FROM tblitemlist WHERE ItemID = " & Val(dgvItemList.Tag), con)
        '        cmd.ExecuteNonQuery()

        '        MsgBox("Deleted successfully!", MsgBoxStyle.Information)

        '        ' Step 3: Refresh the DataGridView
        '        Call data_loader("SELECT * FROM vw_item", dgvItemList)

        '    Catch ex As Exception
        '        MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        '    End Try
        'End If
    End Sub
End Class