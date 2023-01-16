Module ejercicio8
    Sub main()

        Dim numero, ne As Integer

        Console.WriteLine("introduzca un numero")
        numero = Convert.ToInt32(Console.ReadLine())

        ne = numero + 5

        While numero <= ne

            Console.WriteLine("Numero: " & numero & " , Cuadrado: " & Math.Pow(numero, 2) & numero & " , Cubo: " & Math.Pow(numero, 3))
            numero += 1

        End While


        Console.ReadLine()


    End Sub
End Module
