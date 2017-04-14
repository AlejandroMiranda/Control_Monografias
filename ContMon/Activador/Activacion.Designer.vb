<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activacion
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPathFile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.btnSearchFile = New System.Windows.Forms.Button()
        Me.lblDias = New System.Windows.Forms.Label()
        Me.btnSolicitud = New System.Windows.Forms.Button()
        Me.btnPrueba = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblDias)
        Me.Panel1.Controls.Add(Me.btnSolicitud)
        Me.Panel1.Controls.Add(Me.btnPrueba)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 212)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPathFile)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnActivar)
        Me.GroupBox1.Controls.Add(Me.btnSearchFile)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 155)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Activar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Control de monografías."
        '
        'txtPathFile
        '
        Me.txtPathFile.Location = New System.Drawing.Point(180, 63)
        Me.txtPathFile.Name = "txtPathFile"
        Me.txtPathFile.Size = New System.Drawing.Size(212, 20)
        Me.txtPathFile.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Llave de activación:"
        '
        'btnActivar
        '
        Me.btnActivar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivar.Location = New System.Drawing.Point(12, 89)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(122, 50)
        Me.btnActivar.TabIndex = 1
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseVisualStyleBackColor = True
        '
        'btnSearchFile
        '
        Me.btnSearchFile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFile.Location = New System.Drawing.Point(265, 89)
        Me.btnSearchFile.Name = "btnSearchFile"
        Me.btnSearchFile.Size = New System.Drawing.Size(127, 33)
        Me.btnSearchFile.TabIndex = 3
        Me.btnSearchFile.Text = "Buscar activador"
        Me.btnSearchFile.UseVisualStyleBackColor = True
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDias.Location = New System.Drawing.Point(147, 179)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(49, 20)
        Me.lblDias.TabIndex = 2
        Me.lblDias.Text = "Label3"
        Me.lblDias.Visible = False
        '
        'btnSolicitud
        '
        Me.btnSolicitud.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitud.Location = New System.Drawing.Point(272, 172)
        Me.btnSolicitud.Name = "btnSolicitud"
        Me.btnSolicitud.Size = New System.Drawing.Size(127, 37)
        Me.btnSolicitud.TabIndex = 3
        Me.btnSolicitud.Text = "Solicitar Activador"
        Me.btnSolicitud.UseVisualStyleBackColor = True
        '
        'btnPrueba
        '
        Me.btnPrueba.Location = New System.Drawing.Point(7, 172)
        Me.btnPrueba.Name = "btnPrueba"
        Me.btnPrueba.Size = New System.Drawing.Size(134, 37)
        Me.btnPrueba.TabIndex = 1
        Me.btnPrueba.Text = "Activar periodo de prueba"
        Me.btnPrueba.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(142, 129)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(46, 16)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "Label3"
        '
        'Activacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 236)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Activacion"
        Me.Tag = "1"
        Me.Text = "Activador"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrueba As System.Windows.Forms.Button
    Friend WithEvents btnSolicitud As System.Windows.Forms.Button
    Friend WithEvents btnSearchFile As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPathFile As System.Windows.Forms.TextBox
    Friend WithEvents lblDias As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnActivar As System.Windows.Forms.Button
    Friend WithEvents lblId As System.Windows.Forms.Label
End Class
