<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio3
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
        Me.lblpoligonos = New System.Windows.Forms.Label()
        Me.txtValorladomayor = New System.Windows.Forms.TextBox()
        Me.btnRectangulo = New System.Windows.Forms.Button()
        Me.btnTriangulo = New System.Windows.Forms.Button()
        Me.txtValorbase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtValorladomenor = New System.Windows.Forms.TextBox()
        Me.txtValoraltura = New System.Windows.Forms.TextBox()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtValorlado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCuadrado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblpoligonos
        '
        Me.lblpoligonos.AutoSize = True
        Me.lblpoligonos.Location = New System.Drawing.Point(69, 26)
        Me.lblpoligonos.Name = "lblpoligonos"
        Me.lblpoligonos.Size = New System.Drawing.Size(186, 13)
        Me.lblpoligonos.TabIndex = 0
        Me.lblpoligonos.Text = "Calcular areas de diferentes poligonos"
        '
        'txtValorladomayor
        '
        Me.txtValorladomayor.Location = New System.Drawing.Point(185, 191)
        Me.txtValorladomayor.Name = "txtValorladomayor"
        Me.txtValorladomayor.Size = New System.Drawing.Size(100, 20)
        Me.txtValorladomayor.TabIndex = 2
        '
        'btnRectangulo
        '
        Me.btnRectangulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRectangulo.Location = New System.Drawing.Point(559, 181)
        Me.btnRectangulo.Name = "btnRectangulo"
        Me.btnRectangulo.Size = New System.Drawing.Size(95, 37)
        Me.btnRectangulo.TabIndex = 4
        Me.btnRectangulo.Text = "Rectangulo"
        Me.btnRectangulo.UseVisualStyleBackColor = False
        '
        'btnTriangulo
        '
        Me.btnTriangulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTriangulo.Location = New System.Drawing.Point(559, 251)
        Me.btnTriangulo.Name = "btnTriangulo"
        Me.btnTriangulo.Size = New System.Drawing.Size(95, 35)
        Me.btnTriangulo.TabIndex = 4
        Me.btnTriangulo.Text = "Triangulo"
        Me.btnTriangulo.UseVisualStyleBackColor = False
        '
        'txtValorbase
        '
        Me.txtValorbase.Location = New System.Drawing.Point(185, 261)
        Me.txtValorbase.Name = "txtValorbase"
        Me.txtValorbase.Size = New System.Drawing.Size(100, 20)
        Me.txtValorbase.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Valor del lado mayor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Valor de la base"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valor del lado menor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Valor de la altura"
        '
        'txtValorladomenor
        '
        Me.txtValorladomenor.Location = New System.Drawing.Point(432, 190)
        Me.txtValorladomenor.Name = "txtValorladomenor"
        Me.txtValorladomenor.Size = New System.Drawing.Size(100, 20)
        Me.txtValorladomenor.TabIndex = 2
        '
        'txtValoraltura
        '
        Me.txtValoraltura.Location = New System.Drawing.Point(432, 259)
        Me.txtValoraltura.Name = "txtValoraltura"
        Me.txtValoraltura.Size = New System.Drawing.Size(100, 20)
        Me.txtValoraltura.TabIndex = 2
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.Location = New System.Drawing.Point(68, 333)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(94, 24)
        Me.lblR.TabIndex = 5
        Me.lblR.Text = "Resultado"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(202, 333)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(72, 24)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.Text = "Label6"
        Me.lblResultado.Visible = False
        '
        'txtValorlado
        '
        Me.txtValorlado.Location = New System.Drawing.Point(185, 126)
        Me.txtValorlado.Name = "txtValorlado"
        Me.txtValorlado.Size = New System.Drawing.Size(100, 20)
        Me.txtValorlado.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Valor del lado"
        '
        'btnCuadrado
        '
        Me.btnCuadrado.Location = New System.Drawing.Point(559, 119)
        Me.btnCuadrado.Name = "btnCuadrado"
        Me.btnCuadrado.Size = New System.Drawing.Size(95, 32)
        Me.btnCuadrado.TabIndex = 4
        Me.btnCuadrado.Text = "Cuadrado"
        Me.btnCuadrado.UseVisualStyleBackColor = True
        '
        'Ejercicio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.btnTriangulo)
        Me.Controls.Add(Me.btnRectangulo)
        Me.Controls.Add(Me.btnCuadrado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValoraltura)
        Me.Controls.Add(Me.txtValorbase)
        Me.Controls.Add(Me.txtValorladomenor)
        Me.Controls.Add(Me.txtValorladomayor)
        Me.Controls.Add(Me.txtValorlado)
        Me.Controls.Add(Me.lblpoligonos)
        Me.Name = "Ejercicio3"
        Me.Text = "Ejercicio3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblpoligonos As Label
    Friend WithEvents txtValorladomayor As TextBox
    Friend WithEvents btnRectangulo As Button
    Friend WithEvents btnTriangulo As Button
    Friend WithEvents txtValorbase As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValorladomenor As TextBox
    Friend WithEvents txtValoraltura As TextBox
    Friend WithEvents lblR As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtValorlado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCuadrado As Button
End Class
