Imports System.IO
Imports Microsoft.Win32

Public Class Cambio_Lic

    Private Sub Load_CambioLic(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Ico

    End Sub

    Private Sub btnKcm_click(sender As System.Object, e As System.EventArgs) Handles btnSearchKcm.Click
        Dim oFileDialog As New OpenFileDialog()
        oFileDialog.Filter = "Licencia de activación |*.kcm"
        oFileDialog.Multiselect = False
        If oFileDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtPathKcm.Text = oFileDialog.FileName
        End If
    End Sub
    Private Sub btnSearchPkm_Click(sender As Object, e As System.EventArgs) Handles btnSearchPkm.Click
        Dim oFileDialog As New OpenFileDialog()
        oFileDialog.Filter = "Petición de licencia |*.pkm"
        oFileDialog.Multiselect = False
        If oFileDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtPathPkm.Text = oFileDialog.FileName
        End If
    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As System.EventArgs) Handles btnSwitch.Click
        Dim pKcm As Boolean = False
        Dim pPkm As Boolean = False
        'Pruebas para Kcm
        If File.Exists(txtPathKcm.Text) Then
            Dim nPunto As Integer = txtPathKcm.Text.LastIndexOf(".")
            If nPunto > -1 Then
                If txtPathKcm.Text.Substring(nPunto) = ".kcm" Then
                    pKcm = True
                Else
                    MsgBox("La extención no es .kcm")
                End If
            Else
                MsgBox("No tiene extención")
            End If
        Else
            MsgBox("No existe el archivo")
        End If

        If pKcm Then
            'Pruebas para Pkm
            If File.Exists(txtPathPkm.Text) Then
                Dim nPunto As Integer = txtPathPkm.Text.LastIndexOf(".")
                If nPunto > -1 Then
                    If txtPathPkm.Text.Substring(nPunto) = ".pkm" Then
                        pPkm = True
                    Else
                        MsgBox("La extención no es .pkm")
                    End If
                Else
                    MsgBox("No tiene extención")
                End If
            Else
                MsgBox("No existe el archivo")
            End If

            'En caso de contener los archivos correctos.
            If pPkm Then
                Switch()
            End If
        End If
    End Sub
    Private Sub Switch()
        Dim nNumSer As Integer = Nothing 'Nuevo numero de servicio
        Dim nInicio As Integer = Nothing
        Dim nFin As Integer = Nothing
        Dim nMacId As String = Nothing 'MacId de la nueva maquina
        Dim kInfo As String = Nothing 'Información de la licencia
        Dim pInfo As String = Nothing 'Información de la petición
        'Lectura de la información de la licencia
        Dim skInfoPath As New StreamReader(txtPathKcm.Text)
        kInfo = skInfoPath.ReadToEnd
        skInfoPath.Close()
        'Lectura de la información de la petición
        Dim spInfoPath As New StreamReader(txtPathPkm.Text)
        pInfo = spInfoPath.ReadToEnd
        spInfoPath.Close()
        'Descriptación de la información de los dos archivos
        kInfo = Descriptar(kInfo, NumSer)
        pInfo = Descriptar(pInfo, 100)

        'Extraer nuevo mac y numero de servicio
        nInicio = pInfo.IndexOf("<MacId>") + 7
        nFin = pInfo.IndexOf("</MacId>")
        'En caso de no tener daño las etiquetas de la petición
        If nFin > -1 Then
            'Extracción de la nueva MacId y del nuevo NumSer
            nMacId = pInfo.Substring(nInicio, nFin - nInicio)
            nNumSer = getNumId(nMacId)
            'Extraer la MacId de la maquina actual
            nInicio = kInfo.IndexOf("<MacId>") + 7
            nFin = kInfo.IndexOf("</MacId>")
            'En caso de tener dañada la etiqueta de la MacId de la licencia
            If nFin > -1 Then
                'Reemplazo de la MacId
                kInfo = kInfo.Replace(kInfo.Substring(nInicio, nFin - nInicio), nMacId)
                'Remplazo del NumSer
                kInfo = Encriptar(kInfo, nNumSer)
                If pInfo.IndexOf("<ValAct>") > -1 Then
                    kInfo &= pInfo.Substring(pInfo.IndexOf("<ValAct>"))
                End If
                'Eliminación de archivos inservibles
                File.Delete(txtPathKcm.Text)
                File.Delete(txtPathPkm.Text)
                'Creación de la licencia transferida
                Dim sKeyNew As Stream = File.Create(txtPathKcm.Text)
                Dim swKeyNew As New StreamWriter(sKeyNew, System.Text.Encoding.UTF8)
                swKeyNew.Write(kInfo)
                swKeyNew.Close()
                sKeyNew.Close()
                'Subrutina para modificar los registros necesarios para la desactivación del producto en el equipo actual
                Mod_Registros()
            Else
                MsgBox("Etiqueta dañada en la licencia.", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Etiqueta dañada en el archivo de petición")
        End If
    End Sub
    Private Sub Mod_Registros()
        Dim regMS As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key", True)
        Dim regIA As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key\IA", True)
        regMS.DeleteValue("Activado")
        regIA.DeleteValue("DateAct")
        txtPathKcm.Text = ""
        txtPathPkm.Text = ""
        MsgBox("Cambio de licencia completado", MsgBoxStyle.Exclamation)
        Me.Close()
        End
    End Sub
End Class