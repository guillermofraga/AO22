Module Ejercicio9
    Sub main()

        Dim array(99) As Integer

        For i = 0 To array.Length - 1
            If i Mod 2 = 0 Then
                array(i) = Convert.ToInt32(i / 2)
            End If
        Next

        For a = 0 To array.Length - 1
            Console.WriteLine(array(a))
        Next

        Console.ReadLine()

    End Sub
End Module
