Module Module1
    Sub Main()


        Dim seleccionar As Integer

        Console.WriteLine("Introduzca un número del 1 al 15 para seleccionar el ejercicio: ")
        seleccionar = Convert.ToInt32(Console.ReadLine())

        Select Case seleccionar
            Case 1

                Dim palabra As String = "hola"
                Dim letra As Char
                Dim contador As Integer

                Console.WriteLine("Introduzca el valor a buscar: ")
                letra = Convert.ToChar(Console.ReadLine())

                For i = 0 To palabra.Length - 1
                    If palabra(i) = letra Then
                        contador += 1
                    End If
                Next

                Console.WriteLine("EL valor que buscas aparece: " & contador & " veces")



            Case 2

                Dim DNI As String

                Console.WriteLine("Introduzca su DNI: ")
                DNI = Convert.ToString(Console.ReadLine())










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










            Case 14









            Case 15








        End Select


        Console.ReadLine()

    End Sub

End Module
