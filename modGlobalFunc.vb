Imports System.Data.Odbc

Module modGlobalFunc
    Public Function getallText() As List(Of String)
        Dim text As New List(Of String)

        For Each ctrl As Control In frmUserAdd.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                text.Add(txt.Text)
            End If
        Next
        Return text
    End Function

    Public Function ValidateAllTextboxes(frm As Form) As Boolean

        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If String.IsNullOrWhiteSpace(txt.Text) Then
                    MessageBox.Show("Please fill out all fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt.Focus()
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Public Function getTotalItems() As Integer
        Dim cmd As Odbc.OdbcCommand
        Dim total As Integer = 0
        Try
            cmd = New Odbc.OdbcCommand("SELECT COUNT(ItemID) FROM tblitemlist", con)
            total = CInt(cmd.ExecuteScalar)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return total
    End Function

    Public Function getTotalBorrowed() As Integer
        Dim cmd As Odbc.OdbcCommand
        Dim total As Integer = 0
        Try
            cmd = New Odbc.OdbcCommand("SELECT COUNT(BorrowID) FROM tblborrow", con)
            total = CInt(cmd.ExecuteScalar)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return total
    End Function

    Public Function getTotalReturned() As Integer
        Dim cmd As Odbc.OdbcCommand
        Dim total As Integer = 0
        Try
            cmd = New Odbc.OdbcCommand("SELECT COUNT(ReturnID) FROM tblreturn", con)
            total = CInt(cmd.ExecuteScalar)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return total
    End Function
    Public Function getTotalDamaged() As Integer
        Dim cmd As Odbc.OdbcCommand
        Dim total As Integer = 0
        Try
            cmd = New Odbc.OdbcCommand("SELECT COUNT(ReturnID) FROM tblreturn WHERE Lower(Remarks) = 'Damage' OR Lower(Remarks) = 'Critical'  ", con)
            total = CInt(cmd.ExecuteScalar)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return total
    End Function

    Public Sub listLoader()
        Dim cmd As Odbc.OdbcCommand
        frmCartListView.lvCart.Items.Clear()

        cmd = New Odbc.OdbcCommand("SELECT ItemName, ItemDescription, QuantityBorrowed FROM vw_cartlist", con)
        Dim result As Odbc.OdbcDataReader = cmd.ExecuteReader()

        While result.Read()
            Dim itemName As String = result("ItemName").ToString
            Dim qty As Integer = CInt(result("QuantityBorrowed"))
            Dim itemDesc As String = result("ItemDescription").ToString
            Dim listItem As New ListViewItem(itemName)
            listItem.SubItems.Add(itemDesc)
            listItem.SubItems.Add(qty)
            frmCartListView.lvCart.Items.Add(listItem)
        End While
        result.Close()
    End Sub
    Public Sub ClearAllText(ByVal parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()

            ElseIf TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
                CType(ctrl, ComboBox).Text = String.Empty

            ElseIf ctrl.HasChildren Then
                ' Recursively clear inside panels, group boxes, etc.
                ClearAllText(ctrl)
            End If
        Next
    End Sub

    Public Sub DisableForm(ByVal frm As Form)
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""          ' Removes title text
        frm.MinimizeBox = False
        frm.MaximizeBox = False
    End Sub

    Public Sub MsgLogout(ByVal message As String, login As Form, frm As Form)
        If MessageBox.Show(message, "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Login.Show()
            frm.Hide()

        End If
    End Sub

    Public Sub MsgExit(ByVal message As String, frm As Form, homepageFrom As Form, currentForm As Form)
        If MessageBox.Show(message, "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frm.Show()
            Homepage.Hide()
            currentForm.Hide()
        End If
    End Sub
    Public Sub clsoseForm(frm As Form)
        frm.Close()
    End Sub

    Public Sub openForm(frm As Form)
        frm.Show()
    End Sub

    Public Sub SearchItems(ByVal searchText As String, ByVal dgv As DataGridView)
        Try
            Dim sql As String = "SELECT * FROM vw_items WHERE Name LIKE ?"
            Using cmd As New OdbcCommand(sql, con)
                cmd.Parameters.AddWithValue("?", "%" & Trim(searchText) & "%")

                Dim adapter As New OdbcDataAdapter(cmd)
                Dim dtable As New DataTable
                adapter.Fill(dtable)

                dgv.DataSource = dtable
                adapter.Dispose()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading items: " & ex.Message)
        End Try
    End Sub

    Public Function GetItemDescription(ByVal itemName As String) As String
        Dim desc As String = ""
        Try
            Dim cmd As New Odbc.OdbcCommand("SELECT ItemDescription FROM tblitemlist WHERE ItemName = ?", con)
            cmd.Parameters.AddWithValue("?", itemName)

            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                desc = result.ToString()
            End If
        Catch ex As Exception
            MsgBox("Error loading description: " & ex.Message)
        End Try
        Return desc
    End Function

    Public Sub GetBorrowerName(studentNo As String, course As String, section As String, yDesc As String)
        Try
            Dim query As String = "SELECT fname, mi, lname, cCode, section, yDesc FROM vw_students WHERE StudentNo = ?"
            Dim cmd As New Odbc.OdbcCommand(query, con)
            cmd.Parameters.AddWithValue("?", studentNo)
            cmd.Parameters.AddWithValue("?", course)
            cmd.Parameters.AddWithValue("?", section)
            cmd.Parameters.AddWithValue("?", yDesc)
            Dim reader As Odbc.OdbcDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim fullName As String = reader("fname").ToString() & " " & reader("mi").ToString() & " " & reader("lname").ToString()
                Dim c As String = reader("cCode").ToString
                Dim s As String = reader("section").ToString
                Dim yearLevel As String = reader("yDesc").ToString
                frmBorrow.txtBorrowerName.Text = fullName.Trim()
                frmBorrow.txtCourse.Text = course.Trim
                frmBorrow.txtSection.Text = section.Trim
                frmBorrow.txtSchoolYear.Text = yearLevel.Trim
            Else
                MsgBox("Student No not found!", vbExclamation)
                frmBorrow.txtBorrowerName.Clear()
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox("Error loading student name: " & ex.Message, vbCritical)
        End Try
    End Sub

    Public Sub SearchBorrowinglist(ByVal searchText As String, ByVal dgv As DataGridView)
        Try
            Dim sql As String = "SELECT * FROM vw_borrowed_items WHERE Status <> 'Returned' AND StudentName LIKE ?"
            Using cmd As New OdbcCommand(sql, con)
                cmd.Parameters.AddWithValue("?", "%" & Trim(searchText) & "%")

                Dim adapter As New OdbcDataAdapter(cmd)
                Dim dtable As New DataTable
                adapter.Fill(dtable)

                dgv.DataSource = dtable
                adapter.Dispose()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading items: " & ex.Message)
        End Try
    End Sub
End Module
