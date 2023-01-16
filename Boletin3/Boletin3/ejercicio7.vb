Module ejercicio7
    Sub main()
        'Entrada
        Dim num1, num2, suma As Double

        Console.WriteLine("introduzca num1: ")
        num1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("introduzca num2: ")
        num2 = Convert.ToDouble(Console.ReadLine())

        'calculos
        suma = Math.Sqrt(num1 + num2)

        If suma > 0 Then ' o suma = suma
            Console.WriteLine("raiz=" & suma)
        Else
            Console.WriteLine("no se puede calcular la raiz")
        End If

        Console.ReadLine()

    End Sub
End Module
