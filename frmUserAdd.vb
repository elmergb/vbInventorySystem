Public Class frmUserAdd
    Public Property UserID As Integer = 0


    Private Function ValidateAllTextboxes() As Boolean
        For Each text As Control In Me.Controls
            If TypeOf text Is TextBox Then
                Dim txt As TextBox = CType(text, TextBox)
                If String.IsNullOrWhiteSpace(txt.Text) Then
                    MessageBox.Show("Please fill out all fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt.Focus()
                    Return False '
                End If
            End If
        Next
        Return True
    End Function
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        If ValidateAllTextboxes() = False Then
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
End Class