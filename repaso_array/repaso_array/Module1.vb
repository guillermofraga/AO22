Module Module1

    Sub Main()
        'sintaxis
        Dim matriz() As Integer = New Integer(9) {}
        Dim matriz2(9) As Integer
        Console.WriteLine("Elementos:" & matriz.Length)
        Console.WriteLine("Ultimo indice:" & matriz.Length - 1)


        'Recorrer un array para operaciones de sólo lectura
        For Each valor As Integer In matriz2
            Console.Write(valor & " ")
        Next

        'Modificar posiciones impares guardando un 1
        For i = 1 To matriz.Length - 1 Step 2
            matriz(i) = 1
        Next

        'llenar las posiciones pares con números aleatorios entre 1 y 50
        Dim aleatorio As New Random
        For i = 0 To matriz.Length - 1
            matriz(i) = aleatorio.Next(1, 51)
        Next

        For Each numero As Integer In matriz
            Console.Write(numero & " ")
        Next


        Console.ReadLine()

    End Sub

End Module
