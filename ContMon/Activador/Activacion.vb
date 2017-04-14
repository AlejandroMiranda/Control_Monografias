Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Imports System.IO

Public Class Activacion

    Private Sub Loas_Activacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Ico
        btnSolicitud.Tag = "1"
        Me.MaximizeBox = False
        NumSer = getNumId(getMacAddress)
        If pathCommandLine <> "" Then
            txtPathFile.Text = pathCommandLine
        End If

        Dim RegistryValue As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key")
        If RegistryValue.GetValue("Activado") Is Nothing Then
            lblId.Visible = False
            If RegistryValue.GetValue("DTU") IsNot Nothing Then
                btnPrueba.Enabled = False
                btnPrueba.Text = "Periodo de prueba activada"
                Dim fReg As Date = getDateReg()
                Dim Ahora As Date = Now.ToShortDateString
                Dim dias As Long = DateDiff(DateInterval.Day, Ahora, fReg)
                If dias > 0 Then
                    lblDias.Text = "Queda: " & dias & " Días."
                    lblDias.Visible = True
                ElseIf dias = 0 Then
                    lblDias.Text = "Ultimo día."
                    lblDias.Visible = True
                Else
                    lblDias.Text = "Prueba terminada."
                    lblDias.Visible = True
                End If
            End If
        Else
            lblId.Text = "Id:" & getMacAddress()
            lblId.Visible = True
            GroupBox1.Text = "Opción para desactivar"
            Label1.ForeColor = Color.Red
            Label1.Text = "¡Activado!"
            btnSearchFile.Enabled = False
            btnActivar.Enabled = False
            txtPathFile.Enabled = False
            btnPrueba.Enabled = False
            btnSolicitud.Tag = "2"
            btnSolicitud.Text = "Solicitar Cambio"
        End If
    End Sub
    Private Function getDateReg() As Date
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key")
        Dim KeyValue As String = key.GetValue("DTU")
        Dim sFecha As String = Nothing
        For i As Integer = 0 To KeyValue.Length - 1
            sFecha &= Chr(Asc(KeyValue.Chars(i)) - NumSer)
        Next
        Return CDate(sFecha)
    End Function

    Private Sub Click_btnPrueba(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrueba.Click
        If MessageBox.Show("¿Activar los 90 días de prueba?", "Prueba", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                           MessageBoxDefaultButton.Button2) = vbYes Then
            Cursor = Cursors.WaitCursor
            Dim Fecha As String = Now.AddDays(90).ToShortDateString
            Dim sFecha As String = Nothing
            For i As Integer = 0 To Fecha.Length - 1
                sFecha &= Chr(Asc(Fecha.Chars(i)) + NumSer)
            Next
            Dim KeyValue As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key", True)
            KeyValue.SetValue("DTU", sFecha, RegistryValueKind.String)
            lblDias.Text = "Quedan: 90 Días"
            lblDias.Visible = True
            Cursor = Cursors.Default
            Me.Close()
        End If
    End Sub

    Private Sub Click_btnBuscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchFile.Click
        Dim oFile As New OpenFileDialog()
        oFile.Multiselect = False
        oFile.CheckFileExists = True
        oFile.CheckFileExists = True
        oFile.Filter = "Licencia de activación |*.kcm"
        If oFile.ShowDialog <> vbCancel Then
            txtPathFile.Text = oFile.FileName
        End If
    End Sub

    Private Sub Click_btnSolicitud(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolicitud.Click
        If btnSolicitud.Tag = "1" Then
            SolicitudActivar()
        ElseIf btnSolicitud.Tag = "2" Then
            Cambio_Lic.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Click_Activar(ByVal sender As Object, ByVal e As EventArgs) Handles btnActivar.Click
        Cursor = Cursors.WaitCursor
        Try
            If File.Exists(txtPathFile.Text) Then
                Dim punto As Integer = txtPathFile.Text.LastIndexOf(".")
                If punto > -1 Then
                    If txtPathFile.Text.Substring(punto) = ".kcm" Then
                        activar()
                    Else
                        MsgBox("La extención es incorrecta")
                    End If
                Else
                    MsgBox("El archivo no tiene extención")
                End If
            Else
                MsgBox("No existe el archivo")
            End If
        Catch exp As Exception
            MessageBox.Show("Error no controlado en la activación." & vbCr & _
                            exp.Message, "Error en activación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Cursor = Cursors.Default
        End Try
        Cursor = Cursors.Default
    End Sub
    Private Sub activar()
        Dim sReadKey As New StreamReader(txtPathFile.Text)
        Dim infoKey As String = sReadKey.ReadToEnd
        sReadKey.Close()
        infoKey = Descriptar(infoKey, NumSer)
        Dim nInicio As Integer = Nothing
        Dim nFin As Integer = Nothing
        Dim eNamePc, eVersion, eMacId, eActivado, eVerificado As Boolean
        eNamePc = eVersion = eMacId = eActivado = eVerificado = False

        'Verificar etiqueta Activado
        nInicio = infoKey.IndexOf("<Activado>")
        nFin = infoKey.IndexOf("</Activado>")
        If nInicio > -1 And nFin > -1 Then
            eActivado = True
        End If

        'Verificar etiqueta Version
        nInicio = infoKey.IndexOf("<Version>")
        nFin = infoKey.IndexOf("</Version>")
        If nInicio > -1 And nFin > -1 Then
            eVersion = True
        End If

        'Verificar etiqueta MacId
        nInicio = infoKey.IndexOf("<MacId>")
        nFin = infoKey.IndexOf("</MacId>")
        If nInicio > -1 And nFin > -1 Then
            eMacId = True
        End If

        'Verificar etiqueta Verificado
        nInicio = infoKey.IndexOf("<Verificado>")
        nFin = infoKey.IndexOf("</Verificado>")
        If nInicio > -1 And nFin > -1 Then
            eVerificado = True
        End If

        'Verificar etiqueta MacId
        nInicio = infoKey.IndexOf("<NamePc>")
        nFin = infoKey.IndexOf("</NamePc>")
        If nInicio > -1 And nFin > -1 Then
            eNamePc = True
        End If

        If eActivado And eMacId And eVerificado And eVersion And eNamePc Then
            act_Activador(infoKey)
        Else
            MsgBox("Error con el activador." & vbCr & _
                   "Posible falla en etiquetas.", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub act_Activador(inf As String)
        'Verificar que las versiones coincidan.
        Dim version As String = My.Application.Info.Version.ToString
        Dim nPrimario As Integer = version.Substring(0, version.IndexOf("."))
        version = version.Remove(0, version.IndexOf(".") + 1)
        Dim nSecundario As Integer = version.Substring(0, version.IndexOf("."))
        Dim kVersion As String = inf.Substring(inf.IndexOf("<Version>") + 9, inf.IndexOf("</Version>"))
        Dim nkPrimario As Integer = kVersion.Substring(0, kVersion.IndexOf("."))
        kVersion = kVersion.Remove(0, kVersion.IndexOf(".") + 1)
        Dim nkSecundario As Integer = kVersion.Substring(0, kVersion.IndexOf("."))
        'Verificar el valor de las versiones
        If nPrimario = nkPrimario And nSecundario = nkSecundario Then
            Dim regValAct As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key\IA", True)
            If regValAct Is Nothing Then
                Mod_Registros(inf)
            Else
                Dim nInicio As Integer = inf.IndexOf("<Activado>") + 10
                Dim kActivado As String = inf.Substring(nInicio, 4)
                If kActivado = "True" Then
                    Mod_Registros(inf)
                Else
                    If inf.IndexOf("<ValAct>") > -1 Then
                        ModActivador()
                        Mod_Registros(inf)
                    Else
                        MsgBox("Licencia dañada.", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Else
            MsgBox("La versión del sistema y de la licencia no coinciden.", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub Mod_Registros(inf As String)
        inf = inf.Replace("False", "True")
        Dim RegistroMs As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key", True)
        Dim RegistroIA As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key\IA", True)
        RegistroMs.SetValue("Activado", NumSer & "@" & Encriptar(getMacAddress, NumSer), RegistryValueKind.String)
        If RegistroMs.GetValue("DTU") Is Nothing Then
            RegistroMs.SetValue("DTU", Encriptar(Date.Now.ToShortDateString, NumSer), RegistryValueKind.String)
        End If
        If RegistroIA Is Nothing Then
            RegistroMs.CreateSubKey("IA")
            RegistroIA = Registry.CurrentUser.OpenSubKey("Software\MS License Key\IA", True)
        End If
        RegistroIA.SetValue("ValAct", "True", RegistryValueKind.String)
        RegistroIA.SetValue("DateAct", Date.Now.ToShortDateString, RegistryValueKind.String)
        File.Delete(txtPathFile.Text)
        Dim sInfo As Stream = File.Create(txtPathFile.Text)
        Dim SwInfo As New StreamWriter(sInfo, System.Text.Encoding.UTF8)
        SwInfo.Write(Encriptar(inf, NumSer))
        SwInfo.Close()
        sInfo.Close()
        MessageBox.Show("Producto Activado!", "Activado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub SolicitudActivar()
        Dim oFolder As New FolderBrowserDialog()
        MsgBox("Seleccione la carpeta donde se generará el archivo de solicitud", MsgBoxStyle.Information, "Solicitud")
        If oFolder.ShowDialog <> vbCancel Then
            Dim uName As String = Environment.UserName
            Dim sVer As String = My.Application.Info.Version.ToString
            Dim sActv As String = Nothing
            Dim rValAct As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key\IA", False)
            If rValAct Is Nothing Then
                sActv = "False"
            Else
                sActv = "True"
            End If
            Dim uIdBoard As String = getMacAddress()
            Dim Info As String = "<Activado>" & sActv & "</Activado>" & vbCr & _
            "<Version>" & sVer & "</Version>" & vbCr & _
            "<MacId>" & uIdBoard & "</MacId>"
            Dim valact As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key\IA", True)
            If valact.GetValue("ValAct") IsNot Nothing Then
                Info &= "<ValAct>" & valact.GetValue("ValAct") & "</ValAct>"
            End If
            Dim nStream As Stream = Nothing
            Dim wStream As StreamWriter = Nothing
            nStream = File.Create(oFolder.SelectedPath & "\" & uName & ".pkm")
            wStream = New StreamWriter(nStream, System.Text.Encoding.UTF8)
            wStream.Write(Encriptar(Info, 100))
            wStream.Close()
            MsgBox("Solicitud Creada en: " & oFolder.SelectedPath, MsgBoxStyle.Information, "Solicitud")
        Else
            MsgBox("Solicitud Cancelada", MsgBoxStyle.Information, "Solicitud")
        End If
    End Sub
    Private Sub ModActivador()
        Dim sReadKey As New StreamReader(txtPathFile.Text)
        Dim nStream As Stream = Nothing
        Dim sWrite As StreamWriter = Nothing
        Dim infoKey As String = sReadKey.ReadToEnd
        sReadKey.Close()
        infoKey = Descriptar(infoKey, NumSer)
        infoKey = infoKey.Remove(infoKey.IndexOf("<ValAct>"))
        nStream = File.Create(txtPathFile.Text)
        sWrite = New StreamWriter(nStream, System.Text.Encoding.UTF8)
        sWrite.Write(Encriptar(infoKey, NumSer))
        sWrite.Close()
    End Sub
End Class