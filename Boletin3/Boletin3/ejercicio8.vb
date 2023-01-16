Module ejercicio8
    Sub main()
        'Entrada
        Dim contraseñaregistrada, contraseña As String

        Console.WriteLine("Introduzca su nueva contraseña:")
            contraseñaregistrada = Console.ReadLine()

            Console.WriteLine("Introduzca de nuevo la contraseña:")
            contraseña = Console.ReadLine()


            If contraseñaregistrada = contraseña Then
                Console.WriteLine("Contraseña correcta")
            Else
            Console.WriteLine("Contraseña incorrecta")
        End If

            Console.ReadLine()

    End Sub

End Module
