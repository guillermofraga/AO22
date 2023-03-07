Imports System.IO
Module Module1

    Sub Main()

        Dim selecion As Integer

        Console.WriteLine("Introduzca el numero del ejercicio del 1 - 13:")
        selecion = Convert.ToInt32(Console.ReadLine())



        Select Case selecion
            Case 1

                Dim lista1 As ArrayList = New ArrayList(10)
                Dim lista2 As ArrayList = New ArrayList(10)
                Dim aleat As New Random
                Dim posicion, numero, numdel, contador As Integer

                Console.WriteLine("La capacidad de la lista es: " & lista1.Capacity)

                Console.WriteLine("Número de elementos almacenado realmente:" & lista1.Count)

                For i = 0 To lista1.Capacity - 1
                    lista1.Add(aleat.Next(1, 51))
                Next

                Console.WriteLine("La capacidad de la lista es: " & lista1.Capacity)

                Console.WriteLine("Número de elementos almacenado realmente:" & lista1.Count)

                For Each num In lista1
                    Console.WriteLine(num)
                Next

                Console.WriteLine("Introduzca el número a buscar:")
                posicion = Convert.ToInt32(Console.ReadLine())

                Console.WriteLine(lista1.IndexOf(posicion))

                Console.WriteLine("Introduzca el número para saber si esta en la lista:")
                numero = Convert.ToInt32(Console.ReadLine())

                If lista1.Contains(numero) Then
                    Console.WriteLine("El valor está en la lista")
                End If


                Console.WriteLine("Introduzca el número a elimiar:")
                numdel = Convert.ToInt32(Console.ReadLine())

                While lista1.Contains(numdel)
                    lista1.Remove(numdel)
                End While

                If lista1.Contains(numdel) = False Then
                    Console.WriteLine("Número borrado")
                    Console.WriteLine("")
                    For Each num In lista1
                        Console.WriteLine(num)
                    Next
                End If

                '1º manera de hacer una copia
                Dim lista3 As ArrayList = New ArrayList(lista1)


                '2º manera de hacer una copia
                For i = 0 To lista1.Count - 1
                    lista2.Add(lista1(i))
                Next

                For i = 0 To lista1.Count - 1
                    If lista1(i) Is lista2(i) Then
                        contador += 1
                    End If
                Next


                If lista1.Count = contador Then
                    Console.WriteLine("Copia guardada correctamente")
                End If

                lista1.Sort()
                Console.WriteLine("Lista ordenada:")
                For Each num In lista1
                    Console.WriteLine(num)
                Next


                Dim fichero As StreamWriter = New StreamWriter(Directory.GetCurrentDirectory() + "\lista.txt")

                For Each num In lista1
                    fichero.WriteLine(num)
                Next

                fichero.Close()

            Case 2

                Dim lista As ArrayList = New ArrayList(10)
                Dim aleat As New Random
                Dim num, posicion, numdel As Double

                For i = 0 To lista.Capacity - 1
                    lista.Add(aleat.NextDouble())
                    Console.WriteLine(lista(i))
                Next

                Console.WriteLine("Capacidad de la lista: " & lista.Capacity)

                Console.WriteLine("Número de elementos almacenados realmente: " & lista.Count)

                Console.WriteLine("Introduzca el número a buscar:")
                num = Convert.ToDouble(Console.ReadLine())

                Console.WriteLine(lista.IndexOf(num))

                Console.WriteLine("Introduzca el número para saber si está en la lista:")
                posicion = Convert.ToDouble(Console.ReadLine())

                If lista.Contains(posicion) Then
                    Console.WriteLine("El número está en la lista")
                End If

                Console.WriteLine("Introduzca el número que quieres borrar:")
                numdel = Convert.ToDouble(Console.ReadLine())

                lista.Remove(numdel)

                If lista.Contains(numdel) Then
                Else
                    Console.WriteLine("Número borrado")
                    For Each num In lista
                        Console.WriteLine(num)
                    Next
                End If


            Case 3

                Dim lista As ArrayList = New ArrayList(10)
                Dim aleat As New Random
                Dim max, min As Integer

                For i = 0 To lista.Capacity - 1
                    lista.Add(aleat.Next(1, 50))
                    Console.WriteLine(lista(i))
                Next

                max = Convert.ToInt32(lista(0))
                min = Convert.ToInt32(lista(0))

                For i = 0 To lista.Count - 1
                    If max < Convert.ToInt32(lista(i)) Then
                        max = Convert.ToInt32(lista(i))
                    End If
                Next

                For i = 0 To lista.Count - 1
                    If min > Convert.ToInt32(lista(i)) Then
                        min = Convert.ToInt32(lista(i))
                    End If
                Next

                Console.WriteLine("Número más pequeño: " & min)

                Console.WriteLine("Número más grande: " & max)

                'Otra manera

                lista.Sort()

                Console.Write("Número más pequeño: ")
                Console.WriteLine(lista(0))

                Console.Write("Número más pequeño: ")
                Console.WriteLine(lista(lista.Count - 1))


            Case 4

                Dim lista As ArrayList = New ArrayList(10)
                Dim maxs, mins As String
                Dim max, min As Integer
                max = 0
                min = 0

                lista.Add("casa")
                lista.Add("edificio")
                lista.Add("ascensor")
                lista.Add("camion")
                lista.Add("coche")
                lista.Add("horno")
                lista.Add("mesa")
                lista.Add("pan")
                lista.Add("mercado")
                lista.Add("esternocleidomastoideo")


                For Each palabra In lista
                    Console.Write(palabra.ToString().Length & " ")
                Next

                Console.WriteLine("")

                max = Convert.ToInt32(lista(0).ToString().Length)
                min = Convert.ToInt32(lista(0).ToString().Length)

                For i = 0 To lista.Count - 1
                    If max < lista(i).ToString().Length Then
                        maxs = lista(i).ToString()
                    End If
                Next

                For i = 0 To lista.Count - 1
                    If min > lista(i).ToString().Length Then
                        mins = lista(i).ToString()
                    End If
                Next

                Console.WriteLine("La palabra más larga es: " & maxs)

                Console.WriteLine("La palabra más corta es: " & mins)

            Case 5

                Dim edad As ArrayList = New ArrayList(10)
                Dim edadr, suma, promedio As Integer
                suma = 0
                promedio = 0

                For i = 0 To edad.Capacity - 1
                    Console.WriteLine("Introduzca su edada:")
                    edadr = Convert.ToInt32(Console.ReadLine())

                    edad.Add(edadr)
                Next

                For i = 0 To edad.Count - 1
                    suma += Convert.ToInt32(edad(i))
                Next

                promedio = edad.Count

                promedio = Convert.ToInt32(suma / promedio)

                Console.WriteLine("La edad media es: " & promedio)


            Case 6

                Dim numeros As ArrayList = New ArrayList(10)
                Dim aleat As New Random
                Dim suma As Integer = 0

                For i = 0 To numeros.Capacity - 1
                    numeros.Add(aleat.Next(1, 11))
                    Console.Write(numeros(i))
                    Console.Write(" ")
                Next

                Console.WriteLine("")

                For i = 0 To numeros.Count - 1
                    If Convert.ToInt32(numeros(i)) Mod 2 = 0 Then
                        suma += Convert.ToInt32(numeros(i))
                    End If
                Next

                Console.WriteLine("Suma de los números pares: " & suma)


            Case 7

                Dim lista As ArrayList = New ArrayList(10)

                lista.Add("joel")
                lista.Add("alexandre")
                lista.Add("manu")
                lista.Add("pablo")
                lista.Add("iago")
                lista.Add("hugo")
                lista.Add("bruno")
                lista.Add("sergio")
                lista.Add("boris")
                lista.Add("martin")

                lista.Sort()

                For i = 0 To lista.Count - 1
                    Console.WriteLine(lista(i))
                Next




            Case 8

                Dim lista As ArrayList = New ArrayList(10)
                Dim contador As Integer = 0


                lista.Add("casa")
                lista.Add("edificio")
                lista.Add("ascensor")
                lista.Add("camion")
                lista.Add("coche")
                lista.Add("horno")
                lista.Add("mesa")
                lista.Add("pan")
                lista.Add("mercado")
                lista.Add("esternocleidomastoideo")

                For i = 0 To lista.Count - 1
                    If lista(i).ToString().Length > 5 Then
                        Console.WriteLine(lista(i))
                        contador += 1
                    End If
                Next

                Console.WriteLine("Hay " & contador & " palabras que tienen más de 5 letras")


            Case 9

                Dim seleccion As String

                Do

                    Dim peliculas As ArrayList = New ArrayList()
                    Dim searchmovie, addmovie, deletemovie As String

                    For i = 0 To 2
                        Console.WriteLine("Introduzca una pelicula:")
                        addmovie = Console.ReadLine()
                        peliculas.Add(addmovie)
                    Next

                    For i = 0 To peliculas.Count - 1
                        Console.WriteLine(peliculas(i))
                    Next

                    Console.WriteLine("Introduzca la pelicula que desea saber si está en la lista:")
                    searchmovie = Console.ReadLine()

                    If peliculas.Contains(searchmovie) Then
                        Console.WriteLine("La pelicula está en la lista")
                    Else
                        Console.WriteLine("La pelicula no está en la lista")
                    End If

                    Console.WriteLine("")

                    Console.WriteLine("Introduzca la pelicula que desea agregar a la lista:")
                    addmovie = Console.ReadLine()

                    peliculas.Add(addmovie)

                    Console.WriteLine("")

                    Console.WriteLine("Cambios")

                    Console.WriteLine("")

                    For i = 0 To peliculas.Count - 1
                        Console.WriteLine(peliculas(i))
                    Next

                    Console.WriteLine("")

                    Console.WriteLine("Introduzca la pelicula que desea eliminar:")
                    deletemovie = Console.ReadLine()

                    peliculas.Remove(deletemovie)

                    Dim fichero As StreamWriter = New StreamWriter(Directory.GetCurrentDirectory() + "\peliculas.txt", True)

                    For i = 0 To peliculas.Count - 1
                        fichero.WriteLine(peliculas(i))
                    Next

                    fichero.Close()

                    Console.WriteLine("Seguir ejecutando S/N:")
                    seleccion = Console.ReadLine()

                Loop While seleccion = "s"c

            Case 10

                Dim lista2 As ArrayList = New ArrayList(15)
                Dim aleat As New Random
                Dim fichero As StreamReader = New StreamReader(Directory.GetCurrentDirectory() + "\lista.txt")

                While Not fichero.EndOfStream
                    lista2.Add(fichero.ReadLine())
                End While

                fichero.Close()

                For Each num In lista2
                    Console.WriteLine(num)
                Next

                For i = 0 To 4
                    lista2.Add(aleat.Next(100, 201))
                Next

                For Each num In lista2
                    Console.WriteLine(num)
                Next


            Case 11

                Dim lista As ArrayList = New ArrayList()
                Dim aleat As New Random
                Dim cont As Integer = 0
                Dim suma, suma20, contador As Integer
                Dim media, porcentaje As Double

                For i = 0 To 10
                    lista.Add(aleat.Next(1, 26))
                Next

                For i = 0 To lista.Count - 1
                    Console.WriteLine(lista(i))
                Next

                For i = 0 To lista.Count - 1
                    If Convert.ToInt32(lista(i)) = 2 Then
                        Console.WriteLine("El valor 2 esta en la posicion: " & i)
                        cont += 1
                    End If
                Next

                If cont = 0 Then
                    Console.WriteLine("El 2 no está en la lista")
                End If

                For i = 0 To lista.Count - 1
                    suma += Convert.ToInt32(lista(i))
                Next

                Console.WriteLine("La suma de los valores es: " & suma)

                media = suma / Convert.ToInt32(lista.Count)

                Console.WriteLine("La media de los valores generados es: " & media)

                For i = 0 To lista.Count - 1
                    If Convert.ToInt32(lista(i)) > 20 Then
                        suma20 += 1
                    End If
                Next

                porcentaje = (suma20 / Convert.ToInt32(lista.Count)) * 100

                Console.WriteLine("El porcentaje de los números superiores a 20 es: " & porcentaje)



                lista.Sort()

                Dim numeroanterior As Integer = 0

                For Each numeroacomparar In lista
                    If Convert.ToInt32(numeroacomparar) <> numeroanterior Then
                        Dim contador1 As Integer = 0
                        For Each numero As Integer In lista
                            If numero = Convert.ToInt32(numeroacomparar) And numero <> numeroanterior Then
                                contador1 += 1
                            End If
                        Next
                    End If
                    Console.WriteLine(numeroacomparar)
                    numeroanterior += 1
                Next



            Case 12

                Dim tarea As ArrayList = New ArrayList()
                Dim tareacompletada As ArrayList = New ArrayList()
                Dim seleccion As Integer

                Do

                    Console.WriteLine("Introduzca lo que quiere hacer: ")
                    Console.WriteLine("1. introducir tarea")
                    Console.WriteLine("2. completar tarea")
                    Console.WriteLine("3. contar tarea")
                    Console.WriteLine("4. mostrar tareas pendientes")
                    Console.WriteLine("5. mostrar tareas completadas")
                    Console.WriteLine("6. mostrar tareas cuya fecha de vencimiento es el dia de hoy")
                    Console.WriteLine("7. Mostrar tareas más urgentes (prioridad > 8)")
                    Console.WriteLine("8. salir")
                    seleccion = Convert.ToInt32(Console.ReadLine())

                    Select Case seleccion

                        Case 1

                            Dim addworkout As String

                            Console.WriteLine("Nota: La prioridad es un número entre 1 y 10 , siendo 10 muy urgente y 1 nada urgente")

                            Console.WriteLine("Introduzca la tarea con el siguiente formato Titulo*Prioridad*Fechavencimiento (mm-dd-yyyy):")
                            addworkout = Console.ReadLine()

                            tarea.Add(addworkout)

                        Case 2

                            Dim completedworkout As String

                            Console.WriteLine("Introduzca la tarea que desea marcar como completado con el siguiente formato Titulo*Prioridad*Fecha (dd/mm/yyyy):")
                            completedworkout = Console.ReadLine()

                            tareacompletada.Add(completedworkout)

                            tarea.Remove(completedworkout)

                        Case 3

                            Dim contador As Integer = 0

                            For i = 0 To tarea.Count - 1
                                contador += 1
                            Next

                            Console.WriteLine("hay " & contador & " tareas")

                        Case 4

                            For i = 0 To tarea.Count - 1
                                Console.WriteLine(tarea(i))
                            Next


                        Case 5

                            For i = 0 To tareacompletada.Count - 1
                                Console.WriteLine(tareacompletada(i))
                            Next

                        Case 6

                            For Each tareas In tarea
                                Dim array() As String = tareas.ToString.Split("*"c)

                                If array(2) = DateString Then
                                    Console.WriteLine("La tarea " & tareas.ToString & " vence hoy")
                                End If
                            Next

                        Case 7

                            For Each tareas In tarea
                                Dim array() As String = tareas.ToString.Split("*"c)

                                If Convert.ToInt32(array(1)) > 8 Then
                                    Console.WriteLine("La tarea " & tareas.ToString & " tiene prioridad mayor de 8")
                                End If
                            Next


                    End Select

                Loop While seleccion <> 8



            Case 13

                Dim seleccion As Integer
                Dim dni As ArrayList = New ArrayList()


                Do

                    Console.WriteLine("Introduzca lo que quiere hacer:")
                    Console.WriteLine("1. Guardar DNI")
                    Console.WriteLine("2. Eliminar DNI")
                    Console.WriteLine("3. Mostrar DNI")
                    Console.WriteLine("4. Contar DNI")
                    Console.WriteLine("5. salir")
                    seleccion = Convert.ToInt32(Console.ReadLine())


                    Select Case seleccion
                        Case 1

                            Dim adddni As String

                            Console.WriteLine("Introduzca su DNI:")
                            adddni = Console.ReadLine()

                            If dni.Contains(adddni) Then

                            Else
                                dni.Add(adddni)
                            End If


                        Case 2

                            Dim deletedni As String

                            Console.WriteLine("Introduzca el DNI que quiere eliminar:")
                            deletedni = Console.ReadLine()

                            dni.Remove(deletedni)


                        Case 3

                            For Each d In dni
                                Console.WriteLine(d)
                            Next

                        Case 4

                            Dim contador As Integer = 0

                            For i = 0 To dni.Count - 1
                                contador += 1
                            Next

                            Console.WriteLine("Hay " & contador & " dnis")


                    End Select




                Loop While seleccion <> 5

        End Select




        Console.ReadLine()


    End Sub

End Module
