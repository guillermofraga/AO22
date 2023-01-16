Module Ejercicio8
    Sub main()

        Dim matriz(2, 2) As Integer
        Dim minimo, maximo, desviacion, media, desviacion2, posicionf, posicionc, posicionf2, posicionc2 As Double

        generarmatriz2D(matriz, 1, 10)

        For a = 0 To matriz.GetUpperBound(0)
            For b = 0 To matriz.GetUpperBound(1)
                Console.Write(matriz(a, b) & " ")
            Next
            Console.WriteLine("")
            Console.WriteLine("----------")
        Next

        Console.WriteLine("")

        minimo = matriz(0, 0)

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                If minimo > matriz(i, j) Then
                    minimo = matriz(i, j)
                    posicionf2 = i
                    posicionc2 = j
                End If
            Next
        Next

        For i = 0 To matriz.GetUpperBound(0)
            For j = 0 To matriz.GetUpperBound(1)
                If maximo < matriz(i, j) Then
                    maximo = matriz(i, j)
                    posicionf = i
                    posicionc = j
                End If
                media += matriz(i, j)
            Next
        Next

        media = media / 9

        Console.WriteLine("")
        Console.WriteLine("Media: " & media)
        Console.WriteLine("")

        desviacion = media - maximo

        If desviacion < 0 Then
            desviacion *= -1
        End If

        Console.WriteLine("Valor maximo: " & maximo & " desviacion: " & desviacion & " posicion: " & posicionf & "," & posicionc)
        Console.WriteLine("")

        desviacion2 = media - minimo

        If desviacion2 < 0 Then
            desviacion2 *= -1
        End If

        Console.WriteLine("Valor minimo: " & minimo & " desviacion: " & desviacion2 & " posicion: " & posicionf2 & "," & posicionc2)

        Console.ReadLine()

    End Sub
End Module
