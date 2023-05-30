Public Class Ejercicio4
    Private Sub Ejercicio4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        lblMinutos.Text = ""
        lblSegundos.Text = ""
        txtHoras.Text = ""
    End Sub
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim horas As Integer

        If txtHoras.Text = "" Then
            MessageBox.Show("No introdujo ninguna hora")
            txtHoras.Focus()
        Else
            horas = Convert.ToInt32(txtHoras.Text)
            lblMinutos.Text = Convert.ToString(horas * 60)
            lblMinutos.Show()
            lblSegundos.Text = Convert.ToString(horas * 3600)
            lblSegundos.Show()
        End If



    End Sub
End Class