Module Module1

    Sub Main()

        Dim x As New Random
        Dim a As Integer

        a = x.Next(-5, 5)

        For n = 1 To 10
            For i = 1 To 10
                a = x.Next(-5, 5)
                Console.Write(a & " ,")
            Next
            Console.WriteLine()
        Next

        Console.ReadLine()

    End Sub

End Module
