﻿Imports System.IO
Module Module1
    Sub Main()


        Dim seleccionar As Integer

        Console.WriteLine("Introduzca un número del 1 al 16 para seleccionar el ejercicio: ")
        seleccionar = Convert.ToInt32(Console.ReadLine())

        Select Case seleccionar
            Case 1
                Dim matricula() As String = {"2412-ABZ", "9512-GER", "4342-OPW", "1520-PÑA", "7148-IAL", "9872-LÑB", "7420-MAZ", "8621-ÑZM", "1041-BUI", "1032-QDD"}
                Dim c As Char = "Z"c
                Dim ruta As String = Directory.GetCurrentDirectory() + "\Matriculas.txt"

                For i = 0 To matricula.Length - 1
                    If matricula(i).EndsWith(c) Then
                        Console.WriteLine("La matricula " & i & "º acaba en Z")
                    End If
                Next

                For a = 0 To matricula.Length - 1
                    If matricula(a).Contains("34") Then
                        Console.WriteLine("La matricula " & a & "º contiene el número 34")
                    End If
                Next

                For b = 0 To matricula.Length - 1
                    Dim numero As String = matricula(b).Substring(0, 3)
                    Console.WriteLine(numero)
                Next

                For l = 0 To matricula.Length - 1
                    Dim letra As String = matricula(l).Substring(5, 3)
                    Console.WriteLine(letra)
                Next

                Dim guardar As New StreamWriter(ruta, False)

                For p = 0 To matricula.Length - 1
                    guardar.WriteLine(matricula(p))
                Next

                guardar.Close()


            Case 2

                Dim palabra As String = "hola"
                Dim letra As Char
                Dim contador As Integer

                Console.WriteLine("Introduzca el valor a buscar: ")
                letra = Convert.ToChar(Console.ReadLine())

                For i = 0 To palabra.Length - 1
                    If palabra(i) = letra Then
                        contador += 1
                    End If
                Next

                Console.WriteLine("EL valor que buscas aparece: " & contador & " veces")



            Case 3

                Dim DNI As String
                Dim contador As Integer
                Dim n As Integer

                Console.WriteLine("Introduzca su DNI: ")
                DNI = Console.ReadLine()


                For a = 0 To 7
                    If Char.IsDigit(DNI(a)) Then
                        contador += 1
                    Else
                        Exit For
                    End If
                Next

                If contador <> 8 Then
                    Console.WriteLine("Su número de DNI es incorrecto")
                Else
                    Console.WriteLine("Su número de DNI es correcto")
                    n = CInt(DNI.Substring(0, 8))
                End If
                n = n Mod 23
                Dim letra() As Char = {"T"c, "R"c, "W"c, "A"c, "G"c, "M"c, "Y"c, "F"c, "P"c, "D"c, "X"c, "B"c, "N"c, "J"c, "Z"c, "S"c, "Q"c, "V"c, "H"c, "L"c, "C"c, "K"c, "E"c}

                If Char.IsLetter(DNI(DNI.Length - 1)) And DNI(DNI.Length - 1) = letra(n) Then
                    Console.WriteLine("Su letra del DNI es correcta")
                Else
                    Console.WriteLine("No introdujo ninguna letra o su letra no coincide con su numero de DNI")
                End If


                If Char.IsLetter(DNI(DNI.Length - 1)) And contador = 8 Then
                    Console.WriteLine("Su DNI es correcto")
                Else
                    Console.WriteLine("Introdujo mal su DNI")
                End If



            Case 4

                Dim escribir As String

                Console.WriteLine("Escribe: ")
                escribir = Console.ReadLine()

                Dim palabras() As String = escribir.Split(" "c)

                For i = 0 To palabras.Length - 1
                    If palabras(i).StartsWith("b"c) Then
                        Console.WriteLine("Palabra que empieza por b: " & palabras(i))
                    End If
                Next

            Case 5

                Dim correo As String

                Console.WriteLine("Introduzca su correo electronico: ")
                correo = Console.ReadLine()

                If correo.Contains("@"c) Then
                    Console.WriteLine("Introdujo bien su correo")
                Else
                    Console.WriteLine("Introdujo mal su correo")
                End If



            Case 6

                Dim texto, texto2 As String
                Dim cont As Integer

                Console.WriteLine("Escribe: ")
                texto = Console.ReadLine()

                Dim palabras() As String = texto.Split(" "c)

                For i = 0 To palabras.Length - 1
                    If palabras(i).Contains("aba") Then
                        cont += 1
                    End If
                Next

                Console.WriteLine("El string contiene: " & cont & " palabras")

                Console.WriteLine("Introduzca letras a buscar: ")
                texto2 = Console.ReadLine()

                For a = 0 To palabras.Length - 1
                    If palabras(a).Contains(texto2) Then
                        Console.WriteLine("La palabra que contiene " & texto2 & " es: " & palabras(a))
                    End If
                Next

            Case 7

                Dim correo As String
                Dim posicion As Integer

                Console.WriteLine("Introduzca su correo electronico: ")
                correo = Console.ReadLine()

                Dim dominio As String
                posicion = correo.LastIndexOf("@"c)
                posicion += 1
                dominio = correo.Substring(posicion)

                Console.WriteLine("El dominio de su correo es: " & dominio)

            Case 8

                Dim codigo As String
                Dim contador As Integer

                Console.WriteLine("Introduzca el codigo con este formato AA00: ")
                codigo = Console.ReadLine()

                For i = 0 To codigo.Length - 1
                    If Char.IsLetter(codigo(i)) And contador <= 2 Then
                        contador += 1
                    End If
                    If Char.IsDigit(codigo(i)) And contador >= 2 Then
                        contador += 1
                    End If
                Next

                If contador = 4 Then
                    Console.WriteLine("introdujo bien el formato")
                Else
                    Console.WriteLine("introdujo mal el formato")
                End If


            Case 9

                Dim texto As String

                Console.WriteLine("Escribe: ")
                texto = Console.ReadLine()

                Dim b() As Char = texto.ToCharArray()

                For i = 0 To b.Length - 1
                    If b(i) = " "c Then
                        b(i) = "*"c
                    End If
                Next

                For p = 0 To b.Length - 1
                    Console.Write(b(p))
                Next

            Case 10

                Dim nombres(1), salario2(1), nombre(1) As String
                Dim salario(1) As Integer

                nombres(0) = "Pedro Jimenez*14Julio1990?2500"
                nombres(1) = "Maria Benitez*9070!06Agosto1998"

                salario(0) = nombres(0).LastIndexOf("?")
                salario(1) = nombres(1).LastIndexOf("*")

                For i = 0 To nombres.Length - 1
                    If salario(i) = nombres(i).LastIndexOf("?") Then
                        nombre(i) = nombres(i).Substring(0, 13)
                        salario2(i) = nombres(i).Substring(salario(i) + 1, 4)
                    End If

                    If salario(i) = nombres(i).LastIndexOf("*") Then
                        nombre(i) = nombres(i).Substring(0, 13)
                        salario2(i) = nombres(i).Substring(salario(i) + 1, 4)
                    End If
                Next

                Console.WriteLine(salario2(0))
                Console.WriteLine(salario2(1))

                For a = 0 To salario2.Length - 1
                    If salario2(a) > "1000" Then
                        Console.WriteLine("El salario de:" & nombre(a) & " supera los 1000 euros")
                    End If
                Next



            Case 11

                Dim palabra, muñeco(8, 8) As String
                Dim n(6), intentos, contador As Integer
                Dim alet As New Random
                Dim letra As Char

                intentos = 6
                palabra = "asdfa"

                For a = 0 To n.Length - 1
                    n(a) = alet.Next(65, 90)
                Next

                Dim arraycaracteres() As Char = palabra.ToCharArray()

                For x = 0 To arraycaracteres.Length - 1
                    If arraycaracteres(x) = arraycaracteres(x) Then
                        arraycaracteres(x) = Chr(n(x))
                    End If
                Next

                For ñ = 0 To arraycaracteres.Length - 1
                    Console.Write(arraycaracteres(ñ))
                Next

                Console.WriteLine("")

                Console.WriteLine("")

                Do

                    Console.WriteLine("Introduzca una letra en Mayuscula")
                    letra = Convert.ToChar(Console.ReadLine())

                    For m = 0 To arraycaracteres.Length - 1
                        If arraycaracteres(m) = letra Then
                            Console.WriteLine("Acertaste una letra")
                            contador += 1
                        End If
                    Next

                    If contador = 0 Then
                        Console.WriteLine("Fallaste una letra")
                        intentos -= 1
                    End If

                    If intentos = 5 Then
                        For ñ = 0 To muñeco.GetUpperBound(0)
                            For z = 0 To muñeco.GetUpperBound(1)
                                If ñ = 2 And z = 4 Then
                                    muñeco(2, 4) = "O"
                                ElseIf ñ = 3 And z = 4 Then
                                    muñeco(3, 4) = "|"
                                ElseIf ñ = 3 And z = 3 Then
                                    muñeco(3, 3) = "/"
                                ElseIf ñ = 3 And z = 5 Then
                                    muñeco(3, 5) = "\"
                                ElseIf ñ = 4 And z = 3 Then
                                    muñeco(4, 3) = "/"
                                ElseIf ñ = 4 And z = 5 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 5) = "\"
                                Else
                                    muñeco(ñ, z) = "."
                                End If
                                Console.Write(muñeco(ñ, z))
                                Console.ResetColor()
                            Next
                            Console.WriteLine("")
                        Next
                    End If

                    If intentos = 4 Then
                        For ñ = 0 To muñeco.GetUpperBound(0)
                            For z = 0 To muñeco.GetUpperBound(1)
                                If ñ = 2 And z = 4 Then
                                    muñeco(2, 4) = "O"
                                ElseIf ñ = 3 And z = 4 Then
                                    muñeco(3, 4) = "|"
                                ElseIf ñ = 3 And z = 3 Then
                                    muñeco(3, 3) = "/"
                                ElseIf ñ = 3 And z = 5 Then
                                    muñeco(3, 5) = "\"
                                ElseIf ñ = 4 And z = 3 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 3) = "/"
                                ElseIf ñ = 4 And z = 5 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 5) = "\"
                                Else
                                    muñeco(ñ, z) = "."
                                End If
                                Console.Write(muñeco(ñ, z))
                                Console.ResetColor()
                            Next
                            Console.WriteLine("")
                        Next
                    End If

                    If intentos = 3 Then
                        For ñ = 0 To muñeco.GetUpperBound(0)
                            For z = 0 To muñeco.GetUpperBound(1)
                                If ñ = 2 And z = 4 Then
                                    muñeco(2, 4) = "O"
                                ElseIf ñ = 3 And z = 4 Then
                                    muñeco(3, 4) = "|"
                                ElseIf ñ = 3 And z = 3 Then
                                    muñeco(3, 3) = "/"
                                ElseIf ñ = 3 And z = 5 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(3, 5) = "\"
                                ElseIf ñ = 4 And z = 3 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 3) = "/"
                                ElseIf ñ = 4 And z = 5 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 5) = "\"
                                Else
                                    muñeco(ñ, z) = "."
                                End If
                                Console.Write(muñeco(ñ, z))
                                Console.ResetColor()
                            Next
                            Console.WriteLine("")
                        Next
                    End If

                    If intentos = 2 Then
                        For ñ = 0 To muñeco.GetUpperBound(0)
                            For z = 0 To muñeco.GetUpperBound(1)
                                If ñ = 2 And z = 4 Then
                                    muñeco(2, 4) = "O"
                                ElseIf ñ = 3 And z = 4 Then
                                    muñeco(3, 4) = "|"
                                ElseIf ñ = 3 And z = 3 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(3, 3) = "/"
                                ElseIf ñ = 3 And z = 5 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(3, 5) = "\"
                                ElseIf ñ = 4 And z = 3 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 3) = "/"
                                ElseIf ñ = 4 And z = 5 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 5) = "\"
                                Else
                                    muñeco(ñ, z) = "."
                                End If
                                Console.Write(muñeco(ñ, z))
                                Console.ResetColor()
                            Next
                            Console.WriteLine("")
                        Next
                    End If

                    If intentos = 1 Then
                        For ñ = 0 To muñeco.GetUpperBound(0)
                            For z = 0 To muñeco.GetUpperBound(1)
                                If ñ = 2 And z = 4 Then
                                    muñeco(2, 4) = "O"
                                ElseIf ñ = 3 And z = 4 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(3, 4) = "|"
                                ElseIf ñ = 3 And z = 3 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(3, 3) = "/"
                                ElseIf ñ = 3 And z = 5 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(3, 5) = "\"
                                ElseIf ñ = 4 And z = 3 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 3) = "/"
                                ElseIf ñ = 4 And z = 5 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 5) = "\"
                                Else
                                    muñeco(ñ, z) = "."
                                End If
                                Console.Write(muñeco(ñ, z))
                                Console.ResetColor()
                            Next
                            Console.WriteLine("")
                        Next
                    End If

                    If intentos = 0 Then
                        For ñ = 0 To muñeco.GetUpperBound(0)
                            For z = 0 To muñeco.GetUpperBound(1)
                                If ñ = 2 And z = 4 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(2, 4) = "O"
                                ElseIf ñ = 3 And z = 4 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(3, 4) = "|"
                                ElseIf ñ = 3 And z = 3 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(3, 3) = "/"
                                ElseIf ñ = 3 And z = 5 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(3, 5) = "\"
                                ElseIf ñ = 4 And z = 3 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 3) = "/"
                                ElseIf ñ = 4 And z = 5 Then
                                    Console.ForegroundColor = ConsoleColor.Red
                                    muñeco(4, 5) = "\"
                                Else
                                    muñeco(ñ, z) = "."
                                End If
                                Console.Write(muñeco(ñ, z))
                                Console.ResetColor()
                            Next
                            Console.WriteLine("")
                        Next
                        Exit Do
                    End If

                Loop While intentos > 0 Or contador <= 5


                If contador <> 5 Or intentos <= 0 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("YOU LOSE")
                    Console.ResetColor()
                End If




            Case 12








            Case 13







            Case 14










            Case 15









            Case 16








        End Select


        Console.ReadLine()

    End Sub

End Module
