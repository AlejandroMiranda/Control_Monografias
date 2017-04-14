<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLaminas
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
        Me.GBInf = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.NumUp = New System.Windows.Forms.NumericUpDown()
        Me.BoxDep = New System.Windows.Forms.ComboBox()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.lblPC = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GBPs = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChBxInv = New System.Windows.Forms.CheckBox()
        Me.txtPos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddImg = New System.Windows.Forms.Button()
        Me.GBInf.SuspendLayout()
        CType(Me.NumUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPs.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBInf
        '
        Me.GBInf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GBInf.Controls.Add(Me.txtName)
        Me.GBInf.Controls.Add(Me.NumUp)
        Me.GBInf.Controls.Add(Me.BoxDep)
        Me.GBInf.Controls.Add(Me.lblPos)
        Me.GBInf.Controls.Add(Me.Label4)
        Me.GBInf.Controls.Add(Me.txtPC)
        Me.GBInf.Controls.Add(Me.lblPC)
        Me.GBInf.Controls.Add(Me.lblName)
        Me.GBInf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBInf.Location = New System.Drawing.Point(12, 12)
        Me.GBInf.Name = "GBInf"
        Me.GBInf.Size = New System.Drawing.Size(234, 251)
        Me.GBInf.TabIndex = 0
        Me.GBInf.TabStop = False
        Me.GBInf.Text = "Información de la lamina"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(3, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(222, 24)
        Me.txtName.TabIndex = 1
        '
        'NumUp
        '
        Me.NumUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumUp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumUp.Location = New System.Drawing.Point(6, 223)
        Me.NumUp.Name = "NumUp"
        Me.NumUp.Size = New System.Drawing.Size(219, 22)
        Me.NumUp.TabIndex = 4
        Me.NumUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BoxDep
        '
        Me.BoxDep.FormattingEnabled = True
        Me.BoxDep.Location = New System.Drawing.Point(6, 79)
        Me.BoxDep.Name = "BoxDep"
        Me.BoxDep.Size = New System.Drawing.Size(222, 26)
        Me.BoxDep.TabIndex = 2
        '
        'lblPos
        '
        Me.lblPos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPos.AutoSize = True
        Me.lblPos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPos.Location = New System.Drawing.Point(6, 207)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(97, 16)
        Me.lblPos.TabIndex = 2
        Me.lblPos.Text = "Número unico:*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Departamento:*"
        '
        'txtPC
        '
        Me.txtPC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPC.Location = New System.Drawing.Point(6, 122)
        Me.txtPC.Multiline = True
        Me.txtPC.Name = "txtPC"
        Me.txtPC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPC.Size = New System.Drawing.Size(222, 82)
        Me.txtPC.TabIndex = 3
        '
        'lblPC
        '
        Me.lblPC.AutoSize = True
        Me.lblPC.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPC.Location = New System.Drawing.Point(6, 105)
        Me.lblPC.Name = "lblPC"
        Me.lblPC.Size = New System.Drawing.Size(111, 17)
        Me.lblPC.TabIndex = 0
        Me.lblPC.Text = "Palabras Clave:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(62, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Nombre:*"
        '
        'GBPs
        '
        Me.GBPs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GBPs.Controls.Add(Me.Panel1)
        Me.GBPs.Controls.Add(Me.ChBxInv)
        Me.GBPs.Controls.Add(Me.txtPos)
        Me.GBPs.Controls.Add(Me.Label1)
        Me.GBPs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPs.Location = New System.Drawing.Point(12, 269)
        Me.GBPs.Name = "GBPs"
        Me.GBPs.Size = New System.Drawing.Size(234, 141)
        Me.GBPs.TabIndex = 5
        Me.GBPs.TabStop = False
        Me.GBPs.Text = "Posición e inventario"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NumericUpDown2)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(7, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 59)
        Me.Panel1.TabIndex = 8
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(118, 23)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(82, 24)
        Me.NumericUpDown2.TabIndex = 10
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 23)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(81, 24)
        Me.NumericUpDown1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Minimo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Actual"
        '
        'ChBxInv
        '
        Me.ChBxInv.AutoSize = True
        Me.ChBxInv.Checked = True
        Me.ChBxInv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBxInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBxInv.Location = New System.Drawing.Point(6, 47)
        Me.ChBxInv.Name = "ChBxInv"
        Me.ChBxInv.Size = New System.Drawing.Size(88, 20)
        Me.ChBxInv.TabIndex = 7
        Me.ChBxInv.Text = "Inventario:"
        Me.ChBxInv.UseVisualStyleBackColor = True
        '
        'txtPos
        '
        Me.txtPos.Location = New System.Drawing.Point(74, 23)
        Me.txtPos.Name = "txtPos"
        Me.txtPos.Size = New System.Drawing.Size(154, 24)
        Me.txtPos.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Posición:"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(3, 7)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 25)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(252, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 367)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(215, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 25)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Eliminar Imagen"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDelete, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddImg, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(252, 383)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(320, 35)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'btnAddImg
        '
        Me.btnAddImg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddImg.Location = New System.Drawing.Point(109, 7)
        Me.btnAddImg.Name = "btnAddImg"
        Me.btnAddImg.Size = New System.Drawing.Size(100, 25)
        Me.btnAddImg.TabIndex = 13
        Me.btnAddImg.Text = "Insertar Imagen"
        Me.btnAddImg.UseVisualStyleBackColor = True
        '
        'AddLaminas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 422)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GBPs)
        Me.Controls.Add(Me.GBInf)
        Me.MinimumSize = New System.Drawing.Size(600, 460)
        Me.Name = "AddLaminas"
        Me.Text = "Agregar Monografía"
        Me.GBInf.ResumeLayout(False)
        Me.GBInf.PerformLayout()
        CType(Me.NumUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBPs.ResumeLayout(False)
        Me.GBPs.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBInf As System.Windows.Forms.GroupBox
    Friend WithEvents GBPs As System.Windows.Forms.GroupBox
    Friend WithEvents txtPC As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblPC As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPos As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents BoxDep As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumUp As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChBxInv As System.Windows.Forms.CheckBox
    Friend WithEvents txtPos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAddImg As System.Windows.Forms.Button
End Class
