Imports System.Data.SqlClient
Public Class UserDao

    Inherits SQLCon

    Public Function Login(username As String, password As String) As Boolean

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *from tbl_user where username=@username and password=@password"
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read() 'Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache'
                        'ActiveUser.idUser = reader.GetInt32(0)
                        ActiveUser.idUser = reader.GetString(0)
                        ActiveUser.username = reader.GetString(1)
                        ActiveUser.password = reader.GetString(2)
                        ActiveUser.password = reader.GetString(3)
                        ActiveUser.lastname = reader.GetString(4)
                        ActiveUser.firstname = reader.GetString(5)
                        ActiveUser.usertype = reader.GetString(6)
                        ActiveUser.email = reader.GetString(7)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function


End Class
