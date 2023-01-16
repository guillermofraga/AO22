Module Module1

    Sub Main()
        'con option stict off, visual realiza conversiones de tipo sin 
        'byte da valores entre 0 y 255

        Dim numero As Integer = Convert.ToInt32(4.567)
        Console.WriteLine("numero " & numero)

        Dim x As Byte = 90
        Dim y As Integer = 509

        x = Convert.ToByte(y)

        Console.WriteLine("x = " & x) 'overflowexception

        Dim n1 As Integer = 51
        Dim resultado As Integer = Convert.ToInt32(n1 / 7)

        Dim v As Byte = 10
        v = Convert.ToByte(v + 1)

        Console.ReadLine()
    End Sub

End Module
