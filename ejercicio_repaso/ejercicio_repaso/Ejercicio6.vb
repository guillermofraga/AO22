Module Ejercicio6
    Sub main()

        Dim n, p As Integer
        Dim espacio As String
        p = 10

        Console.WriteLine("A")
        Console.WriteLine("")
        For n = 1 To 10

            For a = 1 To n
                Console.Write("*")



            Next
            Console.WriteLine("")

        Next

        Console.WriteLine("")
        Console.WriteLine("B")
        Console.WriteLine("")

        For n = 10 To 1 Step -1

            For a = 1 To n
                Console.Write("*")



            Next
            Console.WriteLine("")

        Next


        Console.WriteLine("")
        Console.WriteLine("C")
        Console.WriteLine("")

        For n = 10 To 1 Step -1

            For a = 1 To p
                Console.Write("*")


            Next
            Console.WriteLine("")
            espacio = espacio + " "
            Console.Write(espacio)
            p = p - 1
        Next

        Console.WriteLine("")
        Console.WriteLine("D")
        Console.WriteLine("")

        For n = 1 To 10

            For a = 1 To n
                Console.Write("*")



            Next


        Next



        Console.ReadLine()


    End Sub
End Module
