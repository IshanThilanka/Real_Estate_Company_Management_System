Imports MySql.Data.MySqlClient

Module LoginInfo

    'Public Sub Logininfo()



    'End Sub

    'Private Function LoginInfo(ByVal ID As String) As System.IO.MemoryStream
    '    Try
    '        DBconnect()
    '        Dim query As String = "SELECT `Image` FROM `admin` WHERE `ID`=@ID"
    '        command = New MySqlCommand(query, DbConnection)
    '        command.Parameters.AddWithValue("@ID", ID)
    '        dr = command.ExecuteReader()
    '        dr.Read()
    '        Dim imgArray() As Byte = dr.Item("Image")
    '        Dim ms As New IO.MemoryStream(imgArray)
    '        command.Dispose()
    '        DbConnection.Close()
    '        dr.Close()
    '        Return ms
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    '    Return Nothing
    'End Function




End Module
