Module Ejercicio22
    Sub main()

        Dim array(3), contador As Double

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduzca un caracter:")
            array(i) = Convert.ToDouble(Console.ReadLine())
        Next

        For a = 0 To array.Length - 1
            If array(a) Mod 2 = 0 And contador = 0 Then
                Console.WriteLine("valor par: " & array(a) & " posicion: " & a)
                contador += 1
            End If
        Next


        Console.ReadLine()


    End Sub
End Module
