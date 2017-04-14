Imports MySql.Data.MySqlClient

Public Class Modificar

    Dim Imagen_Res As Image = Nothing
    Public id_busqueda As String = Nothing

    Private Sub Load_Modificar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Ico
        ImgNew.BackColor = Color.White
        ImgOld.BackColor = Color.White

        NumUp.DecimalPlaces = 0
        NumUp.Maximum = 99999
        NumAct.Maximum = 99999
        NumMin.Maximum = 99999
        NumUp.Minimum = 1
        NumAct.Minimum = 0
        NumMin.Minimum = 1

        txtName.Focus()

        Deps()
        ObtenerInfo()
        Tips()
        BoxDep.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub
    Private Sub Tips()
        Dim Tip As New ToolTip
        Tip.IsBalloon = True
        Tip.ShowAlways = True

        Tip.SetToolTip(txtName, "Nombre de la monografía")
        Tip.SetToolTip(txtPC, "Palabras clave con la que se indentifica")
        Tip.SetToolTip(txtPos, "Posición en almacen")
        Tip.SetToolTip(BoxDep, "Departamento al que pertenece")
        Tip.SetToolTip(NumUp, "Número de la monografía")

        Tip.SetToolTip(btnDelNew, "Eliminar imagen nueva" & vbCr & _
                       "En caso de insertar una imagen que no era")
        Tip.SetToolTip(btnDelOld, "Eliminar imagen antigua" & vbCr & _
                       "En caso de querer dejar la monografía sin imagen")
        Tip.SetToolTip(btnMod, "Guardar modificaciones en la base de datos" & vbCr & _
                       "Esto modificará permanentemente la monografía del sistema")

        Tip.SetToolTip(ChBxInv, "Habilita o deshabilita el control de inventario")
        Tip.SetToolTip(NumAct, "Cantidad actual en almacen")
        Tip.SetToolTip(NumMin, "Cantidad mínima que debe existir en almacen")

        Tip.SetToolTip(ImgNew, "Imagen nueva" & vbCr & _
                       "Representa la nueva imagen que se mostrará")
        Tip.SetToolTip(ImgOld, "Imagen actual" & vbCr & _
                       "Representa la imagen que actualmente se ve")
    End Sub

    Private Sub ObtenerInfo()
        Dim sql As String = "SELECT * FROM laminas as lam, inventarios as inv WHERE lam.id = inv.id_lamina AND lam.id = @id"
        Dim cmd As New MySqlCommand(sql, cnx)
        cmd.Parameters.AddWithValue("@id", id_busqueda)
        cnx.Open()
        Dim lectura As MySqlDataReader = cmd.ExecuteReader
        lectura.Read()
        txtName.Text = lectura("nombre")
        txtName.Tag = lectura("nombre")
        txtPC.Text = lectura("p_clave")
        BoxDep.Text = lectura("dep")
        BoxDep.Tag = lectura("dep")
        If lectura("actual") IsNot DBNull.Value Then
            ChBxInv.Checked = True
            NumAct.Value = lectura("actual")
            NumMin.Value = lectura("min")
        Else
            ChBxInv.Checked = False
            Panel1.Visible = False
            NumAct.Value = 1
            NumMin.Value = 1
        End If
        If lectura("img") IsNot DBNull.Value Then
            ImgOld.Image = Bytes_Imagen(lectura("img"))
        Else
            ImgOld.Image = My.Resources.ImgDefault
        End If
        ImgNew.Image = My.Resources.Agregar
        cnx.Close()
    End Sub
    Private Sub Deps()
        BoxDep.Items.Clear()
        For i As Integer = 0 To Dep.Length - 2
            BoxDep.Items.Add(Dep(i))
        Next
        'If BoxDep.Items.Count <> 0 Then
        '    BoxDep.Text = BoxDep.Items.Item(0)
        'End If
        BoxDep.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
    Private Sub Clearing()
        Me.Enabled = False
        txtName.Text = ""
        txtPC.Text = ""
        txtPos.Text = ""
        BoxDep.Text = ""

        NumUp.Value = 1
        NumAct.Value = 1
        NumMin.Value = 1

        ImgNew.Image = Nothing
        ImgOld.Image = Nothing
        If MessageBox.Show("¿Realizar otra modificación?", "Nueva Modificación", MessageBoxButtons.YesNo, _
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbYes Then
            Busqueda.ShowDialog()
            If cBusqueda Then
                cBusqueda = False
                id_busqueda = sBusqueda
                sBusqueda = ""
                ObtenerInfo()
                Me.Enabled = True
                Deps()
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CheckedChange_ChBxInv(sender As Object, e As EventArgs) Handles ChBxInv.CheckedChanged
        Panel1.Visible = ChBxInv.Checked
    End Sub

    Private Sub btnDelOld_Click(sender As System.Object, e As System.EventArgs) Handles btnDelOld.Click
        If ImgOld.Tag IsNot Nothing Then
            Imagen_Res = ImgOld.Image
            ImgOld.Image = My.Resources.Recuperar
            ImgOld.Tag = Nothing
        End If
    End Sub
    Private Sub ImgOld_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgOld.DoubleClick
        If Imagen_Res IsNot Nothing Then
            ImgOld.Image = Imagen_Res
            ImgOld.Tag = "@"
            Imagen_Res = Nothing
        End If
    End Sub

    Private Sub ImgNew_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgNew.DoubleClick
        Dim OpenFolder As New OpenFileDialog
        OpenFolder.Filter = "Imagenes |*.jpg;*.gnp;*.pnp| Gif |*.gif"
        OpenFolder.Multiselect = False
        If OpenFolder.ShowDialog <> vbCancel Then
            ImgNew.ImageLocation = OpenFolder.FileName
            ImgNew.Tag = "@"
        End If
    End Sub
    Private Sub btnDelNew_Click(sender As System.Object, e As System.EventArgs) Handles btnDelNew.Click
        ImgNew.Image = My.Resources.Agregar
        ImgNew.Tag = Nothing
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        If MessageBox.Show("¿Modificar la monografía?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                           MessageBoxDefaultButton.Button2) = vbYes Then
            Cursor = Cursors.WaitCursor
            btnMod.Enabled = False
            If Dep_Valid() Then
                If Name_Valid() Then
                    Mod_Lam()
                    Mod_Inv()
                    principal.Clearing()
                    Departamentos()
                    Clearing()
                Else
                    MsgBox("El nombre ya existe para el departamento: " & BoxDep.Text & vbCr & _
                           "Favor de introducir otro nombre", MsgBoxStyle.Information, "Nombre duplicado")
                End If
            End If
            btnMod.Enabled = True
            Cursor = Cursors.Default
        End If
    End Sub
    Public Sub Mod_Lam()
        Dim cmd As New MySqlCommand("", cnx)
        If ImgNew.Tag IsNot Nothing Then
            cmd.CommandText = "UPDATE laminas SET nombre = @name, num = @num, img = @img, p_clave = @pclave, dep = @dep, posicion = @pos " & _
                "WHERE id = " & id_busqueda
            cmd.Parameters.AddWithValue("@img", Imagen_Bytes(ImgNew.Image))
        Else
            cmd.CommandText = "UPDATE laminas SET nombre = @name, num = @num, p_clave = @pclave, dep = @dep, posicion = @pos " & _
                "WHERE id = " & id_busqueda
        End If

        cmd.Parameters.AddWithValue("@name", txtName.Text)
        cmd.Parameters.AddWithValue("@num", NumUp.Value)
        cmd.Parameters.AddWithValue("@pclave", txtPC.Text)
        cmd.Parameters.AddWithValue("@dep", BoxDep.Text)
        cmd.Parameters.AddWithValue("@pos", txtPos.Text)
        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()
        Catch ex As Exception
            Cursor = Cursors.Default
            btnMod.Enabled = True
            cnx.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Sub Mod_Inv()
        Dim sql As String = "UPDATE inventarios SET actual = @actual, min = @min WHERE id_lamina = " & id_busqueda
        Dim cmd As New MySqlCommand(sql, cnx)
        Try
            If ChBxInv.Checked Then
                cmd.Parameters.AddWithValue("@actual", NumAct.Value)
                cmd.Parameters.AddWithValue("@min", NumMin.Value)
            Else
                cmd.Parameters.AddWithValue("@actual", DBNull.Value)
                cmd.Parameters.AddWithValue("@min", DBNull.Value)
            End If
            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()
        Catch ex As Exception
            Cursor = Cursors.Default
            btnMod.Enabled = True
            cnx.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function Dep_Valid() As Boolean
        If BoxDep.Text = BoxDep.Tag Then
            Return True
        Else
            If MessageBox.Show("¿Desea mover " & Chr(34) & txtName.Text & Chr(34) & " al departamento: " & BoxDep.Text & _
                               "?", "Cambiar de departamento", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbYes Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    Private Function Name_Valid() As Boolean
        If txtName.Text <> txtName.Tag Then
            Dim sql As String = "SELECT * FROM laminas WHERE nombre = @nom AND dep = @dep LIMIT 1"
            Dim cmd As New MySqlCommand(sql, cnx)
            cmd.Parameters.AddWithValue("@nom", txtName.Text)
            cmd.Parameters.AddWithValue("@dep", BoxDep.Text)
            cnx.Open()
            Dim lect As MySqlDataReader = cmd.ExecuteReader
            If lect.Read Then
                cnx.Close()
                Return False
            Else
                cnx.Close()
                Return True
            End If
        Else
            Return True
        End If
    End Function
End Class