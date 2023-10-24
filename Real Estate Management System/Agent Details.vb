Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Agent_Details





    Dim adapter As New MySqlDataAdapter
    Dim Table As New DataTable
    Private Sub btnbrowseAgeimg_Click(sender As Object, e As EventArgs) Handles btnbrowseAgeimg.Click

        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pcBoxEditAgeImage.Image = Image.FromFile(opf.FileName)

        End If



    End Sub

    Public Sub btnupdatecustomer_Click(sender As Object, e As EventArgs) Handles btnupdatecustomer.Click
        Dim ID, name, address, email, phone As String
        Dim picture As Image

        ID = Agents.AgentDataGrid.SelectedRows.Item(0).Cells(0).Value
        name = txtname.Text
        address = txtaddress.Text
        email = txtemail.Text
        phone = txtphone.Text
        picture = pcBoxEditAgeImage.Image

        Table.Clear()

        If IsEmpty(name) Or IsEmpty(address) Or IsEmpty(email) Or IsEmpty(phone) Then
            MessageBox.Show("All field are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)




        ElseIf MessageBox.Show("Are You sure you want to update the data? ", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DBconnect()

            Dim query As String = "UPDATE `agent` SET `Name`=@name, `Address`=@address,`Email`=@email,`Phone_Number`=@phone, `Image` =@image WHERE Agent_ID=@ID "
            Dim command As MySqlCommand
            command = New MySqlCommand(query, DbConnection)



            Dim fSize As UInt32
            Dim ms As New System.IO.MemoryStream()
            pcBoxEditAgeImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim imgArray() As Byte = ms.GetBuffer
            fSize = ms.Length
            ms.Close()


            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@address", address)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@phone", phone)
            command.Parameters.AddWithValue("@image", imgArray)
            command.Parameters.AddWithValue("@ID", ID)



            If command.ExecuteNonQuery() Then

                MsgBox("Updated Successfully", vbOKOnly + vbInformation, "Success")
                LoadaAgents()




                txtname.Text = ""
                txtaddress.Text = ""
                txtemail.Text = ""
                txtphone.Text = ""
                pcBoxEditAgeImage.Image = Nothing




            Else

                MsgBox("Error Occured", vbOKOnly + vbCritical, "Error")


            End If
        End If
    End Sub

    Private Sub btndltcustomer_click(sender As Object, e As EventArgs) Handles btnDltAgent.Click
        MessageBox.Show("Are you sure you want to delete the data? ", "Delete Agent", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Windows.Forms.DialogResult.Yes Then

            DBconnect()

            Dim query As String = "delete from `agent` where `name`=@name;"

            Dim command As MySqlCommand
            command = New MySqlCommand(query, DbConnection)
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtname.Text

            command.ExecuteNonQuery()


            txtname.Text = ""
            txtaddress.Text = ""
            txtphone.Text = ""
            txtemail.Text = ""

            pcBoxEditAgeImage.Image = Nothing
            Customers.btncusEdit.Visible = False

            If Agents.AgentDataGrid.SelectedRows.Count > 0 Then
                For i As Integer = Agents.AgentDataGrid.SelectedRows.Count - 1 To 0 Step -1
                    Agents.AgentDataGrid.Rows.RemoveAt(Agents.AgentDataGrid.SelectedRows(i).Index)
                    MsgBox("Agent removed successfully", vbOKOnly + vbInformation, "success")
                    Agents.lblAgename.Visible = False
                    Agents.lblAgeemail.Visible = False
                    Agents.lblAgemobile.Visible = False
                    Agents.lblAgeaddress.Visible = False
                    Agents.picboxAgentimg.Image = Nothing




                Next
            Else
                MessageBox.Show("Agent not removed")
            End If


            Me.Hide()



        End If


    End Sub

    Private Sub btncusfrmclose_Click(sender As Object, e As EventArgs) Handles btncusfrmclose.Click
        Agents.Show()
        Me.Hide()


    End Sub
End Class


