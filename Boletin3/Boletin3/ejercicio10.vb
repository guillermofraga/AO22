Module ejercicio10
    Sub main()
        'Entrada
        Dim presion, temperatura As Double

        Console.WriteLine("Presion: ")
        presion = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("temperatura: ")
        temperatura = Convert.ToDouble(Console.ReadLine())

        If presion > 2 Then
            Console.WriteLine("abrir válvula de seguridad")
        End If

        If temperatura > 500 Then
            Console.WriteLine("Redùcir la temperatura")
            Console.ReadLine()
        End If

        If presion > 2 Or temperatura > 500 Then
        Else

            Console.WriteLine("todo en orden")
            Console.ReadLine()
        End If

        Console.ReadLine()

    End Sub
End Module
