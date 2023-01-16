Module ejercicio11
    Sub main()

        Dim horas As Single
        Dim sb, sn As Double

        Console.WriteLine("introduzca horas semanales:")
        horas = Convert.ToSingle(Console.ReadLine())

        If horas <= 38 Then
            sb = horas * 20
            Console.WriteLine("Salario bruto semanal: " & sb)
        Else
            sb = (horas - 38) * 30
            Console.WriteLine("Salario bruto semanal: " & sb)
        End If

        If sb <= 300 Then
            Console.WriteLine("Salario neto: " & sb)
        Else
            sn = sb - (sb * (10 / 100))
            Console.WriteLine("Salario neto: " & sn)
        End If

        Console.ReadLine()

    End Sub
End Module
