Module Ejemplo3
    Sub main()

        Dim nombresprofesores() As String = {"Ramon", "Alberto", "Enrique", "Andrés Luna", "igor"}

        For i = 0 To 4
            Console.WriteLine("Nombres: " & nombresprofesores(i))
        Next

        Console.WriteLine()
        nombresprofesores(0) = "Martin"
        Console.WriteLine()

        For i = 0 To 4
            Console.WriteLine("Nombres: " & nombresprofesores(i))
        Next

        Console.ReadLine()

    End Sub
End Module
