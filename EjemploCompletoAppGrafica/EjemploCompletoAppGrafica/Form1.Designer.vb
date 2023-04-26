<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.txtplataforma = New System.Windows.Forms.TextBox()
        Me.txtvaloracion = New System.Windows.Forms.TextBox()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.lblplataforma = New System.Windows.Forms.Label()
        Me.lblvaloracion = New System.Windows.Forms.Label()
        Me.btnguardarserie = New System.Windows.Forms.Button()
        Me.dtpfechaestreno = New System.Windows.Forms.DateTimePicker()
        Me.lblfechaestreno = New System.Windows.Forms.Label()
        Me.btnAbrirconsultaseries = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(147, 57)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(106, 20)
        Me.txttitulo.TabIndex = 0
        '
        'txtplataforma
        '
        Me.txtplataforma.Location = New System.Drawing.Point(147, 106)
        Me.txtplataforma.Name = "txtplataforma"
        Me.txtplataforma.Size = New System.Drawing.Size(106, 20)
        Me.txtplataforma.TabIndex = 1
        '
        'txtvaloracion
        '
        Me.txtvaloracion.Location = New System.Drawing.Point(147, 157)
        Me.txtvaloracion.Name = "txtvaloracion"
        Me.txtvaloracion.Size = New System.Drawing.Size(106, 20)
        Me.txtvaloracion.TabIndex = 2
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Location = New System.Drawing.Point(74, 60)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(63, 13)
        Me.lbltitulo.TabIndex = 3
        Me.lbltitulo.Text = "Titulo Serie:"
        '
        'lblplataforma
        '
        Me.lblplataforma.AutoSize = True
        Me.lblplataforma.Location = New System.Drawing.Point(74, 113)
        Me.lblplataforma.Name = "lblplataforma"
        Me.lblplataforma.Size = New System.Drawing.Size(60, 13)
        Me.lblplataforma.TabIndex = 4
        Me.lblplataforma.Text = "Plataforma:"
        '
        'lblvaloracion
        '
        Me.lblvaloracion.AutoSize = True
        Me.lblvaloracion.Location = New System.Drawing.Point(74, 160)
        Me.lblvaloracion.Name = "lblvaloracion"
        Me.lblvaloracion.Size = New System.Drawing.Size(60, 13)
        Me.lblvaloracion.TabIndex = 5
        Me.lblvaloracion.Text = "Valoracion:"
        '
        'btnguardarserie
        '
        Me.btnguardarserie.Location = New System.Drawing.Point(147, 255)
        Me.btnguardarserie.Name = "btnguardarserie"
        Me.btnguardarserie.Size = New System.Drawing.Size(106, 55)
        Me.btnguardarserie.TabIndex = 6
        Me.btnguardarserie.Text = "Guardar serie"
        Me.btnguardarserie.UseVisualStyleBackColor = True
        '
        'dtpfechaestreno
        '
        Me.dtpfechaestreno.Location = New System.Drawing.Point(147, 206)
        Me.dtpfechaestreno.Name = "dtpfechaestreno"
        Me.dtpfechaestreno.Size = New System.Drawing.Size(200, 20)
        Me.dtpfechaestreno.TabIndex = 7
        '
        'lblfechaestreno
        '
        Me.lblfechaestreno.AutoSize = True
        Me.lblfechaestreno.Location = New System.Drawing.Point(62, 206)
        Me.lblfechaestreno.Name = "lblfechaestreno"
        Me.lblfechaestreno.Size = New System.Drawing.Size(75, 13)
        Me.lblfechaestreno.TabIndex = 5
        Me.lblfechaestreno.Text = "Fecha estreno"
        '
        'btnAbrirconsultaseries
        '
        Me.btnAbrirconsultaseries.Location = New System.Drawing.Point(442, 255)
        Me.btnAbrirconsultaseries.Name = "btnAbrirconsultaseries"
        Me.btnAbrirconsultaseries.Size = New System.Drawing.Size(118, 55)
        Me.btnAbrirconsultaseries.TabIndex = 8
        Me.btnAbrirconsultaseries.Text = "Consultar Series"
        Me.btnAbrirconsultaseries.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAbrirconsultaseries)
        Me.Controls.Add(Me.dtpfechaestreno)
        Me.Controls.Add(Me.btnguardarserie)
        Me.Controls.Add(Me.lblfechaestreno)
        Me.Controls.Add(Me.lblvaloracion)
        Me.Controls.Add(Me.lblplataforma)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.txtvaloracion)
        Me.Controls.Add(Me.txtplataforma)
        Me.Controls.Add(Me.txttitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txttitulo As TextBox
    Friend WithEvents txtplataforma As TextBox
    Friend WithEvents txtvaloracion As TextBox
    Friend WithEvents lbltitulo As Label
    Friend WithEvents lblplataforma As Label
    Friend WithEvents lblvaloracion As Label
    Friend WithEvents btnguardarserie As Button
    Friend WithEvents dtpfechaestreno As DateTimePicker
    Friend WithEvents lblfechaestreno As Label
    Friend WithEvents btnAbrirconsultaseries As Button
End Class
