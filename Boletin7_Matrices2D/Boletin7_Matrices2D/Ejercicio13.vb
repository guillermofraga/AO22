Module Ejercicio13
    Sub main()

        Dim matriz(3, 3) As Integer

        generarmatriz2D(matriz, 0, 5)

        mostrarMatriz(matriz)


        Dim matriz(3, 3), contador As Integer
        Dim superior, inferior As Boolean
        superior = True
        inferior = True

        generarmatriz2D(matriz, 0, 0)

        mostrarMatriz(matriz)

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                If i < j Then
                    If matriz(i, j) <> 0 Then
                        inferior = False
                    End If
                ElseIf i > j Then
                    If matriz(i, j) <> 0 Then
                        superior = False
                    End If
                End If
            Next
        Next

        If inferior Then
            Console.WriteLine("Matriz triangular inferior")
        End If

        If superior Then
            Console.WriteLine("Matriz triangular superior")
        End If

        Console.ReadLine()

    End Sub
End Module
