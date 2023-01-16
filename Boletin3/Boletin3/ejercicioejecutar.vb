Module ejercicioejecutar
    Sub main()

        'Entrada
        Dim ejercicio As Integer

        Do
            Console.WriteLine("Escoje el ejercicio del boletín 3: 4 - 12")
            Console.WriteLine("pulsa 1 para salir del programa")
            ejercicio = Convert.ToInt32(Console.ReadLine())
            If ejercicio <> 1 Then

            End If
            If ejercicio = 4 Then
                'Resolver el ejercicio 4: Cálculo del menor de 4 variables
                Dim a, b, c, d, menor As Integer
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("Programa que calcula el menor de 4 números.")
                Console.ForegroundColor = ConsoleColor.White

                Console.WriteLine("introduzce un número: ")
                a = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine("introduzce un número: ")
                b = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine("introduzce un número: ")
                c = Convert.ToInt32(Console.ReadLine())
                Console.WriteLine("introduzce un número: ")
                d = Convert.ToInt32(Console.ReadLine())

                Console.WriteLine("el menor es : " & menor)

                If a > b Then
                    menor = b
                Else
                    menor = a
                End If

                If c < menor Then
                    menor = c
                End If

                If d < menor Then
                    menor = d
                End If

                Console.WriteLine("el menor es : " & menor)

            ElseIf ejercicio = 5 Then
                'Variable local al ejercicio 5
                Dim numero As Integer
                Console.WriteLine("introduzce un número: ")
                numero = Convert.ToInt32(Console.ReadLine())

                If numero Mod 2 = 0 Then
                    Console.WriteLine("par")
                    Console.ReadLine()
                Else
                    Console.WriteLine("impar")
                    Console.ReadLine()
                End If

            ElseIf ejercicio = 6 Then
                'Calcular la media de 3 valores
                Dim nota1, nota2, nota3, media As Single
                Console.WriteLine("intro nota1:")
                nota1 = Convert.ToSingle(Console.ReadLine())
                Console.WriteLine("intro nota2:")
                nota2 = Convert.ToSingle(Console.ReadLine())
                Console.WriteLine("intro nota3:")
                nota3 = Convert.ToSingle(Console.ReadLine())

                media = (nota1 + nota2 + nota3) / 3

                If media >= 5 Then
                    Console.WriteLine("aprobado")
                    Console.ReadLine()
                Else
                    Console.WriteLine("suspenso")
                    Console.ReadLine()
                End If

            ElseIf ejercicio = 7 Then

            End If

        Loop While ejercicio <> 1

        Console.ReadLine()

    End Sub
End Module
