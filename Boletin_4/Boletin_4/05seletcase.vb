Module _05seletcase
    Sub main()


        'Select Case --> Evaluar valores discretos de una variable
        Dim opcion As Char
        Dim contador As Byte
        'Ejemplo menú:

        Do

            Console.WriteLine("Escoja una opción: ")
            Console.WriteLine("a. Calcular la raíz de un número")
            Console.WriteLine("b. Obtener el menor de tres números")
            Console.WriteLine("c. Decir si un número es multiplo de 7")
            Console.WriteLine("d. salir")
            opcion = Convert.ToChar(Console.ReadLine())

            'Evaluar la variable opción

            'If opcion = "a"c Then
            'ElseIf opcion = "b"c Then
            'ElseIf opcion = "c"c Then
            'Else
            'End If

            Select Case opcion
                Case "a"c, "A"c
                    Console.WriteLine("opción a: ")
                    Dim raiz As Double
                    Console.WriteLine("Intro número: ")
                    raiz = Convert.ToDouble(Console.ReadLine)
                    raiz = Math.Sqrt(raiz)
                    Console.WriteLine("Raiz " & raiz)

                Case "b"c, "B"c
                    Console.WriteLine("opción b: ")
                Case "c"c, "C"c
                    Console.WriteLine("opción c: ")
                    Dim numero As Integer
                    Console.WriteLine("Intro número: ")
                    numero = Convert.ToInt32(Console.ReadLine())

                    If numero Mod 7 = 0 Then
                        Console.WriteLine("Multiplo de 7")
                    End If

                Case "d"c
                    Console.WriteLine("Adios, Pulse Enter para confirmar")


                Case Else
                    Select Case contador
                        Case 0
                            Console.WriteLine("Error en la opción, te quedan 2 intentos.")
                            contador += Convert.ToByte(1)
                        Case 1
                            Console.WriteLine("Error en la opción, te queda 1 intento.")
                            contador += Convert.ToByte(1)
                        Case 2
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("Error en la opción, you lose.")
                            contador += Convert.ToByte(1)
                    End Select

            End Select



            Console.ReadLine()
        Loop While opcion <> "d"c And contador < 3




    End Sub
End Module
