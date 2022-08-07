Imports MySql.Data.MySqlClient

Module DatabaseCon
    Public Function startconn() As MySqlConnection
        Return New MySqlConnection("server = localhost; USER id= root; DATABASE = payroll_database")
    End Function
    Public CONNECT As MySqlConnection = startconn()
End Module
