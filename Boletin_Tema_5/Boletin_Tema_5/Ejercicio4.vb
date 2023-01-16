Module Ejercicio4
    Sub main()

        Dim array(4) As String


        For i = 0 To 4
            Console.WriteLine("Introduzca los 5 mejores libros:")
            array(i) = Console.ReadLine()
        Next

        For a = 0 To 4
            Console.WriteLine(array(a))
        Next

        Console.ReadLine()



    End Sub
End Module
