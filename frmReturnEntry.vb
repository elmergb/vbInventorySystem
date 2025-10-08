Public Class frmReturnEntry
    Public Property returnID As Integer = 0
    Private Sub frmReturnEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReturnLog_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnLog.Click
        Dim cmd As Odbc.OdbcCommand
        Dim borrowID As Integer = Val(frmBorrowerList.dgvBorrowerList.Item(1, frmBorrowerList.dgvBorrowerList.CurrentRow.Index).Value)
        Dim ItemID As Integer = Val(frmBorrowerList.dgvBorrowerList.Item(0, frmBorrowerList.dgvBorrowerList.CurrentRow.Index).Value)
        Dim qtyBorrowed As Integer = Val(frmBorrowerList.dgvBorrowerList.Item(4, frmBorrowerList.dgvBorrowerList.CurrentRow.Index).Value)
        If Val(frmBorrowerList.Tag) = 0 Then
            Try
                Dim query As String = "SELECT * FROM tblitemlist WHERE ItemID = ?"
                cmd = New Odbc.OdbcCommand(borrowID, con)
                cmd.Parameters.AddWithValue("?", ItemID)
                Dim result = cmd.ExecuteScalar

                If result IsNot Nothing Then
                    qtyBorrowed = CInt(result)
                End If

                cmd = New Odbc.OdbcCommand("UPDATE")
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
