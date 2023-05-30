Public Class Ejercicio2
    Private Sub Ejercicio2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        lblfecha.Text = ""
        txtDia.Text = ""
        txtMes.Text = ""
        txtAño.Text = ""
    End Sub
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim dia, mes, año As Integer
        Dim mes1 As String

        If txtDia.Text = "" Then
            MessageBox.Show("No introdujo ningun día")
            txtDia.BackColor = Color.Red
        Else
            dia = Convert.ToInt32(txtDia.Text)
        End If


        If txtMes.Text = "" Then
            MessageBox.Show("No introdujo ningun mes")
            txtMes.BackColor = Color.Red
        Else
            mes = Convert.ToInt32(txtMes.Text)
            mes1 = MonthName(mes)
        End If

        If txtAño.Text = "" Then
            txtAño.BackColor = Color.Red
            MessageBox.Show("No introdujo ningun año")
        Else
            año = Convert.ToInt32(txtAño.Text)
        End If


        If txtDia.Text <> "" And txtMes.Text <> "" And txtAño.Text <> "" Then
            lblfecha.Text = dia & " de " & mes1 & " de " & año
            lblfecha.Show()
            txtDia.BackColor = Color.White
            txtMes.BackColor = Color.White
            txtAño.BackColor = Color.White
        End If

    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lblfecha.Text = ""
        txtDia.Text = ""
        txtMes.Text = ""
        txtAño.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Ejercicio2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class