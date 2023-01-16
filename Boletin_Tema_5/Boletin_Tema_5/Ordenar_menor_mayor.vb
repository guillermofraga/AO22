Module Ordenar_menor_mayor
    Sub main()

        Dim array() As Integer = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1}
        Dim minimo As Integer

        'generarArray(array, 10)

        minimo = array(0)

        For i = 1 To array.Length - 1
            For a = 1 To array(i)
                If minimo > array(a) Then
                    minimo = array(a)
                End If

            Next
            Console.WriteLine(array(i) & " ")
        Next

        Console.ReadLine()

    End Sub
End Module