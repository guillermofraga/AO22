Public Class Ejercicio4
    Private Sub Ejercicio4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim horas, min, seg As Integer

        If txtHoras.Text = "" Then
            MessageBox.Show("No introdujo ninguna hora")
        Else

        End If



    End Sub
End Class