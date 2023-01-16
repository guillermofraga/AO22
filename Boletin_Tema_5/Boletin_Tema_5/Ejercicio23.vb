Module Ejercicio23
    Sub main()

        Dim array(19) As Integer
        Dim x As New Random

        For i = 0 To array.Length - 1
            array(i) = x.Next(1, 20)
        Next

        Dim a As Integer = array.IndexOf(array, 7)
            If a < 0 Then
            Console.WriteLine("No se encontro el numero")
        Else
            Console.WriteLine("Está en la posición : " & a)
        End If

        Console.ReadLine()


    End Sub
End Module
