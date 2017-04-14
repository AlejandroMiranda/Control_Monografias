Imports MySql
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim cnx As New MySqlConnection()

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        cnx.ConnectionString = "server=127.0.0.1;port=3306;Uid=root;database=laminas"
    End Sub

    Private Sub Click_Button1(sender As Object, e As EventArgs) Handles Button1.Click
        'Obtener valores
        Dim sqlExt As String = "SELECT id FROM laminas"
        Dim dTable As New DataTable
        Dim dAdaprte As New MySqlDataAdapter
        Dim dSet As New DataSet
        Dim cmd As New MySqlCommand(sqlExt, cnx)
        cnx.Open()
        dAdaprte.SelectCommand = cmd
        dAdaprte.Fill(dSet)
        dTable = dSet.Tables(0)
        cnx.Close()

        'Definir tamaño para el ProgressBar
        ProgressBar1.Maximum = dTable.Rows.Count
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0

        'Ingresar información en tabla inventarios
        Dim id As String = Nothing
        Dim sqlInsert As String
        For i As Integer = 0 To dTable.Rows.Count - 1
            id = dTable.Rows(i).Item(0).ToString
            sqlInsert = "INSERT INTO inventarios(id_lamina,min,actual) VALUE (" & id & ",null,null)"
            cmd.CommandText = sqlInsert
            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()
            ProgressBar1.Value += 1
        Next
    End Sub
End Class
