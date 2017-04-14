<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Act_Inventarios
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
        Me.btnShearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BoxDep = New System.Windows.Forms.ComboBox()
        Me.btnSee = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.NumMinimo = New System.Windows.Forms.NumericUpDown()
        Me.NumActual = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShearch
        '
        Me.btnShearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShearch.BackgroundImage = Global.Monografias.My.Resources.Resources.lupa
        Me.btnShearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShearch.Location = New System.Drawing.Point(358, 4)
        Me.btnShearch.Name = "btnShearch"
        Me.btnShearch.Size = New System.Drawing.Size(34, 28)
        Me.btnShearch.TabIndex = 7
        Me.btnShearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(86, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(223, 22)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Departamento:"
        '
        'BoxDep
        '
        Me.BoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxDep.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxDep.FormattingEnabled = True
        Me.BoxDep.Location = New System.Drawing.Point(130, 8)
        Me.BoxDep.Name = "BoxDep"
        Me.BoxDep.Size = New System.Drawing.Size(222, 24)
        Me.BoxDep.TabIndex = 1
        '
        'btnSee
        '
        Me.btnSee.Location = New System.Drawing.Point(317, 37)
        Me.btnSee.Name = "btnSee"
        Me.btnSee.Size = New System.Drawing.Size(75, 23)
        Me.btnSee.TabIndex = 3
        Me.btnSee.Text = "Ver"
        Me.btnSee.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.NumMinimo)
        Me.GroupBox1.Controls.Add(Me.NumActual)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 81)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de inventario"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(261, 18)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 57)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Actualizar cantidades"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'NumMinimo
        '
        Me.NumMinimo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMinimo.Location = New System.Drawing.Point(135, 39)
        Me.NumMinimo.Name = "NumMinimo"
        Me.NumMinimo.Size = New System.Drawing.Size(120, 26)
        Me.NumMinimo.TabIndex = 5
        '
        'NumActual
        '
        Me.NumActual.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumActual.Location = New System.Drawing.Point(9, 39)
        Me.NumActual.Name = "NumActual"
        Me.NumActual.Size = New System.Drawing.Size(120, 26)
        Me.NumActual.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Minimo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Actual:"
        '
        'Act_Inventarios
        '
        Me.AcceptButton = Me.btnSee
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 159)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSee)
        Me.Controls.Add(Me.BoxDep)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Act_Inventarios"
        Me.Text = "Inventarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BoxDep As System.Windows.Forms.ComboBox
    Friend WithEvents btnSee As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents NumMinimo As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumActual As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
