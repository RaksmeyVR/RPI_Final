Public Class UserModel

    Dim userDao As New UserDao()

    Public Function Login(username As String, password As String) As Boolean
        Return userDao.Login(username, password)
    End Function

End Class
