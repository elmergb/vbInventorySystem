Public Class frmTeacherDE
    Public Property teacherID As Integer
    Private Sub frmTeacherDE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DisableForm(Me)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Try

            cmd = New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblteacher WHERE tNum = ?", con)
            cmd.Parameters.AddWithValue("?", txtTnum.Text)
            Dim countExists = Convert.ToInt32(cmd.ExecuteScalar())
            If countExists > 0 Then
                MessageBox.Show("Student Number already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
                Return
            End If
            If teacherID = 0 Then
                ' --- INSERT new teacher ---
                cmd = New Odbc.OdbcCommand("INSERT INTO tblteacher (tNum, fname, mi, lname, Status) VALUES (?, ?, ?, ?, ?)", con)
                With cmd.Parameters
                    .AddWithValue("@tNum", txtTnum.Text)
                    .AddWithValue("@fname", txtFname.Text)
                    .AddWithValue("@mi", txtMi.Text)
                    .AddWithValue("@lname", txtLname.Text)
                    .AddWithValue("@Status", If(ckbisActive.Checked, "Active", "Inactive"))
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Teacher successfully added!", vbInformation)

            Else
                ' --- UPDATE existing teacher ---
                cmd = New Odbc.OdbcCommand("UPDATE tblteacher SET tNum=?, fname=?, mi=?, lname=?, Status=? WHERE teacherID=?", con)
                With cmd.Parameters
                    .AddWithValue("@tNum", txtTnum.Text)
                    .AddWithValue("@fname", txtFname.Text)
                    .AddWithValue("@mi", txtMi.Text)
                    .AddWithValue("@lname", txtLname.Text)
                    .AddWithValue("@Status", If(ckbisActive.Checked, "Active", "Inactive"))
                    .AddWithValue("@teacherID", teacherID)
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Teacher successfully updated!", vbInformation)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            Me.Close()
        End Try
    End Sub


    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class