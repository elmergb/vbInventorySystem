
Public Class Login

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
        Dim adapter As Odbc.OdbcDataAdapter
        Dim dtable As New DataTable
        Dim sql As String = "SELECT * FROM tbluser WHERE username='" & Trim(txtUsername.Text) & "' and pword='" & Trim(txtPword.Text) & "'"
        If txtUsername.Text = "" And txtPword.Text = "" Then
            MsgBox("Insufeccient data!", vbCritical)
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("Input Username!", vbCritical)
            txtUsername.Focus()
        ElseIf txtPword.Text = "" Then
            MsgBox("Input Password!", vbCritical)
            txtPword.Focus()
        Else
            Try
                adapter = New Odbc.OdbcDataAdapter(sql, con)
                adapter.Fill(dtable)
                If dtable.Rows.Count > 0 Then
                    MsgBox("Sucessfully Login! " & dtable.Rows(0)("username"), vbInformation)
                    Homepage.Show()
                    Me.Hide()
                Else
                    MsgBox("Invalid username and password!", vbCritical)
                    txtUsername.Focus()
                End If
                adapter.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                GC.Collect()
            End Try
        End If
    End Sub
End Class