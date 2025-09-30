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
End Module
