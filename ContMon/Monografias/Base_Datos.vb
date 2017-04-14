Imports MySql.Data.MySqlClient
Imports System.ServiceProcess
Imports Microsoft.Win32
Imports System.IO

Public Class Base_Datos

    Private Sub Load_BaseDatos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Ico
        Me.MaximizeBox = False
        btnExp.Enabled = False
        btnImp.Enabled = False
        Dim Srv As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Cnt Monografias")
        If Srv.GetValue("Server") = 1 Then
            btnServer.Text = "Desactivar modo servidor"
        End If
    End Sub

    Private Sub btnPathExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathExp.Click
        Try
            Dim folder As New FolderBrowserDialog()
            folder.ShowDialog()
            txtPathExp.Text = folder.SelectedPath
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub Click_btnExp(ByVal sender As System.Object, e As System.EventArgs) Handles btnExp.Click
        Try
            Cursor = Cursors.WaitCursor
            Me.Enabled = False
            Dim cmd As New Process()
            Dim path As String = txtPathExp.Text
            'Shell("cmd.exe /c c:/xampp/mysql/bin/mysqldump -u root -B laminas > " & Chr(34) & path & "\laminas.sql" & Chr(34) & " -silent", AppWinStyle.Hide, True)
            With cmd.StartInfo
                .UseShellExecute = False
                .WindowStyle = ProcessWindowStyle.Hidden
                .RedirectStandardOutput = True
                .RedirectStandardError = False
                .CreateNoWindow = True
                .FileName = "cmd.exe"
                .Arguments = " /c c:/xampp/mysql/bin/mysqldump -u root -B laminas > " & Chr(34) & path & "\laminas.sql" & Chr(34)
                .WorkingDirectory = "C:\Windows\System32\"
            End With
            cmd.Start()
            cmd.WaitForExit()
            Cursor = Cursors.Default
            Me.Enabled = True
            MsgBox("Base exportada en " & txtPathExp.Text, MsgBoxStyle.Information, "Exportación")
            txtPathExp.Text = ""
        Catch ex As Exception
            Cursor = Cursors.Default
            Me.Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub btnPathImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathImp.Click
        Dim File As New OpenFileDialog()
        File.CheckFileExists = True
        File.CheckFileExists = True
        File.Filter = "Respaldo MySQL |*.sql"
        File.Multiselect = False
        If File.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtPathImp.Text = File.FileName
        End If
    End Sub

    Private Sub btnImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImp.Click
        Try
            Cursor = Cursors.WaitCursor
            Me.Enabled = False
            If My.Computer.FileSystem.FileExists(txtPathImp.Text) Then
                'Shell("cmd.exe /c c:/xampp/mysql/bin/mysql -u root -B laminas < " & Chr(34) & txtPathImp.Text & Chr(34), AppWinStyle.Hide, True)
                Dim cmd As New Process()
                With cmd.StartInfo
                    .UseShellExecute = False
                    .WindowStyle = ProcessWindowStyle.Hidden
                    .RedirectStandardOutput = True
                    .RedirectStandardError = False
                    .CreateNoWindow = True
                    .FileName = "cmd.exe"
                    .Arguments = "/c c:/xampp/mysql/bin/mysql -u root -B laminas < " & Chr(34) & txtPathImp.Text & Chr(34)
                    .WorkingDirectory = "C:\Windows\System32\"
                End With
                cmd.Start()
                cmd.WaitForExit()
                cmd.Close()
                Departamentos()
                MsgBox("Base de datos restaudara", MsgBoxStyle.Information, "Restauración")
                txtPathImp.Text = ""
            Else
                MsgBox("No se encontro el archivo", MsgBoxStyle.Critical, "Archivo inexistente")
            End If
            Cursor = Cursors.Default
            Me.Enabled = True
        Catch ex As Exception
            Cursor = Cursors.Default
            Me.Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub btnCnxRem_Click(sender As System.Object, e As System.EventArgs) Handles btnCnxRem.Click
        Cnx_Remota.ShowDialog()
    End Sub

    Private Sub btnServer_Click(sender As System.Object, e As System.EventArgs) Handles btnServer.Click
        If btnServer.Text = "Activar modo servidor" Then
            If MessageBox.Show("¿Activar el modo Servidor?" & vbCr & _
                               "Si activa este modo se abrira el puerto 3306 que modificar la base de datos remotamente", _
                               "Modo servidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbYes Then
                Try
                    Cursor = Cursors.WaitCursor
                    Shell("C:\Program Files (x86)\Common Files\ConfMon\PortMySQL.exe", AppWinStyle.Hide, True)
                    Dim Stream As Stream = Nothing
                    Dim wStream As StreamWriter = Nothing
                    If File.Exists("C:\xampp\apache\conf\extra\httpd-xampp.conf") Then
                        File.Delete("C:\xampp\apache\conf\extra\httpd-xampp.conf")
                    End If
                    Stream = File.Create("C:\xampp\apache\conf\extra\httpd-xampp.conf")
                    wStream = New StreamWriter(Stream, System.Text.Encoding.Default)
                    wStream.Write(My.Resources.Xampp_Security)
                    wStream.Close()
                    Dim MysqlService As New ServiceController("mysql")
                    Dim ApacheService As New ServiceController("Apache2.4")
                    MysqlService.Stop()
                    MysqlService.WaitForStatus(ServiceControllerStatus.Stopped)
                    MysqlService.Start()
                    ApacheService.Stop()
                    ApacheService.WaitForStatus(ServiceControllerStatus.Stopped)
                    ApacheService.Start()
                    Dim Svr As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Cnt Monografias", True)
                    Svr.DeleteSubKey("Server", False)
                    Svr.SetValue("Server", "1", RegistryValueKind.DWord)
                    btnServer.Text = "Desactivar modo servidor"
                    Cursor = Cursors.Default
                Catch ex As Exception
                    Cursor = Cursors.Default
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
                End Try
            End If
        Else
            If MessageBox.Show("¿Desactivar el modo Servidor?" & vbCr & _
                               "Si desactiva este modo se cerrara el puerto 3306 que modificar la base de datos remotamente", _
                               "Modo servidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbYes Then
                Try
                    Cursor = Cursors.WaitCursor
                    Shell("C:\Program Files (x86)\Common Files\ConfMon\DelPortMySQL.exe", AppWinStyle.Hide, True)
                    Dim Stream As Stream = Nothing
                    Dim wStream As StreamWriter = Nothing
                    If File.Exists("C:\xampp\apache\conf\extra\httpd-xampp.conf") Then
                        File.Delete("C:\xampp\apache\conf\extra\httpd-xampp.conf")
                    End If
                    Stream = File.Create("C:\xampp\apache\conf\extra\httpd-xampp.conf")
                    wStream = New StreamWriter(Stream, System.Text.Encoding.Default)
                    wStream.Write(My.Resources.Xampp_Security_NM)
                    wStream.Close()
                    Dim MysqlService As New ServiceController("mysql")
                    Dim ApacheService As New ServiceController("Apache2.4")
                    MysqlService.Stop()
                    MysqlService.WaitForStatus(ServiceControllerStatus.Stopped)
                    MysqlService.Start()
                    ApacheService.Stop()
                    ApacheService.WaitForStatus(ServiceControllerStatus.Stopped)
                    ApacheService.Start()
                    Dim Svr As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Cnt Monografias", True)
                    Svr.DeleteSubKey("Server", False)
                    Svr.SetValue("Server", "0", RegistryValueKind.DWord)
                    btnServer.Text = "Activar modo servidor"
                    Cursor = Cursors.Default
                Catch ex As Exception
                    Cursor = Cursors.Default
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
                End Try
            End If
        End If
    End Sub

    Private Sub TextChanger_txtExp(ByVal sender As Object, ByVal e As EventArgs) Handles txtPathExp.TextChanged
        If txtPathExp.Text <> "" Then
            btnExp.Enabled = True
        Else
            btnExp.Enabled = False
        End If
    End Sub

    Private Sub TextChanged_txtImp(ByVal sender As Object, ByVal e As EventArgs) Handles txtPathImp.TextChanged
        If txtPathImp.Text <> "" Then
            btnImp.Enabled = True
        Else
            btnImp.Enabled = False
        End If
    End Sub
End Class