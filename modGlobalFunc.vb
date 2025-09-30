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
End Module
