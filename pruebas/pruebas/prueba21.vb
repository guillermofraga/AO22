Module prueba21
    Sub main()

        Dim a, r As Integer

        a = 1

        While a <= 10
            For i = 1 To 10
                r = a * i
                Console.WriteLine(a & " x " & i & " = " & r)

            Next
            Console.WriteLine("-------------------------")
            a += 1
        End While

        Console.ReadLine()

    End Sub
End Module
