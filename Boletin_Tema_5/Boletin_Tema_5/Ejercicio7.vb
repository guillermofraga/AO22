Module Ejercicio7
    Sub main()

        Dim contador As Integer


        Console.WriteLine("Introduzca un valor:")
        contador = Convert.ToInt32(Console.ReadLine())

        Dim array(contador - 1) As Integer

        array(0) = 0
        array(contador - 1) = contador

        Console.WriteLine(array(0) & " " & array(contador - 1))

        Console.ReadLine()

    End Sub
End Module
