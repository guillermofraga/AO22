<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ejercicio4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.lblSegundos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de horas"
        '
        'txtHoras
        '
        Me.txtHoras.Location = New System.Drawing.Point(283, 71)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(123, 20)
        Me.txtHoras.TabIndex = 1
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(230, 141)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(101, 41)
        Me.btnConvertir.TabIndex = 2
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Minutos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(324, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Segundos"
        '
        'lblMinutos
        '
        Me.lblMinutos.AutoSize = True
        Me.lblMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutos.ForeColor = System.Drawing.Color.Black
        Me.lblMinutos.Location = New System.Drawing.Point(182, 253)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(57, 20)
        Me.lblMinutos.TabIndex = 5
        Me.lblMinutos.Text = "Label4"
        Me.lblMinutos.Visible = False
        '
        'lblSegundos
        '
        Me.lblSegundos.AutoSize = True
        Me.lblSegundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundos.ForeColor = System.Drawing.Color.Black
        Me.lblSegundos.Location = New System.Drawing.Point(447, 253)
        Me.lblSegundos.Name = "lblSegundos"
        Me.lblSegundos.Size = New System.Drawing.Size(57, 20)
        Me.lblSegundos.TabIndex = 6
        Me.lblSegundos.Text = "Label5"
        Me.lblSegundos.Visible = False
        '
        'Ejercicio4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMinutos)
        Me.Controls.Add(Me.lblSegundos)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ejercicio4"
        Me.Text = "Ejercicio4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMinutos As Label
    Friend WithEvents lblSegundos As Label
End Class
