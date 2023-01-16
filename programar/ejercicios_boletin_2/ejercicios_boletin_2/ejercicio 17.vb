Module ejercicio_17
    Sub main()
        Dim ladocubo, d, al, v As Double

        'entrada
        Console.WriteLine("lado del cubo:")
        ladocubo = Convert.ToDouble(Console.ReadLine())

        'calculos

        d = Math.Sqrt(3) * ladocubo
        Console.WriteLine("D = " & d)

        al = 4 * (ladocubo ^ 2)
        Console.WriteLine("al = " & al)

        v = ladocubo ^ 3
        Console.WriteLine("v = " & v)

        Console.ReadLine()

    End Sub
End Module
