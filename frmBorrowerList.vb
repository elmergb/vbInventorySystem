Public Class frmBorrowerList

    Private Sub frmBorrowerList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call vbConnection()
        Call data_loader("SELECT * FROM vw_borrowing", dgvBorrowerList)
    End Sub

    Private Sub dgvBorrowerList_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrowerList.CellClick
        If e.RowIndex >= 0 Then
            ' Borrower ID (hidden)
            dgvBorrowerList.Tag = dgvBorrowerList.Item(0, e.RowIndex).Value

            ' Item ID (hidden) - sets ComboBox SelectedValue
            Dim itemIDValue As Object = dgvBorrowerList.Item(1, e.RowIndex).Value
            If itemIDValue IsNot Nothing AndAlso Not IsDBNull(itemIDValue) Then
                frmBorrow.cbItemList.SelectedValue = Convert.ToInt32(itemIDValue)
            Else
                frmBorrow.cbItemList.SelectedIndex = -1
            End If

            ' Borrower Name
            frmBorrow.txtBorrowerName.Text = dgvBorrowerList.Item(2, e.RowIndex).Value.ToString()

            ' Quantity Borrowed
            Dim qtyValue As Object = dgvBorrowerList.Item(3, e.RowIndex).Value
            If IsNumeric(qtyValue) Then
                frmBorrow.nupQuantity.Value = Convert.ToInt32(qtyValue)
            Else
                frmBorrow.nupQuantity.Value = 0
            End If

            ' Contact
            frmBorrow.txtContact.Text = dgvBorrowerList.Item(4, e.RowIndex).Value.ToString()

            ' Purpose
            frmBorrow.txtPurpose.Text = dgvBorrowerList.Item(5, e.RowIndex).Value.ToString()

            ' Date Borrowed (safe conversion)
            Dim dateValue As Object = dgvBorrowerList.Item(6, e.RowIndex).Value
            Dim borrowDate As Date
            If Date.TryParse(dateValue.ToString(), borrowDate) Then
                frmBorrow.dtpBorrowed.Value = borrowDate
            Else
                frmBorrow.dtpBorrowed.Value = Date.Now
            End If

            ' Remarks
            frmBorrow.txtRemarks.Text = dgvBorrowerList.Item(7, e.RowIndex).Value.ToString()
        End If
    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        If Val(dgvBorrowerList.Tag) = 0 Then
            MsgBox("Select a record to return!")
        Else

        End If
    End Sub
End Class