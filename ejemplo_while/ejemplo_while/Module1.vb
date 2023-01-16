Module Module1

    Sub Main()
        'suma de los primeros N numeros
        Dim i, suma As Integer
        i = 0
        suma = 0


        While (i <= 100)
            suma = suma + i 'o suma +=1
            i = i + 1
        End While


        Console.WriteLine("La suma es: " & suma)
        Console.ReadLine()

    End Sub

End Module
