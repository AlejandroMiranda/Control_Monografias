Module General

    Public NumSer As Integer = Nothing
    Public pathCommandLine As String = Nothing

    Public Function Descriptar(txtDescriptar As String, numDescriptar As Integer)
        Dim Res As String = Nothing
        For i As Integer = 0 To txtDescriptar.Length - 1
            Dim nResta As Integer = Asc(txtDescriptar.Chars(i)) - numDescriptar
            If nResta >= 0 Then
                Res &= Chr(nResta)
            Else
                Res &= txtDescriptar.Chars(i)
            End If
        Next
        Return Res
    End Function
    Public Function Encriptar(txtEncriptar As String, numEncriptar As Integer)
        Dim Res As String = Nothing
        For i As Integer = 0 To txtEncriptar.Length - 1
            Res &= Chr(Asc(txtEncriptar.Chars(i)) + numEncriptar)
        Next
        Return Res
    End Function

    Function getMacAddress()
        Dim Board_SN As String = ""
        Dim SN_Board As New System.Management.ManagementObjectSearcher("root\CIMV2", "Select * from Win32_BaseBoard")
        For Each mo As System.Management.ManagementObject In SN_Board.Get()
            Board_SN = mo.GetPropertyValue("SerialNumber").ToString
        Next
        Return Board_SN
    End Function
    Function getNumId(Mac As String) As Integer
        Dim num As Integer = Nothing
        Dim div As Integer = Nothing
        For i As Integer = 0 To Mac.Length - 1
            num += Asc(Mac.Chars(i))
        Next
        div = num / 120
        num = div + (num Mod 120)
        Return num
    End Function
End Module
