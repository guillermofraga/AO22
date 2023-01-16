Module Ejercicio13
    Sub main()

        Dim array(2), suma As Integer

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduzca numeros a sumar:")
            array(i) = Convert.ToInt32(Console.ReadLine())
        Next

        For a = 0 To array.Length - 1
            If a Mod 2 = 0 Then
                suma += array(a)
            End If
        Next

        Console.WriteLine("Suma = " & suma)
        Console.ReadLine()


    End Sub
End Module
