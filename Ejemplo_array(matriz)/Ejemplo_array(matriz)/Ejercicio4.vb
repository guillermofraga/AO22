Module Ejercicio4
    Sub main()

        Dim nombres() As String = {"Anxo", "Sergio", "Martín", "Hugo", "Boris"}
        Dim edad() As Integer = {16, 17, 17, 16, 18}
        Dim vdf() As String = {"Rust", "Zelda: ocarina of time", "ARK", "Stray", "Dragon ball"}

        For i = 0 To 4
            Console.WriteLine("Nombre: " & nombres(i) & " edad: " & edad(i) & " videojuego favorito: " & vdf(i))
            Console.WriteLine()
        Next


        Console.ReadLine()

    End Sub
End Module
