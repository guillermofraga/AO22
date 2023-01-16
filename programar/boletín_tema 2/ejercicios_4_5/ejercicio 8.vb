Module ejercicio_8
    Sub main()
        Dim p, v, n, r, t As Double

        'Entrada
        Console.WriteLine("numero de presión: ")
        p = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("numero de volumen: ")
        v = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("numero de moles: ")
        n = Convert.ToDouble(Console.ReadLine())

        r = 0.082
        Console.WriteLine("numero de constante: " & r)
        Console.ReadLine()

        Console.WriteLine("numero de temperatura: ")
        t = Convert.ToDouble(Console.ReadLine())

        'calculo
        p = n * r * t

        'salida
        Console.WriteLine("Con un volumen de " & v & " litros" & " y una temperatura de " & t & " kelvin " & n & " moles de un gas ideal tiene una presión de " & p & " atmósferas")
        Console.ReadLine()


    End Sub
End Module
