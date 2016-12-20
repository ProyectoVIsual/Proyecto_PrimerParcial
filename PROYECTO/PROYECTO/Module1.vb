Module Module1

    Enum OpMain
        Invalid
        Vote
        Candidate
        Admin
        Out
    End Enum


    Enum LoginVotante
        Cedula = 1
        Out
    End Enum

    Enum OpVotante
        Candidate1 = 1
        Candidate2
        Candidate3
        Candidate4
        Candidate5
        Out
    End Enum

    Enum LoginCandidato
        User = 1
        Out
    End Enum

    Enum OpCandidato
        Resultados = 1
        ListarCandidatos
        Out
    End Enum

    Enum OpCandidatoResultados
        Cresultados = 1
        Out
    End Enum

    Enum OpCandidatoListas
        Lista = 1
        Out
    End Enum

    Enum LoginAdministrador
        User = 1
        Out
    End Enum

    Enum OpAdministrador
        AggCandidato = 1
        DeleteCandidato
        ResultadosAdmin
        VerCandidatosAdmin
        Out
    End Enum

    Enum OpAdminAggCandidato
        Nombre = 1
        Out
    End Enum

    Enum OpAdminDeleteCandidato
        Cedula = 1
        Out
    End Enum

    Enum OpAdminResulCandidato
        AResultados = 1
        Out
    End Enum

    Enum OpAdminListaCandidato
        ALista = 1
        Out
    End Enum

    Sub Main()
        Dim op As String = ""
        Dim opcion As Byte

        Do
            MenuPrincipal()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid

            End Try

            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case OpMain.Vote
                    Console.WriteLine("Votante")
                    manejarLoginVotante()
                Case OpMain.Candidate
                    Console.WriteLine("Candidato")
                    manejarLoginCandidato()
                Case OpMain.Admin
                    Console.WriteLine("Administrador")
                    manejarLoginAdministrador()
                Case OpMain.Out
                    Console.WriteLine("Cerrar la Aplicación")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx [{0}]", opcion)
            End Select

        Loop Until opcion = OpMain.Out

        Console.WriteLine("Gracias Bye")
        Console.ReadKey()
    End Sub

    Sub MenuPrincipal()

        Console.WriteLine("{0}. Votante", CInt(OpMain.Vote))
        Console.WriteLine("{0}. Candidato", CInt(OpMain.Candidate))
        Console.WriteLine("{0}. Administrador", CInt(OpMain.Admin))
        Console.WriteLine("{0}. Cerrar la Aplicación", CInt(OpMain.Out))

    End Sub

    'VOTANTE

    Sub manejarLoginVotante()

        Dim op As String = ""
        Dim opcion As Byte
        Dim cedu As String

        Do
            MenuLoginVotante()

            op = Console.ReadLine()
            opcion = CByte(op) 'Byte parse()
            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case LoginVotante.Cedula
                    Console.WriteLine("Ingrese su numero de cedula")
                    cedu = Console.ReadLine()
                    manejarVotante()
                Case LoginVotante.Out
                    Console.WriteLine("Vuelve al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = LoginVotante.Out
    End Sub

    Sub MenuLoginVotante()

        Console.WriteLine("{0}. Ingrese su numero de cedula", CInt(LoginVotante.Cedula))
        Console.WriteLine("{0}. Regresar al Menu Principal", CInt(LoginVotante.Out))


    End Sub

    Sub manejarVotante()

        Dim op As String = ""
        Dim opcion As Byte

        Do
            MenuVotante()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid

            End Try


            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case OpVotante.Candidate1
                    Console.WriteLine("Candidato 1")
                    Console.WriteLine("Muchas Gracias su Voto Ha Sido Regristado Exitosamente")
                Case OpVotante.Candidate2
                    Console.WriteLine("Candidato 2")
                    Console.WriteLine("Muchas Gracias su Voto Ha Sido Regristado Exitosamente")
                Case OpVotante.Candidate3
                    Console.WriteLine("Candidato 3")
                    Console.WriteLine("Muchas Gracias su Voto Ha Sido Regristado Exitosamente")
                Case OpVotante.Candidate4
                    Console.WriteLine("Candidato 4")
                    Console.WriteLine("Muchas Gracias su Voto Ha Sido Regristado Exitosamente")
                Case OpVotante.Candidate5
                    Console.WriteLine("Candidato 5")
                    Console.WriteLine("Muchas Gracias su Voto Ha Sido Regristado Exitosamente")
                Case OpVotante.Out
                    Console.WriteLine("Regresar al Menú Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpVotante.Out

    End Sub

    Sub MenuVotante()

        Console.WriteLine("{0}. Candidato 1", CInt(OpVotante.Candidate1))
        Console.WriteLine("{0}. Candidato 2", CInt(OpVotante.Candidate2))
        Console.WriteLine("{0}. Candidato 3", CInt(OpVotante.Candidate3))
        Console.WriteLine("{0}. Candidato 4", CInt(OpVotante.Candidate4))
        Console.WriteLine("{0}. Candidato 5", CInt(OpVotante.Candidate5))
        Console.WriteLine("{0}. Regresar al Menú Principal", CInt(OpVotante.Out))

    End Sub

    'CANDIDATO

    Sub manejarLoginCandidato()

        Dim op As String = ""
        Dim opcion As Byte
        Dim user As String
        Dim pass As String

        Do
            MenuLoginCandidato()

            op = Console.ReadLine()
            opcion = CByte(op) 'Byte parse()
            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case LoginCandidato.User
                    Console.WriteLine("Ingrese su usuario")
                    user = Console.ReadLine()
                    Console.WriteLine("Ingrese su contraseña")
                    pass = Console.ReadLine()
                    manejarCandidato()
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = LoginCandidato.Out
    End Sub

    Sub MenuLoginCandidato()

        Console.WriteLine("{0}. Ingrese su usuario", CInt(LoginCandidato.User))
        Console.WriteLine("{0}. Regresar al Menu Principal", CInt(LoginCandidato.Out))


    End Sub

    Sub manejarCandidato()

        Dim op As String = ""
        Dim opcion As Byte

        Do
            MenuCandidato()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid

            End Try


            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case OpCandidato.resultados
                    Console.WriteLine("Resultados")
                    manejarCandidatoResultados()
                Case OpCandidato.listarCandidatos
                    Console.WriteLine("Listar Candidatos")
                    manejarCandidatoListas()
                Case OpCandidato.out
                    Console.WriteLine("Cerrar Sesión")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpCandidato.Out

    End Sub

    Sub MenuCandidato()

        Console.WriteLine("{0}. Resultados", CInt(OpCandidato.resultados))
        Console.WriteLine("{0}. Listar Candidatos", CInt(OpCandidato.listarCandidatos))
        Console.WriteLine("{0}. Cerrar Sesión", CInt(OpCandidato.out))

    End Sub



    Sub manejarCandidatoResultados()

        Dim op As String = ""
        Dim opcion As Byte

        Do
            MenuCandidatoResultados()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid

            End Try


            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case OpCandidatoResultados.cresultados
                    Console.WriteLine("Estos son los Resultados")
                Case OpCandidatoResultados.out
                    Console.WriteLine("Regresar al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpCandidatoResultados.out

    End Sub

    Sub MenuCandidatoResultados()

        Console.WriteLine("Estos son los Resultados", CInt(OpCandidatoResultados.cresultados))
        Console.WriteLine("{0}. Cerrar Sesión", CInt(OpCandidatoResultados.out))

    End Sub

    Sub manejarCandidatoListas()

        Dim op As String = ""
        Dim opcion As Byte

        Do
            MenuCandidatoListas()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid
            End Try

            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case OpCandidatoListas.lista
                    Console.WriteLine("Estos son los Candidatos")
                Case OpCandidatoListas.out
                    Console.WriteLine("Regresar al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpCandidatoListas.out

    End Sub

    Sub MenuCandidatoListas()

        Console.WriteLine("Estos son los Candidatos", CInt(OpCandidatoListas.lista))
        Console.WriteLine("{0}. Cerrar Sesión", CInt(OpCandidatoListas.out))

    End Sub


    'ADMINISTRADOR

    Sub manejarLoginAdministrador()

        Dim op As String = ""
        Dim opcion As Byte
        Dim user As String
        Dim pass As String

        Do
            MenuLoginAdministrador()

            op = Console.ReadLine()
            opcion = CByte(op) 'Byte parse()
            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case LoginAdministrador.User
                    Console.WriteLine("Ingrese su usuario")
                    user = Console.ReadLine()
                    Console.WriteLine("Ingrese su contraseña")
                    pass = Console.ReadLine()
                    manejarAdministrador()
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = LoginAdministrador.Out
    End Sub

    Sub MenuLoginAdministrador()

        Console.WriteLine("{0}. Ingrese su usuario", CInt(LoginAdministrador.User))
        Console.WriteLine("{0}. Regresar al Menu Principal", CInt(LoginAdministrador.Out))


    End Sub

    Sub manejarAdministrador()

        Dim op As String = ""
        Dim opcion As Byte

        Do
            MenuAdministrador()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid
            End Try


            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case OpAdministrador.AggCandidato
                    Console.WriteLine("Agregar Candidato")
                    manejarAdminAggCandidato()
                Case OpAdministrador.DeleteCandidato
                    Console.WriteLine("Eliminar Candidato")
                    manejarAdminDeleteCandidato()
                Case OpAdministrador.ResultadosAdmin
                    Console.WriteLine("Ver Resultados")
                    manejarAdminResulCandidato()
                Case OpAdministrador.VerCandidatosAdmin
                    Console.WriteLine("Ver Candidatos")
                    manejarAdminListaCandidato()
                Case OpAdministrador.Out
                    Console.WriteLine("Cerrar Sesión")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpAdministrador.out

    End Sub

    Sub MenuAdministrador()

        Console.WriteLine("{0}. Agregar Candidato", CInt(OpAdministrador.AggCandidato))
        Console.WriteLine("{0}. Eliminar Candidato", CInt(OpAdministrador.DeleteCandidato))
        Console.WriteLine("{0}. Ver Resultados", CInt(OpAdministrador.ResultadosAdmin))
        Console.WriteLine("{0}. Ver Candidatos", CInt(OpAdministrador.VerCandidatosAdmin))
        Console.WriteLine("{0}. Cerrar Sesión", CInt(OpAdministrador.Out))

    End Sub

    Sub manejarAdminAggCandidato()

        Dim op As String = ""
        Dim opcion As Byte
        Dim nombre As String
        Dim apellido As String
        Dim cedula As Integer
        Dim lista As Integer

        Do
            MenuAdminAggCandidato()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid

            End Try


            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case OpAdminAggCandidato.Nombre
                    Console.WriteLine("Ingrese su Nombre")
                    nombre = Console.ReadLine()
                    Console.WriteLine("Ingrese su Apellido")
                    apellido = Console.ReadLine()
                    Console.WriteLine("Ingrese su numero de cedula")
                    cedula = Console.ReadLine()
                    Console.WriteLine("Ingrese su numero de lista")
                    lista = Console.ReadLine()
                Case OpCandidatoResultados.Out
                    Console.WriteLine("Regresar al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpCandidatoResultados.Out

    End Sub

    Sub MenuAdminAggCandidato()

        Console.WriteLine("{0}. Ingrese sus Datos", CInt(OpAdminAggCandidato.Nombre))
        Console.WriteLine("{0}. Regresar", CInt(OpAdminAggCandidato.Out))

    End Sub


    Sub manejarAdminDeleteCandidato()

        Dim op As String = ""
        Dim opcion As Byte
        Dim cedula As Integer

        Do
            MenuAdminDeleteCandidato()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid

            End Try


            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case OpAdminDeleteCandidato.Cedula
                    Console.WriteLine("Ingrese su Cedula")
                    cedula = Console.ReadLine()
                Case OpCandidatoResultados.Out
                    Console.WriteLine("Regresar al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpAdminDeleteCandidato.Out

    End Sub

    Sub MenuAdminDeleteCandidato()

        Console.WriteLine("{0}. Ingrese su Cedula", CInt(OpAdminDeleteCandidato.Cedula))
        Console.WriteLine("{0}. Regresar", CInt(OpAdminDeleteCandidato.Out))

    End Sub

    Sub manejarAdminResulCandidato()

        Dim op As String = ""
        Dim opcion As Byte


        Do
            MenuAdminResulCandidato()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid

            End Try


            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case OpAdminResulCandidato.AResultados
                    Console.WriteLine("Estos son los Resultados")
                Case OpAdminResulCandidato.Out
                    Console.WriteLine("Regresar al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpAdminResulCandidato.Out

    End Sub

    Sub MenuAdminResulCandidato()

        Console.WriteLine("Estos son los Resultados", CInt(OpAdminResulCandidato.AResultados))
        Console.WriteLine("{0}. Regresar", CInt(OpAdminResulCandidato.Out))

    End Sub

    Sub manejarAdminListaCandidato()

        Dim op As String = ""
        Dim opcion As Byte

        Do
            MenuAdminListaCandidato()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid

            End Try


            Console.WriteLine("Ud a ingresado: {0}", op)

            Select Case opcion
                Case OpAdminListaCandidato.ALista
                    Console.WriteLine("Estos son los Candidatos")
                Case OpAdminListaCandidato.Out
                    Console.WriteLine("Regresar al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpAdminListaCandidato.Out

    End Sub

    Sub MenuAdminListaCandidato()

        Console.WriteLine("Estos son los Candidatos", CInt(OpAdminListaCandidato.ALista))
        Console.WriteLine("{0}. Regresar", CInt(OpAdminListaCandidato.Out))

    End Sub


End Module
