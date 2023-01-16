Module FragaQuirogaGuillermoEjercicio4

    Sub Main()

        'Entrada
        Dim a, b As Integer
        Dim x, y, z, x1, y1 As Double

        Console.WriteLine("Numero 1: ")
        a = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Numero 2: ")
        b = Convert.ToInt32(Console.ReadLine())

        'Calculos

        x = Math.Pow(a, 4) / Math.Pow(a, 3) 'otra forma x= (a^4) / (a^3)

        y = Math.Round(Math.Sqrt(a + Math.Pow(b, 2)), 1) 'otra forma y = math.round(math.sqrt(a + (b^2)), 1)

        z = Math.Round(Math.Sqrt(3 - a), 2)

        x1 = Math.Min(x, y)

        y1 = Math.Min(x1, z)

        'Salida

        Console.WriteLine("x = " & x)
        Console.ReadLine()

        Console.WriteLine("y = " & y)
        Console.ReadLine()

        Console.WriteLine("z = " & z)
        Console.ReadLine()

        Console.WriteLine("Numero más pequeño entre x,y,z: " & y1)
        Console.ReadLine()


    End Sub

End Module
