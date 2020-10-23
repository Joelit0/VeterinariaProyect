Public Class persistenciaTelefonos
    Dim ListaTelefono As New List(Of Integer)
    Dim Connection = New Npgsql.NpgsqlConnection

    Public Sub AgregarTelefono(Ci As Integer, Telefono As Integer)
        Try
            Dim classConnection = New Conexion
            Connection = classConnection.AbrirConexion

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComando = "INSERT INTO Personas (ci,telefono) VALUES (@ci_,@telefono_);"
            cmd.CommandText = cadenaDeComando

            cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.Ci
            cmd.Parameters.Add("@telefono_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.ListaTelefono.Item(i)
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try

    End Sub
End Class
