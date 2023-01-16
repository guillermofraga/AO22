Module ejercicio17
    Sub main()

        Dim n As Double

        Console.WriteLine("Introduzca un numero para saber sus divisores")
        n = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("")

        For i = 1 To n
            If n Mod i = 0 Then
                Console.Write(i & ",")
            End If
        Next

        Console.ReadLine()

    End Sub
End Module
