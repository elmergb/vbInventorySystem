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

        If ValidateAllTextboxes(Me) = False Then
            Return
        End If


        If ItemID = 0 Then
            ' --- ADD NEW ITEM ---
            Try
                If qty <= 0 Then
                    MsgBox("Insert valid amount")
                    Return
                End If
                cmd = New Odbc.OdbcCommand("SELECT ItemID, ItemQuantity FROM tblitemlist WHERE TRIM(ItemName)=? AND TRIM(ItemDescription)=? AND TRIM(ItemLocation)=?", con)
                With cmd.Parameters
                    .AddWithValue("?", Trim(txtNameOFItem.Text))
                    .AddWithValue("?", Trim(txtItemDesc.Text))
                    .AddWithValue("?", Trim(cbLocation.Text))
                End With

                Dim reader As Odbc.OdbcDataReader = cmd.ExecuteReader()
                Dim existingItemID As Integer = 0
                Dim existingQty As Integer = 0

                If reader.Read() Then
                    existingItemID = CInt(reader("ItemID"))
                    existingQty = CInt(reader("ItemQuantity"))
                End If
                reader.Close()

                If existingItemID > 0 Then
                    ' Item already exists → update quantity
                    Dim newQty As Integer = existingQty + qty
                    cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity=?, ItemRemarks=? WHERE ItemID=?", con)
                    With cmd.Parameters
                        .AddWithValue("?", newQty)
                        .AddWithValue("?", Trim(cbRemarks.Text))
                        .AddWithValue("?", existingItemID)
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Item already exists, quantity updated successfully!", MsgBoxStyle.Information, "Updated")
                Else
                    ' Insert new item
                    cmd = New Odbc.OdbcCommand("INSERT INTO tblitemlist (ItemName, ItemDescription, ItemCategory, ItemLocation, ItemQuantity, ItemRemarks) VALUES (?,?,?,?,?,?)", con)
                    With cmd.Parameters
                        .AddWithValue("?", Trim(txtNameOFItem.Text))
                        .AddWithValue("?", Trim(txtItemDesc.Text))
                        .AddWithValue("?", Trim(cbCategory.Text))
                        .AddWithValue("?", Trim(cbLocation.Text))
                        .AddWithValue("?", qty)
                        .AddWithValue("?", Trim(cbRemarks.Text))
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Item saved successfully!", MsgBoxStyle.Information, "Success")
                End If

                If MsgBox("Do you want to add more items?", vbYesNo + vbQuestion) = vbNo Then
                    Me.Close()
                End If
                RaiseEvent ItemAdded(Me, EventArgs.Empty)
                ClearAllText(Me)
                data_loader("SELECT * FROM tblitemlist", frmListItem.dgvItemList)

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()
            End Try

        Else
            Dim damagedQty As Integer = CInt(nupDamaged.Value)
            If qty <= -1 Then
                MsgBox("Nakalimutan mo mag lagay ng item")
                Return
            End If


            Try
                If damagedQty > qty Then
                    Remarks = "Partial Damage"
                ElseIf damagedQty > 0 Then
                    Remarks = "Damaged"
                Else
                    Remarks = "Good"
                End If

                ' --- UPDATE ITEM RECORD ---
                cmd = New Odbc.OdbcCommand("Update(tblitemlist) SET ItemName=?, ItemDescription=?, ItemCategory=?, ItemLocation=?, ItemQuantity=?, ItemRemarks=? WHERE ItemID=?", con)

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

                MsgBox("Item updated successfully!", MsgBoxStyle.Information, "Success")

                cmd = New Odbc.OdbcCommand("SELECT COUNT(*) FROM tbldamaged WHERE ItemID = ?", con)
                cmd.Parameters.AddWithValue("?", ItemID)
                Dim countDamaged As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If countDamaged > 0 Then
                    ' Update existing record
                    cmd = New Odbc.OdbcCommand("UPDATE tbldamaged SET QuantityDamaged=?, DateReported=NOW(), DamageRemarks=? WHERE ItemID=?", con)
                    cmd.Parameters.AddWithValue("?", damagedQty)
                    cmd.Parameters.AddWithValue("?", Remarks)
                    cmd.Parameters.AddWithValue("?", ItemID)
                Else
                    ' Insert new damaged record
                    cmd = New Odbc.OdbcCommand("INSERT INTO tbldamaged (ItemID, QuantityDamaged, DateReported, DamageRemarks) VALUES (?, ?, NOW(), ?)", con)
                    cmd.Parameters.AddWithValue("?", ItemID)
                    cmd.Parameters.AddWithValue("?", damagedQty)
                    cmd.Parameters.AddWithValue("?", Remarks)
                End If

                cmd.ExecuteNonQuery()
                Call data_loader("SELECT * FROM vw_items", frmListItem.dgvItemList)

                ClearAllText(Me)

                RaiseEvent ItemAdded(Me, EventArgs.Empty)
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                RaiseEvent ItemAdded(Me, EventArgs.Empty)
                GC.Collect()
            End Try
        End If

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