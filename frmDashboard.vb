Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call data_loader("SELECT BorrowerName, ItemName, QuantityBorrowed, Purpose, DateBorrowed FROM vw_borrowing ORDER BY DateBorrowed DESC LIMIT 5 ", frmDBdgvBorrow)
        Call data_loader("SELECT  ItemName,BorrowerName, QuantityBorrowed, QuantityReturned, DateReturned FROM vw_transaction ORDER BY DateReturned DESC LIMIT 5 ", frmDBdgvReturn)
        Call data_loader("SELECT * FROM tblitemlist ORDER BY ItemID DESC LIMIT 5 ", frmDBdgvItem)
        Call data_loader("SELECT ItemName, QuantityReturned FROM vw_transaction WHERE TRIM(Remarks)='Damage' OR TRIM(Remarks)='Critical'", dgvDamageItem)
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
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UIToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripDropDownButton2_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton2.Click

    End Sub

    Private Sub LoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoToolStripMenuItem.Click
        If MsgBox("Are you sure to Logout?", vbYesNo + vbQuestion) = vbYes Then
            Me.Close()
            Homepage.Close()
        End If
    End Sub
End Class