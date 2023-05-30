<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio5
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
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.lbloperadores = New System.Windows.Forms.Label()
        Me.lblIgual = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtn1
        '
        Me.txtn1.Location = New System.Drawing.Point(62, 92)
        Me.txtn1.Multiline = True
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(101, 76)
        Me.txtn1.TabIndex = 0
        '
        'txtn2
        '
        Me.txtn2.Location = New System.Drawing.Point(273, 92)
        Me.txtn2.Multiline = True
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(101, 76)
        Me.txtn2.TabIndex = 1
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(62, 245)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(75, 31)
        Me.btnSuma.TabIndex = 2
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(143, 245)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(75, 31)
        Me.btnResta.TabIndex = 3
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicacion.Location = New System.Drawing.Point(224, 245)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(75, 31)
        Me.btnMultiplicacion.TabIndex = 4
        Me.btnMultiplicacion.Text = "*"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(305, 245)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(75, 31)
        Me.btnDivision.TabIndex = 5
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'lbloperadores
        '
        Me.lbloperadores.AutoSize = True
        Me.lbloperadores.Location = New System.Drawing.Point(191, 124)
        Me.lbloperadores.Name = "lbloperadores"
        Me.lbloperadores.Size = New System.Drawing.Size(51, 13)
        Me.lbloperadores.TabIndex = 2
        Me.lbloperadores.Text = "Operador"
        Me.lbloperadores.Visible = False
        '
        'lblIgual
        '
        Me.lblIgual.AutoSize = True
        Me.lblIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgual.Location = New System.Drawing.Point(407, 119)
        Me.lblIgual.Name = "lblIgual"
        Me.lblIgual.Size = New System.Drawing.Size(18, 20)
        Me.lblIgual.TabIndex = 2
        Me.lblIgual.Text = "="
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(450, 119)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(82, 20)
        Me.lblResultado.TabIndex = 3
        Me.lblResultado.Text = "Resultado"
        '
        'Ejercicio5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Boletín_Tema_9.My.Resources.Resources.Bettercallsaul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblIgual)
        Me.Controls.Add(Me.lbloperadores)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtn2)
        Me.Controls.Add(Me.txtn1)
        Me.Name = "Ejercicio5"
        Me.Text = "Ejercicio5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtn1 As TextBox
    Friend WithEvents txtn2 As TextBox
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents lbloperadores As Label
    Friend WithEvents lblIgual As Label
    Friend WithEvents lblResultado As Label
End Class
