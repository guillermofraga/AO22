Module ejercicio12
    Sub main()

        Dim n, nd, suma As Double

        Console.WriteLine("introduzca numero:")
        n = Convert.ToDouble(Console.ReadLine())

        For i = 1 To n
            If n Mod i = 0 Then
                suma += i
            End If

        Next

        Console.WriteLine(suma)

        Console.ReadLine()

    End Sub
End Module
