<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoSolicitud
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblIdAct = New System.Windows.Forms.Label()
        Me.imgProyecto = New System.Windows.Forms.PictureBox()
        CType(Me.imgProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblInfo.Location = New System.Drawing.Point(148, 49)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(284, 86)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "Label1"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(420, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Información de la llave."
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIdAct
        '
        Me.lblIdAct.BackColor = System.Drawing.Color.Transparent
        Me.lblIdAct.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdAct.Location = New System.Drawing.Point(148, 144)
        Me.lblIdAct.Name = "lblIdAct"
        Me.lblIdAct.Size = New System.Drawing.Size(284, 65)
        Me.lblIdAct.TabIndex = 2
        Me.lblIdAct.Text = "Id del equipo actual: "
        Me.lblIdAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgProyecto
        '
        Me.imgProyecto.Location = New System.Drawing.Point(18, 49)
        Me.imgProyecto.Name = "imgProyecto"
        Me.imgProyecto.Size = New System.Drawing.Size(124, 157)
        Me.imgProyecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgProyecto.TabIndex = 3
        Me.imgProyecto.TabStop = False
        '
        'InfoSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 218)
        Me.Controls.Add(Me.lblIdAct)
        Me.Controls.Add(Me.imgProyecto)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InfoSolicitud"
        Me.Text = "Información de la solicitud"
        CType(Me.imgProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents imgProyecto As System.Windows.Forms.PictureBox
    Protected Friend WithEvents lblIdAct As System.Windows.Forms.Label
End Class
