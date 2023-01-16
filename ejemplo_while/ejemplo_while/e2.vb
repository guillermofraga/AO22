Module e2
    Sub main()
        'Generar 100 numeros random entre 0 y 10 con un WHILE

        Dim i As Integer
        Dim rnd As New Random()
        i = 100


        While (i > 0)
            Console.WriteLine(rnd.Next(11))
            i = i - 1
        End While


        'Generar 100 numeros random entre 0 y 10 con un FOR

        'For i = 1 To 500
        'Console.WriteLine(rnd.Next(11))
        'Next

        Console.ReadLine()


    End Sub
End Module
