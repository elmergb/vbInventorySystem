Public Class frmReturnEntry
    Public Property returnID As Integer = 0
    Public Property BorrowID As Integer
    Property ItemID As Integer


    Private Sub frmReturnEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cb_loader("SELECT * FROM tblitemlist", cbItemListR, "ItemName", "ItemID")
        cbItemListR.SelectedValue = ItemID
        cbReturnRemarks.Items.Clear()
        cbReturnRemarks.Items.Add("Good")
        cbReturnRemarks.Items.Add("Damage")
    End Sub

    Private Sub btnReturnLog_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnLog.Click
        Try
            Dim BorrowID As Integer = Me.BorrowID
            Dim Remarks As String = Trim(cbReturnRemarks.Text)
            Dim cmd As Odbc.OdbcCommand
            Dim returnID As Integer
            Dim qtyReturningNow As Integer = CInt(nupQuantityR.Value)

            ' get borrowed quantity for this BorrowID
            Dim borrowedQty As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT IFNULL(SUM(borrowqty), 0) FROM tblborrowing WHERE bID = ?", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            Dim br = cmd.ExecuteScalar()
            If br IsNot Nothing AndAlso Not IsDBNull(br) Then borrowedQty = CInt(br)

            ' get already returned total for this bID
            Dim returnedTotal As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT IFNULL(SUM(QuantityReturned), 0) FROM tblreturn WHERE bID = ?", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            Dim rr = cmd.ExecuteScalar()
            If rr IsNot Nothing AndAlso Not IsDBNull(rr) Then returnedTotal = CInt(rr)

            MsgBox("BorrowID value: " & BorrowID)

            ' validation
            If returnedTotal + qtyReturningNow > borrowedQty Then
                MsgBox("Returned quantity exceeds total borrowed amount.", vbExclamation)
                Exit Sub
            ElseIf qtyReturningNow <= 0 Then
                MsgBox("Insert Amount")
                Exit Sub
            End If

            Dim itemID As Integer = CInt(cbItemListR.SelectedValue)
            cmd = New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con)
            cmd.Parameters.AddWithValue("?", itemID)
            Dim currentQty As Integer = CInt(cmd.ExecuteScalar())

            ' insert to tblreturn
            cmd = New Odbc.OdbcCommand("INSERT INTO tblreturn (bID, QuantityReturned, DateTimeReturned, Remarks) VALUES (?, ?, ?, ?)", con)
            cmd.Parameters.AddWithValue("?", CInt(BorrowID))
            cmd.Parameters.AddWithValue("?", qtyReturningNow)
            cmd.Parameters.AddWithValue("?", dtpBorrowedR.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("?", Remarks)
            cmd.ExecuteNonQuery()

            ' retrieve the new returnID
            cmd = New Odbc.OdbcCommand("SELECT MAX(ReturnID) FROM tblreturn WHERE bID = ?", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            returnID = CInt(cmd.ExecuteScalar())

            ' Handle(damage)
            If Remarks = "Damage" Then
                Dim choice As MsgBoxResult
                choice = MsgBox("There are " & qtyReturningNow & " damaged item(s)." & vbCrLf &
                                "Does the student want to PAY (Yes) or REPLACE (No)?",
                                vbYesNoCancel + vbQuestion, "Damage Detected")

                ' Insert into tbldamaged first
                cmd = New Odbc.OdbcCommand("INSERT INTO tbldamaged (ItemID, QuantityDamaged, DateReported, DamageRemarks, ReturnID, Status) VALUES (?, ?, NOW(), ?, ?, 'Pending')", con)
                cmd.Parameters.AddWithValue("?", itemID)
                cmd.Parameters.AddWithValue("?", qtyReturningNow)
                cmd.Parameters.AddWithValue("?", "Damaged")
                cmd.Parameters.AddWithValue("?", returnID)
                cmd.ExecuteNonQuery()

                ' Get last DamageID
                cmd = New Odbc.OdbcCommand("SELECT MAX(DamageID) FROM tbldamaged", con)
                Dim damageID As Integer = CInt(cmd.ExecuteScalar())

                If choice = vbYes Then
                    ' Student chose PAY
                    cmd = New Odbc.OdbcCommand("INSERT INTO tbldamage_action (DamageID, ActionType, Status) VALUES (?, 'Pay', 'Pending')", con)
                    cmd.Parameters.AddWithValue("?", damageID)
                    cmd.ExecuteNonQuery()

                    MsgBox("Marked as pending payment.", vbInformation)

                ElseIf choice = vbNo Then
                    ' Student chose REPLACE
                    cmd = New Odbc.OdbcCommand("INSERT INTO tbldamage_action (DamageID, ActionType, Status) VALUES (?, 'Replace', 'Pending')", con)
                    cmd.Parameters.AddWithValue("?", damageID)
                    cmd.ExecuteNonQuery()

                    MsgBox("Marked as pending replacement.", vbInformation)

                ElseIf choice = vbCancel Then
                    MsgBox("Damage return canceled.", vbInformation)
                    Exit Sub
                End If
            Else
                cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ItemQuantity + ? WHERE ItemID = ?", con)
                cmd.Parameters.AddWithValue("?", qtyReturningNow)
                cmd.Parameters.AddWithValue("?", itemID)
                cmd.ExecuteNonQuery()
            End If

            MsgBox("Return recorded successfully.", vbInformation)
            Call data_loader("SELECT * FROM vw_borrowed_items", frmReturnList.dgvReturn)

            Me.Close()
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
