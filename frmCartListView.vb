Public Class frmCartListView

    Private Sub frmCartListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With lvCart
            .View = View.Details
            .FullRowSelect = True
            .Columns.Clear()
            .Columns.Add("Item", 150)
            .Columns.Add("Description", 200)
            .Columns.Add("Quantity", 80)
        End With

    End Sub

    Private Sub lvCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCart.SelectedIndexChanged
        If lvCart.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvCart.SelectedItems(0)
            Dim itemName As String = selectedItem.SubItems(0).Text
            Dim desc As String = selectedItem.SubItems(1).Text
            Dim qty As String = selectedItem.SubItems(2).Text


            frmBorrow.cbItemList.Text = itemName
            frmBorrow.txtItemDesc.Text = desc
            frmBorrow.nupQuantity.Value = CInt(qty)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As Odbc.OdbcCommand
        If lvCart.SelectedItems.Count >= 0 Then
            MsgBox("Please select an item to delete.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim itemName As String = lvCart.SelectedItems(0).SubItems(0).Text
            cmd = New Odbc.OdbcCommand("DELETE FROM tblcartlist WHERE ItemID =  (SELECT ItemID From tblitemlist WHERE ItemName = ?)", con)
            cmd.Parameters.AddWithValue("?", itemName)
            cmd.ExecuteNonQuery()

            MsgBox("Item removed successfully!")
            Call listLoader()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If lvCart.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to edit.", MsgBoxStyle.Exclamation)
        Else

        End If
    End Sub

    Private Sub lblName_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class