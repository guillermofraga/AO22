Module ejercicio10
    Sub main()

        Dim m, suma As Double

        Console.WriteLine("introduzca num:")
        m = Convert.ToDouble(Console.ReadLine())

        While m < 0
            Console.WriteLine("Introduzca un numero positivo")
            m = Convert.ToDouble(Console.ReadLine())
        End While

        For n = m To 1 Step -1
            suma += n
        Next

        Console.WriteLine("numero " & suma)
        Console.ReadLine()

    End Sub
End Module
