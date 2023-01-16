Module Ejercicio15
    Sub main()


        Dim matriz(4, 4), contador As Integer

        generarmatriz2D(matriz, -5, 5)

        mostrarMatriz(matriz)

        For g = -5 To 5

            contador = 0

            For i = 0 To matriz.GetUpperBound(0)
                For j = 0 To matriz.GetUpperBound(1)
                    If matriz(i, j) = g Then
                        contador += 1
                    End If
                Next
            Next
            If contador < 2 And contador > 0 Then
                Console.WriteLine("El número " & g & " no esta repetido")
                Console.WriteLine("")
            End If

        Next

        Console.ReadLine()


    End Sub
End Module
