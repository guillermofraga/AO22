Module Ejercicio16
    Sub main()

        Dim matriz(4, 4), contador, vida, pf, pc, pf1, pc1, pf2, pc2, pf3, pc3, salir As Integer
        Dim x As New Random
        vida = 6

        generarmatriz2D(matriz, 1, 5)

        mostrarMatriz(matriz)

        For i = x.Next(0, 5) To matriz.GetUpperBound(0)
            For j = x.Next(0, 5) To matriz.GetUpperBound(1)
                matriz(i, j) = 0
                contador += 1
                If contador = 1 Then
                    pf1 = i
                    pc1 = j
                End If
                If contador = 2 Then
                    pf2 = i
                    pc2 = j
                End If
                If contador = 3 Then
                    pf3 = i
                    pc3 = j
                End If
                If contador = 3 Then
                    Exit For
                End If
            Next
            If contador = 3 Then
                Exit For
            End If
        Next

        Console.WriteLine("")
        Console.WriteLine("")

        mostrarMatriz(matriz)

        Console.WriteLine("")

        Console.WriteLine(pf1 & " " & pc1 & " " & pf2 & " " & pc2 & " " & pf3 & " " & pc3)

        Do

            Console.WriteLine("Introduzca la cordenada de fila donde esta el 0: ")
            pf = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Introduzca la cordenada de la columna donde esta el 0: ")
            pc = Convert.ToInt32(Console.ReadLine())

            If pf1 = pf And pc1 = pc Then
                contador -= 1
                Console.WriteLine("Hacertaste una posicion te quedan: " & contador & " posiciones para encontrar")
            End If

            If pf2 = pf And pc2 = pc Then
                contador -= 1
                Console.WriteLine("Hacertaste una posicion te quedan: " & contador & " posiciones para encontrar")
            End If

            If pf3 = pf And pc3 = pc Then
                contador -= 1
                Console.WriteLine("Hacertaste una posicion te quedan: " & contador & " posiciones para encontrar")
            End If

            If matriz(pf, pc) <> 0 Then
                vida -= 1
                Console.WriteLine("has fallado te quedan: " & vida & " vidas")
            End If

            Console.WriteLine("")

            If contador = 0 Then
                Console.ForegroundColor = ConsoleColor.Blue
                Console.WriteLine("YOU WIN")
                Console.ResetColor()
                Exit Do
            End If

            If vida = 0 Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("GAME OVER")
                Console.ResetColor()
                Exit Do
            End If

        Loop While vida > 0



        Console.WriteLine("")


        Console.WriteLine("Posicion de los ceros: ")

        Console.WriteLine("")
        For a = 0 To matriz.GetUpperBound(0)
            For b = 0 To matriz.GetUpperBound(1)
                If matriz(a, b) = 0 Then
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.Write(matriz(a, b) & " ")
                    Console.ResetColor()
                Else
                    Console.Write(matriz(a, b) & " ")
                End If
            Next
            Console.WriteLine("")
            Console.WriteLine("-----------")
        Next

        Console.ReadLine()





    End Sub
End Module
