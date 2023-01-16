Module Ejercicio10
    Sub main()

        Dim matriz(2, 2), matriz2(2, 2), matriz3(2, 2) As Integer

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                Console.WriteLine("Introduzca un valor para la posicion: " & i & "," & j)
                matriz(i, j) = Convert.ToInt32(Console.ReadLine())

            Next
        Next

        mostrarMatriz(matriz)

        For a = 0 To matriz2.GetUpperBound(0)
            For b = 0 To matriz2.GetUpperBound(1)
                Console.WriteLine("Introduzca un valor para la posicion: " & a & "," & b)
                matriz2(a, b) = Convert.ToInt32(Console.ReadLine())

            Next
        Next

        mostrarMatriz(matriz2)

        Console.WriteLine("")
        Console.WriteLine("Suma de las dos matrices: ")
        Console.WriteLine("")

        For c = 0 To matriz.GetUpperBound(0)
            For d = 0 To matriz.GetUpperBound(1)
                matriz3(c, d) = (matriz(c, d) + matriz2(c, d))
            Next
        Next

        mostrarMatriz(matriz3)

        Console.ReadLine()

    End Sub
End Module
