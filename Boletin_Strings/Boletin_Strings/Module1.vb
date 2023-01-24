Module Module1
    Sub Main()


        Dim seleccionar As Integer

        Console.WriteLine("Introduzca un número del 0 al 15 para seleccionar el ejercicio: ")
        seleccionar = Convert.ToInt32(Console.ReadLine())

        Select Case seleccionar
            Case 0
                Dim matricula() As String = {"2412-ABZ", "9512-GER", "4342-OPW", "1520-PÑA", "7148-IAL", "9872-LÑB", "7420-MAZ", "8621-ÑZM", "1041-BUI", "1032-QDD"}
                Dim c As Char = "Z"c

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

            Case 1

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



            Case 2

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



            Case 3

                Dim escribir As String

                Console.WriteLine("Escribe: ")
                escribir = Console.ReadLine()

                Dim palabras() As String = escribir.Split(" "c)

                For i = 0 To palabras.Length - 1
                    If palabras(i).StartsWith("b"c) Then
                        Console.WriteLine("Palabra que empieza por b: " & palabras(i))
                    End If
                Next

            Case 4

                Dim correo As String

                Console.WriteLine("Introduzca su correo electronico: ")
                correo = Console.ReadLine()

                If correo.Contains("@"c) Then
                    Console.WriteLine("Introdujo bien su correo")
                Else
                    Console.WriteLine("Introdujo mal su correo")
                End If



            Case 5

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

            Case 6








            Case 7






            Case 8






            Case 9







            Case 10







            Case 11








            Case 12







            Case 13










            Case 14









            Case 15








        End Select


        Console.ReadLine()

    End Sub

End Module
