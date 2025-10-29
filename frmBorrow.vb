Public Class frmBorrow
    Public SelectedItemID As Integer
    Private Sub frmBorrow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim qty As Integer = CInt(nupQuantity.Value)
        Call cb_loader("SELECT * FROM tblitemlist", cbItemList, "ItemName", "ItemID")

        If SelectedItemID > 0 Then
            cbItemList.SelectedValue = SelectedItemID
        End If
        cbBorrowRemarks.Items.Clear()
        cbBorrowRemarks.Items.Add("Good")
        cbBorrowRemarks.Items.Add("Damage")

    End Sub


    Private Sub btnCart_Click(sender As Object, e As EventArgs)
        frmCartListView.ShowDialog()

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
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
        cmd.Parameters.AddWithValue("?", cbBorrowRemarks.Text)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Item '" & cbItemList.Text & "' added to cart successfully!", "Cart Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call listLoader()
        cbItemList.SelectedIndex = -1
        txtBorrowerName.Clear()
        nupQuantity.Value = 0
        txtContact.Clear()
        txtPurpose.Clear()
        cbBorrowRemarks.Items.Clear()
        Me.Close()
        

    End Sub

    Private Sub txtBorrowerName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBorrowerName.TextChanged

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtItemDesc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtItemDesc.TextChanged

    End Sub
End Class