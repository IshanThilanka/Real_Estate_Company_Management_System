

Imports MySql.Data.MySqlClient
Public Class AddAgent


    Dim adapter As New MySqlDataAdapter
    Dim Table As New DataTable

    Private Sub btnbrowseAgesimg_Click_1(sender As Object, e As EventArgs) Handles btnbrowseAgeimg.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pcBoxAddAgeImage.Image = Image.FromFile(opf.FileName)

        End If
    End Sub


    Private Sub btnaddAgent_Click_1(sender As Object, e As EventArgs) Handles btnaddAgent.Click

        Dim name, address, email, phone, agreement As String
        Dim picture As Image

        name = txtname.Text
        address = txtaddress.Text
        email = txtemail.Text
        phone = txtphone.Text
        picture = pcBoxAddAgeImage.Image





        If IsEmpty(name) Or IsEmpty(address) Or IsEmpty(email) Or IsEmpty(phone) Then
            MessageBox.Show("All field are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)



        ElseIf Not Validename(name) Or Not Validmail(email) Then
            MessageBox.Show("please Check the Name and Email", "Error Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not Validphone(phone) Then
            MessageBox.Show("Please Check the Phone Number", "Error Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DBconnect() Then

            Dim command As New MySqlCommand("INSERT INTO `agent`(`Name`,`Address`,`Email`,`Phone_Number`,`Image`) VALUES (@name,@address,@email,@phone,@image)", DbConnection)


            Dim fSize As UInt32
            Dim ms As New System.IO.MemoryStream()
            pcBoxAddAgeImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim imgArray() As Byte = ms.GetBuffer
            fSize = ms.Length
            ms.Close()


            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@address", address)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@phone", phone)

            command.Parameters.AddWithValue("@image", imgArray)




            If command.ExecuteNonQuery() = 1 Then

                MsgBox("New Agent Added Successfully", vbOKOnly + vbInformation, "Success")
                txtname.Text = ""
                txtaddress.Text = ""
                txtemail.Text = ""
                txtphone.Text = ""
                txtphone.Text = ""

                pcBoxAddAgeImage.Image = Nothing


                LoadaAgents()
            Else

                MsgBox("Error Occured", vbOKOnly + vbCritical, "Error")

                txtname.Text = ""
                txtaddress.Text = ""
                txtemail.Text = ""
                txtphone.Text = ""



            End If

        End If




    End Sub

    Private Sub btncusfrmclose_Click(sender As Object, e As EventArgs) Handles btncusfrmclose.Click
        Agents.Show()
        Me.Close()

    End Sub
End Class










