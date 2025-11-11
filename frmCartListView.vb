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
            Using trans As Odbc.OdbcTransaction = con.BeginTransaction()
                Try
                    ' 1) Get reserved units for this cart
                    Dim reservedUnits As New List(Of Integer)
                    Using cmdGet As New Odbc.OdbcCommand("SELECT UnitID FROM tblcartserials WHERE CartID = ?", con, trans)
                        cmdGet.Parameters.AddWithValue("?", cartID)
                        Using rdr As Odbc.OdbcDataReader = cmdGet.ExecuteReader()
                            While rdr.Read()
                                reservedUnits.Add(CInt(rdr("UnitID")))
                            End While
                        End Using
                    End Using

                    ' 2) Delete cartserials rows
                    Using cmdDelSerials As New Odbc.OdbcCommand("DELETE FROM tblcartserials WHERE CartID = ?", con, trans)
                        cmdDelSerials.Parameters.AddWithValue("?", cartID)
                        cmdDelSerials.ExecuteNonQuery()
                    End Using

                    ' 3) Mark units back to Available
                    For Each u In reservedUnits
                        Using cmdUpd As New Odbc.OdbcCommand("UPDATE tblitemunits SET ItemStatus='Available' WHERE UnitID = ?", con, trans)
                            cmdUpd.Parameters.AddWithValue("?", u)
                            cmdUpd.ExecuteNonQuery()
                        End Using
                    Next

                    ' 4) Get itemID and qty to restore, and delete cart row
                    Dim itemID As Integer = 0
                    Dim qtyBorrowed As Integer = 0
                    Using cmdGetCart As New Odbc.OdbcCommand("SELECT ItemID, QuantityBorrowed FROM tblcartlist WHERE tempID = ?", con, trans)
                        cmdGetCart.Parameters.AddWithValue("?", cartID)
                        Using rdr2 As Odbc.OdbcDataReader = cmdGetCart.ExecuteReader()
                            If rdr2.Read() Then
                                itemID = CInt(rdr2("ItemID"))
                                qtyBorrowed = CInt(rdr2("QuantityBorrowed"))
                            End If
                        End Using
                    End Using

                    ' Restore itemlist quantity
                    If itemID > 0 AndAlso qtyBorrowed > 0 Then
                        Using cmdRestore As New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ItemQuantity + ? WHERE ItemID = ?", con, trans)
                            cmdRestore.Parameters.AddWithValue("?", qtyBorrowed)
                            cmdRestore.Parameters.AddWithValue("?", itemID)
                            cmdRestore.ExecuteNonQuery()
                        End Using
                    End If

                    ' Delete cart row
                    Using cmdDeleteCart As New Odbc.OdbcCommand("DELETE FROM tblcartlist WHERE tempID = ?", con, trans)
                        cmdDeleteCart.Parameters.AddWithValue("?", cartID)
                        cmdDeleteCart.ExecuteNonQuery()
                    End Using

                    trans.Commit()
                    MsgBox("Item removed from cart and quantity restored successfully!", MsgBoxStyle.Information)

                    Call listLoader()
                    If Application.OpenForms().OfType(Of frmBorrowingDE).Any() Then
                        Dim frm As frmBorrowingDE = Application.OpenForms().OfType(Of frmBorrowingDE).First()
                        data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Items", frm.dgvItemList)
                    End If
                Catch ex As Exception
                    trans.Rollback()
                    MsgBox("Error deleting cart item: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End Using
        End If


    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Dim cmd As Odbc.OdbcCommand
        If lvCart.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to edit.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim selectedItem As ListViewItem = lvCart.SelectedItems(0)
        Dim cartID As Integer = CInt(selectedItem.Tag)

        Dim itemName As String = selectedItem.SubItems(0).Text
        Dim itemDesc As String = If(selectedItem.SubItems.Count > 1, selectedItem.SubItems(1).Text, "")
        Dim qty As Integer = If(selectedItem.SubItems.Count > 2, Val(selectedItem.SubItems(2).Text), 0)
        Dim purpose As String = If(selectedItem.SubItems.Count > 3, selectedItem.SubItems(3).Text, "")
        Dim contact As String = If(selectedItem.SubItems.Count > 4, selectedItem.SubItems(4).Text, "")
        Dim remarks As String = If(selectedItem.SubItems.Count > 5, selectedItem.SubItems(5).Text, "")


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

        If Application.OpenForms().OfType(Of frmBorrowingDE).Any() Then
            Dim frm As frmBorrowingDE = Application.OpenForms().OfType(Of frmBorrowingDE).First()
            data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Items", frm.dgvItemList)
        End If

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