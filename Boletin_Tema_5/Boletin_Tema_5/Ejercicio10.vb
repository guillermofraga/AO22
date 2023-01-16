Module Ejercicio10
    Sub main()

        Dim array(99) As Integer
        Dim x As New Random

        For i = 0 To array.Length - 1
            array(i) += i
            If i Mod 2 <> 0 Then
                array(i) = x.Next(10, 35)
            End If
        Next

        For a = 0 To array.Length - 1
            Console.WriteLine(array(a))
        Next

        Console.ReadLine()

    End Sub
End Module
