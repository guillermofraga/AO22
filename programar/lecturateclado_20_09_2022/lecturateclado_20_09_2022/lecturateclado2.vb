Module lecturateclado2
    Sub main()
        Dim dni As String
        Dim edad As Integer

        dni = InputBox("introduce el DNI: ")
        edad = Convert.ToInt32(InputBox("introduzca la edad: "))

        Console.WriteLine("sus datos han sido guardados con éxito! pulse enter para salir.")
        Console.ReadLine()


    End Sub
End Module
