Module Module1

    Sub Main()
        Dim longitud, area, volumen, radio As Single
        Const pi As Double = 3.141516

        'Entrada : radio
        Console.WriteLine("introduzca el radio: ")
        radio = Convert.ToSingle(Console.ReadLine())

        'calculos
        longitud = Convert.ToSingle(2 * pi * radio)
        Console.WriteLine("longitud = " & longitud)

        'todos los que leen datos los convierte todo en string

        'ejemplos de elevado:
        'area = convert.tosingle(pi * radio * radio)
        'area = convert.tosingle(pi * math.pow(radio, 2))
        'area = convert.tosingle((4/3 * pi * radio ^ 2)

        area = Convert.ToSingle(pi * Math.Pow(radio, 2))
        Console.WriteLine("area = " & area)

        volumen = Convert.ToSingle((4 / 3) * pi * Math.Pow(radio, 3))
        Console.WriteLine("volumen = " & volumen)

        Console.ReadLine()


    End Sub

End Module
