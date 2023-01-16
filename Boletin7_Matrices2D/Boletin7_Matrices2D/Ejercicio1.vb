Module Ejercicio1

    Sub Main()

        Dim matriz(2, 2), seleccionarfila, suma, contador As Integer

        matriz(0, 0) = 1
        matriz(0, 1) = 2
        matriz(0, 2) = 3
        matriz(1, 0) = 4
        matriz(1, 1) = 5
        matriz(1, 2) = 6
        matriz(2, 0) = 7
        matriz(2, 1) = 8
        matriz(2, 2) = 9

        Console.WriteLine("Selecciones una fila del 0 al 2: ")
        seleccionarfila = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine(" ")

        For i = 0 To matriz.GetUpperBound(0)
            Console.Write(matriz(seleccionarfila, i) & " ")
        Next

        Console.WriteLine(" ")

        For c = 0 To matriz.GetUpperBound(0)
            matriz(c, matriz.GetUpperBound(1)) = 0
            For h = 0 To matriz.GetUpperBound(1)
                Console.Write(matriz(c, h) & " ")
            Next
        Next


            Console.WriteLine(" ")


        For j = 0 To matriz.GetUpperBound(1)
            suma += matriz(0, j)
        Next

        Console.WriteLine("Suma de la 1ª Fila: " & suma)

        For a = 0 To matriz.GetUpperBound(1)
            If matriz(a, 1) = 0 Then
                contador += 1
            End If
        Next
        Console.WriteLine(" ")
        Console.WriteLine("Ceros en la segunda columna " & contador)


        Console.ReadLine()
    End Sub

End Module
