Imports MySql.Data.MySqlClient



Module DB
    Const SERVER As String = "localhost"
    Public DbConnection As New MySqlConnection
    Public status As Boolean = False


    Public Function DBconnect() As Boolean
        Try
            DbConnection.ConnectionString = "Server=" + SERVER + ";user=root;password=;database=ict221;Convert Zero Datetime=True"
            DbConnection.Open()

            If DbConnection.State = 1 Then
                status = True

            End If



        Catch ex As Exception
            ex.Message.ToString()





        End Try

        Return status
    End Function



End Module
