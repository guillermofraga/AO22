﻿Module Module1

    Sub Main()

        Dim frase As String = "Me encanta programar"
        Dim letra As Char = frase(0)

        Console.WriteLine("La primera letra es: " & letra)
        Console.WriteLine("Código de: " & letra & " es: " & Convert.ToInt32(letra))


        'Un string es un array de caracteres --> Contar cuantas aes hay
        Dim contador As Integer
        For i = 0 To frase.Length - 1
            If frase(i) = "a"c Then
                contador += 1
            End If
        Next

        'Aprender a procesar formatos de String
        'Funciones de la variable char
        'Char.isDigit(), Char.isletter()

        Dim c1 As Boolean = Char.IsDigit(letra)
        Dim c2 As Boolean = Char.IsLetter(letra)
        Dim c3 As Boolean = Char.IsLower(letra)
        Dim c4 As Boolean = Char.IsUpper(letra)
        Dim letraMinuscula As Char = Char.ToLower(letra)


        'Funciones de la clase String

        '.Lenght --> Devuelve el número total de caracteres
        Dim numerocaracter As Integer = frase.Length

        '.StartsWith(cadena) y .endsWith(cadena)
        Dim c5 As Boolean = frase.StartsWith("Ho")
        Dim c6 As Boolean = frase.EndsWith(".")

        '.contains(cadena) --> Busca cadena y devuelve true si aparece
        Dim c7 As Boolean = frase.Contains("Ho")

        '.indexOf(cadena) --> Devuelve la posición de cadena
        Dim posicion As Integer = frase.IndexOf(" ")

        '.lastindexOn(cadena) --> Devuelve la última aparición de cadena
        Dim ultimaposicion As Integer = frase.LastIndexOf(" ")

        'indexofany(char1,char2,...) --> Busca la primera aparición de cualquiera de los caracteres que se le pasa como parámetro
        Dim caracteres() As Char = {"a"c, "e"c, "i"c, "o"c, "u"c}
        Dim posicion2 As Integer = frase.IndexOfAny(caracteres)

        'substring(indice) --> Devuelve el string formado por los caracteres que hay a partir de ese índice

        Dim frase2 As String = "Me gustan los debates en clase de 1º de GMI.Sobre todo cuando hay polémica"
        Dim subfrase As String = frase2.Substring(3)
        Console.WriteLine("*********Ejemplo substring : ************")
        Console.WriteLine(subfrase)

        Dim subfrase2 As String = frase2.Substring(0, 5)
        Console.WriteLine(subfrase2)

        'split(string) --> Trocea el string original utilizando como separador el string pasado como argumento
        'Devuelve una matriz con los substring generados.

        Dim palabras() As String = frase2.Split(" "c, "."c)

        Console.WriteLine("***************Método Split()*********************")

        'Mostrar la matriz palabras
        For Each palabra In palabras
            Console.Write(palabra & " / ")
        Next

        'Cuantas palabras hay en un String?

        Dim numeropalabras As Integer = frase2.Split(" "c).Length


        Console.ReadLine()

    End Sub

End Module
