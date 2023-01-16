Module Ejercicio12
    Sub main()

        Dim indicador As Char

        Console.WriteLine("Escoga un valor:")
        Console.WriteLine("a. valor 1")
        Console.WriteLine("b. valor 2")
        Console.WriteLine("c. valor 3")
        Console.WriteLine("d. valor 4")
        indicador = Convert.ToChar(Console.ReadLine())


        Select Case indicador
            Case "a"c, "A"c
                Console.WriteLine("Calor")
            Case "b"c, "B"c
                Console.WriteLine("Templado")
            Case "c"c, "C"c
                Console.WriteLine("Frio")
            Case "d"c, "D"c
                Console.WriteLine("Fuera de rango")
        End Select

        Console.ReadLine()

    End Sub
End Module
