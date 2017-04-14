Imports MySql.Data.MySqlClient

Public Class DeleteLaminas

    Private Sub Load_Form(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Ico
        Img.BackColor = Color.White
        Tips()
        'Deps()
    End Sub
    Private Sub Loading_Form(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim tipTem As New ToolTip
        tipTem.ShowAlways = True
        tipTem.Show("Buscar monografía a eliminar", btnSearch, 1500)
    End Sub
    Private Sub Tips()
        Dim Tips As New ToolTip
        Tips.ShowAlways = True
        Tips.IsBalloon = True
        Tips.SetToolTip(btnSearch, "Realizar busqueda")
        Tips.SetToolTip(btnDel, "Eliminar monografía seleccionada de la base de datos" & vbCr & _
                        "Esto eliminará la monografía del sistema")
    End Sub

    'Private Sub Deps()
    '    BoxDep.Items.Clear()
    '    For i As Integer = 0 To Dep.Length - 2
    '        BoxDep.Items.Add(Dep(i))
    '    Next
    '    If BoxDep.Items.Count <> 0 Then
    '        BoxDep.Text = BoxDep.Items.Item(0)
    '    End If
    'End Sub

    Private Sub Clearing()
        txtName.Text = Nothing
        txtPC.Text = Nothing
        NumUp.Text = Nothing
        BoxDep.Text = Nothing
        Img.Image = Nothing
    End Sub

    'Private Sub btnSee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtName.Text <> "" Then
    '        Dim Sql As String = "SELECT * FROM laminas WHERE nombre = @nombre AND dep = @dep"
    '        Dim cmd As New MySqlCommand(Sql, cnx)
    '        cmd.Parameters.AddWithValue("@nombre", txtName.Text)
    '        cmd.Parameters.AddWithValue("@dep", BoxDep.Text)
    '        Try
    '            cnx.Open()
    '            Dim lectura As MySqlDataReader = cmd.ExecuteReader
    '            If lectura.Read Then
    '                BoxDep.Text = lectura("dep")
    '                txtPC.Text = lectura("p_clave")
    '                txtName.Tag = lectura("id")
    '                NumUp.Text = lectura("num")
    '                If lectura("img") IsNot DBNull.Value Then
    '                    Img.Image = Bytes_Imagen(lectura("img"))
    '                Else
    '                    Img.Image = Nothing
    '                End If
    '                btnDel.Enabled = True
    '            Else
    '                MsgBox("No se encontro la lamina", MsgBoxStyle.Exclamation, "Lamina desconosida")
    '            End If
    '            cnx.Close()
    '        Catch ex As Exception
    '            cnx.Close()
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        End Try
    '    End If
    'End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If MessageBox.Show("¿Eliminar Monografía?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                           MessageBoxDefaultButton.Button2) = vbYes Then
            Dim sql As String = "DELETE FROM laminas WHERE id = " & txtName.Tag & "; " & vbCr _
            & "DELETE FROM inventarios WHERE id_lamina = " & txtName.Tag
            Dim cmd As New MySqlCommand(sql, cnx)
            Try
                cnx.Open()
                cmd.ExecuteNonQuery()
                cnx.Close()
                limpiarPrincipal()
                Clearing()
                txtName.Text = Nothing
                Departamentos()
                'Deps()
            Catch ex As Exception
                cnx.Close()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
    Private Sub limpiarPrincipal()
        If txtName.Tag = principal.ID_Selected Or BoxDep.Text = principal.BoxDep.Text Then
            principal.Clearing()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Busqueda.ShowDialog()
        If cBusqueda Then
            cBusqueda = False
            ObtenerInfo(sBusqueda)
            sBusqueda = ""
        End If
    End Sub
    Public Sub ObtenerInfo(id As String)
        Dim sql As String = "SELECT * FROM laminas WHERE id = @id"
        Dim cmd As New MySqlCommand(sql, cnx)
        cmd.Parameters.AddWithValue("@id", id)
        txtName.Tag = id
        cnx.Open()
        Dim lectura As MySqlDataReader = cmd.ExecuteReader
        lectura.Read()
        txtName.Text = lectura("nombre")
        txtPC.Text = lectura("p_clave")
        BoxDep.Text = lectura("dep")
        NumUp.Text = lectura("num")
        If lectura("img") IsNot DBNull.Value Then
            Img.Image = Bytes_Imagen(lectura("img"))
        Else
            Img.Image = Nothing
        End If
        lectura.Close()
        btnDel.Enabled = True
        cnx.Close()
    End Sub

End Class