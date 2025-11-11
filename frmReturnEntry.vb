Public Class frmReturnEntry
    Public Property returnID As Integer = 0
    Public Property BorrowID As Integer
   Public Event ReturnCompleted As EventHandler
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

            ' --- GET BORROWED QUANTITY ---
            Dim borrowedQty As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT IFNULL(SUM(borrowQty), 0) FROM tblborrowing WHERE bID = ?", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            Dim br = cmd.ExecuteScalar()
            If br IsNot Nothing AndAlso Not IsDBNull(br) Then borrowedQty = CInt(br)

            ' --- GET TOTAL RETURNED SO FAR ---
            Dim returnedTotal As Integer = 0
            cmd = New Odbc.OdbcCommand("SELECT IFNULL(SUM(QuantityReturned), 0) FROM tblreturn WHERE bID = ?", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            Dim rr = cmd.ExecuteScalar()
            If rr IsNot Nothing AndAlso Not IsDBNull(rr) Then returnedTotal = CInt(rr)

            ' --- VALIDATION ---
            If returnedTotal + qtyReturningNow > borrowedQty Then
                MsgBox("Returned quantity exceeds total borrowed amount.", vbExclamation)
                Exit Sub
            ElseIf qtyReturningNow <= 0 Then
                MsgBox("Please enter a valid return quantity.", vbExclamation)
                Exit Sub
            End If

            ' --- GET ITEM ID ---
            Dim itemID As Integer = CInt(cbItemListR.SelectedValue)

            ' --- INSERT RETURN RECORD ---
            cmd = New Odbc.OdbcCommand("INSERT INTO tblreturn (bID, QuantityReturned, DateTimeReturned, Remarks) VALUES (?, ?, NOW(), ?)", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            cmd.Parameters.AddWithValue("?", qtyReturningNow)
            cmd.Parameters.AddWithValue("?", Remarks)
            cmd.ExecuteNonQuery()

            ' --- GET RETURN ID ---
            cmd = New Odbc.OdbcCommand("SELECT MAX(ReturnID) FROM tblreturn WHERE bID = ?", con)
            cmd.Parameters.AddWithValue("?", BorrowID)
            returnID = CInt(cmd.ExecuteScalar())

            ' --- GET SERIALS TIED TO THIS BORROW ID ---
            Dim returnedSerials As New List(Of String)
            cmd = New Odbc.OdbcCommand("SELECT UnitID, SerialNo FROM(tblitemunits)  WHERE ItemID = ? AND bID = ? AND ItemStatus = 'Borrowed' ORDER BY UnitID ASC LIMIT ?", con)
            cmd.Parameters.AddWithValue("?", itemID)
            cmd.Parameters.AddWithValue("?", BorrowID)
            cmd.Parameters.AddWithValue("?", qtyReturningNow)

            Dim unitIDs As New List(Of Integer)
            Using rdr As Odbc.OdbcDataReader = cmd.ExecuteReader()
                While rdr.Read()
                    returnedSerials.Add(rdr("SerialNo").ToString())
                    unitIDs.Add(CInt(rdr("UnitID")))
                End While
            End Using

            If unitIDs.Count = 0 Then
                MsgBox("No matching borrowed serials found for this transaction.", vbExclamation)
                Exit Sub
            End If

            ' --- UPDATE ITEM UNITS (SET AVAILABLE, REMOVE bID) ---
            For Each uid As Integer In unitIDs
                cmd = New Odbc.OdbcCommand("Update(tblitemunits)  SET ItemStatus = 'Available', bID = NULL  WHERE UnitID = ?", con)
                cmd.Parameters.AddWithValue("?", uid)
                cmd.ExecuteNonQuery()
            Next

            ' --- DAMAGE HANDLING ---
            If Remarks = "Damage" Then
                Dim choice As MsgBoxResult
                choice = MsgBox("There are " & qtyReturningNow & " damaged item(s)." & vbCrLf &
                                "Does the student want to PAY (Yes) or REPLACE (No)?",
                                vbYesNoCancel + vbQuestion, "Damage Detected")

                ' Record the damage report
                cmd = New Odbc.OdbcCommand("INSERT INTO tbldamaged (ItemID, QuantityDamaged, DateReported, DamageRemarks, ReturnID, Status)   VALUES (?, ?, NOW(), ?, ?, 'Pending')", con)
                cmd.Parameters.AddWithValue("?", itemID)
                cmd.Parameters.AddWithValue("?", qtyReturningNow)
                cmd.Parameters.AddWithValue("?", "Damaged")
                cmd.Parameters.AddWithValue("?", returnID)
                cmd.ExecuteNonQuery()

                ' Get DamageID
                cmd = New Odbc.OdbcCommand("SELECT MAX(DamageID) FROM tbldamaged", con)
                Dim damageID As Integer = CInt(cmd.ExecuteScalar())

                ' Choose action (Pay or Replace)
                If choice = vbYes Then
                    cmd = New Odbc.OdbcCommand("INSERT INTO tbldamage_action (DamageID, ActionType, Status) VALUES (?, 'Pay', 'Pending')", con)
                    cmd.Parameters.AddWithValue("?", damageID)
                    cmd.ExecuteNonQuery()
                    MsgBox("Marked as pending payment.", vbInformation)

                ElseIf choice = vbNo Then
                    cmd = New Odbc.OdbcCommand("INSERT INTO tbldamage_action (DamageID, ActionType, Status) VALUES (?, 'Replace', 'Pending')", con)
                    cmd.Parameters.AddWithValue("?", damageID)
                    cmd.ExecuteNonQuery()
                    MsgBox("Marked as pending replacement.", vbInformation)

                ElseIf choice = vbCancel Then
                    MsgBox("Damage return canceled.", vbInformation)
                    Exit Sub
                End If
            Else
                ' --- UPDATE ITEM STOCK ---
                cmd = New Odbc.OdbcCommand("Update(tblitemlist) SET ItemQuantity = ItemQuantity + ?        WHERE ItemID = ?", con)
                cmd.Parameters.AddWithValue("?", qtyReturningNow)
                cmd.Parameters.AddWithValue("?", itemID)
                cmd.ExecuteNonQuery()
            End If

            ' --- SUCCESS MESSAGE ---
            MsgBox("Return recorded successfully!" & vbCrLf &
                   "Returned Serials: " & String.Join(", ", returnedSerials),
                   vbInformation)

            ' --- REFRESH VIEW ---
            Call data_loader("SELECT * FROM vw_borrowed_items", frmReturnList.dgvReturn)
            RaiseEvent ReturnCompleted(Me, EventArgs.Empty)
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

    Private Sub dtpBorrowedR_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
