Module ejercicio_14
    Sub main()

        Dim rebaja, precio_producto, precio_final, ahorra As Double

        'entrada

        Console.WriteLine("precio del producto: ")
        precio_producto = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("rebaja: ")
        rebaja = Convert.ToDouble(Console.ReadLine())

        'calculos
        precio_final = precio_producto - (precio_producto * rebaja) / 100

        ahorra = precio_producto - precio_final

        'salida
        Console.WriteLine("Al aplicar un " & rebaja & " % de descuento el precio final del producto es de " & precio_final & " y por lo tanto se ahorra " & ahorra & " euros.")

        Console.ReadLine()

    End Sub
End Module
