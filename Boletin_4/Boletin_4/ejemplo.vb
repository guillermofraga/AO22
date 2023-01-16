Module ejemplo

    Sub Main()
        'Programa que me diga si un número es > 100 y/o multiplo de 6

        Dim numero As Integer
        Dim continuar As Char
        Dim c As Single


        Do


            Console.WriteLine("Introduzca un número.")
            numero = Convert.ToInt32(Console.ReadLine())


            If numero Mod 6 = 0 Then
                If numero > 100 Then

                    Console.WriteLine("Multiplo de 6 y > 100")
                Else

                    Console.WriteLine("Múltiplo de 6 y <= 100")
                End If


            Else
                If numero > 100 Then
                    Console.WriteLine("Numero > 100 y no es multiplo de 6")
                Else
                    Console.WriteLine("Numero <= 100 y no es multiplo de 6")
                End If
            End If

            Console.WriteLine("Deseas continuar s/n")
            continuar = Convert.ToChar(Console.ReadLine())

        Loop While continuar = "s"c



    End Sub

End Module
