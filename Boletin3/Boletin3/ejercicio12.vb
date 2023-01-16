Module ejercicio12
    Sub main()

        'Entrada
        Dim precio As Double

        Console.WriteLine("Precio del producto:")
        precio = Convert.ToDouble(Console.ReadLine())

        If precio < 100 Then
            Console.WriteLine("precio final " & precio - (precio * 10 / 100))
            Console.ReadLine()
        Else
            Console.WriteLine("precio final " & precio - (precio * 15 / 100))
            Console.ReadLine()
        End If





    End Sub
End Module
