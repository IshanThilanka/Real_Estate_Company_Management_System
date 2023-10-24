Imports MySql.Data.MySqlClient


Module Decrypt

    Dim command As New MySqlCommand

    Public Sub Encryptedlogin(username As String, password As String)
        Dim salt As String = ""
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader


        If DBconnect() Then
            Dim query As String = "SELECT * FROM admin WHERE Username=@user"
            command = New MySqlCommand(query, DbConnection)
            command.Parameters.AddWithValue("@user", username)
            reader = command.ExecuteReader()



            While reader.Read()
                salt = reader("salt").ToString()
            End While
            reader.Close()


            Dim pass = Encryption.HashString(password)
            Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", pass, salt))
            Dim checkLoginQuery As String = "SELECT COUNT(*) FROM admin WHERE Username =@user AND Password = @pass"
            Dim sqlCommand As New MySqlCommand(checkLoginQuery, DbConnection)
            sqlCommand.Parameters.AddWithValue("@user", username)
            sqlCommand.Parameters.AddWithValue("@pass", hashedAndSalted)
            Dim results As Integer = Convert.ToInt32(sqlCommand.ExecuteScalar())
            If results = 1 Then

                MessageBox.Show("Welcome: " & username, "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dashboard.Show()
                Login.Hide()
            Else
               
                MessageBox.Show("Your username or password is incorrect", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If

    End Sub
















End Module
