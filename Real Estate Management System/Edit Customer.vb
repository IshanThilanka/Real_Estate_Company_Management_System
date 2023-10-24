Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Edit_Customer

    Dim adapter As New MySqlDataAdapter
    Dim Table As New DataTable
    Private Sub btnbrowsecusimg_Click(sender As Object, e As EventArgs)


    End Sub

    Public Sub btnupdatecustomer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btndltcustomer_click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btncusfrmclose_Click(sender As Object, e As EventArgs) Handles btncusfrmclose.Click
        Customers.Show()
        Me.Close()


    End Sub

    Private Sub LinkLabelagreement_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)


    End Sub

    Private Sub Edit_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand
        Dim adapter As New MySqlDataAdapter
        Dim dr As MySqlDataReader
        Dim dt As New DataTable
        Dim name As String
        DBconnect()


        name = Customers.CustomerDataGridView.SelectedRows.Item(0).Cells(1).Value
        Dim query As String = "select `agreement_link` from `agreement` where `Name`=@name"
        command = New MySqlCommand(query, DbConnection)
        command.Parameters.AddWithValue("@name", name)
        dr = command.ExecuteReader()

        While dr.Read()

            LinkLabelagreement.Text = dr.Item("agreement_link")

        End While
        command.Dispose()
        DbConnection.Close()
        dr.Close()

    End Sub

    Private Sub btnbrowsecusimg_Click_1(sender As Object, e As EventArgs) Handles btnbrowsecusimg.Click

        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pcBoxEditcusImage.Image = Image.FromFile(opf.FileName)

        End If


    End Sub

    Private Sub btnupdatecustomer_Click_1(sender As Object, e As EventArgs) Handles btnupdatecustomer.Click
        Dim ID, name, address, email, phone, agreement As String
        Dim picture As Image

        ID = Customers.CustomerDataGridView.SelectedRows.Item(0).Cells(0).Value
        name = txtname.Text
        address = txtaddress.Text
        email = txtemail.Text
        agreement = txtagreement.Text
        phone = txtphone.Text
        picture = pcBoxEditcusImage.Image


        Table.Clear()

        If IsEmpty(name) Or IsEmpty(address) Or IsEmpty(email) Or IsEmpty(agreement) Or IsEmpty(phone) Then
            MessageBox.Show("All field are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)





        ElseIf MessageBox.Show("Are You sure you want to update the data? ", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DBconnect()

            Dim query As String = "UPDATE `customer` SET `Name`=@name, `Address`=@address,`Email`=@email,`Phone_Number`=@phone,`Agreement_Number`=@agreement,`cus_image` =@image WHERE `ID`=@ID "
            Dim command As MySqlCommand
            command = New MySqlCommand(query, DbConnection)



            Dim fSize As UInt32
            Dim ms As New System.IO.MemoryStream()
            pcBoxEditcusImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim imgArray() As Byte = ms.GetBuffer
            fSize = ms.Length
            ms.Close()


            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@address", address)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@phone", phone)
            command.Parameters.AddWithValue("@agreement", agreement)
            command.Parameters.AddWithValue("@image", imgArray)
            command.Parameters.AddWithValue("@ID", ID)



            If command.ExecuteNonQuery() Then

                MsgBox("Updated Successfully", vbOKOnly + vbInformation, "Success")
                Loadcustomer()




                txtname.Text = ""
                txtaddress.Text = ""
                txtemail.Text = ""
                txtphone.Text = ""
                txtagreement.Text = ""
                pcBoxEditcusImage.Image = Nothing
                LinkLabelagreement.Text = ""



            Else

                MsgBox("Error Occured", vbOKOnly + vbCritical, "Error")


            End If
        End If
    End Sub

    Private Sub btnDltCustomer_Click_1(sender As Object, e As EventArgs) Handles btnDltCustomer.Click
        MessageBox.Show("Are you sure you want to delete the data? ", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Windows.Forms.DialogResult.Yes Then

            DBconnect()

            Dim query As String = "delete from `customer` where `name`=@name;"

            Dim command As MySqlCommand
            command = New MySqlCommand(query, DbConnection)
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtname.Text

            command.ExecuteNonQuery()


            txtname.Text = ""
            txtaddress.Text = ""
            txtphone.Text = ""
            txtemail.Text = ""
            txtagreement.Text = ""
            pcBoxEditcusImage.Image = Nothing
            Customers.btncusEdit.Visible = False
            LinkLabelagreement.Text = ""

            If Customers.CustomerDataGridView.SelectedRows.Count > 0 Then
                For i As Integer = Customers.CustomerDataGridView.SelectedRows.Count - 1 To 0 Step -1
                    Customers.CustomerDataGridView.Rows.RemoveAt(Customers.CustomerDataGridView.SelectedRows(i).Index)
                    MsgBox("Customer removed successfully", vbOKOnly + vbInformation, "success")
                    Customers.lblCusname.Visible = False
                    Customers.lblcutaddress.Visible = False
                    Customers.lblcusemail.Visible = False
                    Customers.lblcusmobile.Visible = False
                    Customers.picboxcustomer.Image = Nothing




                Next
            Else
                MessageBox.Show("Customer not removed")
            End If


            Me.Hide()



        End If
    End Sub

    Private Sub LinkLabelagreement_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelagreement.LinkClicked
        Process.Start(LinkLabelagreement.Text)
    End Sub
End Class