Public Class frmReturnEntry
    Public Property returnID As Integer = 0
    Property BorrowID As Integer
    Property ItemID As Integer


    Private Sub frmReturnEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cb_loader("SELECT * FROM tblitemlist", cbItemListR, "ItemName", "ItemID")
        cbItemListR.SelectedValue = ItemID
    End Sub

    Private Sub btnReturnLog_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnLog.Click
        Dim Remarks As String = Trim(txtRemarksR.Text).ToLower()
        Try
            Dim cmd As Odbc.OdbcCommand
            Dim Borrowedqty As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT QuantityBorrowed FROM tblborrow WHERE BorrowID =?", con)
            cmd.Parameters.AddWithValue("?", CInt(BorrowID))
            Dim borrowResult = cmd.ExecuteScalar()

            If borrowResult IsNot Nothing AndAlso Not IsDBNull(borrowResult) Then
                Borrowedqty = CInt(borrowResult)
            End If

            Dim qtyReturnedTotal As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT IFNULL(SUM(QuantityReturned), 0) FROM tblreturn WHERE BorrowID=?", con)
            cmd.Parameters.AddWithValue("?", CInt(BorrowID))
            Dim returnResult = cmd.ExecuteScalar()

            If returnResult IsNot Nothing AndAlso Not IsDBNull(returnResult) Then
                qtyReturnedTotal = CInt(returnResult)
            End If


            If cbItemListR.SelectedValue Is Nothing Then
                MsgBox("Please select an item first.", vbExclamation)
                Exit Sub
            End If

            Dim qtyReturned As Integer = CInt(nupQuantityR.Value)
            Dim itemID As Integer = CInt(cbItemListR.SelectedValue)
            Dim currentQty As Integer = 0

            If qtyReturned + qtyReturnedTotal > borrowResult Then
                MsgBox("Returned quantity exceeds total borrowed amount.", vbExclamation)
                Exit Sub
            End If
            ' 🔹 Get current quantity from database
            cmd = New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con)
            cmd.Parameters.AddWithValue("?", itemID)
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                currentQty = CInt(result)
            End If

            If qtyReturned > currentQty Then
                MsgBox("Returned quantity exceeds borrowed quantity.", vbExclamation)
                Exit Sub
            End If

            ' 🔹 Add back returned quantity
            Dim newQty As Integer = currentQty + qtyReturned
            cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ? WHERE ItemID = ?", con)
            cmd.Parameters.AddWithValue("?", newQty)
            cmd.Parameters.AddWithValue("?", itemID)
            cmd.ExecuteNonQuery()

            If Remarks = "damage" Or Remarks = "critical" Then
                Remarks = "Damage"
            Else
                Remarks = Remarks
            End If

            ' 🔹 Insert into return table
            cmd = New Odbc.OdbcCommand("INSERT INTO tblreturn (BorrowID, QuantityReturned, DateReturned, Remarks) VALUES (?,?,?,?)", con)
            cmd.Parameters.AddWithValue("?", CInt(BorrowID))
            cmd.Parameters.AddWithValue("?", qtyReturned)
            cmd.Parameters.AddWithValue("?", dtpBorrowedR.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("?", Remarks)
            cmd.ExecuteNonQuery()

            MsgBox("Item successfully returned!", vbInformation)
            data_loader("SELECT * FROM vw_transaction WHERE QuantityBorrowed > QuantityReturned", frmReturnList.dgvReturnList)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try

    End Sub
End Class
