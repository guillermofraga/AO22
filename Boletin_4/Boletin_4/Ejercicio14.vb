Module Ejercicio14
    Sub main()

        Dim numero As Double

        Console.WriteLine("intro num:")
        numero = Convert.ToDouble(Console.ReadLine())

        If numero >= 0 And numero < 10 Then
            Console.WriteLine("1 cifra")
        ElseIf numero < 100 Then
            Console.WriteLine("2 cifras")
        ElseIf numero < 1000 Then
            Console.WriteLine("3 cifras")
        ElseIf numero < 10000 Then
            Console.WriteLine("4 cifras")
        ElseIf numero < 100000 Then
            Console.WriteLine("5 cifras")
        ElseIf numero < 1000000 Then
            Console.WriteLine("6 cifras")
        End If

        Console.ReadLine()

    End Sub
End Module
