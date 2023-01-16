Module FragaQuirogaGuillermoejercicio2

    Sub Main()

        Dim horas, precioh, salarion, salariob, horasex, mas35h As Double

        Console.WriteLine("introduzca las horas:")
        horas = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("introduzca salario por hora:")
        precioh = Convert.ToDouble(Console.ReadLine())

        If horas > 0 And horas < 25 Then
            salariob = horas * precioh
        ElseIf horas > 25 And horas < 35 Then
            horasex = (horas - 25) * (precioh + (precioh * (50 / 100)))
            horas = precioh * 25
            salariob = horas + horasex
        Else
            horasex = (horas - 25) * (precioh + (precioh * (50 / 100)))
            mas35h = (horas - 35) * (precioh + (precioh * (75 / 100)))
            horas = precioh * 25
            salariob = horas + horasex + mas35h
        End If



        If salariob > 0 And salariob < 1000 Then
            salarion = salariob - (salariob * (10 / 100))
        ElseIf salariob > 1000 And salariob < 1500 Then
            salarion = salariob - (salariob * (15 / 100))
        ElseIf salariob > 1500 And salariob < 1800 Then
            salarion = salariob - (salariob * (25 / 100))
        Else
            salarion = salariob - (salariob * (30 / 100))
        End If


        Console.WriteLine("salario bruto = " & salariob)
        Console.WriteLine("salario neto = " & salarion)
        Console.ReadLine()


    End Sub

End Module
