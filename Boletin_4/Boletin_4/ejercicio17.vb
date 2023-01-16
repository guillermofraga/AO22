Module ejercicio17
    Sub main()

        Dim n1, n2, n3 As Double

        Console.WriteLine("Introduzca n1:")
        n1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca n2:")
        n2 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca n3:")
        n3 = Convert.ToDouble(Console.ReadLine())


        If n1 < n2 And n1 < n3 And n2 < n3 Then
            Console.WriteLine(n1 & " / " & n2 & " / " & n3)
        ElseIf n2 < n1 And n2 < n3 And n1 < n3 Then
            Console.WriteLine(n2 & " / " & n1 & " / " & n3)
        ElseIf n3 < n1 And n3 < n2 And n1 < n2 Then
            Console.WriteLine(n3 & " / " & n1 & " / " & n2)
        ElseIf n1 > n2 And n1 > n3 And n2 > n3 Then
            Console.WriteLine(n3 & " / " & n2 & " / " & n1)
        ElseIf n2 > n1 And n2 > n3 And n1 > n3 Then
            Console.WriteLine(n3 & " / " & n1 & " / " & n2)
        ElseIf n3 > n1 And n3 > n2 And n1 > n2 Then
            Console.WriteLine(n2 & " / " & n1 & " / " & n3)
        End If

        Console.ReadLine()


    End Sub
End Module
