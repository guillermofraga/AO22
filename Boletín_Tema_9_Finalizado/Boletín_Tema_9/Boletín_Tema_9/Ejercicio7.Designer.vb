<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio7
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtEuros = New System.Windows.Forms.TextBox()
        Me.txtDolares = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConvertiradolares = New System.Windows.Forms.Button()
        Me.btnConvertiraeuros = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Location = New System.Drawing.Point(97, 44)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 33)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Conversor:"
        '
        'txtEuros
        '
        Me.txtEuros.Location = New System.Drawing.Point(97, 108)
        Me.txtEuros.Multiline = True
        Me.txtEuros.Name = "txtEuros"
        Me.txtEuros.Size = New System.Drawing.Size(120, 29)
        Me.txtEuros.TabIndex = 0
        '
        'txtDolares
        '
        Me.txtDolares.Location = New System.Drawing.Point(97, 168)
        Me.txtDolares.Multiline = True
        Me.txtDolares.Name = "txtDolares"
        Me.txtDolares.Size = New System.Drawing.Size(120, 29)
        Me.txtDolares.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(268, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "€"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(268, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "$"
        '
        'btnConvertiradolares
        '
        Me.btnConvertiradolares.Location = New System.Drawing.Point(97, 244)
        Me.btnConvertiradolares.Name = "btnConvertiradolares"
        Me.btnConvertiradolares.Size = New System.Drawing.Size(82, 49)
        Me.btnConvertiradolares.TabIndex = 2
        Me.btnConvertiradolares.Text = "Convertir a dolares"
        Me.btnConvertiradolares.UseVisualStyleBackColor = True
        '
        'btnConvertiraeuros
        '
        Me.btnConvertiraeuros.Location = New System.Drawing.Point(235, 244)
        Me.btnConvertiraeuros.Name = "btnConvertiraeuros"
        Me.btnConvertiraeuros.Size = New System.Drawing.Size(82, 49)
        Me.btnConvertiraeuros.TabIndex = 3
        Me.btnConvertiraeuros.Text = "Convertir a euros"
        Me.btnConvertiraeuros.UseVisualStyleBackColor = True
        '
        'Ejercicio7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Boletín_Tema_9.My.Resources.Resources.Breaking_Bad_escena_cama_de_dinero
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvertiraeuros)
        Me.Controls.Add(Me.btnConvertiradolares)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDolares)
        Me.Controls.Add(Me.txtEuros)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Ejercicio7"
        Me.Text = "Ejercicio7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtEuros As TextBox
    Friend WithEvents txtDolares As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConvertiradolares As Button
    Friend WithEvents btnConvertiraeuros As Button
End Class
