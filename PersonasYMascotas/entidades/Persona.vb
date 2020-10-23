Public Class Persona

    Private _ci As Integer
    Private _nombre As String
    Private _direccion As String
    Private _telefono As List(Of Integer)

    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property ListaTelefono As List(Of Integer)
        Get
            Return _telefono
        End Get
        Set(value As List(Of Integer))
            _telefono = value
        End Set
    End Property

    Public Sub personas()

    End Sub

    Public Sub personas(ci_ As Integer, nombre_ As String, direccion_ As String, telefono_ As List(Of Integer))
        Ci = ci_
        Nombre = nombre_
        Direccion = direccion_
        ListaTelefono = telefono_
    End Sub
End Class
