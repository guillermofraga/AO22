Module ejemploconversionExplicitas
    Sub main()
        'se producen cuando queremos asignar el valor de una variable en una variable de menor capacida o precisión

        Dim numero As Integer = 9
        Dim raiz As Integer = Convert.ToInt32(Math.Sqrt(numero))

        Dim b As Byte = 90
        Dim c As Byte = Convert.ToByte(b)


    End Sub
End Module
