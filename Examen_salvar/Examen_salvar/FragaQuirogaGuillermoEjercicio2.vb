Module FragaQuirogaGuillermoEjercicio2
    Sub main()

        Dim n, m As Double

        n = 10


        For i = 1 To n
            For a = 1 To n
                m = i * a
                Console.WriteLine(i & " x " & a & " = " & m)
            Next
            Console.WriteLine("------------------")
        Next


        Console.ReadLine()

    End Sub
End Module
