Module Ejercicio5
    Sub main()

        Dim matriz(2, 2), matriz2(2, 2) As Integer

        generarmatriz2D(matriz, 1, 10)

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine("")
            Console.WriteLine("-----------------")
        Next


        For a = 0 To matriz.GetUpperBound(0)
            For b = 0 To matriz.GetUpperBound(1)
                matriz2(b, a) = matriz(a, b)
            Next
        Next

        For c = 0 To matriz.GetUpperBound(0)
            For d = 0 To matriz.GetUpperBound(1)
                Console.Write(matriz2(c, d) & " ")
            Next
            Console.WriteLine("")
            Console.WriteLine("-----------")
        Next

        Console.ReadLine()

    End Sub
End Module
