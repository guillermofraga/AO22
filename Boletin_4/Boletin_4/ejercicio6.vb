Module ejercicio6
    Sub main()

        Dim n As Double

        Console.WriteLine("introduzca un número:")
        n = Convert.ToDouble(Console.ReadLine())

        If n Mod 4 = 0 Then
            n = n + 25
            Console.WriteLine("número final: " & n)
        ElseIf n Mod 5 = 0 Then
            n = n + 50
            Console.WriteLine("número final: " & n)
        ElseIf n <> n Mod 4 And n <> n Mod 5 Then
            n = n + 100
            Console.WriteLine("número final: " & n)
        End If


        Console.ReadLine()

    End Sub
End Module
