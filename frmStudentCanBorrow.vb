Public Class frmStudentCanBorrow
    Public Property studentID As Integer
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click


        Dim studentNo As String = txtStudentNumber.Text.Trim()
        Dim fname As String = txtfname.Text.Trim()
        Dim mi As String = txtmi.Text.Trim()
        Dim lname As String = txtlname.Text.Trim()
        'Dim course As String = cbCourses.SelectedValue.ToString()
        Dim section As String = txtSection.Text.Trim()
        Dim ylevel As String = cbYear.SelectedValue.ToString()
        Dim username As String = txtuname.Text.Trim()
        Dim plainPassword As String = txtPword.Text.Trim()
        Dim course As String = cbCourses.SelectedValue.ToString
        ' Validate required fields
        If String.IsNullOrEmpty(studentNo) OrElse
           String.IsNullOrEmpty(fname) OrElse
           String.IsNullOrEmpty(lname) OrElse
           String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If con.State = ConnectionState.Closed Then con.Open()

            Using trans = con.BeginTransaction()
                Try
                    If studentID = 0 Then


                        ' Check duplicate studentNo
                        Using cmdCheck As New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblstudentlist WHERE studentNo = ?", con, trans)
                            cmdCheck.Parameters.AddWithValue("?", studentNo)
                            Dim countExists = Convert.ToInt32(cmdCheck.ExecuteScalar())
                            If countExists > 0 Then
                                MessageBox.Show("Student Number already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                trans.Rollback()
                                Return
                            End If
                        End Using

                        ' Insert into student list
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

                        ' Get new sID
                        Dim newSID As Integer
                        Using cmdNewID As New Odbc.OdbcCommand("SELECT LAST_INSERT_ID()", con, trans)
                            newSID = Convert.ToInt32(cmdNewID.ExecuteScalar())
                        End Using

                        ' Hash password & generate salt

                        ' Insert into user table
                        Using cmdUser As New Odbc.OdbcCommand("INSERT INTO tbluser (username, pword, sID, roleID, isActive) VALUES (?, ?, ?, ?, ?)", con, trans)
                            cmdUser.Parameters.AddWithValue("?", username)
                            cmdUser.Parameters.AddWithValue("?", plainPassword)
                            cmdUser.Parameters.AddWithValue("?", newSID)
                            cmdUser.Parameters.AddWithValue("?", cbRole.SelectedValue)
                            cmdUser.Parameters.AddWithValue("?", If(ckbisActive.Checked, 1, 0))
                            cmdUser.ExecuteNonQuery()
                        End Using

                    Else
                        ' — Update existing student + user

                        ' Update student list
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

                        ' Update user table

                        Using cmdUserUpd As New Odbc.OdbcCommand("UPDATE tbluser SET username = ?, pword= ?, roleID = ?, isActive = ? WHERE sID = ?", con, trans)
                            cmdUserUpd.Parameters.AddWithValue("?", username)
                            cmdUserUpd.Parameters.AddWithValue("?", plainPassword)
                            cmdUserUpd.Parameters.AddWithValue("?", cbRole.SelectedValue)
                            cmdUserUpd.Parameters.AddWithValue("?", If(ckbisActive.Checked, 1, 0))
                            cmdUserUpd.Parameters.AddWithValue("?", studentID)
                            cmdUserUpd.ExecuteNonQuery()
                        End Using
                        ' If password not changed, do not update hash/salt, just update other fields
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
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub
    Private Sub txtlname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtlname.TextChanged

    End Sub

    Private Sub frmStudentCanBorrow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        cb_loader("SELECT * FROM tblcourse", cbCourses, "cCode", "cID")
        cb_loader("SELECT * FROM tblylevel", cbYear, "yDesc", "yID")
        cb_loader("SELECT * FROM tbl_role", cbRole, "Role", "RoleID")
    End Sub

    Private Sub txtPword_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPword.TextChanged

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub
End Class