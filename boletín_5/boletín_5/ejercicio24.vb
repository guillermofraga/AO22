Module ejercicio24
    Sub main()

        Dim n, divisores As Integer

        Console.WriteLine("introduzca un numero")
        n = Convert.ToInt32(Console.ReadLine())

        For i = 1 To n
            divisores = 0
            For a = 1 To i
                If i Mod a = 0 Then
                    divisores += 1
                End If
            Next
            If divisores = 2 Then
                Console.WriteLine(i & ",")
            End If
        Next

        Console.ReadLine()

    End Sub
End Module
