Module Ejercicio26
    Sub main()

        Dim array(9), array2(9) As Integer
        Dim contador As Integer
        Dim ale As New Random

        For i = 0 To array.Length - 1
            array(i) = i
            array2(i) = i
        Next

        For i = 0 To array.Length - 1
            If array(i) = array2(i) Then
                contador += 1
            End If
        Next

        If contador = array.Length Then
            Console.WriteLine("Son iguales")
        Else
            Console.WriteLine("no son iguales")
        End If

        Console.ReadLine()


    End Sub
End Module
