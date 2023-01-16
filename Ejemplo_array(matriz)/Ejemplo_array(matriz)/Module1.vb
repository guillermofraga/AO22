Module Module1

    Sub Main()

        Dim nombres(4) As String

        nombres(0) = "brais"
        nombres(1) = "pablo"
        nombres(2) = "paula"
        nombres(3) = "anxo"
        nombres(4) = "hugo"


        For i = 0 To 4
            Console.WriteLine(nombres(i))

        Next

        Console.ReadLine()

    End Sub

End Module
