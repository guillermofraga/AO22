Module Module1

    Sub Main()

        'Funciones de la librería Math
        'sqrt(numero)--> Raíz de ese número
        Dim n As Integer = 10
        Dim raiz As Double = Math.Sqrt(n)
        Console.WriteLine("la raiz de " & n & " es : " & raiz)

        'pow(base,potencia)--> base elevado a potencia
        Dim resultado As Integer = Convert.ToInt32(Math.Pow(5, 3))
        Dim raizcubica As Double = Math.Pow(150, 1 / 3)

        'Funciones de redondeo
        Dim valor As Double = 3.141652
        Dim enteromayor As Integer = Convert.ToInt32(Math.Ceiling(valor))
        Dim enteromenor As Integer = Convert.ToInt32(Math.Floor(valor))
        Dim enterocercano As Integer = Convert.ToInt32(Math.Round(valor))

        Console.WriteLine(valor & " redondeo hacia arriba: " & enteromayor)
        Console.WriteLine(valor & " redondeo hacia abajo: " & enteromenor)
        Console.WriteLine(valor & " redondeo más cercano: " & enterocercano)

        'ajustar a un número de decimales:
        Dim valorcon2decimales As Double = Math.Round(valor, 2)
        Console.WriteLine(valor & " redondeo con 2 decimales: " & valorcon2decimales)


        'calcular potencias
        Dim x As Single

        Dim potencia As Integer = Convert.ToInt32(Math.Pow(x, 3))
        Dim potencia2 As Double = Math.Pow(x, 1 / 4)
        Dim potencia3 As Double = x ^ 3

        'redondeo --> math.floor(x) , --> math.ceiling










        Console.ReadLine()




    End Sub

End Module
