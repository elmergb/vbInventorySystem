Public Class frmBorrowerCartList
    Private Sub frmBorrowerCartList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call vbConnection()
        Call data_loader("SELECT * FROM vw_cartlist", dgvBorrowerCart)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")

    End Sub

    Private Sub dgvBorrowerCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowerCart.CellContentClick

    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub



    Private Sub LoadStudentData(studentNo As String)
        Dim isFound As Boolean = True
        Try
            Dim query As String = "SELECT fname, mi, lname, cCode, section, yDesc FROM vw_students WHERE StudentNo = ?"
            Dim cmd As New Odbc.OdbcCommand(query, con)
            cmd.Parameters.AddWithValue("?", studentNo)
            Dim reader As Odbc.OdbcDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                ' Fill the form fields
                txtfname.Text = reader("fname").ToString()
                txtmi.Text = reader("mi").ToString()
                txtlname.Text = reader("lname").ToString()
                txtCourse.Text = reader("cCode").ToString()
                txtSection.Text = reader("section").ToString()
                txtYearLevel.Text = reader("yDesc").ToString()
                isFound = True
            Else
                isFound = False
                MessageBox.Show("Student not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            reader.Close()

            If isFound = True Then
                Dim semYearCmd As New Odbc.OdbcCommand("SELECT currentSemester, currentSchoolYear FROM tblsettings LIMIT 1", con)
                Dim semReader As Odbc.OdbcDataReader = semYearCmd.ExecuteReader()
                If semReader.Read() Then
                    cbSemester.Text = semReader("currentSemester").ToString()
                    txtSchoolYear.Text = semReader("currentSchoolYear").ToString()
                End If
                semReader.Close()
                isFound = True
            Else
                isFound = False
                Exit Sub
            End If


        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message)
        End Try
    End Sub

    Private Sub txtStudentNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtStudentNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Call the function to load student data
            LoadStudentData(txtStudentNo.Text)
        End If
    End Sub
End Class