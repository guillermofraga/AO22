Module ejercicio20
    Sub main()

        Dim a, b, suma As Integer

        Console.WriteLine("Introduze numero:")
        a = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduzca factor de numeros:")
        b = Convert.ToInt32(Console.ReadLine())

        For i = 1 To b
            suma = a * i
            Console.WriteLine(a & " x " & i & " = " & suma)
        Next


        Console.ReadLine()


    End Sub
End Module
