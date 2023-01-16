Module ejemplo2
    Sub main()


        Dim nombresfutbolistas(4) As String
        Dim golesfutbolistas(4) As Integer

        For i = 0 To 4
            Console.Write("Introduzca nombre del futbolista:")
            nombresfutbolistas(i) = Console.ReadLine()
            Console.Write("Introduzca los goles:")
            golesfutbolistas(i) = Convert.ToInt32(Console.ReadLine())
        Next

        For i = 0 To 4
            Console.WriteLine("Nombre futbolistas: " & nombresfutbolistas(i) & " Goles: " & golesfutbolistas(i))
        Next

        golesfutbolistas(4) -= 1

        For i = 0 To 4
            Console.WriteLine("Nombre futbolistas: " & nombresfutbolistas(i) & " Goles: " & golesfutbolistas(i))
        Next

        Console.ReadLine()

    End Sub
End Module
