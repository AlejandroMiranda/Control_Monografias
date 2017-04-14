Imports System.IO

Public Class InfoSolicitud

    Private Sub Cargar(ByVal sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Ico
        imgProyecto.Image = My.Resources.Icono_principal
        lblIdAct.Text &= getMacAddress()
        Dim nInicio As Integer = Nothing
        Dim nFin As Integer = Nothing
        Dim Informacion As String = Nothing
        Dim sReadCommandLine As New StreamReader(pathCommandLine)
        Informacion = sReadCommandLine.ReadToEnd
        sReadCommandLine.Close()
        Informacion = Descriptar(Informacion, 100)
        lblInfo.Text = "Id del equipo: "
        nInicio = Informacion.IndexOf("<MacId>") + 7
        nFin = Informacion.IndexOf("</MacId>")
        If nFin > -1 Then
            lblInfo.Text &= Informacion.Substring(nInicio, nFin - nInicio) & vbCr
        Else
            lblInfo.Text &= "Desconocido." & vbCr
        End If
        nInicio = Informacion.IndexOf("<Version>") + 9
        nFin = Informacion.IndexOf("</Version>")
        If nFin > -1 Then
            lblInfo.Text &= "Versión del producto: " & Informacion.Substring(nInicio, nFin - nInicio)
        Else
            lblInfo.Text &= "Versión del producto: Desconocido." & vbCr
        End If
    End Sub
End Class