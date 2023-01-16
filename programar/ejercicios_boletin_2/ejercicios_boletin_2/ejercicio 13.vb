Module ejercicio_13
    Sub main()

        Dim h, a, b As Double


        'entrada:

        Console.WriteLine("introduzca valor a: ")
        a = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("introduzca valor b: ")
        b = Convert.ToDouble(Console.ReadLine())

        'calculo:

        h = Math.Sqrt(a ^ 2 + b ^ 2) 'math.pow(b, ?) sirve para elevar.
        h = Math.Round(h, 2) 'math.round sirve para poner los decimales que quieres.

        'salida:
        Console.WriteLine("hipotenusa = " & h)
        Console.ReadLine()








    End Sub
End Module
