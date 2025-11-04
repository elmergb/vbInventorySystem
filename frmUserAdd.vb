Public Class frmUserAdd
    Public Property UserID As Integer = 0

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        If ValidateAllTextboxes(Me) = False Then
            Return
        End If
        If UserID = 0 Then
            Try
                cmd = New Odbc.OdbcCommand("INSERT INTO tbluser (fname,mi,lname,username,pword) VALUES (?,?,?,?,?)", con)
                With cmd.Parameters
                    .AddWithValue("?", Trim(txtfname.Text))
                    .AddWithValue("?", Trim(txtmi.Text))
                    .AddWithValue("?", Trim(txtlname.Text))
                    .AddWithValue("?", Trim(txtusername.Text))
                    .AddWithValue("?", Trim(txtpword.Text))
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Insert")
                Call data_loader("SELECT * FROM tbluser", frmUserList.dgvUserList)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()
            End Try
        Else
            Try
                cmd = New Odbc.OdbcCommand("UPDATE tbluser SET fname=?, mi=?, lname=?, username=?, pword=? WHERE UserID=" & UserID, con)
                With cmd.Parameters
                    .AddWithValue("?", Trim(txtfname.Text))
                    .AddWithValue("?", Trim(txtmi.Text))
                    .AddWithValue("?", Trim(txtlname.Text))
                    .AddWithValue("?", Trim(txtusername.Text))
                    .AddWithValue("?", Trim(txtpword.Text))
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Edit")
                Call data_loader("SELECT * FROM tbluser", frmUserList.dgvUserList)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()
            End Try
        End If
        'If Val(frmUserList.dgvUserList.Tag) = 0 Then

        'End If
    End Sub

    Private Sub frmUserAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class