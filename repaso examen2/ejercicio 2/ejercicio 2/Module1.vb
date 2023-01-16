Module Module1

    Sub Main()

        Dim a, b, c, d, e, am, a1, a2, a3, bm, b1, b2, b3, s As Double

        Console.WriteLine("introduzca el 1 numero:")
        a = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("introduzca el 2 numero:")
        b = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("introduzca el 3 numero:")
        c = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("introduzca el 4 numero:")
        d = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("introduzca el 5 numero:")
        e = Convert.ToDouble(Console.ReadLine())

        am = Math.Max(a, b)

        a1 = Math.Max(am, c)

        a2 = Math.Max(a1, d)

        a3 = Math.Max(a2, e)

        bm = Math.Min(a, b)

        b1 = Math.Min(bm, c)

        b2 = Math.Min(b1, d)

        b3 = Math.Min(b2, e)

        Console.WriteLine("maximo: " & a3)

        Console.WriteLine("minimo: " & b3)

        If a3 > 0 Then
            a3 = Math.Sqrt(a3)
            Console.WriteLine("raiz: " & a3)
        Else
            Console.WriteLine(a3)
        End If

        If b3 < 0 Then
            b3 = b3 ^ b3
            Console.WriteLine("potencia: " & b3)
        Else
            Console.WriteLine(b3)
        End If

        s = a3 + b3

        Console.WriteLine("suma: " & s)

        Console.ReadLine()

    End Sub

End Module
