Module Ejercicio6
    Sub main()

        Dim array(49) As Double

        For i = 0 To 49
            array(i) += i
        Next

        array(49) = -1

        For a = 0 To 49
            Console.WriteLine(array(a))
            Console.WriteLine()
        Next

        Console.ReadLine()


    End Sub
End Module
