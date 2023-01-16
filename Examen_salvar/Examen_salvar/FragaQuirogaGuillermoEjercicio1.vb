Module FragaQuirogaGuillermoEjercicio1

    Sub Main()

        Dim n, sd, nd As Double

        Console.WriteLine("Introduzca un número:")
        n = Convert.ToDouble(Console.ReadLine())

        For i = 1 To n
            If n Mod i = 0 Then
                sd += i
                nd += 1
            End If


        Next

        sd = sd / nd

        Console.WriteLine("Media = " & sd)

        Console.ReadLine()

    End Sub

End Module
