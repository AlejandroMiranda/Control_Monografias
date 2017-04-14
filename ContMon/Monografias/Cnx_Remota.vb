Imports System.Net.Sockets

Public Class Cnx_Remota

    Dim cnx_remot As Boolean = False

    Private Sub Load_Form(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.MaximizeBox = False
    End Sub

    Private Sub btnCnx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCnx.Click
        Cursor = Cursors.WaitCursor
        cnx_remot = False
        If btnCnx.Text = "Prueba" Then
            cnx.ConnectionString = ""
            cnx.ConnectionString = "server=" & TextBox1.Text & ";port=3306;UId=root;database=laminas"
            Try
                cnx.Open()
                cnx.Close()
                MsgBox("Conexión exitosa", MsgBoxStyle.Information)
                btnCnx.Text = "Conectar"
            Catch ex As Exception
                MsgBox("No se pudo hacer la conexión", MsgBoxStyle.Critical)
                cnx_remot = False
            End Try
        Else
            cnx_remot = True
            principal.BaseDeDatosToolStripMenuItem1.Visible = False
            principal.Clearing()
            Me.Close()
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub Closed_Me(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        If cnx_remot Then
            Base_Datos.Close()
            principal.Show()
            principal.Focus()
        End If
    End Sub
End Class