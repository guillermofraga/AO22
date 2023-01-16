Module ejemploconversionimplícitas

    Sub main()
        'conversiones implícitas son aquellas que se preoducen automáticamente sin que el programador tenga que escribir ningún código a mayores
        'suelen darse cuando asignamos a una variable de mayor tamaño,el valor almacenado en una variable de menor tamaño.
        Dim x1 As Byte = 90
        Dim x2 As Short = x1 'esta operación siempre es segura
        'x1 = x2 esta operación no está permitida porque no es segura

        Dim s1 As Single = 9.45
        Dim d1 As Double = s1

        'Dim d2 As Single = d1 'esta operación no está permitida porque no es segura

    End Sub

End Module
