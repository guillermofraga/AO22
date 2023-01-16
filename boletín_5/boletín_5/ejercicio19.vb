Module ejercicio19
    Sub main()

        Dim n, m, i As Integer

        Console.WriteLine("Introduzca donde comienza el numero:")
        n = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduzca donde acaba el numero:")
        m = Convert.ToInt32(Console.ReadLine())

        For i = n To m
            If i Mod 3 = 0 And i Mod 5 = 0 And i Mod 7 = 0 Then
                Console.WriteLine(i)
            End If
        Next

        Console.ReadLine()


    End Sub
End Module
