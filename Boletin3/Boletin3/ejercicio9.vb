Module ejercicio9
    Sub main()

        'Entrada
        Dim num1, num2 As Double

        Console.WriteLine("introduzca num1:")
        num1 = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("introduzca num2:")
        num2 = Convert.ToDouble(Console.ReadLine)

        If num1 > num2 Then
            Console.WriteLine("calculo = " & Math.Pow(num1, num2))
        Else
            Console.WriteLine("calculo = " & Math.Pow(num2, num1))
        End If

        Console.ReadLine()

    End Sub
End Module
