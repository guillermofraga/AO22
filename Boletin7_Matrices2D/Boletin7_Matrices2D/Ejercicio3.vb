Module Ejercicio3
    Sub main()

        Dim temp(11, 29) As Integer
        Dim media, mes As Double

        generarmatriz2D(temp, 7, 24)

        For i = 0 To temp.GetUpperBound(0)
            For j = 0 To temp.GetUpperBound(1)
                Console.Write(temp(i, j) & " ")
            Next
        Next

        Console.WriteLine(" ")

        For k = 0 To temp.GetUpperBound(0)
            For l = 0 To temp.GetUpperBound(1)
                media += temp(k, l)
            Next
            mes += 1
            media = media / 30
            If mes = 1 Then
                Console.WriteLine("Media temperatura de Enero: " & media)
            ElseIf mes = 2 Then
                Console.WriteLine("Media temperatura de Febrero: " & media)
            ElseIf mes = 3 Then
                Console.WriteLine("Media temperatura de Marzo: " & media)
            ElseIf mes = 4 Then
                Console.WriteLine("Media temperatura de Abril: " & media)
            ElseIf mes = 5 Then
                Console.WriteLine("Media temperatura de Mayo: " & media)
            ElseIf mes = 6 Then
                Console.WriteLine("Media temperatura de Junio: " & media)
            ElseIf mes = 7 Then
                Console.WriteLine("Media temperatura de Julio: " & media)
            ElseIf mes = 8 Then
                Console.WriteLine("Media temperatura de Agosto: " & media)
            ElseIf mes = 9 Then
                Console.WriteLine("Media temperatura de Septiembre: " & media)
            ElseIf mes = 10 Then
                Console.WriteLine("Media temperatura de Octubre: " & media)
            ElseIf mes = 11 Then
                Console.WriteLine("Media temperatura de Noviembre: " & media)
            ElseIf mes = 12 Then
                Console.WriteLine("Media temperatura de Diciembre: " & media)
            End If
            media = 0
        Next


        Console.ReadLine()



    End Sub
End Module
