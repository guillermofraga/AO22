Module FragaQuirogaGuillermoEjercicio3
    Sub main()

        Dim numero, sp, suma As Double

        Console.WriteLine("Introduzca un número:")
        numero = Convert.ToDouble(Console.ReadLine())

        For i = 1 To numero
            For a = 1 To i - 1
                If i Mod a = 0 Then
                    sp += a
                End If
            Next
            If sp = i Then
                Console.WriteLine(i)
                suma = suma + i
            End If
            sp = 0
        Next

        Console.WriteLine(suma)
        Console.ReadLine()

    End Sub
End Module
