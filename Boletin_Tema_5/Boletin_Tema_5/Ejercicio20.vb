Module Ejercicio20
    Sub main()

        Dim array(3), contador As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduzca un numero:")
            array(i) = Convert.ToInt32(Console.ReadLine())
        Next

        For a = 0 To array.Length - 1
            If array(a) > 1000 And contador = 0 Then
                Console.WriteLine("valor: " & array(a) & " Posicion: " & a)
                contador += 1
            End If
        Next


        Console.ReadLine()

    End Sub
End Module
