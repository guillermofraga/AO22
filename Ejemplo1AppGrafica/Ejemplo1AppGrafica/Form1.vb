Public Class Form1
    'Declaración variables globales
    Dim nombre As String

    Private Sub btnSaludarClick(sender As Object, e As EventArgs) Handles btnSaludar.Click
        'Recoger el nombre que el usuario introdujo en la caja de texto
        nombre = txtNombre.Text
        MessageBox.Show("Hola " & nombre)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnContarletras.Click
        Dim numeroletras As Integer = nombre.Length
        MessageBox.Show(nombre & " tiene " & numeroletras.ToString & " letras")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class
