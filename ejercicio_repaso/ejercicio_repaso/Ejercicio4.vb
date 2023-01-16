Module Ejercicio4
    Sub main()

        Dim n, p As Integer
        Dim espacio As String
        p = 5

        For n = 1 To 5
            Console.WriteLine("")
            For i = 1 To n
                Console.Write("*")
            Next
        Next
        For i = 5 To 1 Step -1
            Console.WriteLine("")
            For n = 1 To i
                Console.Write("*")
            Next
        Next

        Console.ReadLine()

    End Sub
End Module
