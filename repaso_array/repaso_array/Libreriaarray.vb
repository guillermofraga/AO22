Module Libreriaarray
    Sub main()

        Dim original(9) As Integer
        Dim copia(9) As Integer
        Dim aleatorio As New Random
        For i = 0 To original.Length - 1
            original(i) = aleatorio.Next(1, 30)
        Next

        'copiar un array en otro
        Array.Copy(original, copia, 4)

        'Búsquedas : binarySearch-->si el array está previamente ordenado
        Dim posicion As Integer = Array.BinarySearch(original, 5)

        Console.WriteLine(posicion)
        Console.ReadLine()

    End Sub
End Module
