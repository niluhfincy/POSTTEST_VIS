Module ValidationModule

    Public Function ValidasiKosong(txt As TextBox, pesan As String, ep As ErrorProvider) As Boolean
        If txt.Text.Trim = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

End Module