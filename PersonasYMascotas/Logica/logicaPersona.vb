﻿Public Class logicaPersona
    Public Sub altaPersona(nuevaPersona As Persona)
        Dim persistencia As New persistenciaPersonas
        persistencia.altaPersona(nuevaPersona)
    End Sub

    Public Sub modificarPersona(nuevaPersona As Persona)
        Dim persistencia As New persistenciaPersonas
        persistencia.modificarPersona(nuevaPersona)
    End Sub

    Public Sub bajaPersona(cedula As Integer)
        Dim persistencia As New persistenciaPersonas
        persistencia.bajaPersona(cedula)
    End Sub

    Public Function ListarPersona()
        Dim persistencia As New persistenciaPersonas
        Return persistencia.listarPersona()
    End Function

    Public Function buscarPersona(cedula As Integer)
        Dim persistencia As New persistenciaPersonas
        Return persistencia.Buscarpersona(cedula)
    End Function

    Public Function buscarTelefono(cedula As Integer) As List(Of Integer)
        Dim persistencia As New persistenciaPersonas
        Return persistencia.buscarTelefono(cedula)
    End Function
End Class
