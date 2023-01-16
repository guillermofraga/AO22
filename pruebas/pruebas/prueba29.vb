Module ejercicio29
    Sub main()

        Dim numero As Integer
        Dim sdivisor As Integer

        Console.WriteLine("Introduzca un número:")
        numero = Convert.ToInt32(Console.ReadLine())


        For i = 1 To numero - 1
            If numero Mod i = 0 Then
                sdivisor += i
            End If
        Next

        If sdivisor = numero Then
            Console.WriteLine("El número " & numero & " es perfecto.")
        Else
            Console.WriteLine("El número " & numero & " no es perfecto.")
        End If

        Console.ReadLine()

    End Sub
End Module
