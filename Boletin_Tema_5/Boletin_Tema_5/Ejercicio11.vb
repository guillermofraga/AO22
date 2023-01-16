Module Ejercicio11
    Sub main()

        Dim array(49) As Double
        Dim x As New Random

        For i = 0 To array.Length - 1
            array(i) = x.Next(-10, 50)
        Next

        For a = 0 To array.Length - 1
            If array(a) < 0 Then
                Console.WriteLine(array(a) & " posicion: " & a)
            End If
        Next

        Console.ReadLine()

    End Sub
End Module
