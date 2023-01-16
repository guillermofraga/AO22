Module EjercicioDFD
    Sub main()

        Dim a, b, c, d, menor As Single

        Console.WriteLine("introduzca 1ºn:")
        a = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("introduzca 2ºn:")
        b = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("introduzca 3ºn:")
        c = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("introduzca 4ºn:")
        d = Convert.ToSingle(Console.ReadLine())

        'If a < b Then
        'If a < c Then
        'ElseIf c < d Then
        'menor = c
        'Else
        'menor = d
        'If a < d Then
        'menor = a
        'Else
        'menor = d
        'End If
        'End If
        'ElseIf b < c Then
        'If b < d Then
        'menor = b
        'Else
        'menor = d
        'End If


        'End If


        'Console.WriteLine("numero menor " & menor)
        'Console.ReadLine()

        If a < b Then
            If a < c Then
                If a < d Then
                    menor = a
                Else
                    menor = d
                End If
            Else
                If c < d Then
                    menor = c
                Else
                    menor = d
                End If

            End If
        Else
            If b < c Then
                If b < d Then
                    menor = b
                Else
                    menor = d
                End If
            Else
                If c < d Then
                    menor = c
                Else
                    menor = d
                End If
            End If
        End If
        Console.WriteLine("El menor es : " & menor)
        Console.ReadLine()

    End Sub
End Module
