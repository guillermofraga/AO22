Module ejercicio7
    Sub main()

        Dim numero As Integer

        Console.WriteLine("introduce un numero del 1 al 10")
        numero = Convert.ToInt32(Console.ReadLine())


        For i = 1 To 10
            Dim multiplo As Integer

            multiplo = numero * i
            Console.WriteLine(numero & " x " & i & " = " & multiplo)
        Next

        Console.ReadLine()

    End Sub
End Module
