Public Class frmTeacherlist

    Private Sub frmTeacherlist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With dgvTeacherList
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

        Call data_loader("SELECT * FROM tblteacher WHERE status = 'Active'", dgvTeacherList)
    End Sub

    Private Sub dgvTeacherList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTeacherList.CellClick
        If e.RowIndex >= 0 Then
            dgvTeacherList.Tag = dgvTeacherList.Item(0, e.RowIndex).Value
            frmTeacherDE.txtTnum.Text = dgvTeacherList.Item(1, e.RowIndex).Value
            frmTeacherDE.txtFname.Text = dgvTeacherList.Item(2, e.RowIndex).Value
            frmTeacherDE.txtMi.Text = dgvTeacherList.Item(3, e.RowIndex).Value
            frmTeacherDE.txtLname.Text = dgvTeacherList.Item(4, e.RowIndex).Value
            frmTeacherDE.txtTnum.Text = dgvTeacherList.Item(5, e.RowIndex).Value
        End If
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim cmd As Odbc.OdbcCommand
        If dgvTeacherList.CurrentRow Is Nothing Then
            MsgBox("Please select a student to delete.", vbInformation)
            Exit Sub
        End If

        Try
            Dim row As DataGridViewRow = dgvTeacherList.CurrentRow
            Dim tID As String = row.Cells("tID").Value.ToString()


            cmd = New Odbc.OdbcCommand("UPDATE tblteacher SET Status=? WHERE tID=?", con)
            With cmd.Parameters
                .AddWithValue("?", "Inactive")
                .AddWithValue("?", tID)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("Teacher Deleted.", vbInformation)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If dgvTeacherList.Tag = 0 Then
            MsgBox("Select a record to edit!")
        Else
            frmTeacherDE.teacherID = Val(dgvTeacherList.Tag)
            frmTeacherDE.Show()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        With frmTeacherDE
            .txtTnum.Clear()
            .txtMi.Clear()
            .txtFname.Clear()
            .txtLname.Clear()
        End With
        dgvTeacherList.Tag = 0
        frmTeacherDE.teacherID = 0
        frmTeacherDE.Show()
    End Sub
End Class