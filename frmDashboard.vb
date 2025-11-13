Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTotalBorrowed.Text = getTotalBorrowed()
        lblItemTotal.Text = getTotalItems()
        lblTotalDamaged.Text = getTotalDamaged().ToString

        Call data_loader("SELECT BorrowerName, ItemName, ItemDescription, QuantityBorrowed, QuantityReturned, QuantityDamaged FROM vw_borrowed_item_status ORDER BY BorrowDateTime  DESC LIMIT 5", dgvRB)
        Call data_loader("SELECT Name, ItemDescription, Quantity FROM vw_items ORDER BY ItemID  DESC LIMIT 5", dgvRR)



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
    End Sub



    Private Sub ltsLogout_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure to Logout?", vbYesNo + vbQuestion, "Logout") = vbYes Then
            Me.Close()
            Homepage.Close()
        End If
    End Sub

    Private Sub ltsExit_Click(sender As Object, e As EventArgs)
        MsgExit("Are you sure you want to exit?", frmLogin, Homepage, Me)
        'If MsgBox("Are you sure to Exit?", vbYesNo + vbQuestion) = vbYes Then
        '    Me.Close()
        '    Homepage.Close()
        'End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblTotalDamaged_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalDamaged.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub dgvRR_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRR.CellContentClick

    End Sub

    Private Sub dgvRA_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRA.CellContentClick

    End Sub
End Class