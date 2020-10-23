
Public Class Conexion
        Public Function AbrirConexion() As Npgsql.NpgsqlConnection
            Dim conexion_pg As Npgsql.NpgsqlConnection
            Try
                conexion_pg = New Npgsql.NpgsqlConnection()
            Dim cadenaDeConexion As String
            cadenaDeConexion = "Server=127.0.0.1;Port=5432;User Id='postgres';Password='ROOT';Database='Joel-db'"

            conexion_pg.ConnectionString = cadenaDeConexion
            conexion_pg.Open()

        Catch ex As Exception
                Throw ex
            End Try

            Return conexion_pg
        End Function
    End Class