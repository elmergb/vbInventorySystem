Imports Microsoft.Reporting.WinForms
Imports System.Data.Odbc
Public Class frmTransactrpt


    Private Sub frmTransactrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.transactdt.EnforceConstraints = False
            Me.DataTableTableAdapter.Fill(Me.transactdt.DataTable)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        Try
            Dim dateFrom As Date = dtpDateFrom.Value.Date
            Dim dateTo As Date = dtpDateTo.Value.Date

            If dateFrom > dateTo Then
                MsgBox("The 'From' date cannot be later than the 'To' date.", vbExclamation, "Invalid Date Range")
                Exit Sub
            End If

            Dim query As String = "SELECT StudentName, ItemName, ItemDescription, QuantityBorrowed, QuantityReturned, QuantityDamaged, DateBorrowed, DateTimeReturned, ReturnRemarks FROM vw_returnlist WHERE DateBorrowed BETWEEN ? AND ?"

            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("?", dateFrom)
                cmd.Parameters.AddWithValue("?", dateTo)

                Dim da As New OdbcDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)


                Dim reportPath As String = "C:\Users\Erica Joy Restum\Documents\Visual Studio 2010\Projects\main\main\Transactrpt.rdlc"
                If Not IO.File.Exists(reportPath) Then
                    MsgBox("Report file not found at: " & reportPath, vbCritical, "Missing Report File")
                    Exit Sub
                End If


                ReportViewer1.Reset()
                ReportViewer1.LocalReport.ReportPath = reportPath
                ReportViewer1.LocalReport.DataSources.Clear()

                ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))


                ReportViewer1.LocalReport.Refresh()
                ReportViewer1.RefreshReport()
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Report Error")
        End Try
    End Sub
End Class