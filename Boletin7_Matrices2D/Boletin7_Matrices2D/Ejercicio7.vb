Module Ejercicio7
    Sub main()

        Dim matriz(2, 2) As Integer
        Dim suma As Double

        generarmatriz2D(matriz, 1, 10)

        For a = 0 To matriz.GetUpperBound(0)
            For b = 0 To matriz.GetUpperBound(1)
                Console.Write(matriz(a, b) & " ")
            Next
            Console.WriteLine("")
            Console.WriteLine("----------")
        Next

        For i = 0 To matriz.GetUpperBound(1)
            suma += matriz(matriz.GetUpperBound(0), i)
        Next

        Console.WriteLine("")
        Console.WriteLine("Suma de la ultima fila: " & suma)

        Console.ReadLine()




    End Sub
End Module
