Module Module1

    Sub Main()
        'Zona declaración de variables
        Dim base, altura, area As Single

        'Entrada
        base = 9
        altura = 4

        'Proceso : area = (base*altura)/2
        area = (base * altura) / 2

        'Salida: Escribir ...
        Console.WriteLine("el área es " & area)

        'Mostrar consola hasta que el usuario pulse enter
        Console.ReadLine()
    End Sub

End Module
