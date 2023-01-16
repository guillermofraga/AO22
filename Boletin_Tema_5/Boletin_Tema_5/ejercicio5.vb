Module ejercicio5
    Sub main()

        Dim array(3) As Short

        For i = 0 To 3
            Console.WriteLine("Introduzca un valor:")
            array(i) = Convert.ToInt16(Console.ReadLine())
        Next


        Console.ReadLine()

    End Sub
End Module
