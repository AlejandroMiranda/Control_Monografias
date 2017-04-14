Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.Win32
Imports System.IO

Module Mod_Global

    Public cnx As New MySqlConnection
    Public Dep() As String = Nothing
    Public sBusqueda As String = Nothing
    Public cBusqueda As Boolean = False

    'Subrutina para buscar que la configuracion del mysql sea la adecuada
    Public Sub Conf_MySQL()
        Dim Key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Cnt Monografias", True)
        If Key.GetValue("My_MySQL") Is Nothing Then
            Dim Stream As Stream = Nothing
            Dim wStream As StreamWriter = Nothing
            If File.Exists("C:\xampp\mysql\bin\my.ini") Then
                Key.SetValue("My_MySQL", 1, RegistryValueKind.DWord)
                File.Delete("C:\xampp\mysql\bin\my.ini")
                Stream = File.Create("C:\xampp\mysql\bin\my.ini")
                wStream = New StreamWriter(Stream, System.Text.Encoding.Default)
                wStream.Write(My.Resources.my_mysql)
                wStream.Close()
            Else
                Key.SetValue("My_MySQL", 0, RegistryValueKind.DWord)
            End If
        Else
            Dim status_mysql As Process() = Process.GetProcessesByName("mysqld")
            If Key.GetValue("My_MySQL") = 0 And status_mysql.Length <> 0 Then
                Dim Stream As Stream = Nothing
                Dim wStream As StreamWriter = Nothing
                File.Delete("C:\xampp\mysql\bin\my.ini")
                Stream = File.Create("C:\xampp\mysql\bin\my.ini")
                wStream = New StreamWriter(Stream, System.Text.Encoding.Default)
                wStream.Write(My.Resources.my_mysql)
                wStream.Close()
                Key.DeleteValue("My_MySQL")
                Key.SetValue("My_MySQL", 1, RegistryValueKind.DWord)
            End If
        End If
    End Sub

    'convertir binario a imágen
    Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'Convertir imágen a binario
    Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    'Extraer limites de laminas
    'Public Sub Limites_Num()
    '    Dim Sql As String = "SELECT COUNT(*) FROM laminas"
    '    Dim cmd As New MySqlCommand(Sql, cnx)
    '    Try
    '        cnx.Open()
    '        Dim Lectura As MySqlDataReader = cmd.ExecuteReader
    '        If Lectura.Read Then
    '            If Lectura(0) <> 0 Then
    '                Modificar.num1.Maximum = CInt(Lectura(0))
    '                Modificar.num2.Maximum = CInt(Lectura(0))
    '                Modificar.NumUp.Maximum = CInt(Lectura(0))
    '                DeleteLaminas.num1.Maximum = CInt(Lectura(0))
    '                DeleteLaminas.num2.Maximum = CInt(Lectura(0))
    '                DeleteLaminas.NumUp.Maximum = CInt(Lectura(0))
    '            Else
    '                Modificar.NumUp.Maximum = 1
    '                Modificar.num2.Maximum = 1
    '                Modificar.num1.Maximum = 1
    '                DeleteLaminas.NumUp.Maximum = 1
    '                DeleteLaminas.num2.Maximum = 1
    '                DeleteLaminas.num1.Maximum = 1
    '            End If
    '        Else
    '            Modificar.NumUp.Maximum = 1
    '            Modificar.num2.Maximum = 1
    '            Modificar.num1.Maximum = 1
    '            DeleteLaminas.NumUp.Maximum = 1
    '            DeleteLaminas.num2.Maximum = 1
    '            DeleteLaminas.num1.Maximum = 1
    '        End If
    '        cnx.Close()
    '    Catch ex As Exception
    '        cnx.Close()
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    'Extraer Departamento

    Public Sub Departamentos()
        ReDim Dep(0)
        Dim sql As String = "SELECT DISTINCT dep FROM laminas ORDER BY dep"
        Dim cmd As New MySqlCommand(sql, cnx)
        Try
            cnx.Open()
            Dim lectura As MySqlDataReader = cmd.ExecuteReader
            Dim i As Integer = Nothing
            Do While lectura.Read
                Dep(i) = lectura("dep").ToString
                i += 1
                ReDim Preserve Dep(i)
            Loop
            cnx.Close()
        Catch mysqlExeption As MySqlException
            If mysqlExeption.Message = "Authentication to host '127.0.0.1' for user 'root' using method 'mysql_native_password' failed with message: Unknown database 'laminas'" _
                Or mysqlExeption.Message = "Table 'laminas.laminas' doesn't exist" Then
                Crear_BD()
            End If
        Catch ex As Exception
            cnx.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Crear la base de datos si no existe
    Private Sub Crear_BD()
        Dim sqlDB As String = "CREATE DATABASE IF NOT EXISTS laminas;"
        Dim sqlCnx As String = "server=localhost;port=3306;uid=root;database=laminas"
        Dim conec As New MySqlConnection("server=localhost;port=3306;uid=root")
        Dim cmd As New MySqlCommand(sqlDB, conec)
        conec.Open()
        cmd.ExecuteNonQuery()
        conec.Close()
        conec.ConnectionString = sqlCnx
        cmd.CommandText = My.Resources.Estructura
        conec.Open()
        cmd.ExecuteNonQuery()
        conec.Close()
    End Sub

    'Optimizacion de la base de datos
    Public Sub Opt_BD()
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Cnt Monografias", True)
        If key.GetValue("Optimizacion") IsNot Nothing Then
            Dim dReg As Date = CDate(key.GetValue("Optimizacion"))
            If dReg = Now.ToShortDateString Then
                Dim sql As String = "OPTIMIZE TABLE laminas"
                Dim cmd As New MySqlCommand(sql, cnx)
                cnx.Open()
                cmd.ExecuteNonQuery()
                cnx.Close()
                key.DeleteValue("Optimizacion")
                key.SetValue("Optimizacion", Now.AddDays(30).ToShortDateString, RegistryValueKind.String)
            End If
        Else
            key.SetValue("Optimizacion", Now.AddDays(30).ToShortDateString, RegistryValueKind.String)
        End If
    End Sub

End Module
