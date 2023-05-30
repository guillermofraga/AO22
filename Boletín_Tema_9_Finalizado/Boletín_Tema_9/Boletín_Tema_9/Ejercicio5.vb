Public Class Ejercicio5
    Private Sub Ejercicio5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        txtn1.Text = ""
        txtn2.Text = ""
        lbloperadores.Text = ""
        lblIgual.Text = ""
        lblResultado.Text = ""
    End Sub
    Private Sub Ejercicio5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtn1.Select()
    End Sub
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim numero, numero1 As Integer

        If txtn1.Text = "" Then
            MessageBox.Show("No introdujo ningun numero")
            txtn1.Focus()
            txtn1.BackColor = Color.Red
        ElseIf txtn2.Text = "" Then
            MessageBox.Show("No introdujo ningun numero")
            txtn2.Focus()
            txtn2.BackColor = Color.Red
            txtn1.BackColor = Color.White
        Else
            numero = Convert.ToInt32(txtn1.Text)
            numero1 = Convert.ToInt32(txtn2.Text)
            lbloperadores.Text = "+"
            txtn1.BackColor = Color.White
            txtn2.BackColor = Color.White
            lblResultado.Text = Convert.ToString(numero + numero1)
            lbloperadores.Show()
        End If
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim numero, numero1 As Integer

        If txtn1.Text = "" Then
            MessageBox.Show("No introdujo ningun numero")
            txtn1.Focus()
            txtn1.BackColor = Color.Red
        ElseIf txtn2.Text = "" Then
            MessageBox.Show("No introdujo ningun numero")
            txtn2.Focus()
            txtn2.BackColor = Color.Red
            txtn1.BackColor = Color.White
        Else
            numero = Convert.ToInt32(txtn1.Text)
            numero1 = Convert.ToInt32(txtn2.Text)
            lbloperadores.Text = "-"
            txtn1.BackColor = Color.White
            txtn2.BackColor = Color.White
            lblResultado.Text = Convert.ToString(numero - numero1)
            lbloperadores.Show()
        End If
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim numero, numero1 As Integer

        If txtn1.Text = "" Then
            MessageBox.Show("No introdujo ningun numero")
            txtn1.Focus()
            txtn1.BackColor = Color.Red
        ElseIf txtn2.Text = "" Then
            MessageBox.Show("No introdujo ningun numero")
            txtn2.Focus()
            txtn2.BackColor = Color.Red
            txtn1.BackColor = Color.White
        Else
            numero = Convert.ToInt32(txtn1.Text)
            numero1 = Convert.ToInt32(txtn2.Text)
            lbloperadores.Text = "*"
            txtn1.BackColor = Color.White
            txtn2.BackColor = Color.White
            lblResultado.Text = Convert.ToString(numero * numero1)
            lbloperadores.Show()
        End If
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim numero, numero1 As Integer

        If txtn1.Text = "" Then
            MessageBox.Show("No introdujo ningun numero")
            txtn1.Focus()
            txtn1.BackColor = Color.Red
        ElseIf txtn2.Text = "" Then
            MessageBox.Show("No introdujo ningun numero")
            txtn2.Focus()
            txtn2.BackColor = Color.Red
            txtn1.BackColor = Color.White
        Else
            numero = Convert.ToInt32(txtn1.Text)
            numero1 = Convert.ToInt32(txtn2.Text)
            lbloperadores.Text = "/"
            txtn1.BackColor = Color.White
            txtn2.BackColor = Color.White
            lblResultado.Text = Convert.ToString(numero / numero1)
            lbloperadores.Show()
        End If
    End Sub
End Class