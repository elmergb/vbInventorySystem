Imports System.Data.Odbc

Public Class frmListItem
    Public BorrowID As Integer
    Public ItemID As Integer
    Private Sub frmListItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_Item", dgvItemList)
        frmAddItem.nupQuantity.Maximum = 1000
        dgvItemList.AutoGenerateColumns = False
        dgvItemList.Tag = 0

        For Each col As DataGridViewColumn In dgvItemList.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ClearAllText(frmAddItem)
        dgvItemList.Tag = 0
        frmAddItem.ShowDialog()
        frmAddItem.ItemID = 0
        'If Val(dgvItemList.Tag) = 0 Then
        '    MsgBox("Select a record ")
        'End If
    End Sub

    Private Sub dgvItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellClick
        If e.RowIndex >= 0 Then
            dgvItemList.Tag = dgvItemList.Rows(e.RowIndex).Cells("Item").Value

            frmAddItem.txtNameOFItem.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString()
            frmAddItem.txtItemDesc.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemDesc").Value.ToString()
            frmAddItem.cbCategory.Text = dgvItemList.Rows(e.RowIndex).Cells("Category").Value.ToString()
            frmAddItem.cbLocation.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemLocation").Value.ToString()
            frmAddItem.cbRemarks.Text = dgvItemList.Rows(e.RowIndex).Cells("Remarks").Value.ToString()

            ' ✅ Quantity
            Dim qty As Object = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
            If qty IsNot Nothing AndAlso Not IsDBNull(qty) AndAlso IsNumeric(qty) Then
                frmAddItem.nupQuantity.Value = CInt(qty)
            Else
                frmAddItem.nupQuantity.Value = 0
            End If

            ' ✅ Damaged (if you have a separate control, e.g., nupDamaged)
            Dim qtydamage As Object = dgvItemList.Rows(e.RowIndex).Cells("Damaged").Value
            If qtydamage IsNot Nothing AndAlso Not IsDBNull(qtydamage) AndAlso IsNumeric(qtydamage) Then
                frmAddItem.nupDamaged.Value = CInt(qtydamage)
            Else
                frmAddItem.nupDamaged.Value = 0
            End If
        End If
    End Sub


    Private Sub btnBorrow_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrow.Click
        If (dgvItemList.Tag) = 0 Then
            MsgBox("Select an item to borrow!", vbInformation, "Select Item")
        Else
            frmBorrow.SelectedItemID = Val(dgvItemList.Tag)
            frmBorrow.ShowDialog()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If (dgvItemList.Tag) = 0 Then
            MsgBox("Select an Item to edit!", vbInformation, "Select Item")
        Else
            frmAddItem.ItemID = Val(dgvItemList.Tag)
            frmAddItem.ShowDialog()
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As New Odbc.OdbcCommand
        If dgvItemList.Tag = 0 Then
            MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
        ElseIf MsgBox("Are you sure to Delete this record?", vbYesNo + vbQuestion + MsgBoxStyle.Question, "Confirm Delete") = vbYes Then
            cmd = New Odbc.OdbcCommand("DELETE FROM tbldamaged WHERE ItemID = " & Val(dgvItemList.Tag), con)
            cmd.ExecuteNonQuery()
            cmd = New Odbc.OdbcCommand("DELETE FROM tblitemlist WHERE ItemID = " & Val(dgvItemList.Tag), con)
            cmd.ExecuteNonQuery()
            MsgBox("Item deleted successfully!")
            Call data_loader("SELECT * FROM vw_Item", dgvItemList)
        End If
    End Sub

    Private Sub EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EToolStripMenuItem.Click
        MsgExit("Are you sure you want to exit?", Login, Homepage, Me)

    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchItems(txtSearch.Text, dgvItemList)
    End Sub

    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        If txtSearch.Text = "Search Item" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.Black
            txtSearch.Font = New Font(txtSearch.Font, FontStyle.Italic)
        End If
    End Sub


    'Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
    '    Call data_loader("SELECT * FROM vw_Item", dgvItemList)
    '    If txtSearch.Text = "" Then
    '        txtSearch.Text = "Search Item"
    '        txtSearch.ForeColor = Color.Gray
    '        txtSearch.Font = New Font(txtSearch.Font, FontStyle.Italic)
    '    End If
    'End Sub
    'Private Sub txtUsername_GotFocus(sender As Object, e As System.EventArgs) Handles txtUsername.GotFocus
    '    If txtUsername.Text = "Username" Then
    '        txtUsername.Text = ""
    '        txtUsername.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub txtUsername_LostFocus(sender As Object, e As System.EventArgs) Handles txtUsername.LostFocus
    '    If txtUsername.Text = "" Then
    '        txtUsername.Text = "Username"
    '        txtUsername.ForeColor = Color.Gray
    '    End If
    'End Sub

    Private Sub dgvItemList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub
End Class