Module Ejercicio25
    Sub main()

        Dim array25(29) As Integer
        generarArray(array25,50)
        mostrararray(array25)

        Dim minimo As Integer = array25(0)

        For i = 0 To array25.Length - 1
            If minimo > array25(i) Then
                minimo = array25(i)
            End If
        Next

        Console.WriteLine("El más pequeño es: " & minimo)

        Console.ReadLine()




        'Dim array(9) As Double

        'For i = 0 To array.Length - 1
        '    array(i) += i + 1
        'Next

        'array.Sort(array)

        'Console.WriteLine(array(0))

        'Console.ReadLine()

    End Sub
End Module
