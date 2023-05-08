<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Series
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblSeriesvistas = New System.Windows.Forms.Label()
        Me.btnVerHBO = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValoracion = New System.Windows.Forms.TextBox()
        Me.txtPlaraforma = New System.Windows.Forms.TextBox()
        Me.txtFechaestreno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(119, 79)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(140, 225)
        Me.ListBox1.TabIndex = 0
        '
        'lblSeriesvistas
        '
        Me.lblSeriesvistas.AutoSize = True
        Me.lblSeriesvistas.Location = New System.Drawing.Point(116, 40)
        Me.lblSeriesvistas.Name = "lblSeriesvistas"
        Me.lblSeriesvistas.Size = New System.Drawing.Size(67, 13)
        Me.lblSeriesvistas.TabIndex = 1
        Me.lblSeriesvistas.Text = "Series Vistas"
        '
        'btnVerHBO
        '
        Me.btnVerHBO.Location = New System.Drawing.Point(438, 79)
        Me.btnVerHBO.Name = "btnVerHBO"
        Me.btnVerHBO.Size = New System.Drawing.Size(75, 23)
        Me.btnVerHBO.TabIndex = 2
        Me.btnVerHBO.Text = "HBO"
        Me.btnVerHBO.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(435, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Valoración"
        '
        'txtValoracion
        '
        Me.txtValoracion.Enabled = False
        Me.txtValoracion.Location = New System.Drawing.Point(510, 146)
        Me.txtValoracion.Name = "txtValoracion"
        Me.txtValoracion.Size = New System.Drawing.Size(149, 20)
        Me.txtValoracion.TabIndex = 4
        '
        'txtPlaraforma
        '
        Me.txtPlaraforma.Enabled = False
        Me.txtPlaraforma.Location = New System.Drawing.Point(510, 205)
        Me.txtPlaraforma.Name = "txtPlaraforma"
        Me.txtPlaraforma.Size = New System.Drawing.Size(149, 20)
        Me.txtPlaraforma.TabIndex = 5
        '
        'txtFechaestreno
        '
        Me.txtFechaestreno.Enabled = False
        Me.txtFechaestreno.Location = New System.Drawing.Point(510, 259)
        Me.txtFechaestreno.Name = "txtFechaestreno"
        Me.txtFechaestreno.Size = New System.Drawing.Size(149, 20)
        Me.txtFechaestreno.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(435, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Plataforma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha de estreno"
        '
        'Series
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFechaestreno)
        Me.Controls.Add(Me.txtPlaraforma)
        Me.Controls.Add(Me.txtValoracion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVerHBO)
        Me.Controls.Add(Me.lblSeriesvistas)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Series"
        Me.Text = "Seires"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblSeriesvistas As Label
    Friend WithEvents btnVerHBO As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValoracion As TextBox
    Friend WithEvents txtPlaraforma As TextBox
    Friend WithEvents txtFechaestreno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
