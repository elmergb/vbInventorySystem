Public Class frmReturnEntry
    Public Property returnID As Integer = 0
    Property BorrowID As Integer
    Property ItemID As Integer


    Private Sub frmReturnEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cb_loader("SELECT * FROM tblitemlist", cbItemListR, "ItemName", "ItemID")
        cbItemListR.SelectedValue = ItemID
        cbReturnRemarks.Items.Clear()
        cbReturnRemarks.Items.Add("Good")
        cbReturnRemarks.Items.Add("Damage")

    End Sub

    Private Sub btnReturnLog_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnLog.Click
        Dim Remarks As String = Trim(cbReturnRemarks.Text).ToLower()
        Dim cmd As Odbc.OdbcCommand
            Try
            ' qty being returned right now
            Dim qtyReturningNow As Integer = CInt(nupQuantityR.Value)

            ' get borrowed quantity for this BorrowID
            Dim borrowedQty As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT IFNULL(SUM(borrowQty), 0) FROM tblborrowing WHERE bID = ?", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            Dim br = cmd.ExecuteScalar()
            If br IsNot Nothing AndAlso Not IsDBNull(br) Then borrowedQty = CInt(br)

            ' get already returned total for this BorrowID
            Dim returnedTotal As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT IFNULL(SUM(QuantityReturned), 0) FROM tblreturn WHERE BorrowID = ?", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            Dim rr = cmd.ExecuteScalar()
            If rr IsNot Nothing AndAlso Not IsDBNull(rr) Then returnedTotal = CInt(rr)


            ' validate
            If returnedTotal + qtyReturningNow > borrowedQty Then
                MsgBox("Returned quantity exceeds total borrowed amount.", vbExclamation)
                Exit Sub
            ElseIf qtyReturningNow <= 0 Then
                MsgBox("Insert Amount")
                Exit Sub
            End If

            Dim itemID As Integer = CInt(cbItemListR.SelectedValue)
            Dim currentQty As Integer = 0

            cmd = New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con)
            cmd.Parameters.AddWithValue("?", itemID)
            Dim cq = cmd.ExecuteScalar()
            If cq IsNot Nothing AndAlso Not IsDBNull(cq) Then
                currentQty = CInt(cq)
            End If

            If Remarks = "damage" Or Remarks = "damaged" Then
                Remarks = "Damage"

            Else
                Remarks = "Good"
            End If

            If Remarks = "Damage" Or Remarks = "damaged" Then
                ' Insert into damaged table, DO NOT add back to stock
                cmd = New Odbc.OdbcCommand("INSERT INTO tbldamaged (ItemID, QuantityDamaged, DateReported, Remarks) VALUES (?, ?, NOW(), ?)", con)
                cmd.Parameters.AddWithValue("?", itemID)
                cmd.Parameters.AddWithValue("?", qtyReturningNow)
                cmd.Parameters.AddWithValue("?", "damaged")
                cmd.ExecuteNonQuery()
            Else
                ' Update with correct math
                Dim newQty As Integer = currentQty + qtyReturningNow
                cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ? WHERE ItemID = ?", con)
                cmd.Parameters.AddWithValue("?", newQty)
                cmd.Parameters.AddWithValue("?", itemID)
                cmd.ExecuteNonQuery()
            End If



            cmd = New Odbc.OdbcCommand(" INSERT INTO tblreturn (BorrowID, QuantityReturned, DateReturned, Remarks) VALUES (?, ?, ?, ?)", con)
            cmd.Parameters.AddWithValue("?", CInt(BorrowID))
            cmd.Parameters.AddWithValue("?", qtyReturningNow)
            cmd.Parameters.AddWithValue("?", dtpBorrowedR.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("?", Remarks)
            cmd.ExecuteNonQuery()


            MsgBox("Item successfully returned!", vbInformation)
            Call data_loader("SELECT * FROM vw_transaction WHERE QuantityBorrowed > QuantityReturned", frmReturnList.dgvReturn)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cbItemListR_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbItemListR.KeyPress
        e.Handled = True
    End Sub

End Class
