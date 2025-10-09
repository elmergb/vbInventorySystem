Public Class frmReturnEntry
    Public Property returnID As Integer = 0
    Private Sub frmReturnEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cb_loader("SELECT * FROM tblitemlist", cbItemListR, "ItemName", "ItemID")
    End Sub

    Private Sub btnReturnLog_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnLog.Click
        Dim cmd As Odbc.OdbcCommand
        Dim borrowID As Integer = Val(frmBorrowerList.dgvBorrowerList.Item(1, frmBorrowerList.dgvBorrowerList.CurrentRow.Index).Value)
        Dim ItemID As Integer = Val(frmBorrowerList.dgvBorrowerList.Item(0, frmBorrowerList.dgvBorrowerList.CurrentRow.Index).Value)
        Dim qtyBorrowed As Integer = Val(frmBorrowerList.dgvBorrowerList.Item(4, frmBorrowerList.dgvBorrowerList.CurrentRow.Index).Value)
        Dim currentQty As Integer = 0
        If Val(frmBorrowerList.Tag) = 0 Then
            Try
                cmd = New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblItemList WHERE ItemID = ?", con)
                cmd.Parameters.AddWithValue("?", ItemID)
                Dim result = cmd.ExecuteScalar

                If result IsNot Nothing Then
                    qtyBorrowed = CInt(result)
                End If

                Dim allQty = currentQty + qtyBorrowed

                cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ?, ItemID = ?", con)
                With cmd.Parameters
                    .AddWithValue("?", allQty)
                    .AddWithValue("?", ItemID)
                End With
                cmd.ExecuteNonQuery()

                ' (Optional) Update borrow status as "Returned"
                cmd = New Odbc.OdbcCommand("UPDATE tblBorrowing SET Status = 'Returned' WHERE BorrowID = ?", con)
                cmd.Parameters.AddWithValue("?", borrowID)
                cmd.ExecuteNonQuery()

                MsgBox("Item successfully returned!", vbInformation)

                ' Reload DataGridView
                data_loader("SELECT * FROM vw_borrowing", frmReturnList.dgvReturnList)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
