Module Ejercicio9
    Sub main()

        Dim matriz(2, 2), contador, contador2 As Integer

        generarmatriz2D(matriz, 0, 3)
        mostrarMatriz(matriz)

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                If matriz(i, j) = 0 Then
                    contador += 1
                End If
            Next
            If contador = matriz.GetUpperBound(1) + 1 Then
                Console.WriteLine("La fila " & i & " esta compuesta por ceros")
                Console.WriteLine("")
                contador2 += 1
            End If
            contador = 0
        Next

        If contador2 = 0 Then
            Console.WriteLine("No hay ninguna fila compuesta por ceros")
        End If

        Console.ReadLine()

    End Sub
End Module
