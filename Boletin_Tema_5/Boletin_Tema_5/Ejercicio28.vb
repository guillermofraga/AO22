Module Ejercicio28
    Sub main()

        Dim array1(9), array2(array1.Length - 1) As Integer

        generarArray(array1, 20)

        For i = 0 To array1.Length - 1
            array2(i) = array1(i)
        Next

        mostrararray(array1)
        Console.WriteLine("----")
        mostrararray(array2)


        Console.ReadLine()

    End Sub
End Module
