Module Funciones
    'Funcion que llena un array con números aleatorios
    Sub generarArray(ByRef matriz() As Integer)
        Dim aleatorio As New Random
        For i = 0 To matriz.Length - 1
            'Meto en matriz de i aleatorio.next
            matriz(i) = aleatorio.Next()
        Next
    End Sub
    Sub generarArray(ByRef matriz() As Integer, ByVal limitUp As Integer)
        Dim aleatorio As New Random
        For i = 0 To matriz.Length - 1
            matriz(i) = aleatorio.Next(limitUp)
        Next
    End Sub

    Sub mostrararray(ByRef matriz() As Integer)

        For Each valor In matriz
            Console.WriteLine(valor & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
