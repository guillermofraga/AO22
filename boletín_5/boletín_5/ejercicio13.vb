Module ejercicio13
    Sub main()

        Dim n, suma As Double

        Console.WriteLine("introduzca un numero:")
        n = Convert.ToDouble(Console.ReadLine())

        For i = 1 To n - 1
            If n Mod i = 0 Then
                suma += i

            End If
        Next

        If suma = n Then
            Console.WriteLine("El numero " & n & " es perfecto")
        Else
            Console.WriteLine("El numero " & n & " no es perfecto")
        End If

        Console.ReadLine()

    End Sub
End Module
