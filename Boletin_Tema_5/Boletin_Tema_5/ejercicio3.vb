Module ejercicio3
    Sub main()

        Dim array(9) As Integer

        For i = 0 To 9
            Console.WriteLine("Introduzca valores positivos:")
            array(i) = Convert.ToInt32(Console.ReadLine())
        Next

        Console.WriteLine("Introduzca valores negativo:")
        array(0) = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduzca valores negativo:")
        array(2) = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduzca valores negativo:")
        array(5) = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduzca valores negativo:")
        array(9) = Convert.ToInt32(Console.ReadLine())

        For a = 0 To 9
            Console.WriteLine("Valor" & array(a))
        Next

        Console.ReadLine()

    End Sub
End Module
