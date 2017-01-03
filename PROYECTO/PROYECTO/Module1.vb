
Imports MySql.Data.MySqlClient
Imports MySql.Data
Module Module1
    Dim SESSION As New InicioSession
    Dim ADMIN_OP As New Op_Administrador
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
                    If SESSION.InicioSessionvOTANTE(cedu) = "EXITO" Then
                        manejarVotante()
                    Else
                        Console.WriteLine("credenciales no validas")
                    End If

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
            ADMIN_OP.MenuParaVotante()

            op = Console.ReadLine()

            Try
                opcion = CByte(op)
            Catch ex As OverflowException
                opcion = 255
            Catch ex As Exception
                opcion = OpMain.Invalid

            End Try


            Console.WriteLine("Ud a ingresado: {0}", op)
            If op.Equals(123) Then
                opcion = 123
            Else
                If ADMIN_OP.Votar(op) Then
                    Console.WriteLine("Voto con exito")
                Else
                    Console.WriteLine("ERROR INGRESE LA OPCCION CORRECTA")
                End If
            End If


        Loop Until opcion = 123

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
        Dim user As String = ""
        Dim pass As String = ""

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
                    If SESSION.InicioSessionCandidato(user, pass) = "EXITO" Then
                        manejarCandidato()
                        'Console.WriteLine("EXITO...")
                        'Console.ReadLine()
                        opcion = LoginCandidato.User
                    Else
                        Console.WriteLine("CREDENCIALES NO VALIDAS")
                    End If



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
                Case OpCandidato.Resultados
                    Console.WriteLine("Resultados")
                    manejarCandidatoResultados()
                Case OpCandidato.ListarCandidatos
                    Console.WriteLine("Listar Candidatos")
                    manejarCandidatoListas()
                Case OpCandidato.Out
                    Console.WriteLine("Cerrar Sesión")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpCandidato.Out

    End Sub

    Sub MenuCandidato()

        Console.WriteLine("{0}. Resultados", CInt(OpCandidato.Resultados))
        Console.WriteLine("{0}. Listar Candidatos", CInt(OpCandidato.ListarCandidatos))
        Console.WriteLine("{0}. Cerrar Sesión", CInt(OpCandidato.Out))

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
                Case OpCandidatoResultados.Cresultados
                    Console.WriteLine("Estos son los Resultados")

                Case OpCandidatoResultados.Out
                    Console.WriteLine("Regresar al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpCandidatoResultados.Out

    End Sub

    Sub MenuCandidatoResultados()

        Console.WriteLine("Estos son los Resultados", CInt(OpCandidatoResultados.Cresultados))
        ADMIN_OP.VerResultados()
        Console.WriteLine("                                ")
        Console.WriteLine("{0}. regresar", CInt(OpCandidatoResultados.Out))

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
                Case OpCandidatoListas.Lista
                    ADMIN_OP.ListarCandidatos()
                Case OpCandidatoListas.Out
                    Console.WriteLine("Regresar al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpCandidatoListas.Out

    End Sub

    Sub MenuCandidatoListas()

        Console.WriteLine("Estos son los Candidatos", CInt(OpCandidatoListas.Lista))
        ADMIN_OP.ListarCandidatos()
        Console.WriteLine("{0}. Regresar", CInt(OpCandidatoListas.Out))

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
                    If SESSION.InicioSessionAdmin(user, pass) = "EXITO" Then
                        manejarAdministrador()
                    Else
                        Console.WriteLine("CREDENCIALES NO VALIDAS")
                    End If

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

        Loop Until opcion = OpAdministrador.Out

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
        Dim edad As Integer
        Dim cedula As Integer
        Dim lista As Integer
        Dim dignidad As String
        Dim usercand As String
        Dim passcand As String

        Dim conex As New MySqlConnection("data source=localhost; user id=root; password=''; database=voto2016")
        '("data source=localhost;user id=root; password=''; database=animales")
        Dim da As MySqlDataAdapter
        Dim ds As New DataSet
        Dim sqls, neensaje As String
        Dim sw As Boolean

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
                    Console.WriteLine("Ingrese su edad")
                    edad = Console.ReadLine()
                    Console.WriteLine("Ingrese su numero de cedula")
                    cedula = Console.ReadLine()
                    Console.WriteLine("Ingrese su numero de lista")
                    lista = Console.ReadLine()
                    Console.WriteLine("Ingrese su dignidad")
                    dignidad = Console.ReadLine()
                    Console.WriteLine("Ingrese su usuario")
                    usercand = Console.ReadLine()
                    Console.WriteLine("Ingrese su contraseña")
                    passcand = Console.ReadLine()
                    If ADMIN_OP.AgregarCandidato(nombre, apellido, edad, cedula, lista, dignidad, usercand, passcand) Then
                        Console.WriteLine("Los Datos Del Candidato Han Sido Ingresados Correctamente")
                    Else
                        Console.WriteLine("DATOS NO INGRESADOS  ")
                    End If


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
                    If ADMIN_OP.EliminarCandidato(cedula) Then
                        Console.WriteLine("Su Candidato Ha Sido Eliminado")
                    Else
                        Console.WriteLine("ERROR")
                    End If


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
                    ADMIN_OP.VerResultados()
                    'Console.WriteLine("Estos son los Resultados")
                Case OpAdminResulCandidato.Out
                    Console.WriteLine("Regresar al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpAdminResulCandidato.Out

    End Sub

    Sub MenuAdminResulCandidato()

        Console.WriteLine("Estos son los Resultados", CInt(OpAdminResulCandidato.AResultados))
        ADMIN_OP.VerResultados()
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
                    ADMIN_OP.ListarCandidatos()
                Case OpAdminListaCandidato.Out
                    Console.WriteLine("Regresar al Menu Principal")
                Case Else
                    Console.WriteLine("xxx Opcion Invalidad xxx")
            End Select

        Loop Until opcion = OpAdminListaCandidato.Out

    End Sub

    Sub MenuAdminListaCandidato()

        Console.WriteLine("Estos son los Candidatos", CInt(OpAdminListaCandidato.ALista))
        ADMIN_OP.ListarCandidatos()
        Console.WriteLine("{0}. Regresar", CInt(OpAdminListaCandidato.Out))

    End Sub


End Module
