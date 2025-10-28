Public Class frmAddItem
    Public Property ItemID As Integer = 0
    Private Sub frmAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRemarks.Items.Clear()
        cbRemarks.Items.Add("Good")
        cbRemarks.Items.Add("Damage")

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim qty As Integer = nupQuantity.Value
        Dim Remarks As String = Trim(cbRemarks.Text)
        If ValidateAllTextboxes(Me) = False Then
            Return
        End If

        Dim isValid As Boolean = True

        If qty <= 0 Then
            MsgBox("Nakalimutan mo mag lagay ng item")
            isValid = False
            Return
        End If




        If ItemID = 0 Then
            Try
                cmd = New Odbc.OdbcCommand("SELECT ItemID, ItemQuantity FROM tblitemlist WHERE TRIM(ItemName)=? AND TRIM(ItemCategory)=? AND TRIM(ItemLocation)=?", con)
                With cmd.Parameters
                    .AddWithValue("?", Trim(txtNameOFItem.Text))
                    .AddWithValue("?", Trim(cbCategory.Text))
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

                    Dim newQty As Integer = existingQty + CInt(nupQuantity.Value)
                    cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity=?, ItemRemarks=? WHERE ItemID=?", con)
                    With cmd.Parameters
                        .AddWithValue("?", newQty)
                        .AddWithValue("?", Trim(cbRemarks.Text))
                        .AddWithValue("?", existingItemID)
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Item already exists, quantity updated successfully!", MsgBoxStyle.Information, "Updated")
                Else

                    cmd = New Odbc.OdbcCommand("INSERT INTO tblitemlist (ItemName, ItemCategory, ItemLocation, ItemQuantity, ItemRemarks) VALUES (?,?,?,?,?)", con)
                    With cmd.Parameters
                        .AddWithValue("?", Trim(txtNameOFItem.Text))
                        .AddWithValue("?", Trim(cbCategory.Text))
                        .AddWithValue("?", Trim(cbLocation.Text))
                        .AddWithValue("?", CInt(nupQuantity.Value))
                        .AddWithValue("?", Trim(cbRemarks.Text))
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Item saved successfully!", MsgBoxStyle.Information, "Success")
                End If
                If MsgBox("Do you want add more Item?", vbYesNo + vbQuestion) = vbNo Then
                    Me.Close()
                End If
                ClearAllText(Me)
                Call data_loader("SELECT * FROM tblitemlist", frmListItem.dgvItemList)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()
            End Try
        Else
            Try
                Dim damagedQty As Integer = CInt(nupQuantity.Value)
                Dim currentQty As Integer = 0
                cmd = New Odbc.OdbcCommand("SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?", con)
                cmd.Parameters.AddWithValue("?", ItemID)
                Dim totalqty = cmd.ExecuteScalar()

                If totalqty IsNot Nothing Then
                    currentQty = CInt(totalqty)
                Else
                    currentQty = 0
                End If

                If Remarks = "Damage" Or Remarks = "Damaged" Then
                    ' Insert into damaged table
                    cmd = New Odbc.OdbcCommand("INSERT INTO tbldamaged (ItemID, QuantityDamaged, DateReported, Remarks)VALUES (?, ?, NOW(), ?)", con)
                    cmd.Parameters.AddWithValue("?", ItemID)
                    cmd.Parameters.AddWithValue("?", damagedQty)
                    cmd.Parameters.AddWithValue("?", "Damaged")
                    cmd.ExecuteNonQuery()

                    '  Update tblitemlist to reduce available quantity
                    Dim newQty As Integer = Math.Max(0, currentQty - damagedQty)
                    cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ?, ItemRemarks = ? WHERE ItemID = ?", con)
                    cmd.Parameters.AddWithValue("?", newQty)
                    cmd.Parameters.AddWithValue("?", "Damaged")
                    cmd.Parameters.AddWithValue("?", ItemID)
                    cmd.ExecuteNonQuery()

                    MsgBox("Damaged items recorded successfully!", vbInformation)
                Else
                    ' not damaged
                    cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemName=?, ItemCategory=?, ItemLocation=?, ItemQuantity=?, ItemRemarks=? WHERE ItemID=?", con)
                    With cmd.Parameters
                        .AddWithValue("?", Trim(txtNameOFItem.Text))
                        .AddWithValue("?", Trim(cbCategory.Text))
                        .AddWithValue("?", Trim(cbLocation.Text))
                        .AddWithValue("?", damagedQty)
                        .AddWithValue("?", Trim(cbRemarks.Text))
                        .AddWithValue("?", ItemID)
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("Item edited successfully!", MsgBoxStyle.Information, "Success")

                End If

                ClearAllText(Me)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()
            End Try

        End If
    End Sub

    Private Sub cbRemarks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRemarks.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearAllText(Me)
    End Sub
End Class