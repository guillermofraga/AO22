﻿Module Module1

    Sub Main()

        'Programa que lee la altura y la edad de un niño, e indica si debe llevar protección, los niños están obligados a llevar
        'silla de proteccion si miden menos de 1,20 o su edad es menor que 8

        Dim edad As Byte
        Dim altura As Single
        Dim condicion As Boolean

        Console.WriteLine("Intro edad: ")
        edad = Convert.ToByte(Console.ReadLine())

        Console.WriteLine("intro altura: ")
        altura = Convert.ToSingle(Console.ReadLine())

        condicion = edad < 8 Or altura < 1.35

        If condicion Then

        End If

        If edad < 8 Or altura < 1.35 Then
            Console.WriteLine("debe de llevar silla de protección.")
        Else
            Console.WriteLine("No debe de llevar silla de protección.")
        End If

        Console.ReadLine()


    End Sub

End Module
