Imports System.Security.Cryptography
Imports System.Text
Public Class frmStudentDE
    Public Property studentID As Integer
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
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim studentNo As String = txtStudentNumber.Text.Trim()
        Dim fname As String = txtfname.Text.Trim()
        Dim mi As String = txtmi.Text.Trim()
        Dim lname As String = txtlname.Text.Trim()
        'Dim course As String = cbCourses.SelectedValue.ToString()
        Dim section As String = txtSection.Text.Trim()
        Dim ylevel As String = cbYear.SelectedValue.ToString()
        Dim username As String = txtuname.Text.Trim()
        Dim course As String = cbCourses.SelectedValue.ToString()
        Dim plainPassword As String = txtPword.Text.Trim()
        Dim hashedEntered As String = HashPassword(plainPassword)

        If String.IsNullOrEmpty(studentNo) OrElse
           String.IsNullOrEmpty(fname) OrElse
           String.IsNullOrEmpty(lname) OrElse
           String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try

            Using trans = con.BeginTransaction()
                Try
                    If studentID = 0 Then

                        Using cmdCheck As New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblstudentlist WHERE studentNo = ?", con, trans)
                            cmdCheck.Parameters.AddWithValue("?", studentNo)
                            Dim countExists = Convert.ToInt32(cmdCheck.ExecuteScalar())
                            If countExists > 0 Then
                                MessageBox.Show("Student Number already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                trans.Rollback()
                                Return
                                Exit Sub
                            End If
                        End Using

                        Using cmdStudent As New Odbc.OdbcCommand("INSERT INTO tblstudentlist (studentNo, fname, mi, lname, cID, section, yID) VALUES (?, ?, ?, ?, ?, ?, ?)", con, trans)
                            cmdStudent.Parameters.AddWithValue("?", studentNo)
                            cmdStudent.Parameters.AddWithValue("?", fname)
                            cmdStudent.Parameters.AddWithValue("?", mi)
                            cmdStudent.Parameters.AddWithValue("?", lname)
                            cmdStudent.Parameters.AddWithValue("?", course)
                            cmdStudent.Parameters.AddWithValue("?", section)
                            cmdStudent.Parameters.AddWithValue("?", ylevel)
                            cmdStudent.ExecuteNonQuery()
                        End Using


                        Dim newSID As Integer
                        Using cmdNewID As New Odbc.OdbcCommand("SELECT LAST_INSERT_ID()", con, trans)
                            newSID = Convert.ToInt32(cmdNewID.ExecuteScalar())
                        End Using

                        Using cmdUser As New Odbc.OdbcCommand("INSERT INTO tbluser (username, pword, sID, roleID, isActive) VALUES (?, ?, ?, ?, ?)", con, trans)
                            cmdUser.Parameters.AddWithValue("?", username)
                            cmdUser.Parameters.AddWithValue("?", hashedEntered)
                            cmdUser.Parameters.AddWithValue("?", newSID)
                            cmdUser.Parameters.AddWithValue("?", cbRole.SelectedValue)
                            cmdUser.Parameters.AddWithValue("?", If(ckbisActive.Checked, 1, 0))
                            cmdUser.ExecuteNonQuery()
                        End Using

                    Else

                        'Using cmdCheck As New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblstudentlist WHERE studentNo = ?", con, trans)
                        '    cmdCheck.Parameters.AddWithValue("?", studentNo)
                        '    Dim countExists = Convert.ToInt32(cmdCheck.ExecuteScalar())
                        '    If countExists > 0 Then
                        '        MessageBox.Show("Student Number already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '        trans.Rollback()
                        '        Return
                        '        Exit Sub
                        '    End If
                        'End Using

                        Using cmdStudentUpd As New Odbc.OdbcCommand("UPDATE tblstudentlist SET studentNo = ?, fname = ?, mi = ?, lname = ?, cID = ?, section = ?, yID = ? WHERE sID = ?", con, trans)
                            cmdStudentUpd.Parameters.AddWithValue("?", studentNo)
                            cmdStudentUpd.Parameters.AddWithValue("?", fname)
                            cmdStudentUpd.Parameters.AddWithValue("?", mi)
                            cmdStudentUpd.Parameters.AddWithValue("?", lname)
                            cmdStudentUpd.Parameters.AddWithValue("?", course)
                            cmdStudentUpd.Parameters.AddWithValue("?", section)
                            cmdStudentUpd.Parameters.AddWithValue("?", ylevel)
                            cmdStudentUpd.Parameters.AddWithValue("?", studentID)
                            cmdStudentUpd.ExecuteNonQuery()
                        End Using


                        Using cmdUserUpd As New Odbc.OdbcCommand("UPDATE tbluser SET username = ?, pword= ?, roleID = ?, isActive = ? WHERE sID = ?", con, trans)
                            cmdUserUpd.Parameters.AddWithValue("?", username)
                            cmdUserUpd.Parameters.AddWithValue("?", plainPassword)
                            cmdUserUpd.Parameters.AddWithValue("?", cbRole.SelectedValue)
                            cmdUserUpd.Parameters.AddWithValue("?", If(ckbisActive.Checked, 1, 0))
                            cmdUserUpd.Parameters.AddWithValue("?", studentID)
                            cmdUserUpd.ExecuteNonQuery()
                        End Using

                        Using cmdUserUpd2 As New Odbc.OdbcCommand("UPDATE tbluser SET username = ?, roleID = ?, isActive = ? WHERE sID = ?", con, trans)
                            cmdUserUpd2.Parameters.AddWithValue("?", username)
                            cmdUserUpd2.Parameters.AddWithValue("?", cbRole.SelectedValue)
                            cmdUserUpd2.Parameters.AddWithValue("?", If(ckbisActive.Checked, 1, 0))
                            cmdUserUpd2.Parameters.AddWithValue("?", studentID)
                            cmdUserUpd2.ExecuteNonQuery()
                        End Using

                    End If
                    trans.Commit()
                    MessageBox.Show("Successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    data_loader("SELECT * FROM vw_students", frmStudentlist.dgvStudentList)

                Catch exInner As Exception
                    trans.Rollback()
                    MessageBox.Show("Error during save: " & exInner.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Close()
        End Try
    End Sub
    Private Sub txtlname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlname.TextChanged

    End Sub

    Private Sub frmStudentCanBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        cb_loader("SELECT * FROM tblcourse", cbCourses, "cCode", "cID")
        cb_loader("SELECT * FROM tblylevel", cbYear, "yDesc", "yID")
        'cb_loader("SELECT * FROM tbl_role", cbRole, "Role", "RoleID")
        txtPword.UseSystemPasswordChar = True
        ckbisActive.Checked = True

        ckbShowPword.Checked = False
        DisableForm(Me)

        If frmLogin.role = "Student" Then
            cb_loader("SELECT roleID, Role FROM tbl_role WHERE Role <> 'Admin'", cbRole, "Role", "roleID")
        ElseIf frmLogin.role = "Admin" Then
            cb_loader("SELECT roleID, Role FROM tbl_role", cbRole, "Role", "roleID")
        Else
            cb_loader("SELECT roleID, Role FROM tbl_role WHERE Role <> 'Admin'", cbRole, "Role", "roleID")
        End If
    End Sub

    Private Sub ckbShowPword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbShowPword.CheckedChanged
        txtPword.UseSystemPasswordChar = Not ckbShowPword.Checked
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub txtmi_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmi.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If txtmi.TextLength >= 1 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmi_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtmi.TextChanged

    End Sub
End Class