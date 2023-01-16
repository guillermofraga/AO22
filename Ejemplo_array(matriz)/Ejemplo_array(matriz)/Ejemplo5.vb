Module Ejemplo5
    Sub main()

        Dim cantidad As Integer

        Console.WriteLine("Numero de jugadores:")
        cantidad = Convert.ToInt32(Console.ReadLine())

        Dim nombre(cantidad - 1), nacionalida(cantidad - 1), goles(cantidad - 1), asistencias(cantidad - 1) As String

        For i = 0 To cantidad - 1
            Console.WriteLine("Nombre: ")
            nombre(i) = Console.ReadLine()
            Console.WriteLine("Nacionalida: ")
            nacionalida(i) = Console.ReadLine()
            Console.WriteLine("goles: ")
            goles(i) = Console.ReadLine()
            Console.WriteLine("asistencias: ")
            asistencias(i) = Console.ReadLine()
            Console.WriteLine()
        Next


        For i = 0 To cantidad - 1
            Console.WriteLine(nombre(i) & " - " & nacionalida(i) & " - " & goles(i) & " - " & asistencias(i))
        Next

        Console.ReadLine()

    End Sub
End Module
