Module Ejercicio12
    Sub main()

        Dim matriz(2, 2), guardar As Integer
        Dim num As Boolean = False

        generarmatriz2D(matriz, 1, 140)

        mostrarMatriz(matriz)

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                If matriz(i, j) > 100 Then
                    guardar = matriz(matriz.GetUpperBound(0), matriz.GetUpperBound(1))
                    matriz(matriz.GetUpperBound(0), matriz.GetUpperBound(1)) = matriz(i, j)
                    matriz(i, j) = guardar
                    num = True
                    Exit For
                End If
            Next
            If num Then
                Exit For
            End If
        Next

        Console.WriteLine("")
        mostrarMatriz(matriz)

        Console.ReadLine()



    End Sub
End Module
