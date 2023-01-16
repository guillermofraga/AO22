Module Ejercicio13
    Sub main()

        Dim matriz(3, 3) As Integer

        generarmatriz2D(matriz, 0, 5)

        mostrarMatriz(matriz)


        If matriz(0, 1) = 0 And matriz(0, 2) = 0 And matriz(0, 3) = 0 And matriz(1, 2) = 0 And matriz(1, 3) = 0 And matriz(2, 3) = 0 Then
            Console.WriteLine("Matriz triangular inferior. ")
        End If

        If matriz(1, 0) = 0 And matriz(2, 0) = 0 And matriz(2, 1) = 0 And matriz(3, 0) = 0 And matriz(3, 1) = 0 And matriz(3, 2) = 0 Then
            Console.WriteLine("Matriz triangular superior. ")
        End If

        Console.ReadLine()

    End Sub
End Module
