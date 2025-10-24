Public Class frmAddItem
    Public Property ItemID As Integer = 0
    Private Sub frmAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRemarks.Items.Clear()
        cbRemarks.Items.Add("Good")
        cbRemarks.Items.Add("Damage")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        If ValidateAllTextboxes(Me) = False Then
            Return
        End If
        If ItemID = 0 Then
            Try


                cmd = New Odbc.OdbcCommand("INSERT INTO tblitemlist (ItemName, ItemCategory, ItemLocation, ItemQuantity, ItemRemarks) VALUES (?,?,?,?,?)", con)
                With cmd.Parameters
                    .AddWithValue("?", Trim(txtNameOFItem.Text))
                    .AddWithValue("?", Trim(cbCategory.Text))
                    .AddWithValue("?", Trim(cbLocation.Text))
                    .AddWithValue("?", CInt(nupQuantity.Value))
                    .AddWithValue("?", Trim(cbRemarks.Text))
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Inserted Successfully", vbInformation)
                If MsgBox("Do you want add more Item?", vbYesNo + vbQuestion) = vbNo Then
                    Me.Close()
                End If
                Call data_loader("SELECT * FROM tblitemlist", frmListItem.dgvItemList)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()
            End Try
        Else
            Try
                cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemName=?, ItemCategory=?, ItemLocation=?, ItemQuantity=?, ItemRemarks=? WHERE ItemID=" & ItemID, con)
                With cmd.Parameters
                    .AddWithValue("?", Trim(txtNameOFItem.Text))
                    .AddWithValue("?", Trim(cbCategory.Text))
                    .AddWithValue("?", Trim(cbLocation.Text))
                    .AddWithValue("?", CInt(nupQuantity.Value))
                    .AddWithValue("?", Trim(cbRemarks.Text))
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Edited Successfully!", vbInformation)
                Call data_loader("SELECT * FROM tblitemlist", frmListItem.dgvItemList)


            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()
            End Try

        End If
    End Sub

    Private Sub cbRemarks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRemarks.SelectedIndexChanged

    End Sub
End Class