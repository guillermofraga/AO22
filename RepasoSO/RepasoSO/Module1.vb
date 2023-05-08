Module Module1

    Sub Main()
        Console.WriteLine("")
        Console.WriteLine("***********************************  HORA DE ESTUDIAR COMANDOS SIUUUUU  ************************************")
        For x = 0 To 100


            Dim seleccion As Integer = 0

            Console.WriteLine("___________________________________________________________________________________________________________")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine("1) rpm")
            Console.WriteLine("")
            Console.WriteLine("2) dnf")
            Console.WriteLine("")
            Console.WriteLine("3) dpkg")
            Console.WriteLine("")
            Console.WriteLine("4) apt")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.Write("Seleccione con que comando quieres practicar: ")
            Console.ForegroundColor = ConsoleColor.Cyan
            seleccion = Convert.ToInt16(Console.ReadLine)
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Dim aleatorio As New Random
            Dim cumplido() As String = {"HUUU estas en modo hot uwu", "PEEERO BUEENOOOO TU QUIEN ERES?", "No seras Marck Sukember o si?", "HALA HALA, no te llamaran Albert Einstain no?",
                        "SOY TU FAAAN FIRMAME LAS T*T*S", "Que bendicion", "Ufff que suerte tuviste he", "Ojala fueras monte para darte machete 7w7",
                        "Ojala fuera granjero para sacarte la leche... Espera creo que asi no era ._.", "No es un avion, no es un pajaro, no es superman, eres tu que va volando uwu",
                        "Eres el puto amo", "Estas en tu prima... digo en tu prime ._."}
            Dim insulto() As String = {"Eres malisimo tio", "Eres un mierdas", "Vas a suspender fijo",
                        "MAAAADRE MIA vete preparando para la recuperacion chaval", "Pero tu estudiaste para el tema o como va la cosa?",
                        "La de estudiar no te la sabes verdad?", "No se si sabias que el profe subio algo que se le conoce como apuntes,averigua que es luego vuelve a intentar crack",
                        "Tu eres autista tio", "A ti te parieron o te cagaron?", "El chico mas estudioso de montecastelo JAJAJAJA", "Tienes un trauma infantil?",
                        "Are you gay?", "Mucho videojuego y poco linux he, muy mal", "mira ni te dire nada malo esta vez", "PAJUOOOOO"}
            Dim aleatorio_incorrecto, aleatorio_correcto As New Random
            Dim numaleatorio_incorrecto, numaleatorio_correcto As Integer
            numaleatorio_incorrecto = aleatorio_incorrecto.Next(0, insulto.Length)
            numaleatorio_correcto = aleatorio_correcto.Next(0, cumplido.Length)
            Select Case seleccion
                Case 1
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("***********************************************    rpm    *******************************************************")
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.White
                    Dim preguntas(16), respuestas(16) As String
                    Dim numaleatorio As Integer
                    Dim respuesta As String
                    preguntas(0) = "Comando para instalar un paquete (paquete.rpm)"
                    respuestas(0) = "rpm -i paquete.rpm"
                    preguntas(1) = "Comando para instalar un nuevo paquete o actualizar uno ya existente (paquete.rpm)"
                    respuestas(1) = "rpm -u paquete.rpm"
                    preguntas(2) = "Comando para actualizar un paquete solo si existe una version anterior (paquete.rpm)"
                    respuestas(2) = "rpm -F paquete.rpm"
                    preguntas(3) = "Comando para buscar un paquete (paquete.rpm)"
                    respuestas(3) = "rpm -q paquete.rpm"
                    preguntas(4) = "Compueba si estan presentes los ficheros de un paquete (paquete.rpm)"
                    respuestas(4) = "rpm -V paquete.rpm"
                    preguntas(5) = "Comando para eliminar un paquete (paquete.rpm)"
                    respuestas(5) = "rpm -e paquete.rpm"
                    preguntas(6) = "Comando para mostrar el proceso de instalacion de un paquete (paquete.rpm)"
                    respuestas(6) = "rpm -h paquete.rpm"
                    preguntas(7) = "Comando para actualizar un paquete hacia una version superior (paquete.rpm)"
                    respuestas(7) = "rpm -U paquete.rpm"
                    preguntas(8) = "Comando para ver informacion de un paquete (paquete.rpm)"
                    respuestas(8) = "rpm -qi paquete.rpm"
                    preguntas(9) = "Comando para ver todos los paquetes instalados en el sistema"
                    respuestas(9) = "rpm -qa"
                    preguntas(10) = "Comando para ver si hay un paquete instalado en el sistema (paquete.rpm) "
                    respuestas(10) = "rpm -qa | grep paquete.rpm"
                    preguntas(11) = "Comando para ver los requisitos para la instalacion de un paquete (paquete.rpm)"
                    respuestas(11) = "rpm -qR paquete.rpm"
                    preguntas(12) = "Comando para ver los archivos de un paquete (paquete.rpm)"
                    respuestas(12) = "rpm -ql paquete.rpm"
                    preguntas(13) = "Comando para ver la lista de dependencias de un paquete (paquete.rpm)"
                    respuestas(13) = "rpm -q --requires paquete.rpm"
                    preguntas(14) = "Comando para ver los ultimos paquetes instalados"
                    respuestas(14) = "rpm -qa --last"

                    numaleatorio = aleatorio.Next(0, 15)
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("Ejercicio: ")
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine(preguntas(numaleatorio))
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.Write("Escriba su respuesta: ")
                    Console.ForegroundColor = ConsoleColor.Cyan
                    respuesta = Console.ReadLine
                    Console.WriteLine()
                    Console.WriteLine()
                    If respuesta = respuestas(numaleatorio) Then
                        Console.ForegroundColor = ConsoleColor.Blue
                        Console.WriteLine("Respuesta CORRECTAA!!!. " & cumplido(numaleatorio_correcto))
                        Console.ForegroundColor = ConsoleColor.White
                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Respuesta INCORRECTAA!!!." & insulto(numaleatorio_incorrecto) & ". La respuesta correcta era " & respuestas(numaleatorio))
                        Console.ForegroundColor = ConsoleColor.White
                    End If

                Case 2
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("***********************************************    dnf    *******************************************************")
                    Console.ForegroundColor = ConsoleColor.White
                    Dim preguntas() As String = {"Comando para ver la lista de repositorios", "Comando para ver todos los repositorios habilitados o deshabilitados",
                        "Comando para instalar un paquete (paquete)", "Comando para desinstalar un paquete (paquete)", "Comando para actualizar un paquete (paquete)",
                        "Comando para verificar que paquetes tenemos que actualizar", "Comando para actualizar todos los paquetes del sistema",
                        "Comando para ver la lista de los grupos (grupo de entorno, grupo de instalados y grupo de disponibles)",
                        "Comando para instalar un grupo de software (grupo)", "Comando para ver toda la informacion relativa de un paquete (paquete)",
                        "Comando para ver todos los paquetes instalados", "Comando para ver la lista de los paquetes que estan disponibles para instalar",
                        "Comando para ver el paquete que esta relacionado con un programa (programa)", "Comando para eliminar los paquetes huerfanos",
                        "Comando para habilitar un repositorio (repositorio)", "Comando para deshabilitar un repositorio (repositorio)",
                        "Comando para añadir un repositoiro (URL_repositorio)", "Comando para buscar un paquete cuyo nombre contenga una palabra (busca un paquete que contenga, (palabra))"}
                    Dim respuestas() As String = {"dnf repolist", "dnf repolist all", "dnf install paquete", "dnf remove paquete",
                        "dnf upgrade paquete", "dnf check-upgrade", "dnf upgrade", "dnf grouplist", "dnf groupinstall grupo",
                        "dnf info paquete", "dnf list installed", "dnf list available", "dnf provides programa", "dnf autoremove",
                        "dnf config-manager --set-enabled repositorio", "dnf config-manager --set-disabled repositorio",
                        "dnf config-manager --add-repo URL_repositorio", "dnf search *palabra*"}

                    Dim numaleatorio As Integer
                    Dim respuesta As String
                    numaleatorio = aleatorio.Next(0, 18)
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("Ejercicio: ")
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine(preguntas(numaleatorio))
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.Write("Escriba su respuesta: ")
                    Console.ForegroundColor = ConsoleColor.Cyan
                    respuesta = Console.ReadLine
                    Console.WriteLine()
                    Console.WriteLine()
                    If respuesta = respuestas(numaleatorio) Then
                        Console.ForegroundColor = ConsoleColor.Blue
                        Console.WriteLine("Respuesta CORRECTAA!!!. " & cumplido(numaleatorio_correcto))
                        Console.ForegroundColor = ConsoleColor.White
                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Respuesta INCORRECTAA!!!." & insulto(numaleatorio_incorrecto) & ". La respuesta correcta era " & respuestas(numaleatorio))
                        Console.ForegroundColor = ConsoleColor.White
                    End If

                Case 3
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("***********************************************    dpkg    *******************************************************")
                    Console.ForegroundColor = ConsoleColor.White
                    Dim preguntas() As String = {"Comando para instalar un paquete (paquete.deb)",
                        "Comando para instalar todos los paquetes que se encuentren presentes en un directorio de manera recursiva (directorio)",
                        "Comando para suprimir un paquete SIN sus ficheros de configuracion (paquete)", "Comando para suprimir un paquete CON todos sus ficheros (paquete)",
                    "Comando para listar todos los paquetes Debian"}
                    Dim respuestas() As String = {"dpkg -i paquete.deb", "dpkg -R directorio", "dpkg -r paquete", "dpkg -P paquete",
                        "dpkg -l"}

                    Dim numaleatorio As Integer
                    Dim respuesta As String
                    numaleatorio = aleatorio.Next(0, preguntas.Length)
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("Ejercicio: ")
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine(preguntas(numaleatorio))
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.Write("Escriba su respuesta: ")
                    Console.ForegroundColor = ConsoleColor.Cyan
                    respuesta = Console.ReadLine
                    Console.WriteLine()
                    Console.WriteLine()
                    If respuesta = respuestas(numaleatorio) Then
                        Console.ForegroundColor = ConsoleColor.Blue
                        Console.WriteLine("Respuesta CORRECTAA!!!. " & cumplido(numaleatorio_correcto))
                        Console.ForegroundColor = ConsoleColor.White
                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Respuesta INCORRECTAA!!!." & insulto(numaleatorio_incorrecto) & ". La respuesta correcta era " & respuestas(numaleatorio))
                        Console.ForegroundColor = ConsoleColor.White
                    End If

                Case 4
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("***********************************************    apt    *******************************************************")
                    Console.ForegroundColor = ConsoleColor.White
                    Dim preguntas() As String = {"Comando para instalar paquetes (paquetes)", "Comando para desinstalar paquetes (paquetes)",
                        "Comando para eliminar paquetes con sus ficheros (paquetes)", "Comando para eliminar de forma automatica aquellos paquetes que no estamos usando",
                        "Comando para ver los paquetes instalados", "Comando para ver la informacion de un paquete (paquete)",
                        "Comando para actualizar nuestros sistemas a la siguiente version que este disponible en la distribucion",
                        "Comando para actualizar el listado de paquete disponibles", "Comando para actualizar todos los paquetes a su ultima version"}
                    Dim respuestas() As String = {"apt-get install paquetes", "apt-get remove paquetes", "apt-get purge paquetes", "apt-get autoremove",
                        "apt-show-versions", "apt-cache show paquete", "apt-get dist-upgrade", "apt-get update", "apt-get upgrade"}

                    Dim numaleatorio As Integer
                    Dim respuesta As String
                    numaleatorio = aleatorio.Next(0, preguntas.Length)
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("Ejercicio: ")
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.Magenta
                    Console.WriteLine(preguntas(numaleatorio))
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.Write("Escriba su respuesta: ")
                    Console.ForegroundColor = ConsoleColor.Cyan
                    respuesta = Console.ReadLine
                    Console.WriteLine()
                    Console.WriteLine()
                    If respuesta = respuestas(numaleatorio) Then
                        Console.ForegroundColor = ConsoleColor.Blue
                        Console.WriteLine("Respuesta CORRECTAA!!!. " & cumplido(numaleatorio_correcto))
                        Console.ForegroundColor = ConsoleColor.White
                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("Respuesta INCORRECTAA!!!." & insulto(numaleatorio_incorrecto) & ". La respuesta correcta era " & respuestas(numaleatorio))
                        Console.ForegroundColor = ConsoleColor.White
                    End If

            End Select
            Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
        Next

    End Sub

End Module
