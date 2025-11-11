Public Class frmDamageActionEntry
    Public Property actionID As Integer
    Private Sub frmDamageActionEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        vbConnection()
        cbActionType.Items.AddRange({"Paid", "Replaced"})
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If actionID > 0 Then
            Try
                Dim actionType As String = cbActionType.Text.Trim()
                Dim notes As String = txtRemarks.Text.Trim()
                Dim amountPaid As Double
                Dim qtyDamage As Integer = CInt(lblqtyDamage.Text)
                Dim itemID As Integer
                Dim damageID As Integer

                If Not Double.TryParse(txtAmount.Text, amountPaid) Then
                    amountPaid = 0
                End If

                ' --- Get ItemID and DamageID linked to this Action ---
                Dim getItemCmd As New Odbc.OdbcCommand("SELECT d.ItemID, d.DamageID FROM tbldamaged d INNER JOIN tbldamage_action a ON d.DamageID = a.DamageID  WHERE a.ActionID = ?", con)
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

                ' --- Update damage action record ---
                Dim cmd As New Odbc.OdbcCommand("Update(tbldamage_action) SET ActionType=?, Status='Completed', AmountPaid=?, Notes=?, DateCompleted=? WHERE ActionID=?", con)
                With cmd.Parameters
                    .AddWithValue("?", actionType)
                    .AddWithValue("?", amountPaid)
                    .AddWithValue("?", notes)
                    .AddWithValue("?", dtpDateTime.Value)
                    .AddWithValue("?", actionID)
                End With
                cmd.ExecuteNonQuery()

                ' --- Update damage status ---
                Dim updateDamageCmd As New Odbc.OdbcCommand("Update(tbldamaged) SET QuantityDamaged = QuantityDamaged - ?, Status = 'Resolved' WHERE DamageID = ?", con)
                updateDamageCmd.Parameters.AddWithValue("?", qtyDamage)
                updateDamageCmd.Parameters.AddWithValue("?", damageID)
                updateDamageCmd.ExecuteNonQuery()

                ' --- If action is Replace, create NEW serials ---
                If actionType = "Replace" Then
                    ' 1️⃣ Get Item Name for serial generation
                    Dim itemName As String = ""
                    Dim getNameCmd As New Odbc.OdbcCommand("SELECT ItemName FROM tblitemlist WHERE ItemID = ?", con)
                    getNameCmd.Parameters.AddWithValue("?", itemID)
                    Dim res = getNameCmd.ExecuteScalar()
                    If res IsNot Nothing Then itemName = res.ToString()

                    ' 2️⃣ Get highest existing serial number for this item
                    Dim lastSerialCmd As New Odbc.OdbcCommand("SELECT SerialNo FROM tblitemunits WHERE ItemID = ? ORDER BY UnitID DESC LIMIT 1", con)
                    lastSerialCmd.Parameters.AddWithValue("?", itemID)
                    Dim lastSerial As String = TryCast(lastSerialCmd.ExecuteScalar(), String)
                    Dim nextNumber As Integer = 1

                    If Not String.IsNullOrEmpty(lastSerial) AndAlso lastSerial.Contains("-") Then
                        Dim parts() As String = lastSerial.Split("-"c)
                        Dim numPart As String = parts(parts.Length - 1)
                        If IsNumeric(numPart) Then nextNumber = CInt(numPart) + 1
                    End If

                    ' 3️⃣ Insert new serials for replacements
                    For i As Integer = 1 To qtyDamage
                        Dim newSerial As String = itemName.Replace(" ", "").ToLower() & "-" & nextNumber.ToString("000")
                        Dim insertSerialCmd As New Odbc.OdbcCommand(" INSERT INTO tblitemunits (ItemID, SerialNo, ItemStatus) VALUES (?, ?, 'Available')", con)
                        insertSerialCmd.Parameters.AddWithValue("?", itemID)
                        insertSerialCmd.Parameters.AddWithValue("?", newSerial)
                        insertSerialCmd.ExecuteNonQuery()
                        nextNumber += 1
                    Next

                    ' 4️⃣ Update main item stock quantity
                    Dim updateStockCmd As New Odbc.OdbcCommand("Update(tblitemlist)  SET ItemQuantity = ItemQuantity + ? WHERE ItemID = ?", con)
                    updateStockCmd.Parameters.AddWithValue("?", qtyDamage)
                    updateStockCmd.Parameters.AddWithValue("?", itemID)
                    updateStockCmd.ExecuteNonQuery()

                    MsgBox("Replacement completed — new serials generated and stock restored.", vbInformation)

                ElseIf actionType = "Pay" Then
                    ' --- For payment, mark resolved but do not adjust quantity ---
                    MsgBox("Payment completed — damage resolved without stock increase.", vbInformation)
                Else
                    MsgBox("completed successfully.", vbInformation)
                End If

            Me.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
            End Try
        End If


    End Sub

    Private Sub txtAmount_GotFocus(sender As Object, e As System.EventArgs) Handles txtAmount.GotFocus
        If txtAmount.Text = "If pay" Then
            txtAmount.Text = ""
            txtAmount.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtAmount_LostFocus(sender As Object, e As System.EventArgs) Handles txtAmount.LostFocus
        If txtAmount.Text = "" Then
            txtAmount.Text = "If pay"
            txtAmount.ForeColor = Color.Gray
        End If
    End Sub


End Class