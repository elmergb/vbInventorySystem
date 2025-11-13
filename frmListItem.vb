Imports System.Data.Odbc

Public Class frmListItem
    Public BorrowID As Integer
    Public ItemID As Integer
    Private Sub frmListItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_items", dgvItemList)
        frmAddItem.nupQuantity.Maximum = 1000
        dgvItemList.AutoGenerateColumns = False
        dgvItemList.Tag = 0

        For Each col As DataGridViewColumn In dgvItemList.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        '190, 214, 246
        With dgvItemList
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
            .ForeColor = Color.Black
        End With
        DisableForm(frmAddItem)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ClearAllText(frmAddItem)
        dgvItemList.Tag = 0
        frmAddItem.nupDamaged.Visible = False
        frmAddItem.lblDamage.Visible = False

        frmAddItem.ItemID = 0
        AddHandler frmAddItem.ItemAdded, AddressOf OnItemAdded

        frmAddItem.ShowDialog()


        frmAddItem.ItemID = 0

    End Sub
    Private Sub OnItemAdded(ByVal sender As Object, ByVal e As EventArgs)
        ' Reload the DataGridView immediately
        data_loader("SELECT * FROM vw_items", dgvItemList)
    End Sub

    Private Sub dgvItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellClick
        If e.RowIndex >= 0 Then
            dgvItemList.Tag = dgvItemList.Rows(e.RowIndex).Cells("Item").Value

            frmAddItem.txtNameOFItem.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString()
            frmAddItem.txtItemDesc.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemDesc").Value.ToString()
            frmAddItem.cbCategory.Text = dgvItemList.Rows(e.RowIndex).Cells("Category").Value.ToString()
            frmAddItem.cbLocation.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemLocation").Value.ToString()
            frmAddItem.cbRemarks.Text = dgvItemList.Rows(e.RowIndex).Cells("Remarks").Value.ToString()


            Dim qty As Object = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
            If qty IsNot Nothing AndAlso Not IsDBNull(qty) AndAlso IsNumeric(qty) Then
                frmAddItem.nupQuantity.Value = CInt(qty)
            Else
                frmAddItem.nupQuantity.Value = 0
            End If


            Dim qtydamage As Object = dgvItemList.Rows(e.RowIndex).Cells("Damaged").Value
            If qtydamage IsNot Nothing AndAlso Not IsDBNull(qtydamage) AndAlso IsNumeric(qtydamage) Then
                frmAddItem.nupDamaged.Value = CInt(qtydamage)
            Else
                frmAddItem.nupDamaged.Value = 0
            End If
        End If
    End Sub


    Private Sub btnBorrow_Click(sender As System.Object, e As System.EventArgs)
        If (dgvItemList.Tag) = 0 Then
            MsgBox("Select an item to borrow!", vbInformation, "Select Item")
        Else
            frmBorrowDE.SelectedItemID = Val(dgvItemList.Tag)
            frmBorrowDE.ShowDialog()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If (dgvItemList.Tag) = 0 Then
            MsgBox("Select an Item to edit!", vbInformation, "Select Item")
        Else
            frmAddItem.nupDamaged.Visible = True
            frmAddItem.lblDamage.Visible = True
            frmAddItem.ItemID = Val(dgvItemList.Tag)
            frmAddItem.ShowDialog()
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As Odbc.OdbcCommand
        If dgvItemList.Tag = 0 Then
            MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
        ElseIf MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion, "Confirm Delete") = vbYes Then
            Try
                ' Step 1: Copy the record to tbldeleteditem (Recycle Bin)
                cmd = New Odbc.OdbcCommand("INSERT INTO tbldeleteditem (deleteID, ItemName, ItemDescription, ItemCategory, ItemQuantity, DeletedDate) SELECT ItemID, ItemName, ItemDescription, ItemCategory, ItemQuantity, NOW()  FROM tblitemlist  WHERE ItemID = " & Val(dgvItemList.Tag), con)
                cmd.ExecuteNonQuery()

                ' Step 2: Delete the record from main table
                cmd = New Odbc.OdbcCommand("DELETE FROM tblitemlist WHERE ItemID = " & Val(dgvItemList.Tag), con)
                cmd.ExecuteNonQuery()

                MsgBox("Deleted successfully!", MsgBoxStyle.Information)

                ' Step 3: Refresh the DataGridView
                Call data_loader("SELECT * FROM vw_items", dgvItemList)

            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub EToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgExit("Are you sure you want to exit?", frmLogin, Homepage, Me)

    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchItems(txtSearch.Text, dgvItemList)
    End Sub


    Private Sub dgvItemList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub

    Private Sub frmListItem_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If CurrentRole.Trim().ToLower() = "student" Then
            btnDelete.Visible = False
            btnEdit.Visible = False
            btnAdd.Location = New Point(1338, 623)
        Else
            btnDelete.Visible = True
            btnEdit.Visible = True
        End If
    End Sub

End Class