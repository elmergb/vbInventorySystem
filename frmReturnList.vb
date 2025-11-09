Public Class frmReturnList

    Private Sub frmReturnList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        Call data_loader("SELECT * FROM vw_borrowed_items WHERE Status = 'Borrowed' ORDER BY DateBorrowed DESC", dgvReturn)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")
        With dgvReturn
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersHeight = 35
            .RowTemplate.Height = 35
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.LightGray
            .BorderStyle = BorderStyle.None
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        For Each col As DataGridViewColumn In dgvReturn.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
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
        Dim returnForm As New frmReturnEntry()

        ' Pass all necessary info
        returnForm.BorrowID = CInt(row.Cells("bID").Value)
        returnForm.ItemID = CInt(row.Cells("ItemID").Value)
        returnForm.cbItemListR.Text = row.Cells("ItemName").Value.ToString()
        returnForm.lblStudentNo.Text = row.Cells("StudentNo").Value.ToString()
        returnForm.lblBorrowerName.Text = row.Cells("borrowerName").Value.ToString()
        returnForm.lblteacher.Text = row.Cells("TeacherName").Value.ToString()
        returnForm.lblSchoolYear.Text = row.Cells("SchoolYear").Value.ToString
        returnForm.lblCourse.Text = row.Cells("CourseCode").Value.ToString()
        returnForm.lblContact.Text = row.Cells("Contact").Value.ToString()
        returnForm.lblPurpose.Text = row.Cells("Purpose").Value.ToString()
        returnForm.lblSemester.Text = row.Cells("Semester").Value.ToString
        returnForm.lblYearLevel.Text = row.Cells("YearLevel").Value.ToString()
        returnForm.lblSection.Text = row.Cells("Sections").Value.ToString()
        returnForm.lblItemDesc.Text = row.Cells("ItemDesc").Value.ToString()
        returnForm.nupQuantityR.Minimum = 1
        returnForm.nupQuantityR.Maximum = RemainingQty
        returnForm.nupQuantityR.Value = 1
        returnForm.cbReturnRemarks.Text = row.Cells("RemarksItem").Value.ToString()

        ' --- Subscribe to the event to refresh DataGridView ---
        AddHandler returnForm.ReturnCompleted, AddressOf OnReturnCompleted


        returnForm.ShowDialog()
    End Sub
    Public Sub LoadReturnItems()
        data_loader("SELECT * FROM vw_borrowed_items WHERE Status = 'Borrowed' ORDER BY DateBorrowed DESC", dgvReturn)
    End Sub
    Private Sub OnReturnCompleted(ByVal sender As Object, ByVal e As EventArgs)
        ' Refresh the DataGridView
        LoadReturnItems()   ' Or whatever your loader method is
    End Sub
    Private Sub dgvBorrowerList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReturn.CellClick
        If e.RowIndex >= 0 Then
            ' Store the selected record’s ID or key
            dgvReturn.Tag = dgvReturn.Rows(e.RowIndex).Cells("bID").Value

            ' Transfer values from the DataGridView to frmBorrow controls
            frmBorrowDE.cbItemList.Text = dgvReturn.Rows(e.RowIndex).Cells("ItemName").Value.ToString()
            frmBorrowDE.txtItemDesc.Text = dgvReturn.Rows(e.RowIndex).Cells("ItemDesc").Value.ToString()
            frmBorrowDE.txtBorrowerName.Text = dgvReturn.Rows(e.RowIndex).Cells("borrowerName").Value.ToString()

            ' Handle Quantity (convert safely to integer)
            Dim qty As Object = dgvReturn.Rows(e.RowIndex).Cells("qtyBorrowed").Value
            If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
                frmBorrowDE.nupQuantity.Value = CInt(qty)
            Else
                frmBorrowDE.nupQuantity.Value = 0
            End If

            frmBorrowDE.txtContact.Text = dgvReturn.Rows(e.RowIndex).Cells("contact").Value.ToString()
            frmBorrowDE.txtPurpose.Text = dgvReturn.Rows(e.RowIndex).Cells("purpose").Value.ToString()

            ' Handle Date safely
            Dim dateBorrowed As Object = dgvReturn.Rows(e.RowIndex).Cells("dateborrowed").Value
            If dateBorrowed IsNot Nothing AndAlso Not IsDBNull(dateBorrowed) Then
                frmBorrowDE.dtpBorrowed.Value = CDate(dateBorrowed)
            End If

            frmBorrowDE.cbBorrowRemarks.Text = dgvReturn.Rows(e.RowIndex).Cells("RemarksItem").Value.ToString()
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

    Private Sub dgvReturn_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReturn.CellContentClick

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class