Public Class logicaPersona
    Public Sub altaPersona(nuevaPersona As Persona)

        Dim persistencia As New persistenciaPersonas
        persistencia.altaPersona(nuevaPersona)

    End Sub

    Public Function buscarPersona(ci As Integer) As Persona
        Dim persistencia As New persistenciaPersonas
        Return persistencia.Buscarpersona(ci)

    End Function
End Class
