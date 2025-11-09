Public Class frmReturnSub

    Private Sub frmReturnSub_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_returnlist ", dgvReturnLists)

        For Each col As DataGridViewColumn In dgvReturnLists.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        With dgvReturnLists
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

    Private Sub dgvReturnList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReturnLists.CellClick
        If e.RowIndex >= 0 Then
            dgvReturnLists.Tag = dgvReturnLists.Rows(e.RowIndex).Cells("ReturnID").Value
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

        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Dim searchText As String = txtSearch.Text.Trim()

            ' Base query: only returned items
            Dim query As String = "SELECT * FROM vw_returnlist"

            ' Add filter if user typed something
            If searchText <> "" Then
                query &= " WHERE StudentName LIKE ? OR ItemName LIKE ?"
            End If

            Using cmd As New Odbc.OdbcCommand(query, con)
                If searchText <> "" Then
                    cmd.Parameters.AddWithValue("?", "%" & searchText & "%")
                    cmd.Parameters.AddWithValue("?", "%" & searchText & "%")
                End If

                Dim da As New Odbc.OdbcDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)

                dgvReturnLists.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox("Error while searching: " & ex.Message, vbCritical, "Search Error")
        End Try
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub
End Class