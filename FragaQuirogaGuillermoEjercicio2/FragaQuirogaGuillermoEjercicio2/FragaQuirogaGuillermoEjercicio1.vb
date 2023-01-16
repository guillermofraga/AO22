Module FragaQuirogaGuillermoEjercicio1

    Sub Main()

        Dim caso As Char
        Dim nf, sf, npe, spe, npr, spr, nim As Integer


        Do

            Console.WriteLine("Selecciona un caso:")
            Console.WriteLine("1. Calcular el factorial de un número introduzido")
            Console.WriteLine("2. Comprueba si ese número es perfecto")
            Console.WriteLine("3. Comprueba si ese número es primo")
            Console.WriteLine("4. Comprueba si ese número es impar")
            caso = Convert.ToChar(Console.ReadLine())


            Select Case caso
                Case "1"c
                    Console.WriteLine("Introduzca un número:")
                    nf = Convert.ToInt32(Console.ReadLine())

                    For i = 1 To nf
                        For n = 1 To i
                            sf = n * i
                        Next
                    Next

                        Console.WriteLine("el factorial de " & nf & " es " & sf)

                Case "2"c

                    Console.WriteLine("Introduzca un número:")
                    npe = Convert.ToInt32(Console.ReadLine())

                    For i = 1 To npe - 1
                        If npe Mod i = 0 Then
                            spe += i
                        End If

                    Next

                    If spe = npe Then
                        Console.WriteLine("El número " & npe & " es perfecto")
                    Else
                        Console.WriteLine("El número " & npe & " no es perfecto")
                    End If

                Case "3"c

                    Console.WriteLine("Introduzca un número:")
                    npr = Convert.ToInt32(Console.ReadLine())

                    For i = 1 To npr
                        If npr Mod i = 0 Then
                            spr += 1
                        End If
                    Next

                    If spr <= 2 Then
                        Console.WriteLine("El número " & npr & " es primo")
                    Else
                        Console.WriteLine("El número " & npr & " no es primo")
                    End If

                    spr = 0

                Case "4"c

                    Console.WriteLine("Introduzca un número:")
                    nim = Convert.ToInt32(Console.ReadLine())

                    If nim Mod 2 = 0 Then
                        Console.WriteLine("El número " & nim & " es par")
                    Else
                        Console.WriteLine("El número " & nim & " es impar")
                    End If


            End Select


            Console.WriteLine()
        Loop


        Console.ReadLine()

    End Sub

End Module
