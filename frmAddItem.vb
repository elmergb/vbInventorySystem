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

                cmd = New Odbc.OdbcCommand("SELECT LAST_INSERT_ID()", con)
                Dim itemID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' --- Create serials for new item ---
                For i As Integer = 1 To qty
                    Dim prefix As String = Trim(txtNameOFItem.Text)
                    prefix = prefix.Replace(" ", "").ToUpper()
                    If prefix.Length > 4 Then prefix = prefix.Substring(0, 4)
                    Dim serialNo As String = prefix & "-" & i.ToString("D3")

                    cmd = New Odbc.OdbcCommand("INSERT INTO tblitemunits (ItemID, SerialNo, ItemStatus, Remarks) VALUES (?,?,?,?)", con)
                    cmd.Parameters.AddWithValue("?", itemID)
                    cmd.Parameters.AddWithValue("?", serialNo)
                    cmd.Parameters.AddWithValue("?", "Available")
                    cmd.Parameters.AddWithValue("?", Remarks)
                    cmd.ExecuteNonQuery()
                Next

                MsgBox("Item added successfully!", MsgBoxStyle.Information, "Success")

                ' --- MERGE WITH EXISTING ITEM (same description/location) ---
            ElseIf existingItemID > 0 AndAlso ItemID = 0 Then
                Dim newQty As Integer = existingQty + qty

                ' Update main list
                cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity=?, ItemRemarks=? WHERE ItemID=?", con)
                cmd.Parameters.AddWithValue("?", newQty)
                cmd.Parameters.AddWithValue("?", Remarks)
                cmd.Parameters.AddWithValue("?", existingItemID)
                cmd.ExecuteNonQuery()

                ' --- Serial handling ---
                Dim cmdMax As New Odbc.OdbcCommand("SELECT MAX(CAST(SUBSTRING_INDEX(SerialNo, '-', -1) AS UNSIGNED)) FROM tblitemunits WHERE ItemID = ?", con)
                cmdMax.Parameters.AddWithValue("?", existingItemID)
                Dim maxSerialObj As Object = cmdMax.ExecuteScalar()
                Dim startSerial As Integer = If(IsDBNull(maxSerialObj), 0, Convert.ToInt32(maxSerialObj))

                ' Add missing serials
                For i As Integer = startSerial + 1 To newQty
                    Dim prefix As String = Trim(txtNameOFItem.Text)
                    prefix = prefix.Replace(" ", "").ToUpper()
                    If prefix.Length > 4 Then prefix = prefix.Substring(0, 4)
                    Dim serialNo As String = prefix & "-" & i.ToString("D3")

                    cmd = New Odbc.OdbcCommand("INSERT INTO tblitemunits (ItemID, SerialNo, ItemStatus, Remarks) VALUES (?,?,?,?)", con)
                    cmd.Parameters.AddWithValue("?", existingItemID)
                    cmd.Parameters.AddWithValue("?", serialNo)
                    cmd.Parameters.AddWithValue("?", "Available")
                    cmd.Parameters.AddWithValue("?", Remarks)
                    cmd.ExecuteNonQuery()
                Next

                MsgBox("Item quantity merged successfully!", MsgBoxStyle.Information, "Updated")

                ' --- EDIT EXISTING ITEM ---
            ElseIf ItemID > 0 Then
                ' Update item info
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

                ' Count current available units (don’t delete borrowed ones)
                Dim cmdCount As New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblitemunits WHERE ItemID = ?", con)
                cmdCount.Parameters.AddWithValue("?", ItemID)
                Dim totalUnits As Integer = Convert.ToInt32(cmdCount.ExecuteScalar())

                ' Add more serials if qty increased
                If qty > totalUnits Then
                    Dim cmdMaxSerial As New Odbc.OdbcCommand("SELECT MAX(CAST(SUBSTRING_INDEX(SerialNo, '-', -1) AS UNSIGNED)) FROM tblitemunits WHERE ItemID = ?", con)
                    cmdMaxSerial.Parameters.AddWithValue("?", ItemID)
                    Dim maxSerialVal As Object = cmdMaxSerial.ExecuteScalar()
                    Dim startSerial As Integer = If(IsDBNull(maxSerialVal), 0, Convert.ToInt32(maxSerialVal))

                    For i As Integer = startSerial + 1 To qty
                        Dim prefix As String = Trim(txtNameOFItem.Text)
                        prefix = prefix.Replace(" ", "").ToUpper()
                        If prefix.Length > 4 Then prefix = prefix.Substring(0, 4)
                        Dim serialNo As String = prefix & "-" & i.ToString("D3")

                        cmd = New Odbc.OdbcCommand("INSERT INTO tblitemunits (ItemID, SerialNo, ItemStatus, Remarks) VALUES (?,?,?,?)", con)
                        cmd.Parameters.AddWithValue("?", ItemID)
                        cmd.Parameters.AddWithValue("?", serialNo)
                        cmd.Parameters.AddWithValue("?", "Available")
                        cmd.Parameters.AddWithValue("?", Remarks)
                        cmd.ExecuteNonQuery()
                    Next

                    ' Reduce quantity but only delete free (Available) units
                ElseIf qty < totalUnits Then
                    Dim excess As Integer = totalUnits - qty
                    cmd = New Odbc.OdbcCommand("DELETE FROM tblitemunits WHERE ItemID = ? AND ItemStatus = 'Available' ORDER BY UnitID DESC LIMIT ?", con)
                    cmd.Parameters.AddWithValue("?", ItemID)
                    cmd.Parameters.AddWithValue("?", excess)
                    cmd.ExecuteNonQuery()
                End If

                MsgBox("Item updated successfully!", MsgBoxStyle.Information, "Success")
            End If

            ' Refresh and clear
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