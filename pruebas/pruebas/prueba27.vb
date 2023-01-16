Module prueba27
    Sub main()

        Dim factores, elementos, resultado As Integer

        Console.WriteLine("Introduce cuantos factores quieres mostrar: ")
        factores = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduzca el número de elementos que quieras mostrar:")
        elementos = Convert.ToInt32(Console.ReadLine())

        For i = 1 To factores
            For j = 1 To elementos
                resultado = i * j
                Console.WriteLine(i & " x " & j & " = " & resultado)
            Next
            Console.WriteLine("----------------------")
        Next

        Console.ReadLine()


    End Sub
End Module
