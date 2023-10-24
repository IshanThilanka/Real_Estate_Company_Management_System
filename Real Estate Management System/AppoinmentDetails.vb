Imports MySql.Data.MySqlClient
Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Resources
Public Class AppoinmentDetails
    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Hide()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btnsendmsg_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AppoinmentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Panel1.BackColor = Color.FromArgb(120, 0, 0, 0)
    End Sub

    Private Sub btnsendmsg_Click_1(sender As Object, e As EventArgs) Handles btnsendmsg.Click
        Dim command As New MySqlCommand
        Dim phone As String





        Try
            DBconnect()

            Dim cmd As New MySqlCommand("UPDATE `appointment` SET `AppointmentStatus`='Approved' WHERE CustomerName='" & lblAppointCusName.Text & "'", DbConnection)

            cmd.ExecuteNonQuery()



            If cmd.ExecuteNonQuery() = 1 Then


                lblappontStatus.Text = "Approved"
            End If
            Loadappointments()
            DbConnection.Close()

            cmd.Dispose()
            DbConnection.Close()



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        DBconnect()

        Dim sql As String = " Select `Phone_Number` FROM `agent` WHERE Agent_ID='" & lblAppointAgentID.Text & "'"
        command = New MySqlCommand(sql, DbConnection)
        Dim reader As MySqlDataReader = command.ExecuteReader
        While reader.Read
            phone = reader.Item("Phone_Number")

        End While


        Try

            Dim apikey = "Mzc2ZjM3NjE1NTRmNzg2NDQ4Njg1MTQzNzI0MjZkMzE="
            Dim message = "You Have an Appointment on " + lblAppointAppDate.Text
            Dim numbers = phone
            Dim strGet As String
            Dim senderName = "Kembima"
            Dim url As String = "https://api.txtlocal.com/send/?"

            strGet = url + "apikey=" + apikey _
                    + "&numbers=" + numbers _
                    + "&message=" + WebUtility.UrlEncode(message) _
                    + "&sender=" + senderName

            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString(strGet)

            MessageBox.Show("Send Message to Agent Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        command.Dispose()
        DbConnection.Close()
        reader.Close()







    End Sub
End Class