Public Class Mascota
    Dim _ci As Integer
    Dim _nombre As String
    Dim _fechaNacimiento As Date

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

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Sub mascotas(ci_ As Integer, nombre_ As String, fechaNacimiento_ As Date)
        Ci = ci_
        Nombre = nombre_
        FechaNacimiento = fechaNacimiento_
    End Sub
End Class
