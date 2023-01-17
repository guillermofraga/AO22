Module Ejercicio14
    Sub main()

        Dim matriz(3, 3) As Integer

        generarmatriz2D(matriz, 0, 5)

        mostrarMatriz(matriz)

        Console.WriteLine("")

        If matriz.GetUpperBound(0) = matriz.GetUpperBound(1) Then
            Console.WriteLine("La matriz es cuadrada. ")
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write(matriz(0, 0))
            Console.ResetColor()
            Console.Write(matriz(0, 1))
            Console.Write(matriz(0, 2))
            Console.Write(matriz(0, 3))
            Console.WriteLine("")
            Console.WriteLine("-----------")
            Console.Write(matriz(1, 0))
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write(matriz(1, 1))
            Console.ResetColor()
            Console.Write(matriz(1, 2))
            Console.Write(matriz(1, 3))
            Console.WriteLine("")
            Console.WriteLine("-----------")
            Console.Write(matriz(2, 0))
            Console.Write(matriz(2, 1))
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write(matriz(2, 2))
            Console.ResetColor()
            Console.Write(matriz(2, 3))
            Console.WriteLine("")
            Console.WriteLine("-----------")
            Console.Write(matriz(3, 0))
            Console.Write(matriz(3, 1))
            Console.Write(matriz(3, 2))
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write(matriz(3, 3))
            Console.ResetColor()
            Console.WriteLine("")
            Console.WriteLine("-----------")

        Else
            Console.WriteLine("La matriz no es cuadrada. ")
        End If

        Console.ReadLine()

    End Sub
End Module
