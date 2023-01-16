Module ejerciciopruebas7
    Sub main()
        'Entrada
        Dim num1, num2, suma As Double

        Do

            Try
                Console.WriteLine("introduzca num1: ")
                num1 = Convert.ToDouble(Console.ReadLine())

                Console.WriteLine("introduzca num2: ")
                num2 = Convert.ToDouble(Console.ReadLine())

                suma = Math.Sqrt(num1 + num2)

                If suma = suma Then ' o suma >= 0
                    Console.WriteLine("raiz=" & suma)
                Else
                    Console.WriteLine("no se puede calcular la raiz")
                End If

                Console.ReadLine()

            Catch ex As Exception
                Console.WriteLine("Error en los datos introducidos.")
                Console.ReadLine()
            End Try
        Loop




    End Sub
End Module
