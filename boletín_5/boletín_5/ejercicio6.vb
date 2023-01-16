Module ejercicio6
    Sub main()

        Dim numero As Integer


        For numero = 1 To 100
            If numero Mod 5 = 0 And numero Mod 7 = 0 Then
                Console.WriteLine(numero)
                Console.WriteLine("multiplo de 5 y 7")
            Else

            End If

        Next


        Console.ReadLine()


    End Sub
End Module
