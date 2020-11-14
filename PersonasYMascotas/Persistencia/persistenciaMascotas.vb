Imports Npgsql

Public Class persistenciaMascotas
    Sub New()
    End Sub
    Dim Connection = New Npgsql.NpgsqlConnection

    Public Sub altaMascota(nuevaMascota As Mascota)
        Try
            Dim classConnection = New Conexion
            Connection = classConnection.AbrirConexion

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenadecomandos As String
            cadenadecomandos = ""
            cmd.CommandText = cadenadecomandos

            Dim cadenaDeComando = "INSERT INTO mascota(anionacimiento, nombre, ci) values (@anionacimiento_, @nombre_, @ci_);"
            cmd.CommandText = cadenaDeComando

            cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaMascota.Ci
            cmd.Parameters.Add("@nombre_", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = nuevaMascota.Nombre
            cmd.Parameters.Add("@anioNacimient_", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = nuevaMascota.AnioNacimiento

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Algo salió mal" & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

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
