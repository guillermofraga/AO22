Module ejercicio3
    Sub main()


        Dim n1 As Double

        Console.WriteLine("introduzca un valor:")
        n1 = Convert.ToDouble(Console.ReadLine())


        'If n1 < 1999 Then
        'Console.WriteLine("valor= " & n1)
        'ElseIf n1 > 2000 And n1 < 2999 Then
        'n1 = n1 - (n1 * (10 / 100))
        'Console.WriteLine("valor= ")
        'End If



        n1 = n1 - (n1 * (25 / 100))

        Console.WriteLine(n1)
        Console.ReadLine()




    End Sub
End Module
