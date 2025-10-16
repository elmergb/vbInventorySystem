Public Class frmBorrow


    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub frmBorrow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call cb_loader("SELECT * FROM tblitemlist", cbItemList, "ItemName", "ItemID")
    End Sub

    Private Sub btnLogSave_Click(sender As System.Object, e As System.EventArgs) Handles btnLogSave.Click
        Dim cmd As Odbc.OdbcCommand
        Try
            Dim availableQuantity As Integer = 0
            Dim checkval As String = "SELECT ItemQuantity FROM tblitemlist WHERE ItemID = ?"
            cmd = New Odbc.OdbcCommand(checkval, con)
            cmd.Parameters.AddWithValue("?", cbItemList.SelectedValue)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                availableQuantity = CInt(result)
            End If

            Dim reqQuantity As Integer = nupQuantity.Value
            Dim isValid As Boolean = True

            If reqQuantity > availableQuantity Then
                MsgBox("Not enough available stock! Only " & availableQuantity & " left", vbInformation)
                isValid = False
            Else
                cmd = New Odbc.OdbcCommand("INSERT INTO tblborrow (ItemID, BorrowerName, QuantityBorrowed, Contact, Purpose, DateBorrowed, Remarks) VALUES (?,?,?,?,?,?,?)", con)
                With cmd.Parameters
                    .AddWithValue("?",(cbItemList.SelectedValue))
                    .AddWithValue("?", Trim(txtBorrowerName.Text))
                    .AddWithValue("?", CInt(nupQuantity.Value))
                    .AddWithValue("?", Trim(txtContact.Text))
                    .AddWithValue("?", Trim(txtPurpose.Text))
                    .AddWithValue("?", dtpBorrowed.Value.ToString("yyyy-MM-dd HH:mm:ss"))
                    .AddWithValue("?", Trim(txtRemarks.Text))
                End With
                cmd.ExecuteNonQuery()

                cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ItemQuantity - ? WHERE ItemID = ?", con)
                With cmd.Parameters
                    .AddWithValue("?", CInt(nupQuantity.Value))
                    .AddWithValue("?", cbItemList.SelectedValue)
                End With
                cmd.ExecuteNonQuery()

                Call data_loader("SELECT * FROM vw_borrowing", frmBorrowerList.dgvBorrowerList)
                MsgBox("Borrowed successfully!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub dtpBorrowed_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpBorrowed.ValueChanged

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click

    End Sub
End Class