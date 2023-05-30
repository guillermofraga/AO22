<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio6
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
        Me.lblGradosCentigrados = New System.Windows.Forms.Label()
        Me.lblGradosFahrenheit = New System.Windows.Forms.Label()
        Me.txtGradoscentigrados = New System.Windows.Forms.TextBox()
        Me.txtGradosfahrenheit = New System.Windows.Forms.TextBox()
        Me.btnConverttofahrenheit = New System.Windows.Forms.Button()
        Me.btnConvertiracentigrados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGradosCentigrados
        '
        Me.lblGradosCentigrados.AutoSize = True
        Me.lblGradosCentigrados.Location = New System.Drawing.Point(105, 87)
        Me.lblGradosCentigrados.Name = "lblGradosCentigrados"
        Me.lblGradosCentigrados.Size = New System.Drawing.Size(100, 13)
        Me.lblGradosCentigrados.TabIndex = 0
        Me.lblGradosCentigrados.Text = "Grados Centigrados"
        '
        'lblGradosFahrenheit
        '
        Me.lblGradosFahrenheit.AutoSize = True
        Me.lblGradosFahrenheit.Location = New System.Drawing.Point(111, 148)
        Me.lblGradosFahrenheit.Name = "lblGradosFahrenheit"
        Me.lblGradosFahrenheit.Size = New System.Drawing.Size(94, 13)
        Me.lblGradosFahrenheit.TabIndex = 1
        Me.lblGradosFahrenheit.Text = "Grados Fahrenheit"
        '
        'txtGradoscentigrados
        '
        Me.txtGradoscentigrados.Location = New System.Drawing.Point(224, 84)
        Me.txtGradoscentigrados.Name = "txtGradoscentigrados"
        Me.txtGradoscentigrados.Size = New System.Drawing.Size(196, 20)
        Me.txtGradoscentigrados.TabIndex = 2
        '
        'txtGradosfahrenheit
        '
        Me.txtGradosfahrenheit.Location = New System.Drawing.Point(224, 145)
        Me.txtGradosfahrenheit.Name = "txtGradosfahrenheit"
        Me.txtGradosfahrenheit.Size = New System.Drawing.Size(196, 20)
        Me.txtGradosfahrenheit.TabIndex = 2
        '
        'btnConverttofahrenheit
        '
        Me.btnConverttofahrenheit.Location = New System.Drawing.Point(151, 244)
        Me.btnConverttofahrenheit.Name = "btnConverttofahrenheit"
        Me.btnConverttofahrenheit.Size = New System.Drawing.Size(92, 37)
        Me.btnConverttofahrenheit.TabIndex = 3
        Me.btnConverttofahrenheit.Text = "Convertir a fahrenheit"
        Me.btnConverttofahrenheit.UseVisualStyleBackColor = True
        '
        'btnConvertiracentigrados
        '
        Me.btnConvertiracentigrados.Location = New System.Drawing.Point(328, 244)
        Me.btnConvertiracentigrados.Name = "btnConvertiracentigrados"
        Me.btnConvertiracentigrados.Size = New System.Drawing.Size(92, 37)
        Me.btnConvertiracentigrados.TabIndex = 3
        Me.btnConvertiracentigrados.Text = "Convertir a centigrados"
        Me.btnConvertiracentigrados.UseVisualStyleBackColor = True
        '
        'Ejercicio6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvertiracentigrados)
        Me.Controls.Add(Me.btnConverttofahrenheit)
        Me.Controls.Add(Me.txtGradosfahrenheit)
        Me.Controls.Add(Me.txtGradoscentigrados)
        Me.Controls.Add(Me.lblGradosFahrenheit)
        Me.Controls.Add(Me.lblGradosCentigrados)
        Me.Name = "Ejercicio6"
        Me.Text = "Ejercicio6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGradosCentigrados As Label
    Friend WithEvents lblGradosFahrenheit As Label
    Friend WithEvents txtGradoscentigrados As TextBox
    Friend WithEvents txtGradosfahrenheit As TextBox
    Friend WithEvents btnConverttofahrenheit As Button
    Friend WithEvents btnConvertiracentigrados As Button
End Class
