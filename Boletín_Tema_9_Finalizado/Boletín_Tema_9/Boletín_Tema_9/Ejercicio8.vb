Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Permissions

Public Class Ejercicio8

    Dim ruta As String = Directory.GetCurrentDirectory + ("\Datos.txt")
    Dim datos As New List(Of String)

    Private Sub Ejercicio8_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        txtDatosnombre.Text = ""
        txtDatosapellidos.Text = ""
        txtDatosedad.Text = ""
        txtDatosemail.Text = ""
        txtDatosDNI.Text = ""
        txtBuscarusuario.Text = ""
        txtEliminarusuario.Text = ""

    End Sub

    Private Sub btnGuardarusuario_Click(sender As Object, e As EventArgs) Handles btnGuardarusuario.Click
        Dim Nombre, Apellidos, Edad, Email, DNI, datofecha As String
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

        datofecha = dtpDatosfechanacimiento.Value.ToShortDateString

        If correcto = 5 Then
            respuesta = MessageBox.Show("La fecha es correcta? s/n: " & datofecha, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        If respuesta = DialogResult.Yes And correcto = 5 Then
            datosseparado = Nombre & "*" & Apellidos & "*" & Edad & "*" & Email & "*" & DNI & "*" & datofecha
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
        ElseIf dnirepetido = False Then
            MessageBox.Show("Su dni esta repetido")
        Else
        End If

        For Each elementos In datos
            MessageBox.Show(elementos)
        Next

        fichero.Close()

    End Sub

    Private Sub Ejercicio8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDatosDNI.MaxLength = 9
        txtDatosedad.MaxLength = 3

        datos.Clear()

        Dim lector As New StreamReader(ruta)
        Dim contador As Integer = 0
        Dim leerdatos(99) As String
        Dim registro As String


        While Not lector.EndOfStream
            leerdatos(contador) = lector.ReadLine()
            contador += 1
        End While

        lector.Close()

        Dim lector2 As New StreamReader(ruta)

        While Not lector2.EndOfStream
            registro = lector2.ReadLine()
            datos.Add(registro)
        End While

        lector2.Close()

        If leerdatos(0) = Nothing Then

        Else
            txtVisualizarnombre.Text = leerdatos(0).Split("*"c)(0)
            txtVisualizarapellidos.Text = leerdatos(0).Split("*"c)(1)
            txtVisualizaredad.Text = leerdatos(0).Split("*"c)(2)
            txtVisualizaremail.Text = leerdatos(0).Split("*"c)(3)
            txtVisualizardni.Text = leerdatos(0).Split("*"c)(4)
            txtFecha.Text = leerdatos(0).Split("*"c)(5)
        End If



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

        If leerdatos2(0) IsNot Nothing Then
            txtVisualizarnombre.Text = leerdatos2(0).Split("*"c)(0)
            txtVisualizarapellidos.Text = leerdatos2(0).Split("*"c)(1)
            txtVisualizaredad.Text = leerdatos2(0).Split("*"c)(2)
            txtVisualizaremail.Text = leerdatos2(0).Split("*"c)(3)
            txtVisualizardni.Text = leerdatos2(0).Split("*"c)(4)
            txtFecha.Text = leerdatos2(0).Split("*"c)(5)
        Else
            For i = 0 To leerdatos2.Length - 1
                If leerdatos2(i) <> Nothing Then
                    txtVisualizarnombre.Text = leerdatos2(i).Split("*"c)(0)
                    txtVisualizarapellidos.Text = leerdatos2(i).Split("*"c)(1)
                    txtVisualizaredad.Text = leerdatos2(i).Split("*"c)(2)
                    txtVisualizaremail.Text = leerdatos2(i).Split("*"c)(3)
                    txtVisualizardni.Text = leerdatos2(i).Split("*"c)(4)
                    txtFecha.Text = leerdatos2(i).Split("*"c)(5)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click

        Dim lector3 As New StreamReader(ruta)
        Dim contador3 As Integer
        Dim leerdatos3(99) As String
        Dim nombre, apellidos, edad, email, dni, fecha As String

        While Not lector3.EndOfStream
            leerdatos3(contador3) = lector3.ReadLine()
            contador3 += 1
        End While


        lector3.Close()

        For i = 0 To leerdatos3.Length - 1
            If leerdatos3(i) <> Nothing Then
                nombre = leerdatos3(i).Split("*"c)(0)
                apellidos = leerdatos3(i).Split("*"c)(1)
                edad = leerdatos3(i).Split("*"c)(2)
                email = leerdatos3(i).Split("*"c)(3)
                dni = leerdatos3(i).Split("*"c)(4)
                fecha = leerdatos3(i).Split("*"c)(5)
            End If
        Next

        txtVisualizarnombre.Text = nombre
        txtVisualizarapellidos.Text = apellidos
        txtVisualizaredad.Text = edad
        txtVisualizaremail.Text = email
        txtVisualizardni.Text = dni
        txtFecha.Text = fecha

    End Sub

    Private Sub btnanterior_Click(sender As Object, e As EventArgs) Handles btnanterior.Click

        Dim lector4 As New StreamReader(ruta)
        Dim contador4 As Integer
        Dim leerdatos4(99) As String
        Dim posicionanterior As Integer

        While Not lector4.EndOfStream
            leerdatos4(contador4) = lector4.ReadLine()
            contador4 += 1
        End While

        lector4.Close()


        For i = 0 To leerdatos4.Length - 1
            If txtVisualizardni.Text <> "" And leerdatos4(i) IsNot Nothing Then
                If txtVisualizardni.Text = leerdatos4(i).Split("*"c)(4) Then
                    posicionanterior = i
                    Exit For
                End If
            End If
        Next

        If posicionanterior - 1 < 0 Then
        Else
            txtVisualizarnombre.Text = leerdatos4(posicionanterior - 1).Split("*"c)(0)
            txtVisualizarapellidos.Text = leerdatos4(posicionanterior - 1).Split("*"c)(1)
            txtVisualizaredad.Text = leerdatos4(posicionanterior - 1).Split("*"c)(2)
            txtVisualizaremail.Text = leerdatos4(posicionanterior - 1).Split("*"c)(3)
            txtVisualizardni.Text = leerdatos4(posicionanterior - 1).Split("*"c)(4)
            txtFecha.Text = leerdatos4(posicionanterior - 1).Split("*"c)(5)
        End If



    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click

        Dim lector5 As New StreamReader(ruta)
        Dim contador5 As Integer
        Dim leerdatos5(99) As String
        Dim posicionsiguiente As Integer

        While Not lector5.EndOfStream
            leerdatos5(contador5) = lector5.ReadLine()
            contador5 += 1
        End While

        lector5.Close()


        For i = 0 To leerdatos5.Length - 1
            If txtVisualizardni.Text <> "" And leerdatos5(i) IsNot Nothing Then
                If txtVisualizardni.Text = leerdatos5(i).Split("*"c)(4) Then
                    posicionsiguiente = i
                    Exit For
                End If
            End If
        Next

        If leerdatos5(posicionsiguiente + 1) = Nothing Then
        Else
            txtVisualizarnombre.Text = leerdatos5(posicionsiguiente + 1).Split("*"c)(0)
            txtVisualizarapellidos.Text = leerdatos5(posicionsiguiente + 1).Split("*"c)(1)
            txtVisualizaredad.Text = leerdatos5(posicionsiguiente + 1).Split("*"c)(2)
            txtVisualizaremail.Text = leerdatos5(posicionsiguiente + 1).Split("*"c)(3)
            txtVisualizardni.Text = leerdatos5(posicionsiguiente + 1).Split("*"c)(4)
            txtFecha.Text = leerdatos5(posicionsiguiente + 1).Split("*"c)(5)
        End If




    End Sub

    Private Sub btnBuscarusuario_Click(sender As Object, e As EventArgs) Handles btnBuscarusuario.Click

        For Each elemento In datos
            If txtBuscarusuario.Text = elemento.Split("*"c)(4) Then
                txtVisualizarnombre.Text = elemento.Split("*"c)(0)
                txtVisualizarapellidos.Text = elemento.Split("*"c)(1)
                txtVisualizaredad.Text = elemento.Split("*"c)(2)
                txtVisualizaremail.Text = elemento.Split("*"c)(3)
                txtVisualizardni.Text = elemento.Split("*"c)(4)
                txtFecha.Text = elemento.Split("*"c)(5)
            End If
        Next

    End Sub

    Private Sub btnBorrarusuario_Click(sender As Object, e As EventArgs) Handles btnBorrarusuario.Click
        Dim confirmacionborrar As DialogResult

        confirmacionborrar = MessageBox.Show("Esta seguro de querer borrar el usuario? s/n: ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmacionborrar = DialogResult.Yes Then

            For Each elemento In datos
                If txtEliminarusuario.Text = elemento.Split("*"c)(4) Then
                    datos.Remove(elemento)
                    Exit For
                End If
            Next

            Dim fichero As StreamWriter = New StreamWriter(ruta, False)

            For Each guardar In datos
                fichero.WriteLine(guardar)
            Next
            fichero.Close()
        End If


    End Sub
End Class