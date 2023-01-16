Module ejemplo3intentos
    Sub main()

        Dim c1 As Single
        Dim n1 As Single
        Dim R1 As String
        Do
            Do
                If c1 = 0 Then
                    Console.WriteLine("Dime un número múltiplo de 6 y mayor que 100.")
                    n1 = Convert.ToSingle(Console.ReadLine())
                    Console.WriteLine("")
                ElseIf c1 = 1 Then
                    Console.WriteLine("Te quedan 2 intentos")
                    n1 = Convert.ToSingle(Console.ReadLine())
                    Console.WriteLine("")
                ElseIf c1 = 2 Then
                    Console.WriteLine("Te quedan 1 intentos")
                    n1 = Convert.ToSingle(Console.ReadLine())
                    Console.WriteLine("")
                ElseIf c1 = 3 Then
                    Console.WriteLine("Te quedan 0 intentos")
                    Console.WriteLine("")

                End If

                c1 += 1
            Loop Until (n1 Mod 6 = 0 And n1 > 100) Or c1 = 3
            If n1 Mod 6 = 0 And n1 > 100 Then
                Console.WriteLine("")
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("you win")
                Console.ResetColor()
                Console.WriteLine("")
                Console.WriteLine("¿Te gustaría volver a jugar? s/n
")
                R1 = Convert.ToString(Console.ReadLine())
            End If

            If c1 = 3 Then
                Console.WriteLine("")
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("you lose")
                Console.ResetColor()
                Console.WriteLine("")
                Console.WriteLine("¿Te gustaría volver a jugar? s/n")
                R1 = Convert.ToString(Console.ReadLine())
                Console.WriteLine("")
            End If
            c1 = 0
            R1 = R1

        Loop While R1 = "s"
        Console.ReadLine()






    End Sub
End Module
