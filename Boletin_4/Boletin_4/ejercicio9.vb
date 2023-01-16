Module ejercicio9
    Sub main()

        Dim litros, precio As Double

        Console.WriteLine("Nº de litros:")
        litros = Convert.ToDouble(Console.ReadLine())

        If litros < 50 Then
            precio = 0
        ElseIf litros >= 50 And litros <= 200 Then
            precio = (litros - 50) * 10
        ElseIf litros >= 200 Then
            precio = (litros - 200) * 20 + 150 * 10

        End If

        Console.WriteLine("precio = " & precio & " euros")
        Console.ReadLine()

    End Sub
End Module
