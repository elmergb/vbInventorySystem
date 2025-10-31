Public Class frmCartListView
    'Public Property StudentNo As String
    'Public Property FirstName As String
    'Public Property MiddleInitial As String
    'Public Property LastName As String
    'Public Property Course As String
    'Public Property Section As String
    'Public Property YearLevel As String
    'Public Property Semester As String
    'Public Property SchoolYear As String
    'Public Property Teacher As String
    'Public Property DateBorrowed As String
    Private Sub frmCartListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ParallelEnumerable sa view details sa return
        'lblStudentNo.Text = StudentNo
        'lblfname.Text = FirstName
        'lblmi.Text = MiddleInitial
        'lblLname.Text = LastName
        'lblCourse.Text = Course
        'lblSection.Text = Section
        'lblYear.Text = YearLevel
        'lblSem.Text = Semester
        'lblSchoolYear.Text = SchoolYear
        'lblTeacher.Text = Teacher
        'lblDate.Text = DateBorrowed

        With lvCart
            .View = View.Details
            .FullRowSelect = True
            .Columns.Clear()
            .Columns.Add("Item", 150)
            .Columns.Add("Description", 200)
            .Columns.Add("Quantity", 80)
        End With

    End Sub

    Private Sub lvCart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCart.SelectedIndexChanged
        If lvCart.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvCart.SelectedItems(0)
            Dim itemName As String = selectedItem.SubItems(0).Text
            Dim desc As String = selectedItem.SubItems(1).Text
            Dim qty As String = selectedItem.SubItems(2).Text


            frmBorrow.cbItemList.Text = itemName
            frmBorrow.txtItemDesc.Text = desc
            frmBorrow.nupQuantity.Value = CInt(qty)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As Odbc.OdbcCommand
        If lvCart.SelectedItems.Count >= 0 Then
            MsgBox("Please select an item to delete.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim itemName As String = lvCart.SelectedItems(0).SubItems(0).Text
            cmd = New Odbc.OdbcCommand("DELETE FROM tblcartlist WHERE ItemID =  (SELECT ItemID From tblitemlist WHERE ItemName = ?)", con)
            cmd.Parameters.AddWithValue("?", itemName)
            cmd.ExecuteNonQuery()

            MsgBox("Item removed successfully!")
            Call listLoader()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If lvCart.SelectedItems.Count = 0 Then
            MsgBox("Please select an item to edit.", MsgBoxStyle.Exclamation)
        Else

        End If
    End Sub

    Private Sub lblName_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    'Public Sub StudentData(studentNo As String)
    '    Dim isFound As Boolean = True
    '    Try
    '        Dim query As String = "SELECT studentNo, fname, mi, lname, cCode, section, yDesc FROM vw_students WHERE StudentNo = ?"
    '        Dim cmd As New Odbc.OdbcCommand(query, con)
    '        cmd.Parameters.AddWithValue("?", studentNo)
    '        Dim reader As Odbc.OdbcDataReader = cmd.ExecuteReader()
    '        If reader.Read() Then
    '            ' Fill the form fields
    '            lblStudentNo.Text = reader("studentNo").ToString()
    '            lblfname.Text = reader("fname").ToString()
    '            lblmi.Text = reader("mi").ToString()
    '            lblLname.Text = reader("lname").ToString()
    '            lblCourse.Text = reader("cCode").ToString()
    '            lblSection.Text = reader("section").ToString()
    '            lblYear.Text = reader("yDesc").ToString()
    '            isFound = True
    '        Else
    '            isFound = False
    '            MessageBox.Show("Student not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If

    '        reader.Close()

    '        If isFound = True Then
    '            Dim semYearCmd As New Odbc.OdbcCommand("SELECT currentSemester, currentSchoolYear FROM tblsettings lIMIT 1 ", con)
    '            Dim semReader As Odbc.OdbcDataReader = semYearCmd.ExecuteReader()
    '            If semReader.Read() Then
    '                lblSem.Text = semReader("currentSemester").ToString()
    '                lblSchoolYear.Text = semReader("currentSchoolYear").ToString()
    '            End If
    '            semReader.Close()
    '            isFound = True
    '        Else
    '            isFound = False
    '            Exit Sub
    '        End If


    '    Catch ex As Exception
    '        MessageBox.Show("Error loading student data: " & ex.Message)
    '    End Try
    'End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class