Imports System.IO
Public Class Ejercicio8

    Dim fichero As New StreamWriter() = Directory.GetCurrentDirectory + ("\Datos.txt")

    Private Sub Ejercicio8_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub btnGuardarusuario_Click(sender As Object, e As EventArgs) Handles btnGuardarusuario.Click
        Dim Nombre, Apellidos, Edad, Email, DNI, fecha As String
        Dim correcto As Integer = 0
        Dim edadcorrecto As Boolean

        For i = 0 To txtDatosedad.Text.Length - 1
            If Char.IsLetter(txtDatosedad.Text(i)) Then
                edadcorrecto = False
            End If
        Next


        If txtDatosnombre.Text = "" Then
            MessageBox.Show("No introdujo ningun nombre")
        Else
            Nombre = txtDatosnombre.Text
            correcto += 1
        End If

        If txtDatosapellidos.Text = "" Then
            MessageBox.Show("No introdujo ningun Apellido")
        Else
            Apellidos = txtDatosnombre.Text
            correcto += 1
        End If

        If txtDatosedad.Text = "" Then
            MessageBox.Show("No introdujo ninguna edad")
        ElseIf edadcorrecto = False Then
            MessageBox.Show("Su edad contiene una letra")
        ElseIf txtDatosapellidos.Text < "18" Then
            MessageBox.Show("No es mayor de edad")
        Else
            Edad = txtDatosnombre.Text
            correcto += 1
        End If


        If txtDatosemail.Text = "" Then
            MessageBox.Show("No introdujo ningun email")
        ElseIf Not txtDatosemail.Text.Contains("@"c) Then
            MessageBox.Show("Su email no contiene ningun arroba")
        Else
            If txtDatosemail.Text.EndsWith(".com") Or txtDatosemail.Text.EndsWith(".es") Or txtDatosemail.Text.EndsWith(".org") Or txtDatosemail.Text.EndsWith(".io") Then
                Email = txtDatosnombre.Text
                correcto += 1
            Else
                MessageBox.Show("Su email no contiene el nombre de ningun dominio (.com , .es , .org , .io)")
            End If
        End If





        'Declaro dni para comprobar que es correcto el dni introducido
        DNI = txtDatosDNI.Text


        Dim contador As Integer


        For i = 0 To DNI.Length - 1
            If Char.IsDigit(DNI(i)) And DNI.Length - 1 = 8 Then
                contador += 1
            End If
        Next

        If txtDatosDNI.Text = "" Then
            MessageBox.Show("No introdujo ningun DNI")
        ElseIf DNI.Length > 9 Or DNI.Length < 9 Then
            MessageBox.Show("Su DNI es incorrecto")
        ElseIf Not Char.IsLetter(txtDatosDNI.Text(8)) Then
            MessageBox.Show("Su DNI no tiene letra")
        ElseIf contador <> 8 Then
            MessageBox.Show("Su DNI no tiene 8 digitos")

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
                correcto += 1
            Else
                MessageBox.Show("Su letra del DNI es incorrecta")
            End If


        End If



        fecha = Convert.ToString(dtpDatosfechanacimiento.Value)

        MessageBox.Show(fecha)

        If correcto = 5 Then

        End If


    End Sub
End Class