Module Module1

    Sub Main()
        'cambiar propiedades de la consola
        'cambiar color del texto
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("programar")
        'cambiar el color de fondo del texto
        Console.BackgroundColor = ConsoleColor.Green
        Console.ReadLine()
        Console.ForegroundColor = ConsoleColor.Red
        'para quitar el color del fondo
        Console.BackgroundColor = Nothing
        Console.WriteLine("programar")
        'cambiar el color de fondo del texto
        Console.BackgroundColor = ConsoleColor.Green
        Console.Beep(37, 200)
        Console.ReadLine()

    End Sub

End Module
