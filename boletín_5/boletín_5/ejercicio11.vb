Module ejercicio11
    Sub main()

        Dim n, suma, n2 As Double

        Console.WriteLine("Introduzca un numero")
        n = Convert.ToDouble(Console.ReadLine())

        For a = 1 To n Step 1
            n2 = 1 / a ^ 3
            suma += n2
        Next

        Console.WriteLine(suma)
        Console.ReadLine()

    End Sub
End Module
