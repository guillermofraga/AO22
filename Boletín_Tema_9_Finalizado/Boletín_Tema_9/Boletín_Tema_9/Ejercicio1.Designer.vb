<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ejercicio1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnPulsar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblNombre.Location = New System.Drawing.Point(123, 41)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(158, 18)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Introduzca el nombre"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCorreo.Location = New System.Drawing.Point(123, 98)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(149, 18)
        Me.lblCorreo.TabIndex = 0
        Me.lblCorreo.Text = "Dirección de correo"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(401, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(401, 98)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(200, 20)
        Me.txtCorreo.TabIndex = 1
        '
        'btnPulsar
        '
        Me.btnPulsar.Location = New System.Drawing.Point(126, 213)
        Me.btnPulsar.Name = "btnPulsar"
        Me.btnPulsar.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar.TabIndex = 2
        Me.btnPulsar.Text = "Pulsame"
        Me.btnPulsar.UseVisualStyleBackColor = True
        '
        'Ejercicio1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Boletín_Tema_9.My.Resources.Resources.breakingbad_sofa
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPulsar)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "Ejercicio1"
        Me.Text = "Ejercicio1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnPulsar As Button
End Class
