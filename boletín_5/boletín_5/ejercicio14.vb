Module ejercicio14
    Sub main()

        Dim n, suma As Double

        Console.WriteLine("Introduzca un numero:")
        n = Convert.ToDouble(Console.ReadLine())

        For i = 1 To n
            If i Mod 5 = 0 Then
                suma += i
            End If
        Next

        Console.WriteLine(suma)
        Console.ReadLine()

    End Sub
End Module
