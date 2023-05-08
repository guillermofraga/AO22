Public Class Ejercicio2
    Private Sub Ejercicio2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
    Private Sub Fecha_TextChanged(sender As Object, e As EventArgs) Handles Fecha.TextChanged
        Dim dia, mes, año As Integer

        dia = Convert.ToInt32(txtDia.Text)

        año = Convert.ToInt32(txtAño.Text)

        mes = Convert.ToInt32(txtMes.Text)

        Fecha.Text = dia & mes & año

    End Sub
End Class