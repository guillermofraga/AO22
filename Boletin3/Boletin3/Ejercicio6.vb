Module Ejercicio6
    Sub main()

        'Entrada
        Dim x, y, z, media As Single


        Console.WriteLine("Numero 1: ")
        x = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("Numero 2: ")
        y = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("Numero 3: ")
        z = Convert.ToSingle(Console.ReadLine())

        'calculos
        media = (x + y + z) / 3

        If media >= 5 Then
            Console.WriteLine("Alumno aprobado")
        Else
            Console.WriteLine("Alumno suspenso")
        End If

        Console.ReadLine()


    End Sub
End Module
