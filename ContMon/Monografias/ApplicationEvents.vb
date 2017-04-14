Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
    Partial Friend Class MyApplication

        Private Function ver_activacion() As Boolean
            Dim keyvalue As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser _
                                                          .OpenSubKey("Software\MS License Key", True)
            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser _
                                                          .OpenSubKey("Software\Cnt Monografias", True)
            If keyvalue.GetValue("Instalacion") IsNot Nothing Then
                If keyvalue.GetValue("Activado") IsNot Nothing Then
                    If getMacRegistro() = getMacAddress() Then
                        Return True
                    Else
                        MessageBox.Show("Registros dañados.", "Error en registros.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End
                    End If
                Else
                    Return False
                End If
            Else
                keyvalue.SetValue("Instalacion", Date.Now.ToShortDateString, Microsoft.Win32.RegistryValueKind.String)
                key.SetValue("Optimizacion", Now.AddDays(30).ToShortDateString, Microsoft.Win32.RegistryValueKind.String)
                Return False
            End If
        End Function

        Private Sub Inicio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Startup
            If ver_activacion() Then
                MainFormulario()
            Else
                Dim KeyValue As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser _
                                                              .OpenSubKey("Software\MS License Key")
                If KeyValue.GetValue("DTU") Is Nothing Then
                    Dim FormActivar As New Activador.Activacion
                    MainForm = FormActivar
                Else
                    Dim dFin As Date = getFecha()
                    Dim Ahora As Date = Now.ToShortDateString
                    Dim dFalt As Long = DateDiff("d", Ahora, dFin)
                    If dFalt > 2 Then
                        MainFormulario()
                    ElseIf dFalt = 2 Then
                        MsgBox("Faltan 2 días para que termine el periodo de prueba", MsgBoxStyle.Information, _
                               "Días restantes")
                        MainFormulario()
                    ElseIf dFalt = 1 Then
                        MsgBox("Faltan 1 días para que termine el periodo de prueba", MsgBoxStyle.Information, _
                               "Días restantes")
                        MainFormulario()
                    ElseIf dFin = Date.Now.ToShortDateString Then
                        MsgBox("Ultimo día para que termine el periodo de prueba", MsgBoxStyle.Information, _
                               "Días restantes")
                        MainFormulario()
                    Else
                        Dim FormActivar As New Activador.Activacion
                        MainForm = FormActivar
                    End If
                End If
            End If
        End Sub

        Private Sub MainFormulario()
            Dim status_Me As Process() = Process.GetProcessesByName("Monografias")
            If status_Me.Length > 1 Then
                MsgBox("Ya esta abierto el sistema", MsgBoxStyle.Critical)
                End
            End If
            Dim status_mysql As Process() = Process.GetProcessesByName("mysqld")
            If status_mysql.Length <> 0 Then
                cnx.ConnectionString = "server=127.0.0.1;port=3306;UId=root;database=laminas"
            Else
                Me.MainForm = Cnx_Remota
            End If
        End Sub

        Public Sub Exp_NC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.UnhandledException
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
        Function getMacRegistro()
            Dim Key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser _
                                                          .OpenSubKey("Software\MS License Key")
            Dim MacKey As String = Nothing
            Dim KeyValue As String = Key.GetValue("Activado")
            Dim num As Integer = CInt(KeyValue.Substring(0, KeyValue.IndexOf("@")))
            KeyValue = KeyValue.Remove(0, KeyValue.IndexOf("@") + 1)
            For i As Integer = 0 To KeyValue.Length - 1
                MacKey &= Chr(Asc(KeyValue.Chars(0)) - num)
                KeyValue = KeyValue.Remove(0, 1)
            Next
            Return MacKey
        End Function

        Function getFecha() As Date
            Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser. _
            OpenSubKey("Software\MS License Key", True)
            Dim NumSer As Integer = getNumId(getMacAddress)
            Dim keyValue As String = key.GetValue("DTU")
            Dim sFecha As String = Nothing
            For i As Integer = 0 To keyValue.Length - 1
                sFecha &= Chr(Asc(keyValue.Chars(i)) - NumSer)
            Next
            Return CDate(sFecha)
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