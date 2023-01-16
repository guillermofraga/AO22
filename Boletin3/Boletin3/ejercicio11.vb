Module ejercicio11
    Sub main()

        'Entrada
        Dim x As Single

        Console.WriteLine("introduzca numero:")
        x = Convert.ToSingle(Console.ReadLine())

        If x Mod 2 = 0 Then
            Console.WriteLine("multiplo de 2")
        End If


        If x Mod 3 = 0 Then
            Console.WriteLine("multiplo de 3")
        End If

        Console.ReadLine()

    End Sub
End Module
