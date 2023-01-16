Module ejercicio8
    Sub main()

        Dim array(99) As Integer
        Dim x As New Random

        For i = 0 To 99
            array(i) = x.Next(0, 10)
        Next

        For a = 0 To 99
            Console.WriteLine(array(a))
        Next

        Console.ReadLine()


    End Sub
End Module
