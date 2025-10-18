Public Class frmBorrow


    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub frmBorrow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call cb_loader("SELECT * FROM tblitemlist", cbItemList, "ItemName", "ItemID")
    End Sub

    Private Sub btnLogSave_Click(sender As System.Object, e As System.EventArgs) Handles btnLogSave.Click
        Dim cmd As Odbc.OdbcCommand
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try


    End Sub
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim cmd As New Odbc.OdbcCommand("INSERT INTO tblcartlist (ItemID, BorrowerName, QuantityBorrowed, Contact, Purpose, DateBorrowed, Remarks) VALUES (?, ?, ?, ?, ?, ?, ?)", con)

        cmd.Parameters.AddWithValue("?", CInt(cbItemList.SelectedValue))  ' ItemID from combo box
        cmd.Parameters.AddWithValue("?", txtBorrowerName.Text)
        cmd.Parameters.AddWithValue("?", CInt(nupQuantity.Value))
        cmd.Parameters.AddWithValue("?", txtContact.Text)
        cmd.Parameters.AddWithValue("?", txtPurpose.Text)
        cmd.Parameters.AddWithValue("?", DateTime.Now)
        cmd.Parameters.AddWithValue("?", txtRemarks.Text)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Item added to temporary list.")

    End Sub
End Class