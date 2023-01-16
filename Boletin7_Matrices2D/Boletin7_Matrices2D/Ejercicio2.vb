Module Ejercicio2
    Sub main()


        Dim matriz(2, 2), suma, media As Double
        Dim r As New Random

        matriz(0, 0) = r.Next(1, 101)
        matriz(0, 1) = r.Next(1, 101)
        matriz(0, 2) = r.Next(1, 101)
        matriz(1, 0) = r.Next(1, 101)
        matriz(1, 1) = r.Next(1, 101)
        matriz(1, 2) = r.Next(1, 101)
        matriz(2, 0) = r.Next(1, 101)
        matriz(2, 1) = r.Next(1, 101)
        matriz(2, 2) = r.Next(1, 101)

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                suma += matriz(i, j)
            Next
        Next

        media = suma / 9

        Console.WriteLine("Media: " & media)

        Console.ReadLine()
    End Sub
End Module
