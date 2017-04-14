Imports MySql.Data.MySqlClient

Public Class AddLaminas

    Private Sub Load_Me(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Ico
        PictureBox1.Image = My.Resources.Agregar
        PictureBox1.Tag = Nothing
        NumUp.DecimalPlaces = 0
        NumUp.Maximum = 99999
        NumUp.Minimum = 1
        NumericUpDown1.Maximum = 99999
        NumericUpDown1.Minimum = 1
        NumericUpDown2.Maximum = 99999
        NumericUpDown2.Minimum = 1
        btnDelete.Enabled = False
        Deps()
        Tips()
        BoxDep.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub
    Private Sub Tips()
        Dim Tip As New ToolTip
        Tip.IsBalloon = True
        Tip.SetToolTip(txtName, "Nombre de titulo de la monografía")
        Tip.SetToolTip(txtPC, "Palabras claves con las que se relaciona la monografía")
        Tip.SetToolTip(txtPos, "Posición en almacen" & vbCr & _
                       "Normalmente primero el cajon seguido de un guión y su número")
        Tip.SetToolTip(BoxDep, "Departamento al que pertenece")

        Tip.SetToolTip(ChBxInv, "Habilita o deshabilita control de inventario")
        Tip.SetToolTip(NumericUpDown1, "Cantidad actual en almacen")
        Tip.SetToolTip(NumericUpDown2, "Cantidad mínima de existencia en almacen")
        Tip.SetToolTip(NumUp, "Número de la monografía" & vbCr & _
                       "Este número lo trae impreso la monografía")

        Tip.SetToolTip(PictureBox1, "Imagen de la monografía" & vbCr & _
                       "Esta imagen es la que se mostrará al cliente")

        Tip.SetToolTip(btnAdd, "Botón para guardar la monografía en la base de datos" & vbCr & _
                       "Da de alta la monografía en el sistema")
        Tip.SetToolTip(btnAddImg, "Botón para buscar la imagen de la monografía" & vbCr & _
                       "También se puede hacer doble clic en el recuadro para la imagen")
        Tip.SetToolTip(btnDelete, "Botón para eliminar la imagen actual seleccionada" & vbCr & _
                       "En caso de insertar una imagen erronea este boton puede eliminarla")
    End Sub

    Private Sub Clearing()
        txtName.Text = ""
        txtPC.Text = ""
        BoxDep.Text = ""
        NumUp.Value = 1
        PictureBox1.Image = My.Resources.Agregar
        PictureBox1.Tag = Nothing
    End Sub

    Private Sub Deps()
        BoxDep.Items.Clear()
        For i As Integer = 0 To Dep.Length - 2
            BoxDep.Items.Add(Dep(i))
        Next
        BoxDep.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Sub Pict(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Dim Folder As New OpenFileDialog
        Folder.Filter = "Imagenes |*.jpg;*.gnp;*.pnp| Gif |*.gif"
        Folder.Multiselect = False
        If Folder.ShowDialog() <> vbCancel Then
            PictureBox1.ImageLocation = Folder.FileName
            PictureBox1.Tag = Folder.FileName
            btnDelete.Enabled = True
        End If
    End Sub
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click, btnAddImg.Click
        PictureBox1.Image = My.Resources.Agregar
        PictureBox1.Tag = Nothing
        btnDelete.Enabled = False
    End Sub
    Private Sub AddImagen_Click(sender As Object, e As EventArgs) Handles btnAddImg.Click
        Pict(sender, e)
    End Sub

    Private Sub TextName_Changer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        NumUp.Value = 1
    End Sub

    Private Sub TextName_KeyEnter(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtName.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            BoxDep.Focus()
        End If
    End Sub
    Private Sub BoxDep_KeyEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BoxDep.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtPC.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Cursor = Cursors.WaitCursor
            Dim vName As Boolean = Name_Valid()
            If vName And txtName.Text <> "" And BoxDep.Text <> "" Then
                Me.Enabled = False
                Lamina()
                Inve()
                Clearing()
                Departamentos()
                Deps()
                txtName.Focus()
                principal.Clearing()
                MsgBox("Lamina registrada", MsgBoxStyle.Information)
            ElseIf NumUp.Text = "" Or txtName.Text = "" Or BoxDep.Text = "" Then
                MsgBox("Se necesita llenar todos los valores con el caracter (*)", MsgBoxStyle.Information, "Falta de información")
            Else
                MsgBox("El nombre ya existe para el departamento: " & BoxDep.Text & vbCr & "Favor de introducir otro nombre", _
                          MsgBoxStyle.Information, "Nombre duplicado")
            End If
            Me.Enabled = True
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            cnx.Close()
            Me.Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Lamina()
        Dim sql As String = "INSERT INTO laminas (nombre,num,p_clave,img,dep,posicion)" & _
            "VALUES (@nombre, @num, @p_clave, @img, @dep,@pos)"
        Dim cmd As New MySqlCommand(sql, cnx)
        cmd.Parameters.AddWithValue("@nombre", txtName.Text)
        cmd.Parameters.AddWithValue("@num", NumUp.Value)      
        cmd.Parameters.AddWithValue("@p_clave", txtPC.Text)
        cmd.Parameters.AddWithValue("@dep", BoxDep.Text)
        If txtPos.Text = "" Then
            cmd.Parameters.AddWithValue("@pos", "-Sin posición-")
        Else
            cmd.Parameters.AddWithValue("@pos", txtPos.Text)
        End If
        If PictureBox1.Tag IsNot Nothing Then
            Dim image As Byte()
            image = Imagen_Bytes(PictureBox1.Image)
            cmd.Parameters.AddWithValue("@img", image)
        Else
            cmd.Parameters.AddWithValue("@img", DBNull.Value)
        End If
        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()
    End Sub
    Private Sub Inve()
        'Variables reutilizables
        Dim sql As String = Nothing
        Dim cmd As New MySqlCommand
        Dim id As String = Nothing
        cmd.Connection = cnx

        Try
            'Obtener id
            sql = "SELECT id FROM laminas WHERE nombre = @nombre AND dep = @dep"
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@nombre", txtName.Text)
            cmd.Parameters.AddWithValue("@dep", BoxDep.Text)

            cnx.Open()
            Dim lectura As MySqlDataReader = cmd.ExecuteReader
            lectura.Read()
            id = lectura("id")
            lectura.Close()
            cmd.Parameters.Clear()
            cnx.Close()

            'Crear registro en inv
            sql = "INSERT INTO inventarios(id_lamina, actual, min) " & _
                "VALUES(@id, @act, @min)"
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@id", id)
            If ChBxInv.Checked Then
                cmd.Parameters.AddWithValue("@act", NumericUpDown1.Value)
                cmd.Parameters.AddWithValue("@min", NumericUpDown2.Value)
            Else
                cmd.Parameters.AddWithValue("@act", DBNull.Value)
                cmd.Parameters.AddWithValue("@min", DBNull.Value)
            End If
            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()
        Catch ex As Exception
            cnx.Close()
            MsgBox("Error al crear inventario", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function Name_Valid() As Boolean
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
    End Function
    'Private Function NumId_Valid() As Boolean
    '    Dim sql As String = "SELECT * FROM laminas WHERE num = @num AND dep = @dep LIMIT 1"
    '    Dim cmd As New MySqlCommand(sql, cnx)
    '    cmd.Parameters.AddWithValue("@num", NumUp.Value)
    '    cmd.Parameters.AddWithValue("@dep", BoxDep.Text)
    '    cnx.Open()
    '    Dim lect As MySqlDataReader = cmd.ExecuteReader
    '    If lect.Read Then
    '        cnx.Close()
    '        Return False
    '    Else
    '        cnx.Close()
    '        Return True
    '    End If
    'End Function

    Private Sub Btn_NumUp(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles NumUp.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnAdd.Focus()
        End If
    End Sub

    Private Sub Change_ChBxInv(ByVal sender As System.Object, ByVal e As EventArgs) Handles ChBxInv.CheckedChanged
        Panel1.Visible = ChBxInv.Checked
    End Sub
End Class