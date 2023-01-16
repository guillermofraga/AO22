Module calculo_media
    Sub main()
        'Zona de declaración de variables
        Dim n1, n2, n3, media As Single

        'Entrada
        n1 = 24

        n2 = 49

        n3 = 84

        'Proceso
        media = (n1 + n2 + n3) / 3

        'Salida: Escribir ...
        Console.WriteLine("la media es " & media)

        'Mostrar consola hasta que el usuario pulse enter
        Console.ReadLine()

    End Sub
End Module
