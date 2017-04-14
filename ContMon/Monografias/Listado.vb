Imports MySql.Data.MySqlClient

Public Class Listado

    Private Sub Load_Me(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Ico
        Me.MaximizeBox = False
        Deps()
    End Sub

    Private Sub Deps()
        BoxDep.Items.Clear()
        BoxDep.Items.Add("Ver minimos y agotados")
        For i As Integer = 0 To Dep.Length - 2
            BoxDep.Items.Add(Dep(i))
        Next
        If BoxDep.Items.Count <> 0 Then
            BoxDep.Text = BoxDep.Items.Item(0)
        End If
    End Sub

    Private Sub Click_Ver(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Dim sql As String = Nothing
        Dim dt As New DataTable
        If BoxDep.Text = "Ver minimos y agotados" Then
            sql = "SELECT lam.nombre as 'Nombre', lam.num as 'Posicion', lam.dep as 'Departamento' FROM laminas as lam, inventarios as inv " _
                & "WHERE inv.id_lamina = lam.id AND inv.actual < inv.min ORDER BY num"
        Else
            sql = "SELECT nombre as 'Nombre', num as 'Posicion' FROM laminas WHERE dep = '" & BoxDep.Text & "'" _
                                & "ORDER BY num"
        End If
        Try
            Dim cmd As New MySqlDataAdapter(sql, cnx)
            cnx.Open()
            cmd.Fill(dt)
            DataGridView1.DataSource = dt
            cnx.Close()
            DataGridView1.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridView1.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Catch ex As Exception
            cnx.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class