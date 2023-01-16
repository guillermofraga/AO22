Module ejercicio_11
    Sub main()

        Dim espacio, tiempo, velocidad As Double

        'entrada

        Console.WriteLine("espacio en metros: ")
        espacio = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("tiempo en segundos: ")
        tiempo = Convert.ToDouble(Console.ReadLine())

        'calculos

        velocidad = espacio / tiempo

        'salida
        Console.WriteLine("La velocidad es de " & velocidad & " metros/segundo")
        Console.ReadLine()


    End Sub
End Module
