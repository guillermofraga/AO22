Module Module1

    Sub Main()

        Dim array(4), suma, n As Integer
        Dim a As New Random

        n = 7

        For i = 0 To array.Length - 1
            array(i) = a.Next(0, 4)
        Next
        For c = 0 To array.Length - 1
            Console.WriteLine(array(c))
        Next




    End Sub

End Module
