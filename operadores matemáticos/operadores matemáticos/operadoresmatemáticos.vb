Module operadoresmatematicos

    Sub Main()

        'Operadores matemáticos : Mod , / , \
        Dim x As Integer = 14
        Dim y As Integer = 4

        Dim resto As Integer = x Mod y
        Dim divisionreal As Double = x / y
        Dim divisionentera As Integer = x \ y

        Console.WriteLine("resto: " & resto)

        Console.WriteLine("dision real: " & divisionreal)

        Console.WriteLine("division entera: " & divisionentera)
        Console.ReadLine()


    End Sub

End Module
