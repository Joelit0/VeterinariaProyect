Imports Npgsql

Public Class persistenciaPersonas
    Sub New()
    End Sub
    Dim Connection = New Npgsql.NpgsqlConnection

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

                While i < nuevaPersona.ListaTelefono.Count
                    cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = Connection

                    cadenaDeComando = "INSERT INTO telefono (ci, tel) VALUES (@ci_,@tel_);"
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

    Public Sub modificarPersona(nuevaPersona As Persona)
        Try
            Dim classConnection = New Conexion
            Connection = classConnection.AbrirConexion

            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComando = "UPDATE persona set nombre = @nombre_, direccion = @direccion_ where persona.ci = @ci_;"
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

    Public Function Buscarpersona(cedula As Integer)
        Dim personaNueva As New Persona
        Try
            Dim ClaseSln As New Conexion
            Dim Connection = ClaseSln.AbrirConexion
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComandos = "Select * FROM persona p WHERE p.ci = @ci_"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = cedula

            Dim reader As Npgsql.NpgsqlDataReader
            reader = cmd.ExecuteReader

            Dim i As Integer
            i = 0
            While (reader.Read())
                personaNueva.Ci = Convert.ToInt32(reader(0).ToString)
                personaNueva.Nombre = reader(1).ToString
                personaNueva.Direccion = reader(2).ToString
            End While

            Return personaNueva
        Catch ex As Exception
            Throw ex
        End Try

        Return personaNueva
    End Function

    Public Function buscarTelefono(cedula As Integer)
        Dim ListaTelefono As New List(Of Integer)
        Try
            Dim ClaseSln As New Conexion
            Dim Connection = ClaseSln.AbrirConexion
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = Connection

            Dim cadenaDeComandos = "Select * FROM telefono t WHERE t.ci = @ci_"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci_", NpgsqlTypes.NpgsqlDbType.Integer).Value = cedula

            Dim reader As Npgsql.NpgsqlDataReader
            reader = cmd.ExecuteReader

            Dim i As Integer
            i = 0
            While (reader.Read())
                Dim telefono = Convert.ToInt32(reader(0).ToString)
                ListaTelefono.Add(telefono)
            End While

        Catch ex As Exception
            Throw ex
        End Try

        Return ListaTelefono
    End Function

    Public Function listarPersona() As List(Of Persona)
        Dim listaPersonas As New List(Of Persona)
        Try
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
                    Dim personaListada As New Persona
                    personaListada.Nombre = Lector(1).ToString
                    listaPersonas.Add(personaListada)
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Connection.Close()
        End Try

        Return listaPersonas
    End Function
End Class