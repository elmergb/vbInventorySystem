﻿Public Class frmReturnList

    Private Sub frmReturnList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        Call data_loader("SELECT * FROM vw_borrowed_items", dgvReturn)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")

    End Sub


    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        If dgvReturn.CurrentRow Is Nothing Then
            MsgBox("Select a record to return.", vbInformation)
            Exit Sub
        End If

        Dim row As DataGridViewRow = dgvReturn.CurrentRow

        Dim RemainingQty As Integer = 0
        If Not IsDBNull(row.Cells("Remaining").Value) AndAlso IsNumeric(row.Cells("Remaining").Value) Then
            RemainingQty = CInt(row.Cells("Remaining").Value)
        End If

        If RemainingQty <= 0 Then
            MsgBox("This item has already been fully returned.", vbInformation, "No Remaining Items")
            Exit Sub
        End If

        With frmReturnEntry
            ' IDs
            Dim BorrowID As Integer = CInt(row.Cells("BorrowID").Value)

            ' Borrower info
            .txtStudentNo.Text = row.Cells("StudentNo").Value.ToString()
            .txtBorrowerNameR.Text = row.Cells("BorrowerName").Value.ToString()
            .txtTeacher.Text = row.Cells("TeacherName").Value.ToString()

            ' Contact & Purpose
            .txtContact.Text = row.Cells("Contact").Value.ToString()
            .txtPurposeR.Text = row.Cells("Purpose").Value.ToString()

            ' Item info
            Dim borrowedItemName As String = row.Cells("ItemName").Value.ToString().Trim()

            ' Get the single item row from DB
            Dim dt As New DataTable()
            Using cmd As New Odbc.OdbcCommand("SELECT ItemID, ItemName FROM tblitemlist WHERE TRIM(ItemName) = ?", con)
                cmd.Parameters.AddWithValue("?", borrowedItemName)
                Using da As New Odbc.OdbcDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            If dt.Rows.Count > 0 Then
                frmReturnEntry.cbItemListR.DataSource = dt
                frmReturnEntry.cbItemListR.DisplayMember = "ItemName"
                frmReturnEntry.cbItemListR.ValueMember = "ItemID"
                frmReturnEntry.cbItemListR.SelectedIndex = 0
            Else
                ' If no matching item found, show the name as plain text
                frmReturnEntry.cbItemListR.DataSource = Nothing
                frmReturnEntry.cbItemListR.Items.Clear()
                frmReturnEntry.cbItemListR.Items.Add(borrowedItemName)
                frmReturnEntry.cbItemListR.SelectedIndex = 0
            End If

            .txtItemDescR.Text = row.Cells("ItemDesc").Value.ToString()

            ' --- Step 7: Quantity setup ---
            Dim qtyBorrowed As Integer = 0
            Dim qtyReturned As Integer = 0

            If Not IsDBNull(row.Cells("qtyBorrowed").Value) AndAlso IsNumeric(row.Cells("qtyBorrowed").Value) Then
                qtyBorrowed = CInt(row.Cells("qtyBorrowed").Value)
            End If
            If Not IsDBNull(row.Cells("qtyReturned").Value) AndAlso IsNumeric(row.Cells("qtyBorrowed").Value) Then
                qtyReturned = CInt(row.Cells("qtyReturned").Value)
            End If

            ' Configure your NumericUpDown (nupReturned)
            .nupQuantityR.Minimum = 1
            .nupQuantityR.Maximum = RemainingQty
            .nupQuantityR.Value = 1 ' default to 1 item being returned

            ' Remarks
            .cbReturnRemarks.Text = row.Cells("RemarksItem").Value.ToString()

            ' --- Step 8: Show the form ---
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