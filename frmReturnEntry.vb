Public Class frmReturnEntry
    Public Property returnID As Integer = 0

    Property BorrowID As Integer

    Property ItemID As Integer

    Private Sub frmReturnEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cb_loader("SELECT * FROM tblitemlist", cbItemListR, "ItemName", "ItemID")
    End Sub

    Private Sub btnReturnLog_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnLog.Click
        Try
            If cbItemListR.SelectedValue Is Nothing Then
                MsgBox("Please select an item first.", vbExclamation)
                Exit Sub
            End If

            Dim qtyReturned As Integer = CInt(nupQuantityR.Value)
            Dim itemID As Integer = CInt(cbItemListR.SelectedValue)
            Dim currentQty As Integer = 0

            ' 🔹 Get current quantity from database
            Dim cmd As New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con)
            cmd.Parameters.AddWithValue("?", itemID)
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                currentQty = CInt(result)
            End If

            ' 🔹 Add back returned quantity
            Dim newQty As Integer = currentQty + qtyReturned
            cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ? WHERE ItemID = ?", con)
            cmd.Parameters.AddWithValue("?", newQty)
            cmd.Parameters.AddWithValue("?", itemID)
            cmd.ExecuteNonQuery()

            ' 🔹 Insert into return table
            cmd = New Odbc.OdbcCommand("INSERT INTO tblreturn (BorrowID, QuantityReturned, DateReturned, Remarks) VALUES (?,?,?,?)", con)
            cmd.Parameters.AddWithValue("?", CInt(BorrowID))
            cmd.Parameters.AddWithValue("?", qtyReturned)
            cmd.Parameters.AddWithValue("?", dtpBorrowedR.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("?", Trim(txtRemarksR.Text))
            cmd.ExecuteNonQuery()

            ' 🔹 Optional: update borrow status
            'Dim updateBorrow As New Odbc.OdbcCommand("UPDATE tblborrow SET Status = 'Returned' WHERE BorrowID = ?", con)
            'updateBorrow.Parameters.AddWithValue("?", BorrowID)
            'updateBorrow.ExecuteNonQuery()

            ' 🔹 Confirm success and reload the DataGridView
            MsgBox("Item successfully returned!", vbInformation)
            data_loader("SELECT * FROM vw_transaction WHERE QuantityBorrowed > QuantityReturned", frmReturnList.dgvReturnList)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try

    End Sub
End Class
