Imports System.Data.Odbc

Module modCon
    Public con As Odbc.OdbcConnection
    Public Sub vbConnection()
        Try
            con = New Odbc.OdbcConnection("dsn=inventory")
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub data_loader(sql As String, dgv As DataGridView)
        Dim adapter As Odbc.OdbcDataAdapter
        Dim dtable As New DataTable
        adapter = New Odbc.OdbcDataAdapter(sql, con)
        adapter.Fill(dtable)
        dgv.DataSource = dtable
        adapter.Dispose()
    End Sub
    Public Sub cb_loader(sql As String, cb As ComboBox, mem As String, val As String)
        Dim adapter As OdbcDataAdapter
        Dim dtable As New DataTable
        adapter = New Odbc.OdbcDataAdapter(sql, con)
        adapter.Fill(dtable)
        cb.DataSource = dtable
        cb.DisplayMember = mem
        cb.ValueMember = val
        adapter.Dispose()
    End Sub

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
End Module
