Partial Class transactdt
    Partial Class DataTableDataTable

        Private Sub DataTableDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.bIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
