Module ejercicio13
    Sub main()

        Dim color As Char

        Console.WriteLine("Escoga un valor:")
        Console.WriteLine("r")
        Console.WriteLine("v")
        Console.WriteLine("a")
        color = Convert.ToChar(Console.ReadLine())


        Select Case color
            Case "r"c, "R"c
                Console.WriteLine("rojo")
            Case "v"c, "V"c
                Console.WriteLine("verde")
            Case "a"c, "A"c
                Console.WriteLine("azul")
            Case Else
                Console.WriteLine("Negro")
        End Select

        Console.ReadLine()












    End Sub
End Module
