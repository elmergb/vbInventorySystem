Public Class frmDamageActionEntry
    Public Property actionID As Integer
    Private Sub frmDamageActionEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        vbConnection()
        cbActionType.Items.AddRange({"Pay", "Replace", "Repair", "Penalty"})
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If actionID <= 0 Then
            MsgBox("No Action ID selected. Please try again.", vbExclamation)
            Exit Sub
        End If
        If actionID > 0 Then
            Try
                ' Make sure connection is open
                If con.State = ConnectionState.Closed Then con.Open()

                Dim actionType As String = cbActionType.Text
                Dim notes As String = txtRemarks.Text
                Dim amountPaid As Double

                ' Debug check
                MsgBox("Action ID: " & actionID)

                ' Safely convert text to number
                If Not Double.TryParse(txtAmount.Text, amountPaid) Then
                    amountPaid = 0
                End If

                ' Use ? placeholders and AddWithValue
                Dim cmd As New Odbc.OdbcCommand("UPDATE tbldamage_action SET ActionType=?, Status=?, AmountPaid=?, Notes=?, DateCompleted=? WHERE ActionID=" & actionID, con)

                With cmd.Parameters
                    .AddWithValue("?", actionType)
                    .AddWithValue("?", "Completed")
                    .AddWithValue("?", amountPaid)
                    .AddWithValue("?", notes)
                    .AddWithValue("?", dtpDateTime.Value)
                End With

                cmd.ExecuteNonQuery()
                MsgBox("Goods")
                Me.Close()

            Catch ex As Exception
                MsgBox("Error: " & ex.Message, vbCritical)
                If con.State = ConnectionState.Open Then con.Close()
            End Try
        End If
    End Sub

End Class