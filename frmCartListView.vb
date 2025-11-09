Public Class frmCartListView

    Private Sub frmCartListView_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        With lvCart
            .View = View.Details
            .FullRowSelect = True
            .Columns.Clear()
            .Columns.Add("Item", 150)
            .Columns.Add("Description", 200)
            .Columns.Add("Quantity", 80)
        End With

    End Sub

    Private Sub lvCart_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvCart.SelectedIndexChanged
        If lvCart.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvCart.SelectedItems(0)
            Dim itemName As String = selectedItem.SubItems(0).Text
            Dim desc As String = selectedItem.SubItems(1).Text
            Dim qty As String = selectedItem.SubItems(2).Text


            frmBorrowDE.cbItemList.Text = itemName
            frmBorrowDE.txtItemDesc.Text = desc
            frmBorrowDE.nupQuantity.Value = CInt(qty)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If lvCart.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to delete.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = lvCart.SelectedItems(0)
        Dim cartID As Integer = CInt(selectedItem.Tag)

        If MessageBox.Show("Are you sure you want to delete this cart item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim cmd As New Odbc.OdbcCommand("DELETE FROM tblcartlist WHERE tempID = ?", con)
                cmd.Parameters.AddWithValue("?", cartID)
                cmd.ExecuteNonQuery()
                MsgBox("Item removed from cart successfully!", MsgBoxStyle.Information)
                Call listLoader()  ' refresh list view
            Catch ex As Exception
                MsgBox("Error deleting cart item: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        If lvCart.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to edit.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = lvCart.SelectedItems(0)
        Dim cartID As Integer = CInt(selectedItem.Tag)

        Dim itemName As String = selectedItem.SubItems(0).Text
        Dim itemDesc As String = selectedItem.SubItems(1).Text
        Dim qty As Integer = CInt(selectedItem.SubItems(2).Text)
        Dim purpose As String = selectedItem.SubItems(3).Text
        Dim contact As String = selectedItem.SubItems(4).Text
        Dim remarks As String = selectedItem.SubItems(5).Text

        Dim editForm As New frmBorrowDE()
        With editForm
            .IsEditMode = True
            .CartID = cartID
            .SelectedItemID = GetItemIDByName(itemName)
            .cbItemList.Text = itemName
            .txtItemDesc.Text = itemDesc
            .nupQuantity.Value = qty
            .txtPurpose.Text = purpose
            .txtContact.Text = contact
            .cbBorrowRemarks.Text = remarks
        End With

        editForm.ShowDialog()

        listLoader()

    End Sub

    Private Sub lblName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Function GetItemIDByName(ByVal itemName As String) As Integer
        Dim result As Integer = -1
        Dim cmd As New Odbc.OdbcCommand("SELECT ItemID FROM tblitemlist WHERE ItemName = ?", con)
        cmd.Parameters.AddWithValue("?", itemName.Trim())
        Dim obj = cmd.ExecuteScalar()
        If obj IsNot Nothing AndAlso Not IsDBNull(obj) Then
            result = CInt(obj)
        End If
        Return result
    End Function

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class