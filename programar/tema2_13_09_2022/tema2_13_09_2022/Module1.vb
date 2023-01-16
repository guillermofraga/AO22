Module Module1

    Sub Main()
        '***********zona de declaración de variables***********
        'reservamos memoria para nuestro programa
        Dim b1 As Byte
        Dim i1 As Integer = 150 'declaración e inicialización
        Dim l1 As Long
        l1 = 450000000

        Dim s1 As Single = 4.56
        Dim d1 As Double


        '******************************************************

        Console.WriteLine("b1=" & b1)
        'visualizar máximo valor que almacena el tipo byte
        Console.WriteLine("máximo valor de byte : " & Byte.MaxValue)
        Console.WriteLine("minimo valor de byte : " & Byte.MinValue)

        Console.WriteLine("s1=" & s1)

        'modificar valores de variable
        b1 = 90
        'b1= b1 + 1
        i1 = i1 + 10
        s1 = 5.88888859
        Console.WriteLine("s1=" & s1)


        Console.ReadLine()
    End Sub

End Module
