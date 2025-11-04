Public Class frmBorrowerCartList

    Private Sub frmBorrowerCartList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call vbConnection()
        'Call data_loader("SELECT * FROM vw_cartlist", dgvBorrowerCart)
        cb_loader("SELECT * FROM tblitemlist", frmReturnEntry.cbItemListR, "ItemName", "ItemID")
        Call data_loader("SELECT ItemID, Name, ItemDescription, ItemCategory, ItemLocation, Quantity FROM vw_Items", dgvItemList)
        cb_loader("SELECT * FROM vw_teacher", cbTeacher, "teacher_fullname", "tID")
        For Each col As DataGridViewColumn In dgvItemList.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
            With dgvItemList
                .EnableHeadersVisualStyles = False
                .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .ColumnHeadersHeight = 35
                .RowTemplate.Height = 35
                .AllowUserToAddRows = False
                .RowHeadersVisible = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .CellBorderStyle = DataGridViewCellBorderStyle.Single
                .GridColor = Color.LightGray
                .BorderStyle = BorderStyle.None
            End With
        Next
    End Sub

    Private Sub dgvItemList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItemList.CellClick
        'medyo confusing pa 
        If e.RowIndex >= 0 Then
            dgvItemList.Tag = dgvItemList.Rows(e.RowIndex).Cells("Item").Value
            frmBorrow.cbItemList.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString
            frmBorrow.txtItemDesc.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemDescription").Value.ToString
            frmAddItem.cbCategory.Text = dgvItemList.Rows(e.RowIndex).Cells("Category").Value.ToString()
            frmAddItem.cbLocation.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemLocation").Value.ToString()
            frmAddItem.nupQuantity.Value = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
            Dim qty As Object = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
            If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
                frmAddItem.nupQuantity.Value = CInt(qty)
            Else
                frmAddItem.nupQuantity.Value = 0
            End If

        End If
        'If e.RowIndex >= 0 Then
        '    dgvItemList.Tag = dgvItemList.Rows(e.RowIndex).Cells("Item").Value

        '    frmAddItem.txtNameOFItem.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString
        '    frmAddItem.txtItemDesc.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemDescription").Value.ToString
        '    frmAddItem.cbCategory.Text = dgvItemList.Rows(e.RowIndex).Cells("Category").Value.ToString()
        '    frmAddItem.cbLocation.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemLocation").Value.ToString()
        '    frmAddItem.nupQuantity.Value = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
        '    Dim qty As Object = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
        '    If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
        '        frmAddItem.nupQuantity.Value = CInt(qty)
        '    Else
        '        frmAddItem.nupQuantity.Value = 0
        '    End If

        'End If
    End Sub

    Public Sub LoadStudentData(studentNo As String)
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
                Dim semYearCmd As New Odbc.OdbcCommand("SELECT currentSemester, currentSchoolYear FROM tblsettings lIMIT 1 ", con)
                Dim semReader As Odbc.OdbcDataReader = semYearCmd.ExecuteReader()
                If semReader.Read() Then
                    txtSemester.Text = semReader("currentSemester").ToString()
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

    Private Sub btnBorrow_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrow.Click
        If txtStudentNo.Text.Trim() = " " Or txtStudentNo.Text.Trim() = "" Then
            MsgBox("Insert Student No. First")
            Exit Sub
        End If
        If (dgvItemList.Tag) = 0 Then
            MsgBox("Select an item to borrow!", vbInformation, "Select Item")
        Else
            frmBorrow.txtYearLevel.Text = txtYearLevel.Text
            frmBorrow.txtSchoolYear.Text = txtSchoolYear.Text
            frmBorrow.txtSemester.Text = txtSemester.Text
            frmBorrow.txtTeacher.Text = cbTeacher.Text
            frmBorrow.txtStudentNo.Text = txtStudentNo.Text
            frmBorrow.SelectedItemID = Val(dgvItemList.Tag)
            frmBorrow.ShowDialog()
        End If

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim cmd As Odbc.OdbcCommand

        If String.IsNullOrWhiteSpace(txtStudentNo.Text) Then
            MsgBox("Please select a student before saving.", vbExclamation)
            Exit Sub
        End If
        Dim cmdCheck As New Odbc.OdbcCommand("SELECT COUNT(*) FROM tblcartlist", con)
        Dim itemCount As Integer = CInt(cmdCheck.ExecuteScalar())

        If itemCount = 0 Then
            MsgBox("No items found in the cart to save.", vbExclamation)
            Exit Sub
        End If
        Dim transaction As Odbc.OdbcTransaction = con.BeginTransaction()
        Try

            ' --- Step 1: Read all cart rows into memory ---
            Dim cmdSelect As New Odbc.OdbcCommand("SELECT * FROM tblcartlist", con, transaction)
            Dim reader As Odbc.OdbcDataReader = cmdSelect.ExecuteReader()

            If reader.HasRows Then

                While reader.Read()
                    Dim insertCmd As New Odbc.OdbcCommand("INSERT INTO tblborrowing (ItemID, borrowQty, borrowDateTime, sID, tID, semester, settingID, remarks, Contact, Purpose, yID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con, transaction)
                    With insertCmd.Parameters
                        .AddWithValue("@ItemID", reader("ItemID"))
                        .AddWithValue("@borrowQty", reader("QuantityBorrowed"))
                        .AddWithValue("@borrowDateTime", reader("borrowDateTime"))
                        .AddWithValue("@sID", reader("sID"))
                        .AddWithValue("@tID", reader("tID"))
                        .AddWithValue("@semester", "semester") ' Change to actual semester if exists
                        .AddWithValue("@settingID", reader("settingID"))
                        .AddWithValue("@remarks", reader("Remarks"))
                        .AddWithValue("@Contact", reader("Contact"))
                        .AddWithValue("@Purpose", reader("Purpose"))
                        .AddWithValue("@yID", reader("yID"))
                        insertCmd.ExecuteNonQuery()
                    End With
                    cmd = New Odbc.OdbcCommand("UPDATE tblitemlist SET ItemQuantity = ItemQuantity - ? WHERE ItemID = ?", con, transaction)
                    cmd.Parameters.AddWithValue("?", reader("QuantityBorrowed"))
                    cmd.Parameters.AddWithValue("?", reader("ItemID"))
                    cmd.ExecuteNonQuery()

                End While
            Else
                MsgBox("No records found. The table is empty.", MsgBoxStyle.Information)
                Exit Sub
            End If
            reader.Close()
            ' --- Step 3: Clear the cart ---
            Dim clearCmd As New Odbc.OdbcCommand("DELETE FROM tblcartlist", con, transaction)
            clearCmd.ExecuteNonQuery()

            transaction.Commit()
            MessageBox.Show("Borrowing finalized successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            transaction.Rollback()
            MsgBox("Error occurred: " & ex.Message, vbCritical)
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub btnCart_Click(sender As System.Object, e As System.EventArgs) Handles btnCart.Click
        ' Dim cartForm As New frmCartListView()
        'para sa mamaya sa view details
        ' Pass all student details to the cart form
        'cartForm.StudentNo = txtStudentNo.Text
        'cartForm.FirstName = txtfname.Text
        'cartForm.MiddleInitial = txtmi.Text
        'cartForm.LastName = txtlname.Text
        'cartForm.Course = txtCourse.Text
        'cartForm.Section = txtSection.Text
        'cartForm.YearLevel = txtYearLevel.Text
        'cartForm.Semester = txtSemester.Text
        'cartForm.SchoolYear = txtSchoolYear.Text
        'cartForm.Teacher = cbTeacher.Text
        'cartForm.DateBorrowed = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        frmCartListView.ShowDialog()
    End Sub

    Private Sub txtStudentNo_Leave(sender As Object, e As System.EventArgs) Handles txtStudentNo.Leave
        If txtStudentNo.Text.Trim() <> "" Then
            GetBorrowerName(txtStudentNo.Text.Trim(), txtCourse.Text.Trim(), txtSection.Text.Trim(), txtSchoolYear.Text.Trim())
        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class