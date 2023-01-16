Module Ejercicio26
    Sub main()

        Dim na As New Random
        Dim n, n1, c1 As Integer
        Dim dificulta, continuar As Char


        Console.WriteLine("dificulta 1")
        Console.WriteLine("dificulta 2")
        Console.WriteLine("dificulta 3")
        dificulta = Convert.ToChar(Console.ReadLine())
        n1 = 0

        Select Case dificulta
            Case "1"c
                n = na.Next(1, 15)
                Do
                    If n1 <> n Then
                        Console.WriteLine("adivina el numero:")
                        n1 = Convert.ToInt32(Console.ReadLine())
                    ElseIf n1 = n Then
                        Console.WriteLine("Acertaste")
                    End If
                    c1 += 1
                Loop Until continuar = "s" Or c1 = 3
            Case "2"c


            Case "3"c


        End Select


        Console.WriteLine(n)

        Console.ReadLine()

    End Sub
End Module
