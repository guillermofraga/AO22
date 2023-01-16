Module ejercicio_6
    Sub main()
        Dim suma As Double
        Dim n1, n2 As Double
        Dim resta As Double
        Dim n3, n4 As Double
        Dim multiplicación As Double
        Dim n5, n6 As Double


        'Entrada:

        Console.WriteLine("numeros a sumar: ")
        n1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("numeros a sumar: ")
        n2 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("numeros a restar: ")
        n3 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("numeros a restar: ")
        n4 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("numeros a multiplicar: ")
        n5 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("numeros a multiplicar: ")
        n6 = Convert.ToDouble(Console.ReadLine())

        'calculos
        suma = n1 + n2
        Console.WriteLine("la suma es = " & suma)

        resta = n3 - n4
        Console.WriteLine("la resta es = " & resta)

        multiplicación = n5 * n6
        Console.WriteLine("la multiplicación es = " & multiplicación)

        Console.ReadLine()







    End Sub
End Module
