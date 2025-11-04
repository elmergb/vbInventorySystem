
Public Class Login
    Public Shared LoggedInUser As String
    Public role As String
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
        DisableForm(Me)
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim isvalid As Boolean = True
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPword.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try

            Dim cmd As New Odbc.OdbcCommand("SELECT pword, Role, isActive FROM vw_user WHERE BINARY username = ?", con)
            cmd.Parameters.AddWithValue("?", username)

            Using rdr As Odbc.OdbcDataReader = cmd.ExecuteReader()
                If rdr.Read() Then
                    Dim dbPassword As String = rdr("pword").ToString()
                    Dim roleVal As String = rdr("Role").ToString()
                    Dim isActive As Boolean = Convert.ToBoolean(rdr("isActive"))

                    If Not isActive Then
                        MessageBox.Show("Account is inactive. Please contact administrator.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    If String.Equals(password, dbPassword, StringComparison.Ordinal) Then
                        role = roleVal
                        MessageBox.Show("Welcome " & role & "!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        isvalid = True
  
                        Me.Hide()
                        Homepage.Show()
                        Return
                    End If
                End If
            End Using

            MessageBox.Show("Login failed. Check your credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
       
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

End Class