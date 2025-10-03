Public Class frmAddItem
    Public Property ItemID As Integer = 0
    Private Sub frmAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                    .AddWithValue("?", Trim(txtRemarks.Text))
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Inserted Successfully", vbInformation)
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
                    .AddWithValue("?", Trim(txtRemarks.Text))
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
End Class