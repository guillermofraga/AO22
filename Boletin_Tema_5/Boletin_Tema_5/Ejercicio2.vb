Module Ejercicio2
    Sub main()

        Dim array(19) As Single

        For i = 0 To 19
            Console.WriteLine("introduzca un valor:")
            array(i) = Convert.ToSingle(Console.ReadLine)
        Next

        For a = 0 To 19
            Console.WriteLine("valor:" & array(a))
        Next

        Console.ReadLine()

    End Sub
End Module
