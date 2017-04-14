<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Base_Datos
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
        Me.txtPathExp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPathExp = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPathImp = New System.Windows.Forms.TextBox()
        Me.btnPathImp = New System.Windows.Forms.Button()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.btnCnxRem = New System.Windows.Forms.Button()
        Me.btnServer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPathExp
        '
        Me.txtPathExp.Location = New System.Drawing.Point(16, 54)
        Me.txtPathExp.Name = "txtPathExp"
        Me.txtPathExp.Size = New System.Drawing.Size(205, 20)
        Me.txtPathExp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Exportar la base de datos."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Carpeta de destino"
        '
        'btnPathExp
        '
        Me.btnPathExp.Location = New System.Drawing.Point(227, 51)
        Me.btnPathExp.Name = "btnPathExp"
        Me.btnPathExp.Size = New System.Drawing.Size(50, 23)
        Me.btnPathExp.TabIndex = 3
        Me.btnPathExp.Text = "Buscar"
        Me.btnPathExp.UseVisualStyleBackColor = True
        '
        'btnExp
        '
        Me.btnExp.Location = New System.Drawing.Point(283, 12)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(90, 62)
        Me.btnExp.TabIndex = 4
        Me.btnExp.Text = "Exportar"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Importar la base de datos."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Archivo origen"
        '
        'txtPathImp
        '
        Me.txtPathImp.Location = New System.Drawing.Point(15, 141)
        Me.txtPathImp.Name = "txtPathImp"
        Me.txtPathImp.Size = New System.Drawing.Size(206, 20)
        Me.txtPathImp.TabIndex = 5
        '
        'btnPathImp
        '
        Me.btnPathImp.Location = New System.Drawing.Point(227, 138)
        Me.btnPathImp.Name = "btnPathImp"
        Me.btnPathImp.Size = New System.Drawing.Size(50, 23)
        Me.btnPathImp.TabIndex = 3
        Me.btnPathImp.Text = "Buscar"
        Me.btnPathImp.UseVisualStyleBackColor = True
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(283, 99)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(90, 62)
        Me.btnImp.TabIndex = 4
        Me.btnImp.Text = "Importar"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'btnCnxRem
        '
        Me.btnCnxRem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCnxRem.Location = New System.Drawing.Point(186, 167)
        Me.btnCnxRem.Name = "btnCnxRem"
        Me.btnCnxRem.Size = New System.Drawing.Size(187, 39)
        Me.btnCnxRem.TabIndex = 6
        Me.btnCnxRem.Text = "Activar Conexión remota"
        Me.btnCnxRem.UseVisualStyleBackColor = True
        '
        'btnServer
        '
        Me.btnServer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServer.Location = New System.Drawing.Point(16, 167)
        Me.btnServer.Name = "btnServer"
        Me.btnServer.Size = New System.Drawing.Size(164, 39)
        Me.btnServer.TabIndex = 7
        Me.btnServer.Text = "Activar modo servidor"
        Me.btnServer.UseVisualStyleBackColor = True
        '
        'Base_Datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 218)
        Me.Controls.Add(Me.btnServer)
        Me.Controls.Add(Me.btnCnxRem)
        Me.Controls.Add(Me.txtPathImp)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.btnPathImp)
        Me.Controls.Add(Me.btnPathExp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPathExp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Base_Datos"
        Me.Text = "Respaldos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPathExp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPathExp As System.Windows.Forms.Button
    Friend WithEvents btnExp As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPathImp As System.Windows.Forms.TextBox
    Friend WithEvents btnPathImp As System.Windows.Forms.Button
    Friend WithEvents btnImp As System.Windows.Forms.Button
    Friend WithEvents btnCnxRem As System.Windows.Forms.Button
    Friend WithEvents btnServer As System.Windows.Forms.Button
End Class
