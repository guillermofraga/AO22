﻿Imports System.IO
Public Class Ejercicio8

    Dim ruta As String = Directory.GetCurrentDirectory + ("\Datos.txt")
    Dim datos As New ArrayList

    Private Sub Ejercicio8_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        txtDatosnombre.Text = ""
        txtDatosapellidos.Text = ""
        txtDatosedad.Text = ""
        txtDatosemail.Text = ""
        txtDatosDNI.Text = ""

    End Sub

    Private Sub btnGuardarusuario_Click(sender As Object, e As EventArgs) Handles btnGuardarusuario.Click
        Dim Nombre, Apellidos, Edad, Email, DNI, fecha As String
        Dim correcto As Integer = 0
        Dim edadcorrecto As Boolean = True
        Dim datosseparado As String
        Dim dnirepetido As Boolean = True



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
            Apellidos = txtDatosapellidos.Text
            correcto += 1
        End If

        If txtDatosedad.Text = "" Then
            MessageBox.Show("No introdujo ninguna edad")
        ElseIf edadcorrecto = False Then
            MessageBox.Show("Su edad contiene una letra")
        ElseIf txtDatosapellidos.Text < "18" Then
            MessageBox.Show("No es mayor de edad")
        Else
            Edad = txtDatosedad.Text
            correcto += 1
        End If


        If txtDatosemail.Text = "" Then
            MessageBox.Show("No introdujo ningun email")
        ElseIf Not txtDatosemail.Text.Contains("@"c) Then
            MessageBox.Show("Su email no contiene ningun arroba")
        Else
            If txtDatosemail.Text.EndsWith(".com") Or txtDatosemail.Text.EndsWith(".es") Or txtDatosemail.Text.EndsWith(".org") Or txtDatosemail.Text.EndsWith(".io") Then
                Email = txtDatosemail.Text
                correcto += 1
            Else
                MessageBox.Show("Su email no contiene el nombre de ningun dominio (.com , .es , .org , .io)")
            End If
        End If





        'Declaro dni para comprobar que es correcto el dni introducido
        DNI = txtDatosDNI.Text


        Dim contador As Integer = 0


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
                DNI = txtDatosDNI.Text
                correcto += 1
            Else
                MessageBox.Show("Su letra del DNI es incorrecta")
            End If


        End If


        Dim respuesta, respuestaGuardar As DialogResult

        fecha = Convert.ToString(dtpDatosfechanacimiento.Value)

        If correcto = 5 Then
            respuesta = MessageBox.Show("La fecha es correcta? s/n: " & fecha, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        If respuesta = DialogResult.Yes And correcto = 5 Then
            datosseparado = Nombre & "*" & Apellidos & "*" & Edad & "*" & Email & "*" & DNI & "*" & fecha
            respuestaGuardar = MessageBox.Show("Los Datos son correctos " & datosseparado.Split("*"c)(0) & " - " & datosseparado.Split("*"c)(1) & " - " & datosseparado.Split("*"c)(2) & " - " & datosseparado.Split("*"c)(3) & " - " & datosseparado.Split("*"c)(4) & " - " & datosseparado.Split("*"c)(5), "Confirmación para guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        Dim lector1 As New StreamReader(ruta)
        Dim contadorlector As Integer = 0
        Dim leerdatos1(99) As String

        While Not lector1.EndOfStream
            leerdatos1(contadorlector) = lector1.ReadLine()
                contadorlector += 1
        End While

        lector1.Close()

        For i = 0 To leerdatos1.Length - 1
            If txtDatosDNI.Text <> "" And leerdatos1(i) <> "" Then
                If txtDatosDNI.Text = leerdatos1(i).Split("*"c)(4) Then
                    dnirepetido = False
                End If
            End If
        Next

        Dim fichero As StreamWriter = New StreamWriter(ruta, True)

        If respuestaGuardar = DialogResult.Yes And dnirepetido = True Then
            datos.Add(datosseparado)
            fichero.WriteLine(datosseparado)
            MessageBox.Show("La base de datos personales ha sido actualizada")
            fichero.Close()
        Else
            MessageBox.Show("Su dni esta repetido")
        End If



    End Sub

    Private Sub Ejercicio8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDatosDNI.MaxLength = 9
        txtDatosedad.MaxLength = 3

        Dim lector As New StreamReader(ruta)
        Dim contador As Integer
        Dim leerdatos(99) As String

        While Not lector.EndOfStream
            leerdatos(contador) = lector.ReadLine()
                contador += 1
        End While

        lector.Close()


        txtVisualizarnombre.Text = leerdatos(0).Split("*"c)(0)
        txtVisualizarapellidos.Text = leerdatos(0).Split("*"c)(1)
        txtVisualizaredad.Text = leerdatos(0).Split("*"c)(2)
        txtVisualizaremail.Text = leerdatos(0).Split("*"c)(3)
        txtVisualizardni.Text = leerdatos(0).Split("*"c)(4)




    End Sub

    Private Sub txtDatosedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDatosedad.KeyPress
        Dim botonpulsado As Char = e.KeyChar

        If Not Char.IsDigit(botonpulsado) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtDatosedad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDatosedad.KeyDown

        If e.KeyCode = Keys.Back Then
            txtDatosedad.Text = ""
        End If

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click

        Dim lector2 As New StreamReader(ruta)
        Dim contador2 As Integer
        Dim leerdatos2(99) As String

        While Not lector2.EndOfStream
            leerdatos2(contador2) = lector2.ReadLine()
            contador2 += 1
        End While

        lector2.Close()

        txtVisualizarnombre.Text = leerdatos2(0).Split("*"c)(0)
        txtVisualizarapellidos.Text = leerdatos2(0).Split("*"c)(1)
        txtVisualizaredad.Text = leerdatos2(0).Split("*"c)(2)
        txtVisualizaremail.Text = leerdatos2(0).Split("*"c)(3)
        txtVisualizardni.Text = leerdatos2(0).Split("*"c)(4)

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        Dim lector3 As New StreamReader(ruta)
        Dim contador3 As Integer
        Dim leerdatos3(99) As String

        While Not lector3.EndOfStream
            leerdatos3(contador3) = lector3.ReadLine()
            contador3 += 1
        End While

        MessageBox.Show(leerdatos3(leerdatos3.Length - 1))

        lector3.Close()

        txtVisualizarnombre.Text = leerdatos3(leerdatos3.Length - 1).Split("*"c)(0)
        txtVisualizarapellidos.Text = leerdatos3(leerdatos3.Length - 1).Split("*"c)(1)
        txtVisualizaredad.Text = leerdatos3(leerdatos3.Length - 1).Split("*"c)(2)
        txtVisualizaremail.Text = leerdatos3(leerdatos3.Length - 1).Split("*"c)(3)
        txtVisualizardni.Text = leerdatos3(leerdatos3.Length - 1).Split("*"c)(4)

    End Sub
End Class