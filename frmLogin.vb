Imports System.Security.Cryptography
Imports System.Text
Public Class frmLogin
    Public Shared LoggedInUser As String
    Public role As String
    Public Function HashPassword(password As String) As String
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)

        Using sha256 As SHA256 = sha256.Create()
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)

            Dim builder As New StringBuilder()
            For Each b As Byte In hashBytes
                builder.Append(b.ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function
    Private Sub txtUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub txtPword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPword.GotFocus
        If txtPword.Text = "Password" Then
            txtPword.Text = ""
            txtPword.ForeColor = Color.Black
            txtPword.PasswordChar = "*"
        End If

    End Sub

    Private Sub txtPword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPword.LostFocus
        If txtPword.Text = "" Then
            txtPword.Text = "Password"
            txtPword.ForeColor = Color.Gray
            txtPword.PasswordChar = ""
        End If
    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vbConnection()
        txtPword.ForeColor = Color.Gray
        txtUsername.ForeColor = Color.Gray
        PictureBox1.Select()
        DisableForm(Me)

        ckbShowPword.Checked = False
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim isvalid As Boolean = True
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPword.Text.Trim()
        Dim hashedEntered As String = HashPassword(password)
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


                    If String.Equals(hashedEntered, dbPassword, StringComparison.Ordinal) Or String.Equals(password, dbPassword, StringComparison.Ordinal) Then
                        role = roleVal
                        MessageBox.Show("Welcome " & txtUsername.Text & "!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)


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

    Private Sub ckbShowPword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbShowPword.CheckedChanged
        If txtPword.Text <> "Password" Then
            If ckbShowPword.Checked Then
                txtPword.PasswordChar = ChrW(0)
            Else
                txtPword.PasswordChar = "*"c
            End If
        End If

    End Sub

    Private Sub CreateAccountToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreateAccountToolStripMenuItem.Click
        With frmStudentDE
            ClearAllText(frmStudentDE)
            .lblActive.Visible = False
            .ckbisActive.Visible = False
            .ckbisActive.Visible = False
        End With
        frmStudentDE.ShowDialog()
    End Sub
End Class