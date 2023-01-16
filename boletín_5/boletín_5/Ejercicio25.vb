Module Ejercicio25
    Sub main()

        Dim aleatorio As New Random
        Dim numn, nump, numc, x As Integer


        For i = 1 To 10 Step 1
            numn = 0
            nump = 0
            numc = 0
            Console.WriteLine(" ")

            For x = 1 To 10 Step 1
                Dim n As Integer = aleatorio.Next(-5, 5)
                Console.Write(n & " ")
                If n < 0 Then
                    numn += 1
                ElseIf n >= 0 Then
                    nump += 1
                End If

                If n < 2 And n > -2 Then
                    numc += 1
                End If

            Next
            x = Convert.ToInt32(numc / 10 * 100)
            Console.WriteLine(numc & " números comprendidos ")
            Console.WriteLine(nump & " números positivos ")
            Console.WriteLine(numn & " números negativos")
            Console.WriteLine(x)
        Next





        Console.ReadLine()

    End Sub
End Module
