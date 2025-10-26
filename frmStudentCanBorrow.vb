Public Class frmStudentCanBorrow
    Public Property studentID As Integer
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand
        Dim studentNo As String = txtStudentNumber.Text
        Dim fname As String = txtfname.Text
        Dim mi As String = txtmi.Text
        Dim lname As String = txtlname.Text
        Dim course As String = cbCourses.SelectedValue
        Dim section As String = txtSection.Text
        Dim ylevel As String = cbYear.SelectedValue
        Try
            If studentID = 0 Then
                cmd = New Odbc.OdbcCommand("SELECT studentNo FROM tblstudentlist WHERE studentNo=?", con)
                cmd.Parameters.AddWithValue("?", studentNo)
                Dim result As Object = cmd.ExecuteScalar

                If result IsNot Nothing Then
                    MsgBox("Student ID already Exist")
                    Exit Sub
                End If

                cmd = New Odbc.OdbcCommand("INSERT INTO tblstudentlist (studentNo, fname, mi, lname, cID, section, yID) VALUES (?,?,?,?,?,?,?)", con)
                With cmd.Parameters
                    .AddWithValue("?", studentNo)
                    .AddWithValue("?", fname)
                    .AddWithValue("?", mi)
                    .AddWithValue("?", lname)
                    .AddWithValue("?", course)
                    .AddWithValue("?", section)
                    .AddWithValue("?", ylevel)
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Sucessfully add")
                Call data_loader("SELECT * FROM vw_students", frmStudentlist.dgvStudentList)
            Else
                cmd = New Odbc.OdbcCommand("UPDATE tblstudentlist SET studentNo=?, fname=?, mi=?, lname=?, cID=?, section=?, yID=? WHERE sID=" & studentID, con)
                With cmd.Parameters
                    .AddWithValue("?", studentNo)
                    .AddWithValue("?", fname)
                    .AddWithValue("?", mi)
                    .AddWithValue("?", lname)
                    .AddWithValue("?", course)
                    .AddWithValue("?", section)
                    .AddWithValue("?", ylevel) 
                End With
                cmd.ExecuteNonQuery()
                MsgBox("Sucessfully add")
                Call data_loader("SELECT * FROM vw_students", frmStudentlist.dgvStudentList)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtlname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtlname.TextChanged

    End Sub

    Private Sub frmStudentCanBorrow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        cb_loader("SELECT * FROM tblcourse", cbCourses, "cCode", "cID")
        cb_loader("SELECT * FROM tblylevel", cbYear, "yDesc", "yID")
    End Sub
End Class