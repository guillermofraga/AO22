Module ejercicio_12
    Sub main()

        Dim area, perimetro, diagonal As Double
        Dim ladocuadrado As Double

        'entrada
        Console.WriteLine("ladocuadrado cm: ")
        ladocuadrado = Convert.ToDouble(Console.ReadLine())

        'calculos

        perimetro = 4 * ladocuadrado
        Console.WriteLine("perimetro = " & perimetro)

        diagonal = ladocuadrado * Math.Sqrt(2)
        Console.WriteLine("diagonal = " & diagonal)

        area = ladocuadrado * ladocuadrado 'o math.pow(lado, 2) sirve para hacer al cuadrado.
        Console.WriteLine("area = " & area) 'math.round(area,2) el numero es para los decimales que quieres ver.
        Console.ReadLine()

    End Sub
End Module
