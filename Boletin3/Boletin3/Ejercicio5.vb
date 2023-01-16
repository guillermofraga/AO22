Module Ejercicio5
    Sub main()

        'Entrada
        Dim numero As Double

        Console.WriteLine("Numero: ")
        numero = Convert.ToDouble(Console.ReadLine())


        If numero Mod 2 = 0 Then
            Console.WriteLine("Par")
        Else
            Console.WriteLine("impar")
        End If

        Console.ReadLine()

    End Sub
End Module
