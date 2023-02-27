Module Module1

    Sub Main()

        Dim selecion As Integer

        Console.WriteLine("Introduzca el numero del ejercicio del 1 - 13:")
        selecion = Convert.ToInt32(Console.ReadLine())

        Select Case selecion
            Case 1

                Dim lista As ArrayList = New ArrayList(10)
                Dim aleat As New Random
                Dim posicion As Integer

                Console.WriteLine("La capacidad de la lista es: " & lista.Capacity)

                Console.WriteLine("Número de elementos almacenado realmente:" & lista.Count)

                For i = 0 To lista.Capacity - 1
                    lista.Add(aleat.Next(1, 51))
                Next

                Console.WriteLine("La capacidad de la lista es: " & lista.Capacity)

                Console.WriteLine("Número de elementos almacenado realmente:" & lista.Count)

                For Each num In lista
                    Console.WriteLine(num)
                Next

                Console.WriteLine("Introduzca el numero a buscar:")
                posicion = Convert.ToInt32(Console.ReadLine())

                Console.WriteLine(lista.IndexOf(posicion))


            Case 2




            Case 3





            Case 4





            Case 5






            Case 6




            Case 7





            Case 8




            Case 9





            Case 10




            Case 11





            Case 12




            Case 13






        End Select




        Console.ReadLine()


    End Sub

End Module
