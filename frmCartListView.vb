Public Class frmCartListView
    Private Sub frmCartListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With lvCart
            .View = View.Details
            .FullRowSelect = True
            .Columns.Clear()
            .Columns.Add("Item", 150)
            .Columns.Add("Quantity", 80)
        End With
        Call listLoader()
    End Sub

    Private Sub lvCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCart.SelectedIndexChanged
        If lvCart.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvCart.SelectedItems(0)
            Dim itemName As String = selectedItem.SubItems(0).Text
            Dim qty As String = selectedItem.SubItems(1).Text


            frmBorrow.cbItemList.Text = itemName
            frmBorrow.nupQuantity.Value = CInt(qty)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As Odbc.OdbcCommand
        If lvCart.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to delete.", MsgBoxStyle.Exclamation)
        End If

        Dim itemName As String = lvCart.SelectedItems(0).SubItems(0).Text
        cmd = New Odbc.OdbcCommand("DELETE FROM tblcartlist WHERE ItemID =  (SELECT ItemID From tblitemlist WHERE ItemName = ?)", con)
        cmd.Parameters.AddWithValue("?", itemName)
        cmd.ExecuteNonQuery()

        MsgBox("Item removed successfully!")
        Call listLoader()
    End Sub
End Class