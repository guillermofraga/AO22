Module ejercicio_7
    Sub main()
        Dim gradoscelsius, gradosfahrenheit As Double

        'Entrada: gradoscelsius
        gradoscelsius = Convert.ToDouble(InputBox("introduzca la temperatura: "))

        'calculos:
        gradosfahrenheit = (9 / 5) * gradoscelsius + 32

        'salida:
        Console.WriteLine(gradoscelsius & "=" & gradosfahrenheit)
        Console.ReadLine()



    End Sub
End Module
