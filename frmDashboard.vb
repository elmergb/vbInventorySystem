Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call data_loader("SELECT BorrowerName, ItemName, QuantityBorrowed, Purpose, DateBorrowed FROM vw_borrowing ORDER BY DateBorrowed DESC LIMIT 5 ", frmDBdgvBorrow)
        Call data_loader("SELECT  ItemName,BorrowerName, QuantityBorrowed, QuantityReturned, DateReturned FROM vw_transaction ORDER BY DateReturned DESC LIMIT 5 ", frmDBdgvReturn)
        Call data_loader("SELECT * FROM tblitemlist ORDER BY ItemID DESC LIMIT 5 ", frmDBdgvItem)
        Call data_loader("SELECT ItemName, ItemQuantity FROM tblitemlist WHERE TRIM(ItemRemarks)='Damage' OR TRIM(ItemRemarks)='Critical'", dgvDamageItem)
        frmDBdgvBorrow.ClearSelection()
        frmDBdgvReturn.ClearSelection()
        frmDBdgvItem.ClearSelection()
        For Each col As DataGridViewColumn In frmDBdgvBorrow.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        For Each col As DataGridViewColumn In frmDBdgvReturn.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        For Each col As DataGridViewColumn In frmDBdgvItem.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        ' Set selection colors to white for a "no highlight" effect
        With frmDBdgvBorrow
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        With frmDBdgvReturn
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        With frmDBdgvItem
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With

        lblTotalBorrowed.Text = getTotalBorrowed()
        lblItemTotal.Text = getTotalItems()
        lblTotalReturned.Text = getTotalReturned()
        lblTotalDamaged.Text = getTotalDamaged().ToString
        lblTsUser.Text = Login.txtUsername.Text
        lblTsTime.Text = Date.Now.ToString(("yyyy-MM-dd HH:mm:ss"))

        'Chart1.Series.Clear()
        'Dim mostBorrowed As New Series("MostBorrowed")
        'mostBorrowed.ChartType = SeriesChartType.Column
        'mostBorrowed.Palette = ChartColorPalette.BrightPastel

        'Dim cmd As New Odbc.OdbcCommand("SELECT ItemName, SUM(QuantityBorrowed) AS TotalBorrowed FROM vw_borrowing GROUP BY ItemName ORDER BY TotalBorrowed DESC LIMIT 5", con)
        'Dim reader As Odbc.OdbcDataReader = cmd.ExecuteReader()
        'While reader.Read()
        '    mostBorrowed.Points.AddXY(reader("ItemName").ToString(), Convert.ToInt32(reader("TotalBorrowed")))
        'End While
        'reader.Close()

        'Dim title As New Title("Top 5 Most Borrowed Items", Docking.Top, New Font("Segoe UI", 14, FontStyle.Bold), Color.Navy)
        'Chart1.Titles.Add(title)
        'Chart1.BackColor = Color.WhiteSmoke
        'Chart1.ChartAreas(0).BackColor = Color.White
        'Chart1.ChartAreas(0).BorderDashStyle = ChartDashStyle.Solid
        'Chart1.ChartAreas(0).BorderWidth = 1
        'Chart1.ChartAreas(0).BorderColor = Color.LightGray
        'Chart1.Legends(0).BackColor = Color.Transparent
        'Chart1.Legends(0).Docking = Docking.Right
        'mostBorrowed.IsVisibleInLegend = False ' hide the series name

        'With Chart1.ChartAreas(0).AxisX.MajorGrid
        '    .LineColor = Color.LightGray
        '    .LineDashStyle = ChartDashStyle.Dot
        'End With
        'With Chart1.ChartAreas(0).AxisY.MajorGrid
        '    .LineColor = Color.LightGray
        '    .LineDashStyle = ChartDashStyle.Dot
        'End With
        'Chart1.Series.Add(mostBorrowed)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
    End Sub

    Private Sub LoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoToolStripMenuItem.Click
        If MsgBox("Are you sure to Logout?", vbYesNo + vbQuestion) = vbYes Then
            Me.Close()
            Homepage.Close()
        End If
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvDamageItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDamageItem.CellContentClick

    End Sub

    Private Sub EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EToolStripMenuItem.Click
        If MsgBox("Are you sure to exit?", vbYesNo + vbQuestion) = vbYes Then
            Me.Close()
            Homepage.Close()
        End If
    End Sub

End Class