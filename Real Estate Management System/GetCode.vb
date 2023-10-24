imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient



Public Class GetCode
    Dim randomCode, touser As String



    Private Sub btngetPassword_Click(sender As Object, e As EventArgs) Handles btngetPassword.Click
        Dim command As New MySqlcommand

        DBconnect()

        Dim sql As String = "select Username, Email from admin where Username=@user AND Email =@email"

        command = New MySqlCommand(sql, DbConnection)

        command.Parameters.AddWithValue("@user", txtresetusername.Text)
        command.Parameters.AddWithValue("@email", txtrecoveremail.Text)

        Dim reader As MySqlDataReader = command.ExecuteReader
        If reader.Read Then

            Dim from, pass, messageBody As String
            Dim rand As Random = New Random()
            randomCode = (rand.Next(999999)).ToString()
            Dim message As MailMessage = New MailMessage()
            touser = txtrecoveremail.Text
            from = "ehithilanka@std.ssl.sab.ac.lk"
            pass = "Ishan@1998"
            messageBody = "Your Password Reset Code is " + randomCode
            message.To.Add(touser)
            message.From = New MailAddress(from)
            message.Body = messageBody
            message.Subject = "Password Reset Code"
            Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.DeliveryMethod = smtp.DeliveryMethod.Network
            smtp.Credentials = New NetworkCredential(from, pass)
            Try
                smtp.Send(message)
                MessageBox.Show("Please check your Email and enter the code")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MessageBox.Show("Incorrect Email Address or Username.Please check  Again", "Inccorect Email or PAssword", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        command.Dispose()
        DbConnection.Close()
        reader.Close()
    End Sub


    Private Sub btnserNewPassword_Click(sender As Object, e As EventArgs) Handles btnserNewPassword.Click
        If (txtrecovercode.Text.Equals(randomCode)) Then
            ResetPassword.Show()
            Me.Hide()
        Else
            MessageBox.Show("Verification Code Wrong.Try Again", "Incorrect Verification Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub










End Class