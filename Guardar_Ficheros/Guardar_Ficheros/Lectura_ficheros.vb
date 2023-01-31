Imports System.IO
Module Lectura_ficheros
    Sub main()

        'Para leer de un fichero:
        '1º --> creamos variables Streamreader (Es necesario que el fichero exista)
        Dim lector As New StreamReader(Globals.ruta)
        '2º --> crear la matriz en la que volcaremos los datos
        Dim productos(99) As String

        '3º --> ir recorriendo los registros y volcarlos en las posiciones de la matriz
        Dim posicion As Integer = 0
        While Not lector.EndOfStream
            productos(posicion) = lector.ReadLine()
            posicion += 1
        End While

        '4º --> Cerrar el lector

        'Mostramos los datos de la matriz

        Console.WriteLine("Productos en tienda: ")

        For Each producto As String In productos
            If producto Is Nothing Then
                Exit For
            End If
            Console.WriteLine(producto)
        Next


        Console.ReadLine()

    End Sub
End Module
