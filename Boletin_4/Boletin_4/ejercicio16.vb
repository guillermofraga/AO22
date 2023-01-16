Module ejercicio16
    Sub main()

        Dim año As Double

        Console.WriteLine("Introduzca el año:")
        año = Convert.ToDouble(Console.ReadLine())

        If año Mod 4 = 0 And año Mod 100 = 0 And año Mod 400 = 0 Then
            Console.WriteLine("el año " & año & " es bisiesto")
        ElseIf año Mod 4 = 0 And año Mod 100 <> 0 Then
            Console.WriteLine("el año " & año & " es bisiesto")
        Else
            Console.WriteLine("el año " & año & " no es bisiesto")
        End If

        Console.ReadLine()



    End Sub
End Module
