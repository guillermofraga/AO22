Module FragaQuirogaGuillermo

    Sub Main()

        Dim seleccion As String
        Dim lista As New ArrayList()

        Do

            Console.WriteLine("")
            Console.WriteLine("Introduzca lo que quiere hacer:")
            Console.WriteLine("a. Rellena el array con números aleatorios negativos y positivos")
            Console.WriteLine("b. Mostrar la suma de los números")
            Console.WriteLine("c. Mostrar el promedio de los números")
            Console.WriteLine("d. Mostrar el número menor y mayor")
            Console.WriteLine("e. Muestra por pantalla la cantidad de números primos que hay en el ArrayList")
            Console.WriteLine("f. Cuenta cuántos números hay por encima del promedio del ArrayList")
            Console.WriteLine("g. Sustituye todos los números negativos por el mismo número en positivo.
Por ejemplo: El -2 lo sustituiría por el 2.")
            Console.WriteLine("h. Muestra por pantalla la posición del último número impar del ArrayList")
            Console.WriteLine("i. Muestra por pantalla la cantidad de veces que aparece cada número,
ordenado de menor a mayor.")
            Console.WriteLine("j. salir")
            Console.WriteLine("")
            seleccion = Console.ReadLine()


            Select Case seleccion
                Case "a"c, "A"c

                    Dim numadd As Integer
                    Dim aleat As New Random


                    Console.WriteLine("Introduzca cuantos numeros aleatorios quieres almacenar")
                    numadd = Convert.ToInt32(Console.ReadLine())

                    numadd -= 1

                    For i = 0 To numadd
                        lista.Add(aleat.Next(-10, 11))
                    Next

                    Console.WriteLine("")

                    For Each num In lista
                        Console.WriteLine(num)
                    Next


                Case "b"c, "B"c

                    Dim suma As Double
                    suma = 0

                    For Each num In lista
                        suma += Convert.ToDouble(num)
                    Next

                    Console.WriteLine("suma de todos los números: " & suma)


                Case "c"c, "C"c

                    Dim promedio, suma As Double
                    promedio = 0
                    suma = 0

                    For Each num In lista
                        suma += Convert.ToDouble(num)
                    Next

                    promedio = suma / lista.Count

                    Console.WriteLine("El promedio de los números es: " & promedio)


                Case "d"c, "D"c

                    Dim menor, mayor As Integer

                    mayor = Convert.ToInt32(lista(0))
                    menor = Convert.ToInt32(lista(0))


                    For i = 0 To lista.Count - 1
                        If mayor < Convert.ToInt32(lista(i)) Then
                            mayor = Convert.ToInt32(lista(i))
                        End If
                    Next


                    For i = 0 To lista.Count - 1
                        If menor > Convert.ToInt32(lista(i)) Then
                            menor = Convert.ToInt32(lista(i))
                        End If
                    Next

                    Console.WriteLine("El número más grande es: " & mayor)
                    Console.WriteLine("El número más pequeño es: " & menor)


                Case "e"c, "E"c

                    Dim contador As Integer = 0

                    For i = 0 To lista.Count - 1
                        For a = 1 To lista.Count - 1
                            If Convert.ToInt32(lista(i)) Mod a = 0 Then
                                contador += 1
                            End If
                        Next
                        If contador <= 2 Then
                            Console.WriteLine("El número: " & Convert.ToInt32(lista(i)) & " es primo")
                        End If
                        contador = 0
                    Next


                Case "f"c, "F"c

                    Dim promedio, suma As Double
                    promedio = 0
                    suma = 0

                    For Each num In lista
                        suma += Convert.ToDouble(num)
                    Next

                    promedio = suma / lista.Count

                    For i = 0 To lista.Count - 1
                        If Convert.ToInt32(lista(i)) > promedio Then
                            Console.WriteLine("El número: " & Convert.ToInt32(lista(i)) & " esta por encima del promedio")
                        End If
                    Next


                Case "g"c, "G"c

                    Dim num As Double

                    For i = 0 To lista.Count - 1
                        If Convert.ToInt32(lista(i)) < 0 Then
                            num = Convert.ToInt32(lista(i))
                            num = num * -1
                            lista(i) = num
                        End If
                    Next

                    For i = 0 To lista.Count - 1
                        Console.WriteLine(lista(i))
                    Next


                Case "h"c, "H"c


                    For i = 0 To lista.Count - 1
                        If Convert.ToInt32(lista(i)) Mod 2 <> 0 Then

                        End If
                    Next


                Case "i"c, "I"c

                    Dim contador As Integer = 0

                    lista.Sort()

                    For i = 0 To lista.Count - 1
                        For a = 0 To lista.Count - 1
                            If Convert.ToInt32(lista(i)) = Convert.ToInt32(lista(a)) Then
                                contador += 1
                            End If

                        Next
                        Console.WriteLine("El número: " & Convert.ToInt32(lista(i)) & " se repite " & contador)
                        contador = 0
                    Next


















            End Select

        Loop While seleccion <> "j"c



        Console.ReadLine()

    End Sub

End Module
