Module Module1

    Sub Main()
        'crear una matriz 2d de tipo integer
        Dim matriz(2, 2) As Integer

        matriz(0, 0) = 3
        matriz(0, 1) = 4
        matriz(0, 2) = 9
        matriz(1, 0) = 1
        matriz(1, 1) = 2
        matriz(1, 2) = 3
        matriz(2, 0) = 4
        matriz(2, 1) = 5
        matriz(2, 2) = 7



        'GetUpperbound(int dimension)--> devuelve el ultimo índice accesible de esa dimension
        Dim matriz2(2, 1) As Integer
        Dim filas As Integer = matriz2.GetUpperBound(0)
        Dim columnas As Integer = matriz2.GetUpperBound(1)
        Console.WriteLine("ultimo índice de fila de matriz 2: " & filas)
        Console.WriteLine("ultimo índice de columnas de matriz 2: " & columnas)
        Console.WriteLine("-----------")
        'Puedo usarlos para recorrer las matrices 2d
        For a = 0 To matriz2.GetUpperBound(0)
            For b = 0 To matriz2.GetUpperBound(1)
                Console.Write(matriz2(a, b) & " ")
            Next
            Console.WriteLine(" ")
        Next
        Console.WriteLine("")
        Console.WriteLine("-------------")

        'visualizar por pantalla
        '1ª fila
        For i = 0 To 2
            For j = 0 To 2
                Console.Write(matriz(i, j) & " ")
            Next
        Next
        Console.WriteLine()

        '2ª fila
        For i = 0 To 2
            Console.Write(matriz(1, i) & " ")
        Next
        Console.WriteLine()

        '3ª fila
        For i = 0 To 2
            Console.Write(matriz(2, i) & " ")
        Next

        Console.ReadLine()
    End Sub

End Module
