Public Class frmReturnEntry
    Public Property returnID As Integer = 0

    Property BorrowID As Integer

    Property ItemID As Integer

    Private Sub frmReturnEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cb_loader("SELECT * FROM tblitemlist", cbItemListR, "ItemName", "ItemID")
    End Sub

    Private Sub btnReturnLog_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnLog.Click
        Dim cmd As Odbc.OdbcCommand

        Try
            ' 1️⃣ Validate selection
            If cbItemListR.SelectedValue Is Nothing Then
                MsgBox("Please select an item first.", vbExclamation)
                Exit Sub
            End If

            Dim qtyReturned As Integer = CInt(nupQuantityR.Value)
            Dim currentQty As Integer = 0

            ' 2️⃣ Get current stock
            cmd = New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con)
            cmd.Parameters.AddWithValue("?", cbItemListR.SelectedValue)
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                currentQty = CInt(result)
            End If

            ' 3️⃣ Compute new quantity
            Dim newQty As Integer = currentQty + qtyReturned

            ' 4️⃣ Update item stock
            cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ? WHERE ItemID = ?", con)
            With cmd.Parameters
                .AddWithValue("?", newQty)
                .AddWithValue("?", cbItemListR.SelectedValue)
            End With
            cmd.ExecuteNonQuery()

            ' 5️⃣ Insert return record
            cmd = New Odbc.OdbcCommand("INSERT INTO tblreturn (BorrowID, QuantityReturned, DateReturned, Remarks) VALUES (?,?,?,?)", con)
            With cmd.Parameters
                .AddWithValue("?", CInt(BorrowID))
                .AddWithValue("?", qtyReturned)
                .AddWithValue("?", dtpBorrowedR.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                .AddWithValue("?", Trim(txtRemarksR.Text))
            End With
            cmd.ExecuteNonQuery()

            ' 6️⃣ Optional: update borrow status
            'cmd = New Odbc.OdbcCommand("UPDATE tblborrow SET Status = 'Returned' WHERE BorrowID = ?", con)
            'cmd.Parameters.AddWithValue("?", BorrowID)
            'cmd.ExecuteNonQuery()

            ' 7️⃣ Notify and refresh
            MsgBox("Item successfully returned!", vbInformation)
            data_loader("SELECT * FROM vw_transaction", frmReturnList.dgvReturnList)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try

    End Sub
End Class
