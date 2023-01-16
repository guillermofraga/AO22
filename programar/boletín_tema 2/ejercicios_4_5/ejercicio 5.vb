Module ejercicio_5
    Sub Main()

        Dim precio As Double
        Dim cantidad As Short
        Dim precio_total As Single

        'Entrada: precio, cantidad
        Console.WriteLine("precio: ")
        precio = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("cantidad: ")
        cantidad = Convert.ToInt16(Console.ReadLine())

        'calculos
        precio_total = Convert.ToSingle(precio * cantidad)

        'salida
        Console.WriteLine("El precio del producto es: " & precio & " euros" & " y la cantidad que compra es: " & cantidad & " por lo tanto debe pagar = " & precio_total & " euros." & " vuelva pronto.")

        Console.ReadLine()

    End Sub
End Module
