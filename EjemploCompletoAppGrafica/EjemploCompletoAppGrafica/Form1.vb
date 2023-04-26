Public Class Form1
    'Zona declaracion variables globales a Form1
    Public seriesVistas As New List(Of String)

    Private Sub btnguardarserie_Click(sender As Object, e As EventArgs) Handles btnguardarserie.Click
        Dim titulo, plataforma As String
        Dim valoracion As Double
        Dim fechaestreno As Date
        Dim correcto As Boolean = True
        'Guardar datos introducidos por el usuario

        If txttitulo.Text <> "" Then
            titulo = txttitulo.Text
        Else
            txttitulo.BackColor = Color.Beige
            Me.ActiveControl = txttitulo
            MessageBox.Show("El título es obligatorio")
            correcto = False
        End If

        'Validar valoracion
        Try
            valoracion = Convert.ToDouble(txtvaloracion.Text)

            'Valido que sea un número entre 1 y 10
            If valoracion < 1 Or valoracion > 10 Then
                txtvaloracion.BackColor = Color.Firebrick
                txtvaloracion.SelectAll()
                Me.ActiveControl = txtvaloracion
                correcto = False
                MessageBox.Show("La valoracion debe estar entre 1 y 10")
            End If

        Catch ex As Exception
            txtvaloracion.BackColor = Color.Firebrick
            txtvaloracion.SelectAll()
            Me.ActiveControl = txtvaloracion
            correcto = False
            MessageBox.Show("La valoracion debe ser numérica")
        End Try


        plataforma = txtplataforma.Text

        fechaestreno = dtpfechaestreno.Value

        If correcto Then
            'Creo el String que quiero guardar en la lista
            Dim registro As String = titulo + "*" + plataforma + "*" + valoracion.ToString + "*" + fechaestreno.ToString
            'Añado a la lista
            seriesVistas.Add(registro)


            MessageBox.Show("Serie guardada con éxito")
        End If
    End Sub

    Private Sub btnAbrirconsultaseries_Click(sender As Object, e As EventArgs) Handles btnAbrirconsultaseries.Click
        Series.ShowDialog()
    End Sub
End Class
