Module Ejercicio17
    Sub main()

        Dim array(2) As Integer
        Dim porcentaje, suma As Double

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduzca un numero:")
            array(i) = Convert.ToInt32(Console.ReadLine())
        Next

        For a = 0 To array.Length - 1
            If array(a) Mod 2 <> 0 Then
                suma += 1
            End If
        Next

        porcentaje = (suma / 3) * 100

        Console.WriteLine(porcentaje & "%")
        Console.ReadLine()



    End Sub
End Module