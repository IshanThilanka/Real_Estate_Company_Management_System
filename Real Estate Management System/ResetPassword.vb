Imports MySql.Data.MySqlClient

Public Class ResetPassword
    Private Sub btnresetPssword_Click(sender As Object, e As EventArgs) Handles btnresetPssword.Click
        Dim username As String = "Ishan98" 'GetCode.txtresetusername.Text
        Dim Password As String
        Dim adapter As New MySqlDataAdapter
        If txtnewpassword.Text = txtnewRpassword.Text Then


            Password = Trim(txtnewpassword.Text)

            Dim HashedPasword = Encryption.HashString(Password)
            Dim salt = Encryption.GenereateSalt
            Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", HashedPasword, salt))
            Try
                DBconnect()

                Dim sql As String
                Dim result As Integer

                Dim command As New MySqlCommand("UPDATE `admin` SET `Password`=@password,  `Salt` = '" & salt & "'   WHERE Username = '" & username & "'", DbConnection)


                command.Parameters.AddWithValue("@password", hashedAndSalted)
                command.Parameters.AddWithValue("@salt", salt)




                result = command.ExecuteNonQuery()
                adapter.Dispose()

                If result = 1 Then
                    MessageBox.Show("Password reseted successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    Login.Show()
                    Me.Hide()
                End If
                command.Dispose()
                    DbConnection.Close()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class