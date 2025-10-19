Module modGlobalFunc
    Public Function getallText() As List(Of String)
        Dim text As New List(Of String)

        For Each ctrl As Control In frmUserAdd.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                text.Add(txt.Text)
            End If
        Next
        Return text
    End Function

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

    Public Sub listLoader()
        Dim cmd As Odbc.OdbcCommand
        frmBorrow.lvCart.Items.Clear()

        cmd = New Odbc.OdbcCommand("SELECT ItemName, QuantityBorrowed FROM vw_cartlist", con)
        Dim result As Odbc.OdbcDataReader = cmd.ExecuteReader()

        While result.Read()
            Dim itemName As String = result("ItemName").ToString
            Dim qty As Integer = CInt(result("QuantityBorrowed"))

            Dim listItem As New ListViewItem(itemName)
            listItem.SubItems.Add(qty)
            frmBorrow.lvCart.Items.Add(listItem)
        End While
        result.Close()
    End Sub
End Module
