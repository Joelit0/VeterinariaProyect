Public Class logicaPersona
    Public Sub altaPersona(nuevaPersona As Persona)
        Dim persistencia As New persistenciaPersonas
        persistencia.altaPersona(nuevaPersona)
    End Sub

    Public Function buscarPersona(cedula As Integer)
        Dim persistencia As New persistenciaPersonas
        Return persistencia.Buscarpersona(cedula)
    End Function

    Public Function buscarTelefono(cedula As Integer) As List(Of Integer)
        Dim persistencia As New persistenciaPersonas
        Return persistencia.buscarTelefono(cedula)
    End Function
End Class
