Public Class frmAddItem
    Private Sub frmAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'If frmUserAdd.ValidateAllTextboxes() = False Then
        '    Return
        'End If

        If Val(frmListItem.dgvItemList.Tag) = 0 Then
            Try
                Dim cmd As Odbc.OdbcCommand
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
        End If
    End Sub
End Class