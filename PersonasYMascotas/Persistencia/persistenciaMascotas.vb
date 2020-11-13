Imports Npgsql

Public Class persistenciaMascotas
    Sub New()
    End Sub
    Dim Connection = New Npgsql.NpgsqlConnection

    Public Function listarMascota() As List(Of Mascota)
        Dim listaMascotas As New List(Of Mascota)
        Try
            Dim claseConexion As New Conexion

            Connection = claseConexion.AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComandos = "SELECT * FROM mascota"

            cmd.CommandText = cadenaDeComandos

            Dim Lector As Npgsql.NpgsqlDataReader
            Lector = cmd.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read()
                    Dim mascotaListada As New Mascota
                    mascotaListada.Nombre = Lector(1).ToString
                    listaMascotas.Add(mascotaListada)
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try

        Return listaMascotas
    End Function
End Class
