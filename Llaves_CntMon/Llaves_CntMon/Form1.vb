Imports System.IO

Public Class Form1

    Dim InfAct As String = "Información actual..."
    Dim InfMod As String = "Información actualizada..."
    Dim User As String = Nothing

    Public Sub Load_Form1(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.llave_act1
        btnPathSol.AutoEllipsis = True
        btnValidar.Enabled = False
        Panel1.BackColor = Color.FromArgb(50, Color.Black)
    End Sub

    Private Sub btnPathSol_Click(sender As System.Object, e As System.EventArgs) Handles btnPathSol.Click
        Dim oFile As New OpenFileDialog()
        oFile.Filter = "Petición de llave |*.pkm| Llave|*.kcm"
        oFile.Multiselect = False
        If oFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtPathPKM.Text = oFile.FileName
        Else
            MsgBox("Busqueda cancelada")
        End If
    End Sub

    Private Sub txtChange_txtPath(ByVal sender As Object, ByVal e As EventArgs) Handles txtPathPKM.TextChanged
        btnValidar.Enabled = False
    End Sub

    Private Sub btnVal_Click(sender As System.Object, e As System.EventArgs) Handles btnVal.Click
        If File.Exists(txtPathPKM.Text) Then
            Dim nPunto As Integer = txtPathPKM.Text.LastIndexOf(".")
            If nPunto > -1 Then
                If txtPathPKM.Text.Substring(nPunto) = ".pkm" Then
                    Verificar()
                ElseIf txtPathPKM.Text.Substring(nPunto) = ".kcm" Then
                    VerificarKcm()
                Else
                    MsgBox("El archivo no es una petición de llave")
                End If
            Else
                MsgBox("El archivo no tiene extención")
            End If
        Else
            MsgBox("El archivo no existe")
        End If
    End Sub
    Private Sub Verificar()
        Dim sReadPKM As New StreamReader(txtPathPKM.Text)
        Dim inf As String = sReadPKM.ReadToEnd
        Dim vActivado As Boolean = Nothing
        Dim vVersion As Boolean = Nothing
        Dim vMacId As Boolean = Nothing

        sReadPKM.Close()
        inf = Descriptar(inf, 100)
        lblInfo.Text = InfAct & vbCr
        lblInfo.Text &= inf

        'Validar integridad de la etiqueta Activado
        Dim nInicio As Integer = inf.IndexOf("<Activado>") + 10
        Dim nFin As Integer = inf.IndexOf("</Activado>")
        If nInicio > -1 And nFin > -1 Then
            If inf.Substring(nInicio, nFin - nInicio) = "False" Then
                vActivado = True
            End If
        End If
        'Validar integridad de la etiqueta Version
        nInicio = inf.IndexOf("<Version>")
        nFin = inf.IndexOf("</Version>")
        If nInicio > -1 And nFin > -1 Then
            vVersion = True
        End If
        'Validar integridad de la etiqueta MacId
        nInicio = inf.IndexOf("<MacId>")
        nFin = inf.IndexOf("</MacId>")
        If nInicio > -1 And nFin > -1 Then
            vMacId = True
        End If
        If vActivado And vVersion And vMacId Then
            btnValidar.Enabled = True
            'Extraer nombre
            User = txtPathPKM.Text
            User = User.Remove(0, User.LastIndexOf("\") + 1)
            User = User.Remove(User.IndexOf("."), 4)
        End If
    End Sub
    Private Sub VerificarKcm()
        Dim mac As String = InputBox("Id equipo (MacId): ", "MacId")
        If mac <> "" Then
            Dim sReadKCM As New StreamReader(txtPathPKM.Text)
            Dim NumServ As Integer = getNumId(mac)
            Dim info As String = sReadKCM.ReadToEnd
            info = Descriptar(info, NumServ)
            lblInfo.Text = InfAct & info
            sReadKCM.Close()
        Else
            MsgBox("Cancelado...")
        End If
    End Sub

    Private Sub btnValidar_Click(sender As System.Object, e As System.EventArgs) Handles btnValidar.Click
        lblInfo.Text = lblInfo.Text.Remove(0, InfAct.Length)
        lblInfo.Text &= vbCr & _
            "<Verificado>" & Date.Now.ToShortDateString & "</Verificado>" & vbCr & _
            "<NamePc>" & Environment.UserName & "</NamePc>"

        Dim LimitPath As Integer = txtPathPKM.Text.LastIndexOf("\")
        Dim path As String = txtPathPKM.Text.Substring(0, LimitPath + 1)
        path &= "Llave " & User & ".kcm"
        Dim sFileNew As Stream = File.Create(path)
        Dim swFileNew As New StreamWriter(sFileNew, System.Text.Encoding.UTF8)
        Dim NumMacId As Integer = Nothing
        Dim nInicio As Integer = lblInfo.Text.IndexOf("<MacId>") + 7
        Dim nFin As Integer = lblInfo.Text.IndexOf("</MacId>")
        If nFin > -1 Then
            NumMacId = getNumId(lblInfo.Text.Substring(nInicio, nFin - nInicio))
        End If
        swFileNew.Write(Encriptar(lblInfo.Text, NumMacId))
        swFileNew.Close()
        sFileNew.Close()

        lblInfo.Text = InfMod & lblInfo.Text
        MsgBox("Llave generada en: " & path)
    End Sub
End Class
