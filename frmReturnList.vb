Public Class frmReturnList

    Private Sub frmReturnList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call data_loader("SELECT * FROM vw_transaction", dgvReturnList)
        Dim sb As New System.Text.StringBuilder()
        If dgvReturnList.Columns.Count = 0 Then
            MsgBox("Columns count = 0 (no columns yet)")
        Else

            For Each col As DataGridViewColumn In dgvReturnList.Columns
                sb.AppendLine(col.Index & " - " & col.HeaderText & " (Name: " & col.Name & ")")
            Next

            ' ✅ Correct MsgBox syntax: first argument = text, second (optional) = style, third = caption
            MsgBox(sb.ToString(), MsgBoxStyle.Information, "DataGridView Columns")
        End If
    End Sub

    Private Sub dgvReturnList_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReturnList.CellContentClick

    End Sub

    Private Sub dgvReturnList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReturnList.CellClick
        'If e.RowIndex >= 0 Then
        '    ' IDs for return logic
        '    frmReturnEntry.BorrowID = dgvReturnList.Item(0, e.RowIndex).Value   ' BorrowID
        '    frmReturnEntry.ItemID = dgvReturnList.Item(1, e.RowIndex).Value     ' ItemID

        '    ' Fill fields from vw_transaction
        '    frmReturnEntry.cbItemListR.Text = dgvReturnList.Item(2, e.RowIndex).Value        ' ItemName
        '    frmReturnEntry.txtBorrowerNameR.Text = dgvReturnList.Item(3, e.RowIndex).Value   ' BorrowerName
        '    frmReturnEntry.nupQuantityR.Value = dgvReturnList.Item(4, e.RowIndex).Value      ' QuantityBorrowed
        '    frmReturnEntry.txtPurposeR.Text = dgvReturnList.Item(7, e.RowIndex).Value        ' Purpose
        '    frmReturnEntry.dtpBorrowedR.Value = CDate(dgvReturnList.Item(8, e.RowIndex).Value) ' DateBorrowed
        '    frmReturnEntry.txtRemarksR.Text = dgvReturnList.Item(10, e.RowIndex).Value       ' Remarks
        'End If
        If e.RowIndex < 0 Then Return

        ' Helper lambda to safely read a cell value
        Dim ReadCell As Func(Of Integer, Object) = Function(colIndex As Integer)
                                                       Dim val = dgvReturnList.Item(colIndex, e.RowIndex).Value
                                                       If val Is Nothing OrElse IsDBNull(val) Then
                                                           Return Nothing
                                                       End If
                                                       Return val
                                                   End Function

        ' Safely read IDs (use 0 when missing)
        Dim bidObj = ReadCell(0)
        frmReturnEntry.BorrowID = If(bidObj Is Nothing, 0, CInt(bidObj))

        Dim itemObj = ReadCell(1)
        frmReturnEntry.ItemID = If(itemObj Is Nothing, 0, CInt(itemObj))

        ' ItemName (ComboBox text) - if missing, clear selection
        Dim nameObj = ReadCell(2)
        If nameObj Is Nothing Then
            frmReturnEntry.cbItemListR.SelectedIndex = -1
        Else
            frmReturnEntry.cbItemListR.Text = nameObj.ToString()
        End If

        ' BorrowerName
        Dim borrowerObj = ReadCell(3)
        frmReturnEntry.txtBorrowerNameR.Text = If(borrowerObj Is Nothing, String.Empty, borrowerObj.ToString())

        ' QuantityBorrowed -> numeric updown (guard and clamp)
        Dim qtyObj = ReadCell(4)
        Try
            Dim qtyVal As Integer = If(qtyObj Is Nothing, 0, CInt(qtyObj))
            If qtyVal < frmReturnEntry.nupQuantityR.Minimum Then qtyVal = CInt(frmReturnEntry.nupQuantityR.Minimum)
            If qtyVal > frmReturnEntry.nupQuantityR.Maximum Then qtyVal = CInt(frmReturnEntry.nupQuantityR.Maximum)
            frmReturnEntry.nupQuantityR.Value = qtyVal
        Catch
            frmReturnEntry.nupQuantityR.Value = frmReturnEntry.nupQuantityR.Minimum
        End Try

        ' Purpose
        Dim purposeObj = ReadCell(7)
        frmReturnEntry.txtPurposeR.Text = If(purposeObj Is Nothing, String.Empty, purposeObj.ToString())

        ' DateBorrowed -> only set if valid
        Dim dateObj = ReadCell(8)
        If dateObj IsNot Nothing Then
            Try
                frmReturnEntry.dtpBorrowedR.Value = CDate(dateObj)
            Catch
                ' keep the existing dtp value if conversion fails
            End Try
        End If

        ' Remarks (index 10 in your view before; if your view uses index 10 for remarks)
        Dim remarksObj = ReadCell(10)
        frmReturnEntry.txtRemarksR.Text = If(remarksObj Is Nothing, String.Empty, remarksObj.ToString())
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If Val(dgvReturnList.Tag) = 0 Then
            MsgBox("Select a record to return", vbInformation)
        Else
            frmReturnEntry.ItemID = Val(dgvReturnList.Tag)
            frmReturnEntry.BorrowID = Val(dgvReturnList.Tag)
            frmReturnEntry.ShowDialog()
        End If
    End Sub
End Class