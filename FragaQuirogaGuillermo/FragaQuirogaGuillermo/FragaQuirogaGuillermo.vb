Module FragaQuirogaGuillermo

    Sub Main()

        Dim seleccion As Integer


        Do

            Console.WriteLine("Introduzca el numero del ejercicio del 1 - 5:")
            seleccion = Convert.ToInt32(Console.ReadLine())

            Select Case seleccion
                Case 1

                    Dim palabrasintro As String = "Buenos dias"
                    Dim palabras() As String = palabrasintro.Split(" "c)
                    Dim contador As Integer = 0

                    Console.WriteLine("Palabra: " & palabrasintro)
                    Console.WriteLine("")

                    For i = 0 To palabras.Length - 1
                        contador += 1
                    Next

                    Console.WriteLine("En el string hay: " & contador & " palabras")



                Case 2

                    Dim palabras As String = "caracter a buscar"
                    Dim caracter As Char
                    Dim contador As Integer = 0

                    Console.WriteLine("Palabra: " & palabras)
                    Console.WriteLine("")

                    Console.WriteLine("Introduzca el caracter a buscar:")
                    caracter = Convert.ToChar(Console.ReadLine())

                    For i = 0 To palabras.Length - 1
                        If palabras(i) = caracter Then
                            Console.WriteLine("El caracter esta en la posición: " & i)
                            contador += 1
                        End If
                    Next

                    If contador = 0 Then
                        Console.WriteLine("El caracter que buscas no se pudo encontrar")
                    End If

                Case 3

                    Dim palabra As String = "pal@bras que conteng@n un @rroba"
                    Dim palabras() As String = palabra.Split(" "c)
                    Dim contador As Integer = 0

                    Console.WriteLine("Palabra: " & palabra)
                    Console.WriteLine("")

                    For i = 0 To palabras.Length - 1
                        If palabras(i).Contains("@"c) Then
                            contador += 1
                        End If
                    Next

                    If contador = 0 Then
                        Console.WriteLine("No hay ninguna palabra que contenga un @")
                    Else
                        Console.WriteLine("Hay " & contador & " palabras que contienen un @")
                    End If



                Case 4

                    Dim palabra As String = "caracteres que no son letras en un string"
                    Dim contador As Integer = 0

                    Console.WriteLine("Palabra: " & palabra)
                    Console.WriteLine("")

                    For i = 0 To palabra.Length - 1
                        If Char.IsLetter(palabra(i)) Or palabra(i) = " "c Then
                        Else
                            contador += 1
                        End If
                    Next

                    If contador = 0 Then
                        Console.WriteLine("No hay ningun caracter que no sea una letra")
                    Else
                        Console.WriteLine("Hay " & contador & " caracteres que no son una letra")
                    End If

                Case 5

                    Dim IBAN As String

                    Console.WriteLine("Introduzca su iban: ")
                    IBAN = Console.ReadLine()

                    If IBAN.Length = 24 Then
                    ElseIf IBAN.Length > 24 Then
                        Console.WriteLine("sobran caracteres en el IBAN")
                        Exit Select
                    ElseIf IBAN.Length < 24 Then
                        Console.WriteLine("faltan caracteres en el IBAN")
                        Exit Select
                    End If

                    If IBAN(0) = "E" And IBAN(1) = "S" Then
                    Else
                        Console.WriteLine("Su código del país es incorrecto")
                        Exit Select
                    End If

                    If Char.IsDigit(IBAN(2)) And Char.IsDigit(IBAN(3)) Then
                    Else
                        Console.WriteLine("No hay ningun digito despues del código del país")
                        Exit Select
                    End If

                    If IBAN(2) = IBAN(12) And IBAN(3) = IBAN(13) Then
                        Console.WriteLine("Su IBAN es correcto")
                    Else
                        Console.WriteLine("Su digito de control es incorrecto")
                        Exit Select
                    End If


            End Select

        Loop While seleccion <> 6

        Console.ReadLine()
    End Sub

End Module
