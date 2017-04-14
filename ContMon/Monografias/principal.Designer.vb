<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDeDatosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenciaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtShell = New System.Windows.Forms.TextBox()
        Me.Img = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BoxDep = New System.Windows.Forms.ComboBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DescargarImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizaInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInv = New System.Windows.Forms.Label()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.txtShellAv = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChBxShellAv = New System.Windows.Forms.CheckBox()
        Me.btnAddVent = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 90)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(322, 303)
        Me.ListBox1.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ListadoToolStripMenuItem1, Me.VerCajaToolStripMenuItem, Me.InventariosToolStripMenuItem, Me.BaseDeDatosToolStripMenuItem1, Me.LicenciaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(733, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ListadoToolStripMenuItem1
        '
        Me.ListadoToolStripMenuItem1.Name = "ListadoToolStripMenuItem1"
        Me.ListadoToolStripMenuItem1.Size = New System.Drawing.Size(74, 20)
        Me.ListadoToolStripMenuItem1.Text = "Ver listado"
        '
        'VerCajaToolStripMenuItem
        '
        Me.VerCajaToolStripMenuItem.Name = "VerCajaToolStripMenuItem"
        Me.VerCajaToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.VerCajaToolStripMenuItem.Text = "Reporte de ventas"
        '
        'InventariosToolStripMenuItem
        '
        Me.InventariosToolStripMenuItem.Name = "InventariosToolStripMenuItem"
        Me.InventariosToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.InventariosToolStripMenuItem.Text = "Actualizar inventario"
        '
        'BaseDeDatosToolStripMenuItem1
        '
        Me.BaseDeDatosToolStripMenuItem1.Name = "BaseDeDatosToolStripMenuItem1"
        Me.BaseDeDatosToolStripMenuItem1.Size = New System.Drawing.Size(158, 20)
        Me.BaseDeDatosToolStripMenuItem1.Text = "Respaldo de Base de datos"
        '
        'LicenciaToolStripMenuItem1
        '
        Me.LicenciaToolStripMenuItem1.Name = "LicenciaToolStripMenuItem1"
        Me.LicenciaToolStripMenuItem1.Size = New System.Drawing.Size(62, 20)
        Me.LicenciaToolStripMenuItem1.Text = "Licencia"
        '
        'txtShell
        '
        Me.txtShell.Location = New System.Drawing.Point(76, 30)
        Me.txtShell.Name = "txtShell"
        Me.txtShell.Size = New System.Drawing.Size(258, 20)
        Me.txtShell.TabIndex = 1
        '
        'Img
        '
        Me.Img.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Img.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Img.Location = New System.Drawing.Point(340, 56)
        Me.Img.Name = "Img"
        Me.Img.Size = New System.Drawing.Size(381, 276)
        Me.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img.TabIndex = 3
        Me.Img.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Departamento:"
        '
        'BoxDep
        '
        Me.BoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxDep.FormattingEnabled = True
        Me.BoxDep.Location = New System.Drawing.Point(113, 63)
        Me.BoxDep.Name = "BoxDep"
        Me.BoxDep.Size = New System.Drawing.Size(221, 21)
        Me.BoxDep.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DescargarImagenToolStripMenuItem, Me.ModificarToolStripMenuItem1, Me.EliminarToolStripMenuItem1, Me.ActualizaInventarioToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 92)
        '
        'DescargarImagenToolStripMenuItem
        '
        Me.DescargarImagenToolStripMenuItem.Name = "DescargarImagenToolStripMenuItem"
        Me.DescargarImagenToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DescargarImagenToolStripMenuItem.Text = "Descargar Imagen"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(178, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'ActualizaInventarioToolStripMenuItem
        '
        Me.ActualizaInventarioToolStripMenuItem.Name = "ActualizaInventarioToolStripMenuItem"
        Me.ActualizaInventarioToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ActualizaInventarioToolStripMenuItem.Text = "Actualiza inventario"
        '
        'lblInv
        '
        Me.lblInv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInv.BackColor = System.Drawing.Color.Lime
        Me.lblInv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInv.Location = New System.Drawing.Point(341, 364)
        Me.lblInv.Name = "lblInv"
        Me.lblInv.Size = New System.Drawing.Size(380, 29)
        Me.lblInv.TabIndex = 7
        Me.lblInv.Text = "Inventario"
        Me.lblInv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPos
        '
        Me.lblPos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPos.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblPos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPos.Location = New System.Drawing.Point(341, 335)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(296, 29)
        Me.lblPos.TabIndex = 7
        Me.lblPos.Text = "Posición"
        Me.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtShellAv
        '
        Me.txtShellAv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShellAv.Enabled = False
        Me.txtShellAv.Location = New System.Drawing.Point(490, 30)
        Me.txtShellAv.Margin = New System.Windows.Forms.Padding(0)
        Me.txtShellAv.Name = "txtShellAv"
        Me.txtShellAv.Size = New System.Drawing.Size(170, 20)
        Me.txtShellAv.TabIndex = 5
        '
        'txtNum
        '
        Me.txtNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtNum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(635, 335)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(85, 29)
        Me.txtNum.TabIndex = 8
        Me.txtNum.Text = "Número"
        Me.txtNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'ChBxShellAv
        '
        Me.ChBxShellAv.AutoSize = True
        Me.ChBxShellAv.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChBxShellAv.Location = New System.Drawing.Point(342, 28)
        Me.ChBxShellAv.Name = "ChBxShellAv"
        Me.ChBxShellAv.Size = New System.Drawing.Size(151, 24)
        Me.ChBxShellAv.TabIndex = 9
        Me.ChBxShellAv.Text = "Busqueda avanzada"
        Me.ChBxShellAv.UseVisualStyleBackColor = False
        '
        'btnAddVent
        '
        Me.btnAddVent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddVent.Location = New System.Drawing.Point(663, 27)
        Me.btnAddVent.Name = "btnAddVent"
        Me.btnAddVent.Size = New System.Drawing.Size(62, 24)
        Me.btnAddVent.TabIndex = 10
        Me.btnAddVent.Text = "Vender"
        Me.btnAddVent.UseVisualStyleBackColor = True
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 407)
        Me.Controls.Add(Me.txtShellAv)
        Me.Controls.Add(Me.btnAddVent)
        Me.Controls.Add(Me.ChBxShellAv)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblPos)
        Me.Controls.Add(Me.lblInv)
        Me.Controls.Add(Me.BoxDep)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtShell)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Img)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(749, 445)
        Me.Name = "principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laminas - Ventana de busqueda"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents txtShell As System.Windows.Forms.TextBox
    Friend WithEvents Img As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BoxDep As System.Windows.Forms.ComboBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DescargarImagenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblInv As System.Windows.Forms.Label
    Friend WithEvents lblPos As System.Windows.Forms.Label
    Friend WithEvents txtShellAv As System.Windows.Forms.TextBox
    Friend WithEvents txtNum As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChBxShellAv As System.Windows.Forms.CheckBox
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaseDeDatosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LicenciaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAddVent As System.Windows.Forms.Button
    Friend WithEvents InventariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizaInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
