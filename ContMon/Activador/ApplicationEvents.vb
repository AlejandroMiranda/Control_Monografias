Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
    Partial Friend Class MyApplication
        Private Sub Inicio(ByVal sender As Object, e As EventArgs) Handles Me.Startup
            NumSer = getNumId(getMacAddress)
            If CommandLineArgs.Count() <> 0 Then
                Dim extencion As String = Nothing
                Dim punto As Integer = CommandLineArgs.Item(0).LastIndexOf(".")
                extencion = CommandLineArgs.Item(0).Substring(punto)
                If (extencion = ".pkm") Then
                    Me.MainForm = InfoSolicitud
                End If
                pathCommandLine = CommandLineArgs.Item(0)
            End If
        End Sub

        Private Sub Exception_NC(ByVal sender As Object, e As EventArgs) Handles Me.UnhandledException
            MsgBox("Error no controlado")
        End Sub

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
    End Class
End Namespace

