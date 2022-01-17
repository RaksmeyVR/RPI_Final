Imports System.Data.SqlClient
Public MustInherit Class SQLCon
    'Server Configuration
    Public datasource As String = "DESKTOP-PDVHOEE"
    Public database As String = "ODMS"


    'Global Variable Declaration
    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public dt As New DataTable
    Public ds As New DataSet
    Public cs As String
    Protected Sub New()
        cs = "Data Source=" + datasource + ";Initial Catalog=" + database + ";integrated security= true"
        '"Server=DESKTOP-UT3VJU7;DataBase= ODNS; integrated security= true"

    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(cs)
    End Function
End Class
