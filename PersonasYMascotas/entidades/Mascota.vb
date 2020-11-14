Public Class Mascota
    Dim _ci As Integer
    Dim _nombre As String
    Dim _anioNacimiento As Integer

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

    Public Property AnioNacimiento As Integer
        Get
            Return _anioNacimiento
        End Get
        Set(value As Integer)
            _anioNacimiento = value
        End Set
    End Property

    Public Sub mascotas(ci_ As Integer, nombre_ As String, anioNacimiento_ As Integer)
        Ci = ci_
        Nombre = nombre_
        AnioNacimiento = anioNacimiento_
    End Sub
End Class
