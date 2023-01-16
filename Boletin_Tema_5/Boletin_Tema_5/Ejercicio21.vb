Module Ejercicio21
    Sub main()

        Dim array(3) As String
        Dim contador As Double

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduzca un caracter:")
            array(i) = Console.ReadLine()
        Next

        For a = 0 To array.Length - 1
            If array(a) = Nothing And contador = 0 Then
                Console.WriteLine("Posicion: " & a)
                contador += 1
            End If
        Next


        Console.ReadLine()


    End Sub
End Module
