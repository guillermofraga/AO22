Module Ejercicio16
    Sub main()

        Dim n As Integer

        Console.WriteLine("introduzca un numero")
        n = Convert.ToInt32(Console.ReadLine)
        Console.WriteLine("")
        For i = 1 To n
            If i Mod 3 = 0 Then
                Console.Write(i & ", ")
            End If
        Next

        Console.ReadLine()



    End Sub
End Module
