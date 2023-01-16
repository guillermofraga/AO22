Module ejercicio5
    Sub main()

        Dim nota As Double

        Console.WriteLine("intro nota:")
        nota = Convert.ToDouble(Console.ReadLine())

        If nota < 0 Or nota > 10 Then
            Console.WriteLine("Error en la nota")
        ElseIf nota < 5 Then
            Console.WriteLine("suspenso")
        ElseIf nota >= 5 And nota <= 6.5 Then
            Console.WriteLine("aprobado")
        ElseIf nota >= 6.5 And nota <= 8.5 Then
            Console.WriteLine("notable")
        ElseIf nota >= 8.5 And nota <= 10 Then
            Console.WriteLine("sobresaliente")

        End If



        Console.ReadLine()


    End Sub
End Module
