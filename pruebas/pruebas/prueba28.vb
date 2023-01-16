Module prueba28
    Sub main()


        Dim a, suma As Integer

        Console.WriteLine("introduzca un número:")
        a = Convert.ToInt32(Console.ReadLine())


        For i = 1 To a
            If a Mod i = 0 Then
                suma += 1
            End If
        Next

        If suma <= 2 Then
            Console.WriteLine("número primo")
        Else
            Console.WriteLine("número no primo")
        End If

        Console.ReadLine()

    End Sub
End Module
