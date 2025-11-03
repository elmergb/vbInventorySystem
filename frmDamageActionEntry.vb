Public Class frmDamageActionEntry
    Public Property actionID As Integer
    Private Sub frmDamageActionEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        vbConnection()
        cbActionType.Items.AddRange({"Pay", "Replace", "Repair", "Penalty"})
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
       If actionID > 0 Then
    Try
        Dim actionType As String = cbActionType.Text.Trim()
        Dim notes As String = txtRemarks.Text.Trim()
        Dim amountPaid As Double
        Dim qtyDamage As Integer = CInt(lblQtyDamage.Text)
        Dim itemID As Integer
                Dim damageID As Integer
        ' Debug check
        MsgBox("Action ID: " & actionID)

        ' Safely convert text to number
        If Not Double.TryParse(txtAmount.Text, amountPaid) Then
            amountPaid = 0
        End If

        ' ✅ 1. Get the ItemID connected to this ActionID
                Dim getItemCmd As New Odbc.OdbcCommand(" SELECT d.ItemID, d.DamageID FROM tbldamaged d INNER JOIN tbldamage_action a ON d.DamageID = a.DamageID WHERE a.ActionID = ?", con)
                getItemCmd.Parameters.AddWithValue("?", actionID)

                Dim rdr As Odbc.OdbcDataReader = getItemCmd.ExecuteReader()
                If rdr.Read() Then
                    itemID = CInt(rdr("ItemID"))
                    damageID = CInt(rdr("DamageID"))
                Else
                    MsgBox("Unable to find related ItemID or DamageID.", vbExclamation)
                    rdr.Close()
                    Exit Sub
                End If
                rdr.Close()

                ' ✅ 2. Update the damage action as completed
                Dim cmd As New Odbc.OdbcCommand(" Update(tbldamage_action)SET ActionType=?, Status=?, AmountPaid=?, Notes=?, DateCompleted=? WHERE ActionID=?", con)

                With cmd.Parameters
                    .AddWithValue("?", actionType)
                    .AddWithValue("?", "Completed")
                    .AddWithValue("?", amountPaid)
                    .AddWithValue("?", notes)
                    .AddWithValue("?", dtpDateTime.Value)
                    .AddWithValue("?", actionID)
                End With

                cmd.ExecuteNonQuery()

                ' ✅ 3. If the action is "Replace", restore the item to good stock
                If actionType.ToLower() = "replace" Or actionType.ToLower() = "paid" Then
                    Dim updateStockCmd As New Odbc.OdbcCommand("Update(tblitemlist)SET ItemQuantity = ItemQuantity + ?  WHERE ItemID = ?", con)
                    updateStockCmd.Parameters.AddWithValue("?", qtyDamage)
                    updateStockCmd.Parameters.AddWithValue("?", itemID)
                    updateStockCmd.ExecuteNonQuery()

                    Dim updateDamageCmd As New Odbc.OdbcCommand("Update(tbldamaged) SET QuantityDamaged = QuantityDamaged - ?, Status = 'Resolved' WHERE DamageID = ?", con)
                    updateDamageCmd.Parameters.AddWithValue("?", qtyDamage)
                    updateDamageCmd.Parameters.AddWithValue("?", damageID)
                    updateDamageCmd.ExecuteNonQuery()

                    MsgBox("Replacement completed — stock restored successfully.", vbInformation)
                ElseIf actionType.ToLower() = "pay" Then
                    MsgBox("Payment completed — no stock adjustment made.", vbInformation)
                Else
                    MsgBox("Action completed.", vbInformation)
                End If

                Me.Close()

            Catch ex As Exception
        MsgBox("Error: " & ex.Message, vbCritical)
            End Try
End If

    End Sub

End Class