Module Ejercicio16
    Sub main()

        Dim array(2), suma As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduzca un numero:")
            array(i) = Convert.ToInt32(Console.ReadLine())
        Next

        For a = 0 To array.Length - 1
            If array(a) < 0 Then
                suma += 1
            End If
        Next

        Console.Write(suma)
        Console.ReadLine()


    End Sub
End Module
