
Public Class Login
    Public Shared LoggedInUser As String
    Private Sub txtUsername_GotFocus(sender As Object, e As System.EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As System.EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPword_GotFocus(sender As Object, e As System.EventArgs) Handles txtPword.GotFocus
        If txtPword.Text = "Password" Then
            txtPword.Text = ""
            txtPword.ForeColor = Color.Black
            txtPword.PasswordChar = "*"
        End If

    End Sub

    Private Sub txtPword_LostFocus(sender As Object, e As System.EventArgs) Handles txtPword.LostFocus
        If txtPword.Text = "" Then
            txtPword.Text = "Password"
            txtPword.ForeColor = Color.Gray
            txtPword.PasswordChar = ""
        End If

    End Sub
    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        vbConnection()
        txtPword.ForeColor = Color.Gray
        txtUsername.ForeColor = Color.Gray
        PictureBox1.Select()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim cmd As Odbc.OdbcCommand

        Try
            cmd = New Odbc.OdbcCommand("SELECT pword FROM tbluser WHERE username=? ", con)
            cmd.Parameters.AddWithValue("?", Trim(txtUsername.Text))
            Dim result As Object = cmd.ExecuteScalar()

            If result Is Nothing Then
                MsgBox("User not found!")
            ElseIf String.Equals(txtPword.Text, result.ToString()) Then
                MsgBox("Login sucessfull")
                LoggedInUser = Trim(txtUsername.Text)
                Homepage.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect Password!")
            End If
        Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()
            End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class