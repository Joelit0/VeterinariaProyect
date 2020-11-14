Public Class logicaMascota
    Public Function ListarMascota()
        Dim persistencia As New persistenciaMascotas
        Return persistencia.listarMascota()
    End Function

    Public Sub altaMascota(nuevaMascota As Mascota)
        Dim persistencia As New persistenciaMascotas
        persistencia.altaMascota(nuevaMascota)
    End Sub
End Class
