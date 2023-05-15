Public Class Ejercicio8
    Private Sub Ejercicio8_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub btnGuardarusuario_Click(sender As Object, e As EventArgs) Handles btnGuardarusuario.Click
        Dim Nombre, Apellidos, Edad, Email, DNI, fecha As String

        If txtDatosnombre.Text = "" Then
            MessageBox.Show("No introdujo ningun nombre")
        Else
            Nombre = txtDatosnombre.Text
        End If

        If txtDatosapellidos.Text = "" Then
            MessageBox.Show("No introdujo ningun Apellido")
        Else
            Apellidos = txtDatosnombre.Text
        End If

        If txtDatosedad.Text = "" Then
            MessageBox.Show("No introdujo ninguna edad")
        Else
            Edad = txtDatosnombre.Text
        End If

        If txtDatosemail.Text = "" Then
            MessageBox.Show("No introdujo ningun email")
        Else
            Email = txtDatosnombre.Text
        End If

        If txtDatosDNI.Text = "" Then
            MessageBox.Show("No introdujo ningun DNI")
        Else
            Dim DNIbien As Double
            Dim letra As Char
            Dim letras() As String = {"T"c, "R"c, "W"c, "A"c, "G"c, "M"c, "Y"c, "F"c, "P"c, "D"c, "X"c, "B"c, "N"c, "J"c, "Z"c, "S"c, "Q"c, "V"c, "H"c, "L"c, "C"c, "K"c, "E"c}
            letra = Convert.ToChar(txtDatosDNI.Text.Substring(8, 1))
            DNIbien = Convert.ToDouble(txtDatosDNI.Text.Substring(0, 8))
            DNIbien = DNIbien Mod 23
            If letra = letras(Convert.ToInt32(DNIbien)) Then
                MessageBox.Show(Convert.ToString(DNIbien))
                DNI = txtDatosnombre.Text
            Else
                MessageBox.Show("Su letra del DNI es incorrecta")
            End If


        End If







        fecha = dtpDatosfechanacimiento.ToString

        MessageBox.Show(fecha)

    End Sub
End Class