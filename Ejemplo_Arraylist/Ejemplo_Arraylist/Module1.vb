Module Module1
    Sub Main()

        'Creamos un Arraylist con los diferentes elementos que queremos introducir

        Dim nombrespresidentes(3) As String

        nombrespresidentes(0) = "Gerard Piqué"
        nombrespresidentes(1) = "Spursito"
        nombrespresidentes(2) = "Xbuyer"
        nombrespresidentes(3) = "Iker Casillas"

        Dim jugadores As ArrayList = New ArrayList()
        Dim arbitros As ArrayList = New ArrayList(4)
        Dim presidentes As ArrayList = New ArrayList(nombrespresidentes)

        'Agregamos un jugador
        jugadores.Add("Ronaldinho")
        jugadores.Add("Gabri Veiga")
        jugadores.Add("Alvaro Rodriguez")

        'Borrar un jugador segun su indice
        jugadores.RemoveAt(2)

        'Borrar un jugador segun su valor
        presidentes.Remove("Xbuyer")

        'Comprobar si un elemento esta dentro de una lista
        Dim estacontenido As Boolean
        estacontenido = jugadores.Contains("Ronaldinho")

        'Comprobamos la cantidad de presidentes que hay
        Console.WriteLine("Tenemos " & presidentes.Count & " Presidentes")

        'Saber el indice de un elemento

        Console.WriteLine("El indice de Alvaro Rodriguez es: " & jugadores.IndexOf("Alvaro Rodriguez"))

        'Añadimos a un posible Bd0
        jugadores.Insert(0, "Vini Jr.")

        'Anadir a Cristiano antes de Gabri Veiga y a messi despues
        Dim posicion As Integer
        posicion = jugadores.IndexOf("Gabri Veiga")
        jugadores.Insert(posicion, "Cristiano Ronaldo")
        jugadores.Insert(posicion + 2, "Leo Messi")

        'Quiero obtener el jugador en la ultima posicion
        Dim ultimojugador As String

        ultimojugador = Convert.ToString(jugadores.Item(jugadores.Count - 1))

        Console.WriteLine("El ultimo jugador de la lista es: " & ultimojugador)

        'Quiero obtener el array
        jugadores.Sort()



        'Mostramos por pantalla

        Console.WriteLine("Los jugadores de mi equipo son:")

        For Each jugador In jugadores
            Console.WriteLine(jugador)
        Next

        Console.WriteLine("Los arbitros de la liga son:")

        For Each arbitro In arbitros
            Console.WriteLine(arbitro)
        Next

        Console.WriteLine("Los presidentes de la liga son:")

        For Each presidente In presidentes
            Console.WriteLine(presidente)
        Next
        '



        Console.ReadLine()
    End Sub

End Module
