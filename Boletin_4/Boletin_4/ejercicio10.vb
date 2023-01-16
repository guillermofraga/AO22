Module ejercicio10
    Sub main()

        Dim precio As Double

        Console.WriteLine("precio del producto:")
        precio = Convert.ToDouble(Console.ReadLine())

        If precio < 500 Then
            Console.WriteLine("precio final = " & precio)
        ElseIf precio >= 500 And precio <= 1000 Then
            precio = precio - (precio * (3 / 100))
            Console.WriteLine("Precio final = " & precio)
        ElseIf precio >= 1000 And precio <= 2000 Then
            precio = precio - (precio * (5 / 100))
            Console.WriteLine("precio final = " & precio)
        ElseIf precio >= 2000 And precio <= 3000 Then
            precio = precio - (precio * (7 / 100))
            Console.WriteLine("precio final = " & precio)
        ElseIf precio > 3000 Then
            precio = precio - (precio * (10 / 100))
            Console.WriteLine("precio final = " & precio)

        End If

        Console.ReadLine()

    End Sub
End Module
