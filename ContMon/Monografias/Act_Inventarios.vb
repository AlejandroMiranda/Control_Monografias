Imports MySql.Data.MySqlClient

Public Class Act_Inventarios

    Dim id_lam As Integer = Nothing

    Private Sub Act_Inventarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Ico
        Me.MaximizeBox = False
        NumActual.Minimum = 0
        NumActual.DecimalPlaces = 0
        NumMinimo.Minimum = 1
        NumMinimo.DecimalPlaces = 0
        btnUpdate.Enabled = False
        Deps()
        Tips()
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
        Dim Tips As New ToolTip
        Tips.SetToolTip(btnSee, "Ver información del inventario")
        Tips.SetToolTip(btnShearch, "Buscar" & vbCr _
                        & "En caso de no conocer el nombre exacto")
        Tips.SetToolTip(btnUpdate, "Actualizar cantidades")

        Tips.SetToolTip(txtName, "Nombre exacto para obtener su información")
        Tips.SetToolTip(BoxDep, "Departamento al que pertenece")
        Tips.SetToolTip(NumActual, "Cantidad actual en inventario")
        Tips.SetToolTip(NumMinimo, "Cantidad mínima deseable en el inventario")
    End Sub

    Private Sub btnSee_Click(sender As Object, e As EventArgs) Handles btnSee.Click
        If txtName.Text <> "" Then
            Dim sql As String = "SELECT lam.id, inv.min, inv.actual FROM inventarios as inv, laminas as lam " & _
                "WHERE lam.id = inv.id_lamina AND lam.dep = @departamento AND lam.nombre = @nombre"
            Dim cmd As New MySqlCommand(sql, cnx)
            cmd.Parameters.AddWithValue("@departamento", BoxDep.Text)
            cmd.Parameters.AddWithValue("@nombre", txtName.Text)
            cnx.Open()
            Dim lectura As MySqlDataReader = cmd.ExecuteReader
            If lectura.Read Then
                If lectura("min") IsNot DBNull.Value Then
                    id_lam = lectura("id")
                    NumActual.Value = lectura("actual")
                    NumMinimo.Value = lectura("min")
                    btnUpdate.Enabled = True
                Else
                    MsgBox("'" & txtName.Text & "' no cuenta con inventario." & vbCr & _
                           "Para habilitar su inventario valla a Modificar y habilite la opcion Inventario.", _
                           MsgBoxStyle.Information, "Sin Inventario")
                End If
            Else
                MsgBox("No se encontro '" & txtName.Text & "'." & vbCr & _
                       "Revise que el nombre sea el correcto.", MsgBoxStyle.Information, "No encontrado")
            End If
            lectura.Close()
            cnx.Close()
        End If
    End Sub

    Private Sub btnShearch_Click(sender As System.Object, e As System.EventArgs) Handles btnShearch.Click
        Busqueda.Inventarios = True
        Busqueda.ShowDialog()
        If cBusqueda Then
            cBusqueda = False
            ObtenerInfo(sBusqueda)
        End If
        sBusqueda = Nothing
    End Sub
    Public Sub ObtenerInfo(id As String)
        Dim sql As String = "SELECT lam.nombre, lam.dep, inv.actual, inv.min FROM laminas as lam, inventarios as inv " & _
                "WHERE lam.id = inv.id_lamina AND lam.id = @id"
        Dim cmd As New MySqlCommand(sql, cnx)
        cmd.Parameters.AddWithValue("@id", id)
        cnx.Open()
        Dim lectura As MySqlDataReader = cmd.ExecuteReader
        If lectura.Read Then
                BoxDep.Text = lectura("dep")
                txtName.Text = lectura("nombre")
                NumActual.Value = lectura("actual")
                NumMinimo.Value = lectura("min")
                id_lam = id
                btnUpdate.Enabled = True
        End If
        lectura.Close()
        cnx.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        btnUpdate.Enabled = False
        NumActual.Value = 1
        NumMinimo.Value = 1
        id_lam = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MessageBox.Show("¿Modificar inventario?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbYes Then
            Dim sql As String = "UPDATE inventarios SET min = @min, actual = @actual WHERE id_lamina = @id"
            Dim cmd As New MySqlCommand(sql, cnx)
            cmd.Parameters.AddWithValue("@min", NumMinimo.Value)
            cmd.Parameters.AddWithValue("@id", id_lam)
            cmd.Parameters.AddWithValue("@actual", NumActual.Value)
            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()
            If principal.ListBox1.SelectedIndices.Count <> 0 Then
                If principal.ID_Selected = id_lam Then
                    principal.txtShell.Text = ""
                    principal.txtShellAv.Text = ""
                End If
            End If
            MsgBox("Actualizaión completa", MsgBoxStyle.Information, "Inventario actualizado")
        End If
    End Sub

End Class