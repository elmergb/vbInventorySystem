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
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPword.Text.Trim()
        Dim hashedEntered As String = HashPassword(password)

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' ✅ Get user info directly from vw_user
            Dim cmd As New Odbc.OdbcCommand("SELECT UserID, pword, Role, isActive, username FROM vw_user WHERE BINARY username = ?", con)
            cmd.Parameters.AddWithValue("?", username)

            Using rdr As Odbc.OdbcDataReader = cmd.ExecuteReader()
                If rdr.Read() Then
                    Dim dbPassword As String = rdr("pword").ToString()
                    Dim roleVal As String = rdr("Role").ToString()
                    Dim isActive As Boolean = Convert.ToBoolean(rdr("isActive"))
                    Dim userID As Integer = Convert.ToInt32(rdr("UserID"))

                    If Not isActive Then
                        MessageBox.Show("Account is inactive. Please contact administrator.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    If String.Equals(hashedEntered, dbPassword, StringComparison.Ordinal) OrElse String.Equals(password, dbPassword, StringComparison.Ordinal) Then
                        ' Save to global variables
                        CurrentUserID = userID
                        CurrentUsername = username
                        CurrentRole = roleVal

                        Dim cmdLog As New Odbc.OdbcCommand("INSERT INTO tblloginhistory (UserID, LoginTime) VALUES (?, NOW())", con)
                        cmdLog.Parameters.AddWithValue("?", userID)
                        cmdLog.ExecuteNonQuery()


                        Dim cmdGetID As New Odbc.OdbcCommand("SELECT LAST_INSERT_ID()", con)
                        CurrentLogID = Convert.ToInt32(cmdGetID.ExecuteScalar())

                        MessageBox.Show("Welcome " & username & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.Hide()
                        Homepage.Show()
                        Return
                    End If
                End If
            End Using

            MessageBox.Show("Login failed. Check your credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LogLoginAttempt(ByVal userID As Integer, ByVal username As String, ByVal status As String)
        Try
            Dim logCmd As New Odbc.OdbcCommand("INSERT INTO tblloginhistory (UserID, Username, Status, LoginTime) VALUES (?, ?, ?, NOW())", con)
            logCmd.Parameters.AddWithValue("?", userID)
            logCmd.Parameters.AddWithValue("?", username)
            logCmd.Parameters.AddWithValue("?", status)
            logCmd.ExecuteNonQuery()
        Catch ex As Exception

            Console.WriteLine("Login log error: " & ex.Message)
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

    Private Sub CreateAccountToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        With frmStudentDE
            ClearAllText(frmStudentDE)
            .lblActive.Visible = False
            .ckbisActive.Visible = False
            .ckbisActive.Visible = False
        End With
        frmStudentDE.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure to exit?", vbYesNo + vbQuestion, "Exit") = vbYes Then
            Me.Close()
        End If
    End Sub
End Class