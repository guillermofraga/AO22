Module Ejercicio18
    Sub main()

        Dim array(3) As String
        Dim suma As Double

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduzca un numero:")
            array(i) = Console.ReadLine()
        Next

        For a = 0 To array.Length - 1
            If array(a) = Nothing Then
                suma += 1
            End If
        Next

        Console.WriteLine("hay " & suma & " posiciones vacías")
        Console.ReadLine()




    End Sub
End Module
