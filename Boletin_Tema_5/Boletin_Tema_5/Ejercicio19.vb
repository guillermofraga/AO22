Module Ejercicio19
    Sub main()

        Dim array(3) As Double

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduzca un numero:")
            array(i) = Convert.ToInt32(Console.ReadLine())
        Next

        For a = 0 To array.Length - 1
            If array(a) > 1000 Then
                Console.WriteLine(array(a))
            End If
        Next


        Console.ReadLine()

    End Sub
End Module
