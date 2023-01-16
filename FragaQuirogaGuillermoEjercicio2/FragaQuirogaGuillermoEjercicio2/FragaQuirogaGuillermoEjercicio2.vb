Module FragaQuirogaGuillermoEjercicio2
    Sub main()

        Dim n, s As Integer


        Console.WriteLine("Introduzca un número:")
        n = Convert.ToInt32(Console.ReadLine())

        For i = 1 To n
            For a = 1 To i
                If i Mod a = 0 Then
                    s += 1
                End If
            Next
            If s <= 2 Then
                Console.WriteLine("El número " & i & " es primo")
            Else
                Console.WriteLine("El número " & i & " no es primo")
            End If
            s = 0
        Next


        Console.ReadLine()

    End Sub
End Module
