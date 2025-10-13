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
            ' Validate ComboBox selection
            If cbItemListR.SelectedValue Is Nothing Then
                    MsgBox("Please select an item first.", vbExclamation)
                    Exit Sub
                End If

            ' Validate BorrowerList and selection
            'If frmBorrowerList Is Nothing OrElse frmBorrowerList.dgvBorrowerList.CurrentRow Is Nothing Then
            '    MsgBox("No borrower record selected.", vbExclamation)
            '    Exit Sub
            'End If

            Dim qtyReturned As Integer = CInt(nupQuantityR.Value)
            Dim currentQty As Integer = 0

            ' Update item quantity in stock
            Dim newQty As Integer = currentQty + qtyReturned
            cmd = New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblItemList WHERE ItemID = ?", con)
            cmd.Parameters.AddWithValue("?", ItemID)
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                currentQty = CInt(result)
            End If

            cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ? WHERE ItemID =?", con)
            With cmd.Parameters
                .AddWithValue("?", CInt(newQty))
                .AddWithValue("?", CInt(cbItemListR.SelectedValue))
            End With
            cmd.ExecuteNonQuery()

            ' Insert return record
            cmd = New Odbc.OdbcCommand("INSERT INTO tblreturn (BorrowID,QuantityReturned,DateReturned,Remarks) VALUES (?,?,?,?)", con)
                With cmd.Parameters
                    .AddWithValue("?", CInt(BorrowID))
                    .AddWithValue("?", qtyReturned)
                    .AddWithValue("?", dtpBorrowedR.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                    .AddWithValue("?", Trim(txtRemarksR.Text))
                End With
                cmd.ExecuteNonQuery()




            ' Optionally update borrow status as "Returned"
            'cmd = New Odbc.OdbcCommand("UPDATE tblborrow SET Status = 'Returned' WHERE BorrowID = ?", con)
            'cmd.Parameters.AddWithValue("?", BorrowID)
            'cmd.ExecuteNonQuery()

            MsgBox("Item successfully returned!", vbInformation)

                ' Reload DataGridView
                data_loader("SELECT * FROM vw_transaction", frmReturnList.dgvReturnList)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try
    End Sub
End Class
