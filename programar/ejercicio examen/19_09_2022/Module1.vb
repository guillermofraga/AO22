Module Module1
    'Programa que calcula el precio final de una vivenda, teniendo en cuenta los siguientes impuestos:
    'La inmobiliaria se lleva el 3% del precio inicial
    'El ayuntamiento el 9% del precio inicial: impuesto Transf patrimonio

    Sub Main()
        Dim vivienda, inmobiliaria, ayuntamiento, precio_final As Single

        'Entrada
        vivienda = 120000

        'Cálculos:
        inmobiliaria = 0.03 * vivienda

        ayuntamiento = vivienda * (9 / 100)

        precio_final = vivienda + inmobiliaria + ayuntamiento

        'Salida por pantalla
        Console.WriteLine("precio inicial: " & vivienda & " euros")

        Console.WriteLine("cuota inmobiliaria: " & inmobiliaria & " euros")

        Console.WriteLine("impuesto transferencia: " & ayuntamiento & " euros")

        Console.WriteLine("el precio final es " & precio_final & " euros")

        Console.ReadLine()
    End Sub

End Module
