Imports Microsoft.Win32
Imports MySql.Data.MySqlClient

Public Class principal

    Public ID_Selected As String
    Dim Tips As New ToolTip
    Dim count As Integer = Nothing

    Private Sub Cargar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Ico
        Img.ContextMenuStrip = ContextMenuStrip1
        Img.Image = My.Resources.ImgDefault
        btnAddVent.Enabled = False
        Conf_MySQL()
        Opt_BD()
        Departamentos()
        Deps()
        ConfigTips()
        txtShell.Focus()
        Permanecer()
    End Sub
    Public Sub Clearing()
        txtShell.Text = ""
        BoxDep.Text = ""
        Deps()
    End Sub
    Private Sub ConfigTips()
        Tips.Active = True
        Tips.IsBalloon = True
        Tips.SetToolTip(ListBox1, "Resultado de busqueda" & vbCr & "De click para ver la imagen")
        Tips.SetToolTip(txtShell, "Inserta el tema a buscar")
        Tips.SetToolTip(btnAddVent, "Realizar venta")
        Tips.SetToolTip(lblInv, "Cantidad actual en el inventario")
        Tips.SetToolTip(lblPos, "Posición de almacenamiento")
        Tips.SetToolTip(txtShellAv, "Prueba")
        Tips.SetToolTip(txtShell, "Inserta el nombre a buscar" & _
                        vbCr & "O agregé al inicio % para buscar en todo el nombre")
        Tips.SetToolTip(ChBxShellAv, "Realizar busqueda añadiendo palabras claves")
        Tips.SetToolTip(txtShellAv, "Inserte una palabra clave")
        Tips.SetToolTip(BoxDep, "Selecciona el departamento donde se va a buscar")
        Tips.SetToolTip(txtNum, "Número")
    End Sub

    Private Sub Permanecer()
        Dim keyvale As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\MS License Key")
        If keyvale.GetValue("DTU") Is Nothing Then
            Me.Close()
        End If
    End Sub

    Public Sub Deps()
        BoxDep.Items.Clear()
        For i As Integer = 0 To Dep.Length - 2
            BoxDep.Items.Add(Dep(i))
        Next
        If BoxDep.Items.Count <> 0 Then
            BoxDep.Text = BoxDep.Items.Item(0)
        End If
    End Sub

    Private Sub SelectedChanger_ListBox1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Cursor = Cursors.WaitCursor
            ListBox1.Enabled = False
            lblInv.BackColor = Color.Lime
            lblPos.BackColor = SystemColors.InactiveCaption
            Dim sql As String = "SELECT lam.img, lam.num, lam.id, lam.posicion, inv.actual, inv.min FROM laminas as lam, inventarios as inv WHERE nombre = @nombre AND dep = @dep AND lam.id = inv.id_lamina"
            Dim cmd As New MySqlCommand(sql, cnx)
            cmd.Parameters.AddWithValue("@nombre", ListBox1.Items.Item(ListBox1.SelectedIndex).ToString)
            cmd.Parameters.AddWithValue("@dep", BoxDep.Text)
            Try
                cnx.Open()
                Dim lectura As MySqlDataReader = cmd.ExecuteReader
                lectura.Read()
                txtNum.Text = lectura("num").ToString
                lblPos.Text = lectura("posicion")
                If lectura("img") IsNot DBNull.Value Then
                    Img.Image = Bytes_Imagen(lectura("img"))
                    Img.Tag = " "
                Else
                    Img.Image = My.Resources.ImgDefault
                    Img.Tag = Nothing
                End If
                If lectura("actual") IsNot DBNull.Value Then
                    lblInv.Text = "Inventario: " & lectura("actual")
                    If lectura("actual") < lectura("min") And lectura("actual") > 0 Then
                        lblInv.BackColor = Color.Yellow
                    ElseIf lectura("actual") = 0 Then
                        lblInv.BackColor = Color.Red
                    End If
                Else
                    lblInv.Text = "No tiene inventario"
                End If
                ID_Selected = lectura("id")
                cnx.Close()
            Catch ex As Exception
                cnx.Close()
                ID_Selected = -1
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
            ListBox1.Enabled = True
            btnAddVent.Enabled = True
            ListBox1.Focus()
            Cursor = Cursors.Default
        Else
            ID_Selected = -1
        End If
    End Sub

    Private Sub ChangerText_BoxDep(ByVal sender As Object, ByVal e As EventArgs) Handles BoxDep.TextChanged
        Text_Search(sender, e)
    End Sub
    Private Sub Text_SearhcAv(ByVal sender As Object, ByVal e As EventArgs) Handles txtShellAv.TextChanged
        Text_Search(sender, e)
    End Sub
    Private Sub Text_Search(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShell.TextChanged
        ListBox1.Items.Clear()
        txtNum.Text = "Número"
        lblInv.Text = "Inventario"
        lblInv.BackColor = Color.Lime
        lblPos.Text = "Posición"
        lblPos.BackColor = SystemColors.InactiveCaption
        Img.Image = My.Resources.ImgDefault
        Img.Tag = Nothing
        btnAddVent.Enabled = False
        If txtShell.Text <> "" Or (txtShellAv.Text <> "" And txtShellAv.Enabled) Then
            Dim SQL As String
            If ChBxShellAv.Checked And txtShell.Text <> "" Then
                SQL = "SELECT nombre FROM laminas WHERE (nombre like '" & txtShell.Text & "%' or p_clave like '%" & txtShellAv.Text & "%') AND dep = '" & BoxDep.Text & "' ORDER BY nombre"
            ElseIf ChBxShellAv.Checked Then
                SQL = "SELECT nombre FROM laminas WHERE p_clave like '%" & txtShellAv.Text & "%' AND dep = '" & BoxDep.Text & "' ORDER BY nombre"
            Else
                SQL = "SELECT nombre FROM laminas WHERE nombre like '" & txtShell.Text & "%' AND dep = '" & BoxDep.Text & "' ORDER BY nombre"
            End If
            Dim cmd As New MySqlCommand(SQL, cnx)
            Try
                cnx.Open()
                Dim Lectura As MySqlDataReader = cmd.ExecuteReader
                Do While Lectura.Read
                    ListBox1.Items.Add(Lectura(0).ToString)
                Loop
                cnx.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                cnx.Close()
            End Try
        End If
    End Sub
    Private Sub Change_ChBxShellAv(ByVal sender As Object, ByVal e As EventArgs) Handles ChBxShellAv.CheckedChanged
        txtShellAv.Enabled = ChBxShellAv.Checked
        txtShellAv.Text = ""
    End Sub

    Private Sub Click_vender(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddVent.Click
        Me.Enabled = False
        Cursor = Cursors.WaitCursor
        If lblInv.BackColor <> Color.Red Then
            Try
                Dim sql As String = "INSERT INTO ventas(id_lamina, fecha) VALUES (@id_lamina, @fecha); " & _
                       "UPDATE inventarios SET actual = (actual - 1) WHERE id_lamina = @id_lamina AND actual > 0"
                Dim sqlInv As String = "SELECT actual FROM inventarios WHERE id_lamina = @id_lamina"
                Dim cmd As New MySqlCommand(sql, cnx)
                cmd.Parameters.AddWithValue("@id_lamina", ID_Selected)
                cmd.Parameters.AddWithValue("@fecha", Format(Now(), "yyy/MM/dd"))
                cnx.Open()
                cmd.ExecuteNonQuery()
                cnx.Close()
                cmd.CommandText = sqlInv
                SelectedChanger_ListBox1(sender, e)
                AvisoVenta_ToolTip()
            Catch ex As Exception
                MsgBox("Error al vender", MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Inventario Agotado")
        End If
        Cursor = Cursors.Default
        Me.Enabled = True
    End Sub
    Private Sub AvisoVenta_ToolTip()
        Dim tVenta As New ToolTip
        Dim posicion As Point = btnAddVent.Location
        Dim x As Integer = posicion.X
        Dim y As Integer = posicion.Y - 30
        tVenta.ToolTipTitle = "Venta realizada"
        tVenta.Show(ListBox1.Items(ListBox1.SelectedIndex).ToString, MenuStrip1, x, y, 1500)
    End Sub

    'Eventos para acceder a las ventanas
    Private Sub Click_Add(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        AddLaminas.Show()
    End Sub
    Private Sub Click_Mod(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If ListBox1.SelectedIndex <> -1 Then
            Busqueda.txtShell.Text = ListBox1.Text
            Busqueda.ShowDialog()
            If cBusqueda Then
                cBusqueda = False
                Modificar.id_busqueda = sBusqueda
                sBusqueda = ""
                Modificar.Show()
            End If
        Else
            Busqueda.ShowDialog()
            If cBusqueda Then
                cBusqueda = False
                Modificar.id_busqueda = sBusqueda
                sBusqueda = ""
                Modificar.Show()
            End If
        End If
    End Sub
    Private Sub Click_Del(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        DeleteLaminas.Show()
        If ListBox1.SelectedIndex <> -1 Then
            DeleteLaminas.ObtenerInfo(ID_Selected)
        End If
    End Sub
    Private Sub BaseDeDatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BaseDeDatosToolStripMenuItem1.Click
        Base_Datos.ShowDialog()
    End Sub
    Private Sub ListadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoToolStripMenuItem1.Click
        Listado.Show()
    End Sub
    Private Sub Licencia_Click(sender As Object, e As System.EventArgs) Handles LicenciaToolStripMenuItem1.Click
        Dim FormActivación As New Activador.Activacion
        FormActivación.Show()
    End Sub
    Private Sub Inventarios(sender As Object, e As EventArgs) Handles InventariosToolStripMenuItem.Click
        If lblInv.Text <> "No tiene inventario" Then
            Act_Inventarios.Show()
            Act_Inventarios.ObtenerInfo(ID_Selected)
        Else
            Act_Inventarios.Show()
        End If
    End Sub
    Private Sub Ventas_click(sender As Object, e As EventArgs) Handles VerCajaToolStripMenuItem.Click
        Ventas.Show()
    End Sub


    Private Sub Click_Descargar(sender As Object, ByVal e As EventArgs) Handles DescargarImagenToolStripMenuItem.Click
        If Img.Tag IsNot Nothing Then
            If MessageBox.Show("¿Desea descargar la imagen: " & ListBox1.Items.Item(ListBox1.SelectedIndex).ToString & "?", _
                               "Descargar imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                               MessageBoxDefaultButton.Button2) = vbYes Then
                Try
                    Dim oFolder As New FolderBrowserDialog()
                    If oFolder.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
                        Dim sImagen As Image = Img.Image
                        sImagen.Save(oFolder.SelectedPath & "\" & ListBox1.Items.Item(ListBox1.SelectedIndex).ToString & ".jpg")
                        MsgBox("Descarga completada", MsgBoxStyle.Information, "Descarga")
                    Else
                        MsgBox("Descarga Cancelada", MsgBoxStyle.Information, "Descarga")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Error")
                End Try
            End If
        End If
    End Sub
    'Modificaciones
    Private Sub Click_Modificar(sender As Object, ByVal e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        If ListBox1.SelectedIndex <> -1 Then
            If MessageBox.Show("¿Desea modificar: " & ListBox1.Items.Item(ListBox1.SelectedIndex).ToString & "?", _
                               "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                               MessageBoxDefaultButton.Button2) = vbYes Then
                Modificar.id_busqueda = ID_Selected
                Modificar.Show()
            End If
        End If
    End Sub
    Private Sub Click_Eliminar(sender As Object, ByVal e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        If ListBox1.SelectedIndex <> -1 Then
            If MessageBox.Show("¿Desea eliminar: " & ListBox1.Items.Item(ListBox1.SelectedIndex).ToString & "?", _
                               "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                               MessageBoxDefaultButton.Button2) = vbYes Then
                DeleteLaminas.ObtenerInfo(ID_Selected)
                DeleteLaminas.Show()
            End If
        End If
    End Sub
    Private Sub Click_ActualizaInv(sender As Object, e As EventArgs) Handles ActualizaInventarioToolStripMenuItem.Click
        If ListBox1.SelectedIndex <> -1 Then
            If lblInv.Text <> "No tiene inventario" Then
                If MessageBox.Show("¿Desea actualizar el inventario de: " & ListBox1.Items.Item(ListBox1.SelectedIndex).ToString & "?", _
                                   "Inventarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                   MessageBoxDefaultButton.Button2) = vbYes Then
                    Act_Inventarios.Show()
                    Act_Inventarios.ObtenerInfo(ID_Selected)
                End If
            Else
                MsgBox(ListBox1.Items.Item(ListBox1.SelectedIndex).ToString & ", no tiene inventario" & _
                       vbCr & "Sí desea llevar inventario, valla a 'Modificar' para habilitarlo", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class