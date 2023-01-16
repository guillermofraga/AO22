Module descuento
    Sub main()
        'Zona declaración de variables
        Dim precio_inicial, rebaja, precio_final As Single

        'Entrada
        precio_inicial = 29.99

        rebaja = 15

        'Proceso
        precio_final = precio_inicial * (rebaja / 100)

        'Salida: Escribir ...
        Console.WriteLine("el precio final es " & precio_final)

        'Mostrar consola hasta que el usuario pulse enter
        Console.ReadLine()
    End Sub
End Module
