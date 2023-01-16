Module FragaQuirogaGuillermoEjercicio5
    Sub main()

        'Entrada
        Const impuestoreval As Double = 3.4
        Dim precioventa, importe, CI, antiguedad, preciocatastral As Double

        Console.WriteLine("importe: ")
        importe = Convert.ToDouble(Console.ReadLine())

        CI = 0.03

        Console.WriteLine("antiguedad: ")
        antiguedad = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("preciocatastral: ")
        preciocatastral = Convert.ToDouble(Console.ReadLine())

        'Calculos

        precioventa = importe + CI + impuestoreval * (antiguedad / 100) * preciocatastral

        Console.WriteLine("Precioventa: " & precioventa)
        Console.ReadLine()


    End Sub
End Module
