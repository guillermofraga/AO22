Module Ejercicio15
    Sub main()

        Dim a, b, c, x1, x2 As Double

        Console.WriteLine("valor de a=")
        a = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("valor de b=")
        b = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("valor de c=")
        c = Convert.ToDouble(Console.ReadLine())


        If a = 0 Then
            x1 = c / b
            x2 = c / b
            Console.WriteLine("x1 = " & x1)
            Console.WriteLine("x2 = -" & x2)
        ElseIf b = 0 Then
            x1 = Math.Sqrt(c / a)
            x2 = Math.Sqrt(c / a)
            Console.WriteLine("x1 = " & x1)
            Console.WriteLine("x2 = -" & x2)
        ElseIf c = 0 Then
            x1 = b / a
            x2 = b / a
            Console.WriteLine("x1 = " & x1)
            Console.WriteLine("x2 = -" & x2)
        ElseIf a <> 0 And b <> 0 And c <> 0 Then
            x1 = (b + Math.Sqrt((b ^ 2) - 4 * a * c)) / (2 * a)
            x2 = (-b - Math.Sqrt((b ^ 2) - 4 * a * c)) / (2 * a)
            Console.WriteLine("x1 = " & x1)
            Console.WriteLine("x2 = " & x2)
        End If

        Console.ReadLine()

    End Sub
End Module
