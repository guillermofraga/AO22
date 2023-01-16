Module Ejercicio11
    Sub main()

        Dim matriz(2, 2), guardar As Integer
        Dim negativo As Boolean = False

        generarmatriz2D(matriz, -5, 5)

        mostrarMatriz(matriz)

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                If matriz(i, j) < 0 Then
                    guardar = matriz(0, 0)
                    matriz(0, 0) = matriz(i, j)
                    matriz(i, j) = guardar
                    negativo = True
                    Exit For
                End If
            Next
            If negativo Then
                Exit For
            End If
        Next

        Console.WriteLine("")
        mostrarMatriz(matriz)

        Console.ReadLine()

    End Sub
End Module
