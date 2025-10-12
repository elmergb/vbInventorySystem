Public Class frmReturnEntry
    Public BorrowID As Integer
    Public ItemID As Integer
    Public QtyBorrowed As Integer
    Public Property ReturnIDs As Integer = 0
    Public Property returnID As Integer = 0
    Private Sub frmReturnEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cb_loader("SELECT * FROM tblitemlist", cbItemListR, "ItemName", "ItemID")
    End Sub

    Private Sub btnReturnLog_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnLog.Click
        Dim cmd As Odbc.OdbcCommand
        Dim itemID As Integer = Me.ItemID
        Dim borrowID As Integer = Me.BorrowID
        Dim qtyReturned As Integer = CInt(nupQuantityR.Value) ' The quantity being returned
        Dim currentQty As Integer = 0

        Try
            ' Get current stock quantity
            cmd = New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblItemList WHERE ItemID = ?", con)
            cmd.Parameters.AddWithValue("?", itemID)
            Dim result = cmd.ExecuteScalar

            If result IsNot Nothing Then
                currentQty = CInt(result)
            End If

            ' Add returned quantity to current stock
            Dim newQty = currentQty + qtyReturned
            newQty = nupQuantityR.Value
            ' Update item quantity in stock
            cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ?  WHERE ItemID = ?", con)
            With cmd.Parameters
                .AddWithValue("?", newQty)
                .AddWithValue("?", itemID)
            End With
            cmd.ExecuteNonQuery()

            ' Update borrow status as "Returned"
            'cmd = New Odbc.OdbcCommand("UPDATE tblborrow SET Status = 'Returned' WHERE BorrowID = ?", con)
            'cmd.Parameters.AddWithValue("?", borrowID)
            'cmd.ExecuteNonQuery()

            MsgBox("Item successfully returned!", vbInformation)

            ' Reload DataGridView
            data_loader("SELECT * FROM vw_borrowing", frmReturnList.dgvReturnList)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try

    End Sub
End Class
