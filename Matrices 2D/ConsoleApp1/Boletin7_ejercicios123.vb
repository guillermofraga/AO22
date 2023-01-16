Module Boletin7_ejercicios123
    Sub main()

        Dim opcion As Integer
        Do
            Console.WriteLine("Escoja un Ejercicio:")
            Console.WriteLine("10 para salir.")
            opcion = Convert.ToInt32(Console.ReadLine())


            Select Case opcion
                Case 1
                    Dim matriz(,) As Integer = {{3, 4, 1}, {9, 8, 1}, {5, 2, 1}}
                    Dim fila As Integer
                    Console.WriteLine("Escoja una fila:")
                    fila = Convert.ToInt32(Console.ReadLine())


                    Console.WriteLine("Valores fila indice:" & fila)
                    For i = 0 To matriz.GetUpperBound(1)
                        Console.Write(matriz(fila, i) & " ")
                    Next
                    Console.WriteLine(" ")
                    Console.WriteLine("Pulse Enter para continuar")




                    For a = 0 To matriz.GetUpperBound(0)
                        matriz(a, matriz.GetUpperBound(1)) = 0
                        For h = 0 To matriz.GetUpperBound(1)
                            Console.Write(matriz(a, h))
                        Next
                    Next

                    Dim suma As Integer = 0

                    For l = 0 To matriz.GetUpperBound(1)
                        suma += matriz(0, l)
                    Next

                    Dim contador As Integer = 0

                    For ñ = 0 To matriz.GetUpperBound(0)
                        If matriz(ñ, 1) = 0 Then
                            contador += 1
                        End If
                    Next

                    Console.WriteLine("Hay: " & contador & " ceros.")


                    Console.ReadLine()
                Case 2


            End Select


        Loop While opcion < 10




    End Sub
End Module
