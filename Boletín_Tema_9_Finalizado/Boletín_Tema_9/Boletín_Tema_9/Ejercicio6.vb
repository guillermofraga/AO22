Public Class Ejercicio6
    Private Sub Ejercicio6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        txtGradoscentigrados.Text = ""
        txtGradosfahrenheit.Text = ""
    End Sub

    Private Sub btnConverttofahrenheit_Click(sender As Object, e As EventArgs) Handles btnConverttofahrenheit.Click
        Dim centigrados As Double

        If txtGradoscentigrados.Text = "" Then
            MessageBox.Show("No introdujo ningun grado centigrado")
            txtGradoscentigrados.Focus()
        Else
            centigrados = Convert.ToDouble(txtGradoscentigrados.Text.Split("º"c)(0))
            txtGradosfahrenheit.Text = Convert.ToString(centigrados * 9 / 5 + 32 & "ºF")
        End If

    End Sub

    Private Sub btnConvertiracentigrados_Click(sender As Object, e As EventArgs) Handles btnConvertiracentigrados.Click
        Dim fahrenheint As Double

        If txtGradosfahrenheit.Text = "" Then
            MessageBox.Show("No introdujo ningun grado fahrenheit")
            txtGradosfahrenheit.Focus()
        Else
            fahrenheint = Convert.ToDouble(txtGradosfahrenheit.Text.Split("º"c)(0))
            txtGradoscentigrados.Text = Convert.ToString((fahrenheint - 32) * 5 / 9 & "ºC")
        End If

    End Sub
End Class