Module Ejercicio14
    Sub main()

        Dim array(2), suma As Integer
        Dim cuadrado As Double

        For i = 0 To array.Length - 1
            Console.WriteLine("Introduzca numeros a sumar:")
            array(i) = Convert.ToInt32(Console.ReadLine())
        Next

        For a = 0 To array.Length - 1
            cuadrado = Math.Pow(array(a), 2)
            suma += Convert.ToInt32(cuadrado)
        Next

        Console.WriteLine("Suma = " & suma)
        Console.ReadLine()


    End Sub
End Module
