


Imports MySql.Data.MySqlClient

Public Class Sales



    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelcusdetails.BackColor = Color.FromArgb(120, 0, 0, 0)
        PanelPropdetail.BackColor = Color.FromArgb(120, 0, 0, 0)
        lbltime.Text = System.DateTime.Now.ToShortTimeString
        lbldate.Text = System.DateTime.Now.ToLongDateString

        'If DBconnect() Then
        '    Dim cmd As New MySqlCommand("select * from property Where Status='Unsold'", DbConnection)
        '    Dim adapter As New MySqlDataAdapter(cmd)
        '    Dim table As New DataTable()
        '    adapter.Fill(table)

        '    ComboBoxPropID.DisplayMember = "Name"
        '    ComboBoxPropID.ValueMember = "ID"
        '    ComboBoxPropID.DataSource = table





        'End If


        salescombo()

    End Sub


    Private Sub ComboBoxPropID_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncusfrmclose_Click(sender As Object, e As EventArgs) Handles btncusfrmclose.Click
        Me.Hide()

    End Sub

    '   




    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click




        Dim PropID, PropName, Price, dateTime As String

        PropID = txtpropID.Text
        PropName = ComboBoxPropID.SelectedValue
        Price = txtprice.Text
        If IsEmpty(PropID) Or IsEmpty(Price) Then
            MsgBox("All Fields Required", vbOKOnly + vbExclamation, "Error")
        ElseIf Not isDigit(Price) Then
            MsgBox("Price Not valid", vbOKOnly + vbExclamation, "Error")
        Else


            lblcus.BackColor = Color.Navy
            lblcus.ForeColor = Color.White
            lblprop.BackColor = Color.White
            lblprop.ForeColor = Color.Black
            PanelPropdetail.Visible = False
            panelcusdetails.Visible = True



        End If



    End Sub



    Public Sub btnAddbewsale_Click(sender As Object, e As EventArgs) Handles btnAddbewsale.Click
        Dim Agreement, name, address, email, phone, PropID, PropName, Price, dateTime, agreementlink As String
        Dim picture As Image

        PropID = txtpropID.Text
        PropName = ComboBoxPropID.SelectedItem
        Price = txtprice.Text
        dateTime = DateTimePicker.Value.ToShortDateString
        name = txtname.Text
        address = txtaddress.Text
        email = txtemail.Text
        Agreement = txtagreement.Text
        phone = txtphone.Text
        picture = pcBoxAddcusImage.Image
        agreementlink = txtagreementlink.Text


        If IsEmpty(name) Or IsEmpty(address) Or IsEmpty(email) Or IsEmpty(Agreement) Or IsEmpty(phone) Then
            MessageBox.Show("All field are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not Validename(name) Or Not Validmail(email) Then
            MessageBox.Show("please Check the Name and Email", "Error Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not Validphone(phone) Then
            MessageBox.Show("Please Check the Phone Number", "Error Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf Not isDigit(Agreement) Then
            MsgBox("Agreement Number Not valid", vbOKOnly + vbExclamation, "Error")

        ElseIf DBconnect() Then


            Dim sql As String
            Dim result As Integer
            Dim command As New MySqlCommand
            sql = "INSERT INTO `sales`(`Property_ID`,`Property_Name`, `Customer_Name`,`Price`,`Date`,`Agreemenr_Number`) VALUES (@propID,@propName,@cusname,@price,@date,@agreement) LIMIT 1"

            command.CommandText = sql
            command.Connection = DbConnection


            command.Parameters.AddWithValue("@propID", PropID)
            command.Parameters.AddWithValue("@propName", PropName)
            command.Parameters.AddWithValue("@price", Price)
            command.Parameters.AddWithValue("@cusname", name)
            command.Parameters.AddWithValue("@date", dateTime)
            command.Parameters.AddWithValue("@agreement", Agreement)

            dashboarddata()

            result = command.ExecuteNonQuery()
            If result = 1 Then

                LoadaSales()

                txtname.Text = ""
                txtprice.Text = ""
                txtagreement.Text = ""

                ComboBoxPropID.SelectedIndex = -1

                sql = "UPDATE `property` SET Status='Sold' WHERE ID=@ID"
                command.Parameters.AddWithValue("@ID", PropID)

                command.CommandText = sql
                command.Connection = DbConnection
                command.ExecuteNonQuery()
                Loadproerty()

                DBconnect()
                sql = "INSERT INTO `customer`(`Name`,`Address`,`Email`,`Phone_Number`,`Agreement_Number`,`cus_image`) VALUES (@name,@address,@email,@phone,@agreement,@image)"


                Dim fSize As UInt32
                Dim ms As New System.IO.MemoryStream()
                pcBoxAddcusImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim imgArray() As Byte = ms.GetBuffer
                fSize = ms.Length
                ms.Close()


                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@address", address)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@phone", phone)

                command.Parameters.AddWithValue("@image", imgArray)


                command.CommandText = sql
                command.Connection = DbConnection

                If command.ExecuteNonQuery() = 1 Then
                    Loadcustomer()
                    SalesSum()
                    dashboarddata()
                    MsgBox("New Sale Added", vbOKOnly + vbInformation, "Success")
                    txtname.Text = ""
                    txtaddress.Text = ""
                    txtemail.Text = ""
                    txtphone.Text = ""
                    txtphone.Text = ""
                    txtagreement.Text = ""
                    pcBoxAddcusImage.Image = Nothing
                    txtagreementlink.Text = ""



                    DBconnect()

                    sql = "INSERT INTO `agreement`( `Agreemenr_Number`, `Name`,`Property_Name`, `Agreement_Link`) VALUES (@Anumber,@Name,@propName,@AgLink)"

                    command.Parameters.AddWithValue("@Anumber", Agreement)
                    command.Parameters.AddWithValue("@AgLink", agreementlink)



                    command.CommandText = sql
                    command.Connection = DbConnection
                    command.ExecuteNonQuery()
                    LoadAgreements()
                Else

                    MsgBox("Error Occured", vbOKOnly + vbCritical, "Error")

                    txtname.Text = ""
                    txtaddress.Text = ""
                    txtemail.Text = ""
                    txtphone.Text = ""
                    txtagreement.Text = ""
                    txtagreementlink.Text = ""

                End If

            End If

        End If





    End Sub

    Private Sub btnbrowsecusimg_Click(sender As Object, e As EventArgs) Handles btnbrowsecusimg.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pcBoxAddcusImage.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        lblcus.BackColor = Color.White
        lblprop.BackColor = Color.Navy
        lblcus.ForeColor = Color.Black
        lblprop.ForeColor = Color.White
        PanelPropdetail.Visible = True
        panelcusdetails.Visible = False

    End Sub



    Private Sub ComboBoxPropID_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxPropID.SelectedIndexChanged
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader
        Dim Name = ComboBoxPropID.SelectedItem


        If DBconnect() Then
            Dim query As String = "SELECT  `Price`,`ID` FROM property WHERE Name=@name"
            command = New MySqlCommand(query, DbConnection)
            command.Parameters.AddWithValue("@name", Name)
            reader = command.ExecuteReader()



            While reader.Read()
                txtprice.Text = reader("Price").ToString()
                txtpropID.Text = reader("ID")
            End While
            reader.Close()


        End If

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        PastSales.Show()
    End Sub
End Class