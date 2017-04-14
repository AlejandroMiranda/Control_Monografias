<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar
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
        Me.GBInfo = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumMin = New System.Windows.Forms.NumericUpDown()
        Me.NumAct = New System.Windows.Forms.NumericUpDown()
        Me.ChBxInv = New System.Windows.Forms.CheckBox()
        Me.NumUp = New System.Windows.Forms.NumericUpDown()
        Me.BoxDep = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.txtPos = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GBImg = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblOld = New System.Windows.Forms.Label()
        Me.btnDelOld = New System.Windows.Forms.Button()
        Me.ImgOld = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDelNew = New System.Windows.Forms.Button()
        Me.ImgNew = New System.Windows.Forms.PictureBox()
        Me.GBInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBImg.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ImgOld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBInfo
        '
        Me.GBInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GBInfo.Controls.Add(Me.Panel1)
        Me.GBInfo.Controls.Add(Me.ChBxInv)
        Me.GBInfo.Controls.Add(Me.NumUp)
        Me.GBInfo.Controls.Add(Me.BoxDep)
        Me.GBInfo.Controls.Add(Me.Label6)
        Me.GBInfo.Controls.Add(Me.btnMod)
        Me.GBInfo.Controls.Add(Me.Label8)
        Me.GBInfo.Controls.Add(Me.Label3)
        Me.GBInfo.Controls.Add(Me.Label2)
        Me.GBInfo.Controls.Add(Me.Label1)
        Me.GBInfo.Controls.Add(Me.txtPC)
        Me.GBInfo.Controls.Add(Me.txtPos)
        Me.GBInfo.Controls.Add(Me.txtName)
        Me.GBInfo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBInfo.Location = New System.Drawing.Point(12, 12)
        Me.GBInfo.Name = "GBInfo"
        Me.GBInfo.Size = New System.Drawing.Size(209, 474)
        Me.GBInfo.TabIndex = 1
        Me.GBInfo.TabStop = False
        Me.GBInfo.Text = "Datos de la lamina"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.NumMin)
        Me.Panel1.Controls.Add(Me.NumAct)
        Me.Panel1.Location = New System.Drawing.Point(6, 347)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 67)
        Me.Panel1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Mínimo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Actual:"
        '
        'NumMin
        '
        Me.NumMin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMin.Location = New System.Drawing.Point(71, 37)
        Me.NumMin.Name = "NumMin"
        Me.NumMin.Size = New System.Drawing.Size(108, 22)
        Me.NumMin.TabIndex = 8
        Me.NumMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumAct
        '
        Me.NumAct.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumAct.Location = New System.Drawing.Point(71, 9)
        Me.NumAct.Name = "NumAct"
        Me.NumAct.Size = New System.Drawing.Size(108, 22)
        Me.NumAct.TabIndex = 7
        Me.NumAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChBxInv
        '
        Me.ChBxInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChBxInv.AutoSize = True
        Me.ChBxInv.Location = New System.Drawing.Point(6, 320)
        Me.ChBxInv.Name = "ChBxInv"
        Me.ChBxInv.Size = New System.Drawing.Size(89, 21)
        Me.ChBxInv.TabIndex = 6
        Me.ChBxInv.Text = "Inventario"
        Me.ChBxInv.UseVisualStyleBackColor = True
        '
        'NumUp
        '
        Me.NumUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumUp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumUp.Location = New System.Drawing.Point(85, 238)
        Me.NumUp.Name = "NumUp"
        Me.NumUp.Size = New System.Drawing.Size(117, 22)
        Me.NumUp.TabIndex = 4
        Me.NumUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BoxDep
        '
        Me.BoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxDep.FormattingEnabled = True
        Me.BoxDep.Location = New System.Drawing.Point(6, 88)
        Me.BoxDep.Name = "BoxDep"
        Me.BoxDep.Size = New System.Drawing.Size(196, 25)
        Me.BoxDep.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Departamento:*"
        '
        'btnMod
        '
        Me.btnMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMod.Location = New System.Drawing.Point(6, 420)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(196, 48)
        Me.btnMod.TabIndex = 9
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Posición:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Número:*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Palabras claves:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'txtPC
        '
        Me.txtPC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPC.Location = New System.Drawing.Point(0, 137)
        Me.txtPC.Multiline = True
        Me.txtPC.Name = "txtPC"
        Me.txtPC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPC.Size = New System.Drawing.Size(202, 95)
        Me.txtPC.TabIndex = 3
        '
        'txtPos
        '
        Me.txtPos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPos.Location = New System.Drawing.Point(6, 292)
        Me.txtPos.Name = "txtPos"
        Me.txtPos.Size = New System.Drawing.Size(196, 22)
        Me.txtPos.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(6, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(196, 22)
        Me.txtName.TabIndex = 1
        '
        'GBImg
        '
        Me.GBImg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBImg.Controls.Add(Me.SplitContainer1)
        Me.GBImg.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBImg.Location = New System.Drawing.Point(227, 12)
        Me.GBImg.Name = "GBImg"
        Me.GBImg.Size = New System.Drawing.Size(482, 474)
        Me.GBImg.TabIndex = 2
        Me.GBImg.TabStop = False
        Me.GBImg.Text = "Imagenes"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 21)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblOld)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelOld)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ImgOld)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnDelNew)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ImgNew)
        Me.SplitContainer1.Size = New System.Drawing.Size(476, 450)
        Me.SplitContainer1.SplitterDistance = 223
        Me.SplitContainer1.TabIndex = 0
        '
        'lblOld
        '
        Me.lblOld.AutoSize = True
        Me.lblOld.Location = New System.Drawing.Point(44, 4)
        Me.lblOld.Name = "lblOld"
        Me.lblOld.Size = New System.Drawing.Size(99, 17)
        Me.lblOld.TabIndex = 1
        Me.lblOld.Text = "Imagen Actual"
        '
        'btnDelOld
        '
        Me.btnDelOld.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelOld.Location = New System.Drawing.Point(3, 423)
        Me.btnDelOld.Name = "btnDelOld"
        Me.btnDelOld.Size = New System.Drawing.Size(217, 23)
        Me.btnDelOld.TabIndex = 10
        Me.btnDelOld.Text = "Eliminar Imagen"
        Me.btnDelOld.UseVisualStyleBackColor = True
        '
        'ImgOld
        '
        Me.ImgOld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgOld.Location = New System.Drawing.Point(3, 21)
        Me.ImgOld.Name = "ImgOld"
        Me.ImgOld.Size = New System.Drawing.Size(217, 396)
        Me.ImgOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgOld.TabIndex = 0
        Me.ImgOld.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Imagen Nueva"
        '
        'btnDelNew
        '
        Me.btnDelNew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelNew.Location = New System.Drawing.Point(3, 423)
        Me.btnDelNew.Name = "btnDelNew"
        Me.btnDelNew.Size = New System.Drawing.Size(243, 23)
        Me.btnDelNew.TabIndex = 11
        Me.btnDelNew.Text = "Eliminar Imagen"
        Me.btnDelNew.UseVisualStyleBackColor = True
        '
        'ImgNew
        '
        Me.ImgNew.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgNew.Location = New System.Drawing.Point(3, 21)
        Me.ImgNew.Name = "ImgNew"
        Me.ImgNew.Size = New System.Drawing.Size(238, 396)
        Me.ImgNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgNew.TabIndex = 0
        Me.ImgNew.TabStop = False
        '
        'Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 498)
        Me.Controls.Add(Me.GBImg)
        Me.Controls.Add(Me.GBInfo)
        Me.MinimumSize = New System.Drawing.Size(737, 536)
        Me.Name = "Modificar"
        Me.Text = "Modificar Monografías"
        Me.GBInfo.ResumeLayout(False)
        Me.GBInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBImg.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ImgOld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBInfo As System.Windows.Forms.GroupBox
    Friend WithEvents GBImg As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPC As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents ImgOld As System.Windows.Forms.PictureBox
    Friend WithEvents ImgNew As System.Windows.Forms.PictureBox
    Friend WithEvents lblOld As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDelOld As System.Windows.Forms.Button
    Friend WithEvents btnDelNew As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents BoxDep As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumUp As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumAct As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChBxInv As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPos As System.Windows.Forms.TextBox
End Class
