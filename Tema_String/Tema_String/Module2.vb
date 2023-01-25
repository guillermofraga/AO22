Module Module2
    Sub main()

        Dim matricula(19) As String
        matricula(0) = "1234-KLXZ"
        matricula(1) = "1234-KLSJ"
        matricula(2) = "1234-KLQO"
        matricula(3) = "1234-KLXE"
        matricula(4) = "1234-KLQB"
        matricula(5) = "1234-KLTV"
        matricula(6) = "1234-KLGC"
        matricula(7) = "1234-KLQS"
        matricula(8) = "1234-KLWA"
        matricula(19) = "1234-KLRZ"

        For i = 0 To matricula.Length - 1
            If Not matricula(i) Is Nothing Then
                If matricula(i).EndsWith("Z"c) Then
                    Console.WriteLine("La matricula " & matricula(i) & " termina en Z")
                End If
            End If
        Next


        Console.ReadLine()

    End Sub
End Module
