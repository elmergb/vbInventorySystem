Public Class frmBorrow
    Public SelectedItemID As Integer
    Private Sub frmBorrow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim qty As Integer = CInt(nupQuantity.Value)
        Call cb_loader("SELECT * FROM tblitemlist", cbItemList, "ItemName", "ItemID")

        If SelectedItemID > 0 Then
            cbItemList.SelectedValue = SelectedItemID
        End If
    End Sub

    Private Sub btnLogSave_Click(sender As System.Object, e As System.EventArgs) Handles btnLogSave.Click
        Dim cmd As Odbc.OdbcCommand


        Try
            cmd = New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblcartlist", con)
            If CInt(cmd.ExecuteScalar()) = 0 Then
                MsgBox("Cart is empty. Add items first.", vbExclamation)
                Exit Sub
            End If

            cmd = New Odbc.OdbcCommand("SELECT * FROM tblcartlist", con)
            Dim reader As Odbc.OdbcDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim insertCmd As New Odbc.OdbcCommand("INSERT INTO tblborrow (ItemID, BorrowerName, QuantityBorrowed, Contact, Purpose, DateBorrowed, Remarks) VALUES (?, ?, ?, ?, ?, ?, ?)", con)
                insertCmd.Parameters.AddWithValue("?", reader("ItemID"))
                insertCmd.Parameters.AddWithValue("?", reader("BorrowerName"))
                insertCmd.Parameters.AddWithValue("?", reader("QuantityBorrowed"))
                insertCmd.Parameters.AddWithValue("?", reader("Contact"))
                insertCmd.Parameters.AddWithValue("?", reader("Purpose"))
                insertCmd.Parameters.AddWithValue("?", reader("DateBorrowed"))
                insertCmd.Parameters.AddWithValue("?", reader("Remarks"))
                insertCmd.ExecuteNonQuery()

                ' 2. Update the item quantity in tblitemlist
                Dim updateCmd As New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ItemQuantity - ? WHERE ItemID = ?", con)
                updateCmd.Parameters.AddWithValue("?", reader("QuantityBorrowed"))
                updateCmd.Parameters.AddWithValue("?", reader("ItemID"))
                updateCmd.ExecuteNonQuery()
            End While

            reader.Close()

            ' 3. Clear the cart
            Dim clearCmd As New Odbc.OdbcCommand("DELETE FROM tblcartlist", con)
            clearCmd.ExecuteNonQuery()

            MessageBox.Show("Borrowing finalized successfully!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try


    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim isValid As Boolean = True
        Dim availableQty As Integer = 0
        Dim totalqty As New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con)
        totalqty.Parameters.AddWithValue("?", CInt(cbItemList.SelectedValue))
        Dim availqty = totalqty.ExecuteScalar()

        If availqty IsNot Nothing Then
            availableQty = CInt(availqty)
        End If

        If nupQuantity.Value > availqty Then
            MsgBox("Not enough available stock! Only " & availableQty & " left", vbInformation)
            isValid = False
            Exit Sub
        End If

        Dim cmd As New Odbc.OdbcCommand("INSERT INTO tblcartlist (ItemID, BorrowerName, QuantityBorrowed, Contact, Purpose, DateBorrowed, Remarks) VALUES (?, ?, ?, ?, ?, ?, ?)", con)

        cmd.Parameters.AddWithValue("?", CInt(cbItemList.SelectedValue))  ' ItemID from combo box
        cmd.Parameters.AddWithValue("?", txtBorrowerName.Text)
        cmd.Parameters.AddWithValue("?", CInt(nupQuantity.Value))
        cmd.Parameters.AddWithValue("?", txtContact.Text)
        cmd.Parameters.AddWithValue("?", txtPurpose.Text)
        cmd.Parameters.AddWithValue("?", DateTime.Now)
        cmd.Parameters.AddWithValue("?", txtRemarks.Text)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Item '" & cbItemList.Text & "' added to cart successfully!", "Cart Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call listLoader()
        cbItemList.SelectedIndex = -1
        txtBorrowerName.Clear()
        nupQuantity.Value = 0
        txtContact.Clear()
        txtPurpose.Clear()
        txtRemarks.Clear()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        frmCartListView.ShowDialog()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class