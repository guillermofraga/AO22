<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ejercicio2
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(431, 189)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 42)
        Me.btnSalir.TabIndex = 25
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(431, 141)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(98, 42)
        Me.btnLimpiar.TabIndex = 26
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(431, 93)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(98, 42)
        Me.btnConvertir.TabIndex = 27
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(145, 164)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(97, 20)
        Me.txtAño.TabIndex = 21
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(145, 138)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(97, 20)
        Me.txtMes.TabIndex = 22
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(145, 112)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(97, 20)
        Me.txtDia.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(87, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(87, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(87, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Día"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "La fecha es:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Introduce los datos"
        '
        'Fecha
        '
        Me.Fecha.Enabled = False
        Me.Fecha.Location = New System.Drawing.Point(145, 240)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(115, 20)
        Me.Fecha.TabIndex = 28
        '
        'Ejercicio2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ejercicio2"
        Me.Text = "Ejercicio2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnConvertir As Button
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtMes As TextBox
    Friend WithEvents txtDia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Fecha As TextBox
End Class
