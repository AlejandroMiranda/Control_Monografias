Imports MySql.Data.MySqlClient

Public Class Busqueda

    Public Inventarios As Boolean = False

    Private Sub Busqueda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Ico
        Me.MaximizeBox = False
        Deps()
        Tips()
        txtShell.Focus()
    End Sub
    Private Sub Deps()
        BoxDep.Items.Clear()
        For i As Integer = 0 To Dep.Length - 2
            BoxDep.Items.Add(Dep(i))
        Next
        If BoxDep.Items.Count <> 0 Then
            BoxDep.Text = BoxDep.Items.Item(0)
        End If
    End Sub
    Private Sub Tips()
        Dim tip As New ToolTip
        tip.IsBalloon = True
        tip.SetToolTip(txtShell, "Nombre de la monografía a buscar")
        tip.SetToolTip(ChBxShellAv, "Realizar busqueda incluyendo palabras clave")
        tip.SetToolTip(BoxDep, "Departamento donde se realizará la busqueda")
        tip.SetToolTip(btnOk, "Selecciónar monografía")
        tip.SetToolTip(ListView1, "Lista de resultado de busqueda")
    End Sub

    Private Sub Cerrado(sender As Object, e As EventArgs) Handles Me.FormClosed
        Inventarios = False
        txtShell.Text = ""
    End Sub

    Private Sub DoubleClick_ListView1(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Click_btnOk(sender, e)
    End Sub
    Private Sub Click_btnOk(sender As Object, e As EventArgs) Handles btnOk.Click
        If ListView1.SelectedIndices.Count() <> 0 Then
            cBusqueda = True
            sBusqueda = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
            Me.Close()
            ListView1.Items.Clear()
            txtShell.Text = ""
        End If
    End Sub

    Private Sub ChangedChBxShellAv(sender As Object, e As EventArgs) Handles ChBxShellAv.CheckedChanged
        ChangeText_txtShell(sender, e)
    End Sub
    Private Sub ChangeText_txtShell(sender As Object, e As EventArgs) Handles txtShell.TextChanged
        ListView1.Items.Clear()
        If txtShell.Text <> "" Then
            Dim Sql As String
            Dim cmd As New MySqlCommand
            cmd.Connection = cnx
            If Inventarios Then
                If ChBxShellAv.Checked Then
                    Sql = "SELECT lam.id, lam.nombre FROM laminas as lam, inventarios as inv WHERE (lam.nombre like '" & txtShell.Text & _
                    "%' OR lam.p_clave like '%" & txtShell.Text & "%') AND lam.dep like '" & BoxDep.Text & "' AND inv.actual is not null AND inv.id_lamina = lam.id"
                Else
                    Sql = "SELECT lam.id, lam.nombre FROM laminas as lam, inventarios as inv WHERE lam.nombre like '" & txtShell.Text & _
                    "%' AND lam.dep like '" & BoxDep.Text & "' AND inv.actual is not null AND inv.id_lamina = lam.id"
                End If
            Else
                If ChBxShellAv.Checked Then
                    Sql = "SELECT id, nombre FROM laminas WHERE (nombre like '" & txtShell.Text & _
                    "%' OR p_clave like '%" & txtShell.Text & "%') AND dep like '" & BoxDep.Text & "'"
                Else
                    Sql = "SELECT id, nombre FROM laminas WHERE nombre like '" & txtShell.Text & _
                    "%' AND dep like '" & BoxDep.Text & "'"
                End If
            End If
            cmd.CommandText = Sql

            cnx.Open()
            Dim lectura As MySqlDataReader = cmd.ExecuteReader
            Dim i As Integer = 0
            Do While lectura.Read
                ListView1.Items.Add(lectura("nombre"))
                ListView1.Items(i).SubItems.Add(lectura("id"))
                i += 1
            Loop
            lectura.Close()
            cnx.Close()
        End If
    End Sub
    Private Sub ChangedText_BoxDep(sender As Object, e As EventArgs) Handles BoxDep.TextChanged
        ChangeText_txtShell(sender, e)
    End Sub
End Class