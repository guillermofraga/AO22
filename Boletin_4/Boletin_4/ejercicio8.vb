Module ejercicio8
    Sub main()

        Dim opcion, continuar As Char

        Do
            Console.WriteLine("Escoja una opción: ")
            Console.WriteLine("a. suma")
            Console.WriteLine("b. resta")
            Console.WriteLine("c. multiplicar")
            Console.WriteLine("d. dividir")
            Console.WriteLine("e. raíz de la suma")
            opcion = Convert.ToChar(Console.ReadLine())

            Select Case opcion
                Case "a"c, "A"c
                    Console.WriteLine("opción a: ")
                    Dim na1, na2, a As Double
                    Console.WriteLine("introduzca numero1:")
                    na1 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("introduzca numero2:")
                    na2 = Convert.ToDouble(Console.ReadLine())
                    a = na1 + na2
                    Console.WriteLine("suma: " & a)
                    Console.ReadLine()

                Case "b"c, "B"c
                    Console.WriteLine("opción b: ")
                    Dim nb1, nb2, b As Double
                    Console.WriteLine("introduzca numero1:")
                    nb1 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("introduzca numero2:")
                    nb2 = Convert.ToDouble(Console.ReadLine())
                    b = nb1 - nb2
                    Console.WriteLine("resta: " & b)
                    Console.ReadLine()

                Case "c"c, "C"c
                    Console.WriteLine("opción c: ")
                    Dim nc1, nc2, c As Double
                    Console.WriteLine("introduzca numero1:")
                    nc1 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("introduzca numero2:")
                    nc2 = Convert.ToDouble(Console.ReadLine())
                    c = nc1 * nc2
                    Console.WriteLine("multiplicacion: " & c)
                    Console.ReadLine()

                Case "d"c, "D"c
                    Console.WriteLine("opción c: ")
                    Dim nd1, nd2, d As Double
                    Console.WriteLine("introduzca numero1:")
                    nd1 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("introduzca numero2:")
                    nd2 = Convert.ToDouble(Console.ReadLine())
                    d = nd1 / nd2
                    Console.WriteLine("division: " & d)
                    Console.ReadLine()

                Case "e"c, "E"c
                    Console.WriteLine("opción c: ")
                    Dim ne1, ne2, e As Double
                    Console.WriteLine("introduzca numero1:")
                    ne1 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("introduzca numero2:")
                    ne2 = Convert.ToDouble(Console.ReadLine())
                    e = Math.Sqrt(ne1 + ne2) 'math.abs te devuelve el numero en positivo si la raiz es negativa ejemplo:(raiz = -7 te devuelve un 7)
                    Console.WriteLine("raiz: " & e)
                    Console.ReadLine()

            End Select
            Console.WriteLine("¿Desea continuar? S/N")
            continuar = Convert.ToChar(Console.ReadLine())
        Loop While continuar = "s"c Or continuar = "s"c





    End Sub
End Module
