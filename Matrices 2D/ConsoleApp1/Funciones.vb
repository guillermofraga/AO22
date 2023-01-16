Module Funciones
    Public Sub generarmatriz2D(ByRef matriz(,) As Integer, ByVal limiteinf As Integer, ByVal limitesuperior As Integer)
        Dim aleatorio As New Random

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                matriz(i, j) = aleatorio.Next(limiteinf, limitesuperior + 1)
            Next
        Next

    End Sub

    Public Sub mostrarMatriz(ByRef m(,) As Integer)

        For a = 0 To m.GetUpperBound(0)
            For b = 0 To m.GetUpperBound(1)
                Console.Write(m(a, b))
            Next
            Console.WriteLine()
        Next



    End Sub
End Module
