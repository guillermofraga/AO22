Imports System.IO
Public Class Form1
    'Zona declaracion variables globales a Form1
    Public seriesVistas As New List(Of String)
    Public rutaFichero As String = Directory.GetCurrentDirectory() + "\series.txt"

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

    Private Sub Form1_FormClosed(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim respuesta As DialogResult = MessageBox.Show("Desea actualizar el fichero", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            'Escribir la lista en el fichero
            Dim escritor As StreamWriter = New StreamWriter(rutaFichero, False)
            'Recorrer toda la lista y volcar registro a registro al fichero

            For Each elemento As String In seriesVistas
                escritor.WriteLine(elemento)
            Next

            escritor.Close()

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Leer el fichero y volcar la información a la lista
        Dim lector As StreamReader = New StreamReader(rutaFichero)

        Dim registro As String = Nothing

        While Not lector.EndOfStream
            registro = lector.ReadLine()
            seriesVistas.Add(registro)

        End While

        lector.Close()

    End Sub

    Private Sub btnTE_Click(sender As Object, e As EventArgs) Handles btnTE.Click
        TecladoEventos.Show()
    End Sub
End Class
