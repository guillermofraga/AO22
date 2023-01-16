Module Ejercicio24
    Sub main()

        Dim orden() As Integer = {7, 6, 5, 4, 3, 2, 1}

        Array.Sort(orden)
        Dim i As Integer
        For Each i In orden
            Console.Write(i & " ")
        Next


        Array.Reverse(orden)
        Console.ReadLine()

    End Sub
End Module
