Public Class Ejercicio1
    Private Sub Ejercicio1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        txtNombre.Text = ""
        txtCorreo.Text = ""
    End Sub
    Private Sub btnPulsar_Click(sender As Object, e As EventArgs) Handles btnPulsar.Click
        Dim nombre As String
        Dim correo As String

        nombre = txtNombre.Text

        correo = txtCorreo.Text

        MessageBox.Show(nombre)
        MessageBox.Show(correo)



    End Sub
End Class