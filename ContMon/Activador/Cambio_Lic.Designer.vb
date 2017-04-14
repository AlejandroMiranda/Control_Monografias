<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cambio_Lic
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPathKcm = New System.Windows.Forms.TextBox()
        Me.btnSearchKcm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPathPkm = New System.Windows.Forms.TextBox()
        Me.btnSearchPkm = New System.Windows.Forms.Button()
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cambio de licencia."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Licencia de la maquina actual (*.kcm):"
        '
        'txtPathKcm
        '
        Me.txtPathKcm.Location = New System.Drawing.Point(12, 80)
        Me.txtPathKcm.Name = "txtPathKcm"
        Me.txtPathKcm.Size = New System.Drawing.Size(446, 20)
        Me.txtPathKcm.TabIndex = 2
        '
        'btnSearchKcm
        '
        Me.btnSearchKcm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchKcm.Location = New System.Drawing.Point(350, 45)
        Me.btnSearchKcm.Name = "btnSearchKcm"
        Me.btnSearchKcm.Size = New System.Drawing.Size(108, 29)
        Me.btnSearchKcm.TabIndex = 3
        Me.btnSearchKcm.Text = "Buscar (*.kcm)"
        Me.btnSearchKcm.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Petición de licencia de la maquina nueva:"
        '
        'txtPathPkm
        '
        Me.txtPathPkm.Location = New System.Drawing.Point(12, 141)
        Me.txtPathPkm.Name = "txtPathPkm"
        Me.txtPathPkm.Size = New System.Drawing.Size(446, 20)
        Me.txtPathPkm.TabIndex = 2
        '
        'btnSearchPkm
        '
        Me.btnSearchPkm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPkm.Location = New System.Drawing.Point(350, 106)
        Me.btnSearchPkm.Name = "btnSearchPkm"
        Me.btnSearchPkm.Size = New System.Drawing.Size(108, 29)
        Me.btnSearchPkm.TabIndex = 3
        Me.btnSearchPkm.Text = "Buscar (*.pkm)"
        Me.btnSearchPkm.UseVisualStyleBackColor = True
        '
        'btnSwitch
        '
        Me.btnSwitch.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwitch.Location = New System.Drawing.Point(95, 167)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(289, 47)
        Me.btnSwitch.TabIndex = 4
        Me.btnSwitch.Text = "Realizar cambio de licencia."
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'Cambio_Lic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 225)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.btnSearchPkm)
        Me.Controls.Add(Me.btnSearchKcm)
        Me.Controls.Add(Me.txtPathPkm)
        Me.Controls.Add(Me.txtPathKcm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Cambio_Lic"
        Me.Text = "Cambio de licencia."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPathKcm As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchKcm As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPathPkm As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchPkm As System.Windows.Forms.Button
    Friend WithEvents btnSwitch As System.Windows.Forms.Button
End Class
