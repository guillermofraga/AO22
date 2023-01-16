Module ejercicio18
    Sub main()


        Dim n, suma As Integer

        Console.WriteLine("introduzca un numero")
        n = Convert.ToInt32(Console.ReadLine())


        While n <= 0
            Console.WriteLine("introduzca un numero")
            n = Convert.ToInt32(Console.ReadLine())
        End While


        For i = 1 To n
            If n Mod i = 0 Then
                suma += 1
            End If
        Next

        If suma <> 2 Then
            Console.WriteLine("El numero no es primo")
        Else
            Console.WriteLine("El numero es primo")
        End If


        Console.ReadLine()

    End Sub
End Module
