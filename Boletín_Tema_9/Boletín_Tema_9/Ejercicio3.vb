Public Class Ejercicio3
    Private Sub Ejercicio3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub btnCuadrado_Click(sender As Object, e As EventArgs) Handles btnCuadrado.Click
        Dim cuadrado As Integer

        If txtValorlado.Text = "" Then
            MessageBox.Show("No introdujo ningun valor de el lado")
        Else
            cuadrado = Convert.ToInt32(txtValorlado.Text)
            lblResultado.Text = Convert.ToString(cuadrado ^ 2)
            lblResultado.Show()
        End If



    End Sub

    Private Sub btnRectangulo_Click(sender As Object, e As EventArgs) Handles btnRectangulo.Click
        Dim ladomayor, ladomenor As Integer

        If txtValorladomayor.Text = "" Then
            MessageBox.Show("No introdujo ningun valor de el lado mayor")
        ElseIf txtValorladomenor.Text = "" Then
            MessageBox.Show("No introdujo ningun valor de el lado menor")
        Else
            ladomayor = Convert.ToInt32(txtValorladomayor.Text)
            ladomenor = Convert.ToInt32(txtValorladomenor.Text)
            lblResultado.Text = Convert.ToString(ladomayor * ladomenor)
            lblResultado.Show()
        End If
    End Sub

    Private Sub btnTriangulo_Click(sender As Object, e As EventArgs) Handles btnTriangulo.Click
        Dim valorbase, valoraltura As Integer

        If txtValorbase.Text = "" Then
            MessageBox.Show("No introdujo ningun valor de la base")
        ElseIf txtValoraltura.Text = "" Then
            MessageBox.Show("No introdujo ningun valor de la altura")
        Else
            valorbase = Convert.ToInt32(txtValorbase.Text)
            valoraltura = Convert.ToInt32(txtValoraltura.Text)
            lblResultado.Text = Convert.ToString(valorbase * valoraltura / 2)
            lblResultado.Show()
        End If
    End Sub
End Class