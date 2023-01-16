Module ejercicio22
    Sub main()
        Dim opcion As Char

        Console.WriteLine("Qué apartado quieres? (a-d)")
        opcion = Char.Parse(Console.ReadLine)

        Select Case opcion
            Case "a"c

                For i = 7 To 1 Step -1


                    For a = 1 To i
                        Console.Write("*")

                    Next
                    Console.WriteLine("")

                Next
                Console.ReadLine()
            Case "b"c

                For i = 1 To 5
                    For a = 1 To i
                        Console.Write("*")

                    Next
                    Console.WriteLine("")
                Next
                Console.ReadLine()
            Case "c"c

                For d = 1 To 5 Step 1
                    Console.WriteLine()
                    For e = 1 To d
                        Console.Write("*")
                    Next
                Next
                For r = 4 To 1 Step -1
                    Console.WriteLine()
                    For t = 1 To r
                        Console.Write("*")
                    Next
                Next

            Case "d"c

                For p = 7 To 1 Step -1
                    Console.WriteLine()
                    For j = 1 To p
                        Console.Write(j)
                    Next
                Next
                Console.ReadLine()


        End Select
        Console.ReadLine()

    End Sub
End Module
