Imports Npgsql
Public Class persistenciaPersonas
    Sub New()
    End Sub
    Dim Connection = New Npgsql.NpgsqlConnection

    'alta
    Public Sub altaPersona(nuevaPersona As Persona)
        Try
            Dim classConnection = New Conexion
            Connection = classConnection.AbrirConexion

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComando = "INSERT INTO persona (ci, nombre, direccion) VALUES (@ci_ ,@nombre_ ,@direccion_);"
            cmd.CommandText = cadenaDeComando

            cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.Ci
            cmd.Parameters.Add("@nombre_", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = nuevaPersona.Nombre
            cmd.Parameters.Add("@direccion_", NpgsqlTypes.NpgsqlDbType.Varchar, 150).Value = nuevaPersona.Direccion
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()


            If resultado = 1 Then
                Dim i As Integer
                i = 0

                'Ingresar telefonos
                While i < nuevaPersona.ListaTelefono.Count
                    cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = Connection

                    cadenaDeComando = "INSERT INTO telefono (ci, tel) VALUES (@ci_,@te Dim cmd As New pgsql.NpgsqlCommandl_);"
                    cmd.CommandText = cadenaDeComando

                    cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.Ci
                    cmd.Parameters.Add("@tel_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.ListaTelefono.Item(i)

                    resultado = cmd.ExecuteNonQuery()

                    i = i + 1
                End While

            End If

        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try

    End Sub

    'modificar
    Public Sub modificarPersona(nuevaPersona As Persona)
        Try
            Dim classConnection = New Conexion
            Connection = classConnection.AbrirConexion

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComando = "INSERT INTO persona (ci, nombre, direccion) VALUES (@ci_,@nombre_,@direccion_);"
            cmd.CommandText = cadenaDeComando

            cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.Ci
            cmd.Parameters.Add("@nombre_", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = nuevaPersona.Nombre
            cmd.Parameters.Add("@direccion_", NpgsqlTypes.NpgsqlDbType.Varchar, 150).Value = nuevaPersona.Direccion
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()


            If resultado = 1 Then
                Dim i As Integer
                i = 0
                cadenaDeComando = "DELETE FROM telefono WHERE telefono.ci = @ci_"
                cmd.CommandText = cadenaDeComando
                cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.Ci
                resultado = cmd.ExecuteNonQuery()

                'Modificar telefonos
                While i < nuevaPersona.ListaTelefono.Count
                    cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = Connection

                    cadenaDeComando = "INSERT INTO telefono (tel, ci) VALUES (@tel_, @ci_);"
                    cmd.CommandText = cadenaDeComando

                    cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.Ci
                    cmd.Parameters.Add("@tel_", NpgsqlTypes.NpgsqlDbType.Integer).Value = nuevaPersona.ListaTelefono.Item(i)

                    resultado = cmd.ExecuteNonQuery()

                    i = i + 1
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Sub

    Public Function Buscarpersona(ci As Integer) As Persona
        Dim personaNueva As New Persona
        Try
            Dim ClaseSln As New Conexion
            Connection = ClaseSln.AbrirConexion
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComandos = "Select * FROM persona WHERE ci = @ci_"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            Dim reader As Npgsql.NpgsqlDataReader = cmd.ExecuteReader


            If reader.HasRows Then
                reader.Read()

                personaNueva.Ci = Convert.ToInt32(reader(0).ToString)
                personaNueva.Nombre = reader(1).ToString
                personaNueva.Direccion = reader(2).ToString
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return personaNueva
    End Function

    Public Function listarPersona() As List(Of Persona)
        Try
            Dim listaPersonas As List(Of Persona)

            Dim claseConexion As New Conexion

            Connection = claseConexion.AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComandos = "SELECT * FROM persona"

            cmd.CommandText = cadenaDeComandos

            Dim Lector As Npgsql.NpgsqlDataReader
            Lector = cmd.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read()

                End While
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try
    End Function
End Class
