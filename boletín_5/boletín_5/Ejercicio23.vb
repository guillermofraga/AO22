Module Ejercicio23
    Sub main()

        Dim n, suma As Double

        Console.WriteLine("introduzca un numero:")
        n = Convert.ToDouble(Console.ReadLine())

        For i = 1 To n
            For j = 1 To i - 1
                If i Mod j = 0 Then
                    suma += j
                End If
            Next
            If i = suma Then
                Console.WriteLine(i & " es perfecto.")
            End If
            suma = 0
        Next
        Console.ReadLine()

        Console.ReadLine()










    End Sub
End Module
