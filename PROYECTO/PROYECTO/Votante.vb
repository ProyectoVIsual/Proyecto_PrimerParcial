﻿Public Class Votante
    Inherits Persona


    Sub New()
        Me.Nombre = "Desconocido"
        Me.Apellido = "Desconocido"
        Me.Cedula = "Desconocido"
        Me.edad = 0
    End Sub


    Sub New(ByVal nombre As String, ByVal apellido As String, ByVal cedula As String, ByVal edad As Byte)
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Cedula = cedula
        Me.edad = edad

    End Sub


End Class
