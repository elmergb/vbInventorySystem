Public Class frmAddItem
    Public Property ItemID As Integer = 0
    Public Event ItemAdded As EventHandler
    Private Sub frmAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRemarks.Items.Clear()
        If ItemID = 0 Then
            cbRemarks.Items.Add("Good")
        Else
            cbRemarks.Items.Add("Good")
            cbRemarks.Items.Add("Damage")
        End If

        cbLocation.Focus()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim qty As Integer = CInt(nupQuantity.Value)
        Dim Remarks As String = Trim(cbRemarks.Text)

        ' --- Validation ---
        If ValidateAllTextboxes(Me) = False Then Return
        If qty <= 0 Then
            MsgBox("Insert a valid quantity", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            ' --- Check if item already exists by Name + Description + Location ---
            cmd = New Odbc.OdbcCommand("SELECT ItemID, ItemQuantity FROM tblitemlist WHERE TRIM(ItemName)=? AND TRIM(ItemDescription)=? AND TRIM(ItemLocation)=?", con)
            cmd.Parameters.AddWithValue("?", Trim(txtNameOFItem.Text))
            cmd.Parameters.AddWithValue("?", Trim(txtItemDesc.Text))
            cmd.Parameters.AddWithValue("?", Trim(cbLocation.Text))
            Dim reader As Odbc.OdbcDataReader = cmd.ExecuteReader()
            Dim existingItemID As Integer = 0
            Dim existingQty As Integer = 0

            If reader.Read() Then
                existingItemID = Convert.ToInt32(reader("ItemID"))
                existingQty = Convert.ToInt32(reader("ItemQuantity"))
            End If
            reader.Close()

            ' --- NEW ITEM ---
            If ItemID = 0 AndAlso existingItemID = 0 Then
                ' Insert into tblitemlist
                cmd = New Odbc.OdbcCommand("INSERT INTO tblitemlist (ItemName, ItemDescription, ItemCategory, ItemLocation, ItemQuantity, ItemRemarks) VALUES (?,?,?,?,?,?)", con)
                With cmd.Parameters
                    .AddWithValue("?", Trim(txtNameOFItem.Text))
                    .AddWithValue("?", Trim(txtItemDesc.Text))
                    .AddWithValue("?", Trim(cbCategory.Text))
                    .AddWithValue("?", Trim(cbLocation.Text))
                    .AddWithValue("?", qty)
                    .AddWithValue("?", Remarks)
                End With
                cmd.ExecuteNonQuery()

                ' Get new ItemID
                cmd = New Odbc.OdbcCommand("SELECT LAST_INSERT_ID()", con)
                Dim itemID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' *** Insert units for new item ***
                For i As Integer = 1 To qty
                    Dim serialNo As String = txtNameOFItem.Text.Substring(0, Math.Min(4, txtNameOFItem.Text.Length)).ToUpper() & "-" & i.ToString("D3")
                    cmd = New Odbc.OdbcCommand("INSERT INTO tblitemunits (ItemID, SerialNo, ItemStatus, Remarks) VALUES (?,?,?,?)", con)
                    cmd.Parameters.AddWithValue("?", itemID)
                    cmd.Parameters.AddWithValue("?", serialNo)
                    cmd.Parameters.AddWithValue("?", "Available")
                    cmd.Parameters.AddWithValue("?", Remarks)
                    cmd.ExecuteNonQuery()
                Next

                MsgBox("Item added successfully!", MsgBoxStyle.Information, "Success")

                ' --- EXISTING ITEM MERGE (same description/location) ---
            ElseIf existingItemID > 0 AndAlso ItemID = 0 Then
                Dim newQty As Integer = existingQty + qty

                ' Update tblitemlist
                cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity=?, ItemRemarks=? WHERE ItemID=?", con)
                cmd.Parameters.AddWithValue("?", newQty)
                cmd.Parameters.AddWithValue("?", Remarks)
                cmd.Parameters.AddWithValue("?", existingItemID)
                cmd.ExecuteNonQuery()

                ' *** Handle units for merge (avoid duplicate serials) ***
                ' 1. Find current max serial number for this item
                Dim cmdMax As New Odbc.OdbcCommand("SELECT MAX(CAST(SUBSTRING(SerialNo, 6) AS UNSIGNED)) FROM tblitemunits WHERE ItemID = ?", con)
                cmdMax.Parameters.AddWithValue("?", existingItemID)
                Dim maxSerialObj As Object = cmdMax.ExecuteScalar()
                Dim startSerial As Integer = If(IsDBNull(maxSerialObj), 0, Convert.ToInt32(maxSerialObj))

                ' 2. Add missing units starting from maxSerial + 1
                For i As Integer = startSerial + 1 To newQty
                    Dim serialNo As String = txtNameOFItem.Text.Substring(0, Math.Min(4, txtNameOFItem.Text.Length)).ToUpper() & "-" & i.ToString("D3")
                    cmd = New Odbc.OdbcCommand("INSERT INTO tblitemunits (ItemID, SerialNo, ItemStatus, Remarks) VALUES (?,?,?,?)", con)
                    cmd.Parameters.AddWithValue("?", existingItemID)
                    cmd.Parameters.AddWithValue("?", serialNo)
                    cmd.Parameters.AddWithValue("?", "Available")
                    cmd.Parameters.AddWithValue("?", Remarks)
                    cmd.ExecuteNonQuery()
                Next

                ' 3. Remove extra units if newQty < current total units
                Dim cmdCheck As New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblitemunits WHERE ItemID = ?", con)
                cmdCheck.Parameters.AddWithValue("?", existingItemID)
                Dim currentUnits As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                If newQty < currentUnits Then
                    Dim unitsToRemove As Integer = currentUnits - newQty
                    cmd = New Odbc.OdbcCommand("DELETE FROM tblitemunits WHERE ItemID = ? AND ItemStatus = 'Available' ORDER BY SerialNo DESC LIMIT ?", con)
                    cmd.Parameters.AddWithValue("?", existingItemID)
                    cmd.Parameters.AddWithValue("?", unitsToRemove)
                    cmd.ExecuteNonQuery()
                End If

                MsgBox("Item quantity merged successfully!", MsgBoxStyle.Information, "Updated")

                ' --- EDITING EXISTING ITEM ---
            ElseIf ItemID > 0 Then
                ' Update tblitemlist
                cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemName=?, ItemDescription=?, ItemCategory=?, ItemLocation=?, ItemQuantity=?, ItemRemarks=? WHERE ItemID=?", con)
                With cmd.Parameters
                    .AddWithValue("?", Trim(txtNameOFItem.Text))
                    .AddWithValue("?", Trim(txtItemDesc.Text))
                    .AddWithValue("?", Trim(cbCategory.Text))
                    .AddWithValue("?", Trim(cbLocation.Text))
                    .AddWithValue("?", qty)
                    .AddWithValue("?", Remarks)
                    .AddWithValue("?", ItemID)
                End With
                cmd.ExecuteNonQuery()

                ' Handle damaged items
                Dim damagedQty As Integer = CInt(nupDamaged.Value)
                If damagedQty > 0 Then
                    Dim damageRemarks As String = If(damagedQty = qty, "Damaged", "Partial Damage")
                    cmd = New Odbc.OdbcCommand("SELECT COUNT(*) FROM tbldamaged WHERE ItemID = ?", con)
                    cmd.Parameters.AddWithValue("?", ItemID)
                    Dim countDamaged As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If countDamaged > 0 Then
                        cmd = New Odbc.OdbcCommand("UPDATE tbldamaged SET QuantityDamaged=?, DateReported=NOW(), DamageRemarks=? WHERE ItemID=?", con)
                        cmd.Parameters.AddWithValue("?", damagedQty)
                        cmd.Parameters.AddWithValue("?", damageRemarks)
                        cmd.Parameters.AddWithValue("?", ItemID)
                        cmd.ExecuteNonQuery()
                    Else
                        cmd = New Odbc.OdbcCommand("INSERT INTO tbldamaged (ItemID, QuantityDamaged, DateReported, DamageRemarks) VALUES (?, ?, NOW(), ?)", con)
                        cmd.Parameters.AddWithValue("?", ItemID)
                        cmd.Parameters.AddWithValue("?", damagedQty)
                        cmd.Parameters.AddWithValue("?", damageRemarks)
                        cmd.ExecuteNonQuery()
                    End If
                End If

                ' *** Update tblitemunits for edits ***
                ' 1. Find current max serial
                Dim cmdMaxEdit As New Odbc.OdbcCommand("SELECT MAX(CAST(SUBSTRING(SerialNo, 6) AS UNSIGNED)) FROM tblitemunits WHERE ItemID = ?", con)
                cmdMaxEdit.Parameters.AddWithValue("?", ItemID)
                Dim maxSerialEdit As Object = cmdMaxEdit.ExecuteScalar()
                Dim startSerialEdit As Integer = If(IsDBNull(maxSerialEdit), 0, Convert.ToInt32(maxSerialEdit))

                ' 2. Add units if qty > current
                cmd = New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblitemunits WHERE ItemID = ?", con)
                cmd.Parameters.AddWithValue("?", ItemID)
                Dim currentUnitsEdit As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If qty > currentUnitsEdit Then
                    For i As Integer = startSerialEdit + 1 To qty
                        Dim serialNo As String = txtNameOFItem.Text.Substring(0, Math.Min(4, txtNameOFItem.Text.Length)).ToUpper() & "-" & i.ToString("D3")
                        cmd = New Odbc.OdbcCommand("INSERT INTO tblitemunits (ItemID, SerialNo, ItemStatus, Remarks) VALUES (?,?,?,?)", con)
                        cmd.Parameters.AddWithValue("?", ItemID)
                        cmd.Parameters.AddWithValue("?", serialNo)
                        cmd.Parameters.AddWithValue("?", "Available")
                        cmd.Parameters.AddWithValue("?", Remarks)
                        cmd.ExecuteNonQuery()
                    Next
                ElseIf qty < currentUnitsEdit Then
                    Dim unitsToRemove As Integer = currentUnitsEdit - qty
                    cmd = New Odbc.OdbcCommand("DELETE FROM tblitemunits WHERE ItemID = ? AND ItemStatus = 'Available' ORDER BY SerialNo DESC LIMIT ?", con)
                    cmd.Parameters.AddWithValue("?", ItemID)
                    cmd.Parameters.AddWithValue("?", unitsToRemove)
                    cmd.ExecuteNonQuery()
                End If

                MsgBox("Item updated successfully!", MsgBoxStyle.Information, "Success")
            End If

            ' --- Refresh grid and clear ---
            Call data_loader("SELECT * FROM vw_item_summary", frmListItem.dgvItemList)
            ClearAllText(Me)
            RaiseEvent ItemAdded(Me, EventArgs.Empty)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

 
  
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure to cancel this record?", vbYesNo + vbQuestion, "cancellatio") = vbYes Then
            txtItemDesc.Clear()
            txtNameOFItem.Clear()
            cbCategory.SelectedValue = -1
            cbRemarks.SelectedValue = -1
            cbLocation.SelectedValue = -1
        End If
    End Sub
End Class