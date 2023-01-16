Module Ejercicio15
    Sub main()

        Dim n, fa As Double

        Console.WriteLine("Introduzca un numero:")
        n = Convert.ToDouble(Console.ReadLine())
        fa = 1

        For i = n To 1 Step -1
            fa *= i
        Next

        Console.WriteLine(fa)
        Console.ReadLine()

    End Sub
End Module
