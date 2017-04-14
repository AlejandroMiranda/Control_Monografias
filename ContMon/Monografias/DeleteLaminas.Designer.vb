<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteLaminas
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
        Me.GBImg = New System.Windows.Forms.GroupBox()
        Me.Img = New System.Windows.Forms.PictureBox()
        Me.GBInfo = New System.Windows.Forms.GroupBox()
        Me.BoxDep = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.NumUp = New System.Windows.Forms.TextBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GBImg.SuspendLayout()
        CType(Me.Img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBImg
        '
        Me.GBImg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBImg.Controls.Add(Me.Img)
        Me.GBImg.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBImg.Location = New System.Drawing.Point(210, 12)
        Me.GBImg.Name = "GBImg"
        Me.GBImg.Size = New System.Drawing.Size(364, 367)
        Me.GBImg.TabIndex = 5
        Me.GBImg.TabStop = False
        Me.GBImg.Text = "Imagen"
        '
        'Img
        '
        Me.Img.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Img.Location = New System.Drawing.Point(6, 21)
        Me.Img.Name = "Img"
        Me.Img.Size = New System.Drawing.Size(349, 339)
        Me.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img.TabIndex = 0
        Me.Img.TabStop = False
        '
        'GBInfo
        '
        Me.GBInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GBInfo.Controls.Add(Me.BoxDep)
        Me.GBInfo.Controls.Add(Me.btnSearch)
        Me.GBInfo.Controls.Add(Me.NumUp)
        Me.GBInfo.Controls.Add(Me.btnDel)
        Me.GBInfo.Controls.Add(Me.Label3)
        Me.GBInfo.Controls.Add(Me.Label4)
        Me.GBInfo.Controls.Add(Me.Label2)
        Me.GBInfo.Controls.Add(Me.Label1)
        Me.GBInfo.Controls.Add(Me.txtPC)
        Me.GBInfo.Controls.Add(Me.txtName)
        Me.GBInfo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBInfo.Location = New System.Drawing.Point(14, 12)
        Me.GBInfo.Name = "GBInfo"
        Me.GBInfo.Size = New System.Drawing.Size(190, 367)
        Me.GBInfo.TabIndex = 4
        Me.GBInfo.TabStop = False
        Me.GBInfo.Text = "Datos de la lamina"
        '
        'BoxDep
        '
        Me.BoxDep.Enabled = False
        Me.BoxDep.Location = New System.Drawing.Point(6, 84)
        Me.BoxDep.Name = "BoxDep"
        Me.BoxDep.Size = New System.Drawing.Size(178, 25)
        Me.BoxDep.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Monografias.My.Resources.Resources.lupa
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(150, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(34, 28)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'NumUp
        '
        Me.NumUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumUp.Enabled = False
        Me.NumUp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumUp.Location = New System.Drawing.Point(6, 310)
        Me.NumUp.Name = "NumUp"
        Me.NumUp.Size = New System.Drawing.Size(178, 22)
        Me.NumUp.TabIndex = 6
        Me.NumUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(6, 337)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(178, 23)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Número:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Departamento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Palabras claves:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'txtPC
        '
        Me.txtPC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPC.Enabled = False
        Me.txtPC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPC.Location = New System.Drawing.Point(6, 133)
        Me.txtPC.Multiline = True
        Me.txtPC.Name = "txtPC"
        Me.txtPC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPC.Size = New System.Drawing.Size(178, 152)
        Me.txtPC.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(6, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 22)
        Me.txtName.TabIndex = 3
        '
        'DeleteLaminas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 391)
        Me.Controls.Add(Me.GBImg)
        Me.Controls.Add(Me.GBInfo)
        Me.MinimumSize = New System.Drawing.Size(600, 429)
        Me.Name = "DeleteLaminas"
        Me.Text = "Eliminar Monografías"
        Me.GBImg.ResumeLayout(False)
        CType(Me.Img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBInfo.ResumeLayout(False)
        Me.GBInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBImg As System.Windows.Forms.GroupBox
    Friend WithEvents GBInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPC As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Img As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumUp As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents BoxDep As System.Windows.Forms.TextBox
End Class
