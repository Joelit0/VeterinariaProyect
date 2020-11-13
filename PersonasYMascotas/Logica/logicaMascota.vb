Public Class logicaMascota
    Public Function ListarMascota()
        Dim persistencia As New persistenciaMascotas
        Return persistencia.listarMascota()
    End Function
End Class
