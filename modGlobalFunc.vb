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
            cmd = New Odbc.OdbcCommand("SELECT COUNT(BorrowID) FROM vw_borrowed_items WHERE Status = 'Borrowed'", con)
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
            cmd = New Odbc.OdbcCommand("SELECT COUNT(ReturnID) FROM vw_returnlist WHERE ReturnStatus = 'Returned' OR ReturnStatus = 'Partially Returned'", con)
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
            cmd = New Odbc.OdbcCommand("SELECT COUNT(ActionID) FROM tbldamage_action WHERE Status = 'Pending' ", con)
            total = CInt(cmd.ExecuteScalar)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return total
    End Function

    Public Sub listLoader()
        frmCartListView.lvCart.Items.Clear()

        Dim sql As String = "SELECT c.tempID, i.ItemName, i.ItemDescription, c.QuantityBorrowed, c.Purpose, c.Contact,  c.Remarks FROM tblcartlist c INNER JOIN tblitemlist i ON c.ItemID = i.ItemID"

        Using cmd As New Odbc.OdbcCommand(sql, con)
            Using rdr As Odbc.OdbcDataReader = cmd.ExecuteReader()
                While rdr.Read()
                    Dim lvi As New ListViewItem(rdr("ItemName").ToString())
                    lvi.SubItems.Add(rdr("ItemDescription").ToString())
                    lvi.SubItems.Add(rdr("QuantityBorrowed").ToString())
                    lvi.SubItems.Add(rdr("Purpose").ToString())
                    lvi.SubItems.Add(rdr("Contact").ToString())
                    lvi.SubItems.Add(rdr("Remarks").ToString())

                    ' --- Fetch reserved serials (optional, last column) ---
                    Dim serials As New List(Of String)
                    Using cmdSerial As New Odbc.OdbcCommand("SELECT SerialNo FROM tblcartserials WHERE CartID = ?", con)
                        cmdSerial.Parameters.AddWithValue("?", rdr("tempID"))
                        Using rdrSerial As Odbc.OdbcDataReader = cmdSerial.ExecuteReader()
                            While rdrSerial.Read()
                                serials.Add(rdrSerial("SerialNo").ToString())
                            End While
                        End Using
                    End Using

                    ' Optional: keep serials in last column (for reference only)
                    lvi.SubItems.Add(String.Join(", ", serials))

                    lvi.Tag = rdr("tempID")
                    frmCartListView.lvCart.Items.Add(lvi)
                End While
            End Using
        End Using
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
        'frm.ControlBox = False
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
                frmBorrowDE.txtBorrowerName.Text = fullName.Trim()
                frmBorrowDE.txtCourse.Text = course.Trim
                frmBorrowDE.txtSection.Text = section.Trim
                frmBorrowDE.txtSchoolYear.Text = yearLevel.Trim
            Else
                MsgBox("Student No not found!", vbExclamation)
                frmBorrowDE.txtBorrowerName.Clear()
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
