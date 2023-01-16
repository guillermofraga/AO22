Module FragaQuirogaGuillermoEjercicio3
    Sub main()


        Dim n1 As Double


        Console.WriteLine("introduzca un numero")
        n1 = Convert.ToDouble(Console.ReadLine())

        If n1 Mod 2 = 0 Then
            Console.WriteLine("multiplo de 2")
        Else
            Console.WriteLine("no es multiplo de 2")
        End If

        If n1 Mod 3 = 0 Then
            Console.WriteLine("multiplo de 3")
        Else
            Console.WriteLine("no es multiplo de 3")
        End If

        If n1 Mod 5 = 0 Then
            Console.WriteLine("multiplo de 5")
        Else
            Console.WriteLine("no es multiplo de 5")
        End If


        Console.ReadLine()


    End Sub
End Module
