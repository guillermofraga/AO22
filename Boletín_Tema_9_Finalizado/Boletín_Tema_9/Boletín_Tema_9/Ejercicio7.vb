Public Class Ejercicio7
    Private Sub Ejercicio7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        txtDolares.Text = ""
        txtEuros.Text = ""
    End Sub

    Private Sub btnConvertiraeuros_Click(sender As Object, e As EventArgs) Handles btnConvertiraeuros.Click
        Dim dolares As Double

        If txtDolares.Text = "" Then
            MessageBox.Show("No introdujo ningun dolar")
            txtDolares.Focus()
        Else
            dolares = Convert.ToDouble(txtDolares.Text.Split("$"c)(0))
            txtEuros.Text = Convert.ToString(dolares * 0.91 & "€")
        End If

    End Sub

    Private Sub btnConvertiradolares_Click(sender As Object, e As EventArgs) Handles btnConvertiradolares.Click

        Dim euros As Double

        If txtEuros.Text = "" Then
            MessageBox.Show("No introdujo ningun euro")
            txtEuros.Focus()
        Else
            euros = Convert.ToDouble(txtEuros.Text.Split("€"c)(0))
            txtDolares.Text = Convert.ToString(euros * 1.1 & "$")

        End If


    End Sub
End Class