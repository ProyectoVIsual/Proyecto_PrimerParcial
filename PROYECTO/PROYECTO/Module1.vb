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
                Case OpMain.Admin
                    Console.WriteLine("Administrador")
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

End Module
