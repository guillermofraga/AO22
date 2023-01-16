Module ejercicio_16
    Sub main()

        Dim a, b, c, mayor, menor, resultado As Double

        'entrada:

        Console.WriteLine("a : ")
        a = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("b : ")
        b = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("c : ")
        c = Convert.ToDouble(Console.ReadLine())

        'calculos

        mayor = Math.Max(a, b)

        mayor = Math.Max(mayor, c)

        menor = Math.Min(a, Math.Min(b, c))


        resultado = Math.Sqrt(mayor ^ menor) + Math.Pow(a, 5)
        'resultado = Math.Sqrt(Math.Pow(Math.Max(a, Math.Max(b, c)), Math.Min(a, Math.Min))) por completar




    End Sub
End Module
