Public Class MesaElectoral

    Private _administrador As Administrador
    Public Property Admin() As Administrador
        Get
            Return _administrador
        End Get
        Set(ByVal value As Administrador)
            _administrador = value
        End Set
    End Property

    Private _ubicacion As String
    Public Property Ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
        End Set
    End Property

    Private _candidatos As ArrayList

    Private _listaVotantes As ArrayList
    Private _vocales As ArrayList
    Sub New(ByVal admin As Administrador, ByVal ubi As String)
        Me._administrador = admin
        Me._ubicacion = ubi
        Me._listaVotantes = New ArrayList()
        Me._vocales = New ArrayList()
        Me._candidatos = New ArrayList()

    End Sub
End Class
