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
        Dim cmd As Odbc.OdbcCommand
            Try
            Dim Borrowedqtyy As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT QuantityBorrowed FROM tblborrow WHERE ItemID = ? AND BorrowerName = ?", con)
            cmd.Parameters.AddWithValue("?", CInt(cbItemListR.SelectedValue))
            cmd.Parameters.AddWithValue("?", txtBorrowerNameR.Text)
            Dim borrowResult = cmd.ExecuteScalar()

            If borrowResult Is Nothing OrElse IsDBNull(borrowResult) Then
                MsgBox("This borrower did not borrow the selected item.", vbCritical, "Error")
                Exit Sub
            End If

            ' qty being returned right now
            Dim qtyReturningNow As Integer = CInt(nupQuantityR.Value)

            ' 1) get borrowed quantity for this BorrowID
            Dim borrowedQty As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT IFNULL(SUM(QuantityBorrowed), 0) FROM tblborrow WHERE BorrowID = ?", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            Dim br = cmd.ExecuteScalar()
            If br IsNot Nothing AndAlso Not IsDBNull(br) Then borrowedQty = CInt(br)

            ' 2) get already returned total for this BorrowID
            Dim returnedTotal As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT IFNULL(SUM(QuantityReturned), 0) FROM tblreturn WHERE BorrowID = ?", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            Dim rr = cmd.ExecuteScalar()
            If rr IsNot Nothing AndAlso Not IsDBNull(rr) Then returnedTotal = CInt(rr)


            ' 3) validate
            If returnedTotal + qtyReturningNow > borrowedQty Then
                MsgBox("Returned quantity exceeds total borrowed amount.", vbExclamation)
                Exit Sub
            ElseIf qtyReturningNow <= 0 Then
                MsgBox("Insert Amount")
                Exit Sub
            End If

            Dim qtyReturned As Integer = CInt(nupQuantityR.Value)
            Dim itemID As Integer = CInt(cbItemListR.SelectedValue)
            Dim currentQty As Integer = 0


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
