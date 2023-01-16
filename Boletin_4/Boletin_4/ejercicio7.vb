Module ejercicio7
    Sub main()

        Dim t As Single

        Console.WriteLine("introduzca la temperatura:")
        t = Convert.ToSingle(Console.ReadLine())

        If t < 0 Then
            Console.WriteLine("Sólido")
        ElseIf t > 0 And t <= 100 Then
            Console.WriteLine("Líquido")
        ElseIf t > 100 And t < 1000000 Then
            Console.WriteLine("Vapor")
        ElseIf t >= 1000000 Then
            Console.WriteLine("Plasma")

        End If



        Console.ReadLine()



    End Sub
End Module
