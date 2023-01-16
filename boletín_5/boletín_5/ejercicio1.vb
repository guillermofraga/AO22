Module ejercicio1

    Sub Main()

        Dim a, b, c, d As Integer
        Dim pi As Double
        a = -1

        Console.WriteLine("A")

        While a <= 9
            a += 2
            Console.WriteLine(a)
        End While

        Console.WriteLine("presiona enter para continuar")
        Console.ReadLine()


        Console.WriteLine("B")
        b = 0

        While b <= 8
            b += 2
            Console.WriteLine(b)
        End While

        Console.WriteLine("presiona enter para continuar")
        Console.ReadLine()

        Console.WriteLine("C")
        c = 0

        While c <= 20
            c += 5
            Console.WriteLine(c)
        End While

        Console.WriteLine("presiona enter para continuar")
        Console.ReadLine()

        Console.WriteLine("D")
        d = 110

        While d >= 60
            d -= 10
            Console.WriteLine(d)
        End While

        Console.WriteLine("presiona enter para continuar")
        Console.ReadLine()

        Console.WriteLine("Pi")
        pi = -1

        While pi < 7
            pi += 2
            Console.WriteLine(pi * Math.PI)
        End While

        Console.ReadLine()

    End Sub

End Module
