Module ejercicio_10_c
    Sub main()

        Dim horas, dias, horasmensual As Single
        Dim salarionetoanual, salariobrutomensual, salariohora, salariobrutoanual As Double
        Dim irpf As Double

        'entrada

        horas = 8

        dias = 30

        salariohora = 14

        irpf = 0.37

        'calculos

        horasmensual = horas * dias

        salariobrutomensual = horasmensual * salariohora

        salariobrutoanual = salariobrutomensual * 12

        salarionetoanual = salariobrutoanual * irpf

        Console.WriteLine("salario bruto = " & salariobrutoanual)


        Console.WriteLine("salarioneto = " & salarionetoanual)
        Console.ReadLine()

    End Sub
End Module
