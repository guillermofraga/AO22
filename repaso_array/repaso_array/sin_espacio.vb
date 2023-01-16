Module sin_espacio
    Sub main()

        Dim array() As Integer = {-3, -2, -1, 0, 1, 2, 3, 4, 5}
        Dim contador As Integer
        Dim iteraciones As Integer

        For i = 0 To array.Length - 1
            If array(i) < 0 Then
                contador += 1
            Else
                Exit For
            End If
            iteraciones += 1
        Next

        Console.WriteLine("hay " & contador & " numeros negativos")
        Console.WriteLine("hay " & iteraciones & " iteraciones")
        Console.ReadLine()

    End Sub
End Module
