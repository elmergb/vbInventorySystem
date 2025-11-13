Public Class frmStudentlist

    Private Sub frmStudentlist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_user", dgvStudentList)

        LoadStudents()
        'If e.RowIndex >= 0 Then
        '    dgvItemList.Tag = dgvItemList.Rows(e.RowIndex).Cells("Item").Value

        '    frmAddItem.txtNameOFItem.Text = dgvItemList.Rows(e.RowIndex).Cells("NameofItem").Value.ToString
        '    frmAddItem.cbCategory.Text = dgvItemList.Rows(e.RowIndex).Cells("Category").Value.ToString()
        '    frmAddItem.cbLocation.Text = dgvItemList.Rows(e.RowIndex).Cells("ItemLocation").Value.ToString()
        '    frmAddItem.nupQuantity.Value = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
        '    Dim qty As Object = dgvItemList.Rows(e.RowIndex).Cells("Quantity").Value
        '    If qty IsNot Nothing AndAlso Not IsDBNull(qty) Then
        '        frmAddItem.nupQuantity.Value = CInt(qty)
        '    Else
        '        frmAddItem.nupQuantity.Value = 0
        '    End If
        '    frmAddItem.cbRemarks.Text = dgvItemList.Rows(e.RowIndex).Cells("Remarks").Value.ToString()
        For Each col As DataGridViewColumn In dgvStudentList.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        With dgvStudentList
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersHeight = 25
            .RowTemplate.Height = 25
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.LightGray
            .BorderStyle = BorderStyle.None
            .ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
        DisableForm(frmStudentDE)
    End Sub

    Private Sub LoadStudents(Optional ByVal search As String = "")
        Dim query As String = "SELECT * FROM vw_user"

        If search <> "" Then
            query &= " WHERE studentNo LIKE '%" & search & "%' " &
                     "OR fname LIKE '%" & search & "%' " &
                     "OR lname LIKE '%" & search & "%' " &
                     "OR cCode LIKE '%" & search & "%' " &
                     "OR section LIKE '%" & search & "%' " &
                     "OR yDesc LIKE '%" & search & "%'"
        End If

        Dim da As New Odbc.OdbcDataAdapter(query, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvStudentList.DataSource = dt
    End Sub

    Private Sub dgvStudentList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudentList.CellClick
        'If e.RowIndex >= 0 Then
        '    dgvStudentList.Tag = dgvStudentList.Item(0, e.RowIndex).Value
        '    frmStudentCanBorrow()
        'End If

        If e.RowIndex >= 0 Then
            dgvStudentList.Tag = dgvStudentList.Rows(e.RowIndex).Cells("sIDs").Value
            frmStudentDE.txtStudentNumber.Text = dgvStudentList.Rows(e.RowIndex).Cells("StudentNo").Value.ToString()
            frmStudentDE.txtfname.Text = dgvStudentList.Rows(e.RowIndex).Cells("fname").Value.ToString()
            frmStudentDE.txtmi.Text = dgvStudentList.Rows(e.RowIndex).Cells("mi").Value.ToString()
            frmStudentDE.txtlname.Text = dgvStudentList.Rows(e.RowIndex).Cells("lname").Value.ToString()
            frmStudentDE.cbCourses.SelectedValue = dgvStudentList.Rows(e.RowIndex).Cells("course").Value.ToString()
            frmStudentDE.txtSection.Text = dgvStudentList.Rows(e.RowIndex).Cells("section").Value.ToString()
            frmStudentDE.cbYear.SelectedValue = dgvStudentList.Rows(e.RowIndex).Cells("yDesc").Value.ToString()
            frmStudentDE.cbRole.SelectedValue = dgvStudentList.Rows(e.RowIndex).Cells("Role").Value.ToString()
            frmStudentDE.txtuname.Text = dgvStudentList.Rows(e.RowIndex).Cells("UserName").Value.ToString()
            frmStudentDE.txtPword.Text = dgvStudentList.Rows(e.RowIndex).Cells("pword").Value.ToString()
            frmStudentDE.ckbisActive.Checked = CBool(dgvStudentList.Rows(e.RowIndex).Cells("isActive").Value)

        End If

    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Val(dgvStudentList.Tag) = 0 Then
            MsgBox("Select a record to Edit!")
        Else
            frmStudentDE.txtPword.Clear()
            frmStudentDE.studentID = Val(dgvStudentList.Tag)
            frmStudentDE.lbltext.Text = "Edit"
            frmStudentDE.lbltext.Location = New Point(220, 18)
            frmStudentDE.Show()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmStudentDE.studentID = 0
        frmStudentDE.Show()
        With frmStudentDE
            .txtfname.Clear()
            .txtlname.Clear()
            .txtmi.Clear()
            .lblActive.Visible = False
            .txtPword.Clear()
            .txtSection.Clear()
            .txtStudentNumber.Clear()
            .txtuname.Clear()
            .ckbisActive.Checked = True
            .ckbisActive.Visible = False
            .cbCourses.SelectedValue = -1
            .cbRole.SelectedValue = -1
            .cbYear.SelectedValue = -1
        End With
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If dgvStudentList.CurrentRow Is Nothing Then
            MsgBox("Please select a student to delete.", vbInformation)
            Exit Sub
        End If

        Dim row As DataGridViewRow = dgvStudentList.CurrentRow
        Dim sID As Integer = CInt(row.Cells("sIDs").Value)
        Dim role As String = row.Cells("Role").Value.ToString().Trim().ToLower()

        If role = "admin" Then
            MsgBox("You cannot delete an Admin account.", vbExclamation, "Action Denied")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this user?", vbYesNo + vbQuestion, "Confirm Delete") = vbYes Then
            Try
                Dim query As String = "DELETE FROM tbluser WHERE sID = ?"

                Using cmd As New Odbc.OdbcCommand(query, con)
                    cmd.Parameters.AddWithValue("?", sID)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("User deleted successfully.", vbInformation)
                Call data_loader("SELECT * FROM vw_user", dgvStudentList)
                LoadStudents()

            Catch ex As Exception
                MsgBox("Error deleting record: " & ex.Message, vbCritical)
            End Try
        End If


    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        LoadStudents(txtSearch.Text.Trim())

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvStudentList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudentList.CellContentClick

    End Sub

    Private Sub frmStudentlist_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If CurrentRole.Trim().ToLower() = "student" Then
            btnDelete.Visible = False
            btnEdit.Visible = False
            btnAdd.Location = New Point(1338, 623)
        Else
            btnDelete.Visible = True
            btnEdit.Visible = True
        End If
    End Sub
End Class