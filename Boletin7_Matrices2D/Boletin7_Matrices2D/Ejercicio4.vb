Module Ejercicio4
    Sub main()

        Dim matriz(2, 2), porcentaje, contador As Double
        Dim r As New Random

        matriz(0, 0) = 0
        matriz(0, 1) = 0
        matriz(0, 2) = 2
        matriz(1, 0) = 0
        matriz(1, 1) = 1
        matriz(1, 2) = 0
        matriz(2, 0) = 1
        matriz(2, 1) = 0
        matriz(2, 2) = 1

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                If matriz(i, j) = 0 Then
                    contador += 1
                End If
            Next
        Next

        porcentaje = (contador / matriz.Length) * 100

        Console.WriteLine("porcentaje de 0: " & porcentaje & "%")

        Console.ReadLine()


    End Sub
End Module
