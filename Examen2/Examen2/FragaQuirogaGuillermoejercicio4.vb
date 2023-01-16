Module FragaQuirogaGuillermoejercicio4
    Sub main()


        Dim opcion As Char

        Console.WriteLine("seleccione un numero")
        Console.WriteLine("a. 1")
        Console.WriteLine("b. 2")
        Console.WriteLine("c. 3")
        Console.WriteLine("d. 4")
        Console.WriteLine("e. 5")
        opcion = Convert.ToChar(Console.ReadLine())


        Select Case opcion
            Case "a"c, "A"c
                Console.WriteLine("introdujiste un 1")
            Case "b"c, "B"c
                Console.WriteLine("introdujiste un 2")
            Case "c"c, "C"c
                Console.WriteLine("introdujiste un 3")
            Case "d"c, "D"c
                Console.WriteLine("introdujiste un 4")
            Case "e"c, "E"c
                Console.WriteLine("Error en el número introducido")
        End Select

        Console.ReadLine()






    End Sub
End Module
