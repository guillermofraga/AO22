Module Module1

    Sub Main()
        'lectura por teclado
        'funciones: console.readline , inputbox

        'programa que pide el usuario: DNI, Edad, Salario, Teléfono

        Dim dni As String
        Dim edad As Byte
        Dim salario As Single
        Dim telefono As String

        Console.Write("introduzca el dni: ")
        dni = Console.ReadLine()

        Console.WriteLine("introduzca la edad: ")
        edad = Convert.ToByte(Console.ReadLine())
        'que error es este

        Console.WriteLine("introduzca su salario: ")
        salario = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("introduzca su teléfono: ")
        telefono = Console.ReadLine

        Console.WriteLine("Sus datos han sido guardados con éxito! Pulse Enter para salir.")
        Console.ReadLine()


    End Sub

End Module
