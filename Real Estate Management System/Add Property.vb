Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Add_Property

    Public command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter(command)
    Dim table As New DataTable










    Private Sub btnCAccount_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncusfrmclose_Click(sender As Object, e As EventArgs) Handles btncusfrmclose.Click
        Properties.Show()
        Me.Close()

    End Sub

    Private Sub Add_Property_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Panel3.BackColor = Color.FromArgb(120, 0, 0, 0)
    End Sub

    Private Sub btnbrowseimg_Click(sender As Object, e As EventArgs) Handles btnbrowseimg.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pcBoxAddImage.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub btnCAccount_Click(sender As Object, e As EventArgs) Handles btnCAccount.Click

        Dim PropertyType, Pname, Description, Price, AgentID As String
        Dim picture As Image
        PropertyType = ComboboxPropType.SelectedItem
        Pname = txtPropertyname.Text
        Description = txtDescription.Text
        Price = txtPrice.Text
        AgentID = txtAgentID.Text
        picture = pcBoxAddImage.Image




        If IsEmpty(Pname) Or IsEmpty(Description) Or IsEmpty(Price) Or IsEmpty(AgentID) Then
            MessageBox.Show("All field are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not IsNumeric(Price) Then
            MessageBox.Show("Please Enter Valid Data.Check Price and Name Again", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not IsNumeric(Price) Then
            MessageBox.Show("Please Enter Valid Price.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            DBconnect()


            Dim sql As String
            Dim result As Integer

            Dim command As New MySqlCommand("INSERT INTO `Property`(`Type`,`Name`,`Description`,`Price`,`AgentID`,`Image`) VALUES (@type,@name,@desc,@price,@agentID,@image)", DbConnection)

            Dim fSize As UInt32
            Dim ms As New System.IO.MemoryStream()
            pcBoxAddImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim imgArray() As Byte = ms.GetBuffer
            fSize = ms.Length
            ms.Close()


            command.Parameters.AddWithValue("@type", PropertyType)
            command.Parameters.AddWithValue("@name", Pname)
            command.Parameters.AddWithValue("@desc", Description)
            command.Parameters.AddWithValue("@price", Price)
            command.Parameters.AddWithValue("@agentID", AgentID)
            command.Parameters.AddWithValue("@image", imgArray)





            'command.CommandText = sql
            'command.Connection = DbConnection
            'adapter.SelectCommand = command






            result = command.ExecuteNonQuery()
            If result = 1 Then
                MsgBox("New Property Added", vbOKOnly + vbInformation, "Success")



                ComboboxPropType.SelectedIndex = -1
                txtPropertyname.Text = ""
                txtDescription.Text = ""
                txtPrice.Text = ""
                txtAgentID.Text = ""
                pcBoxAddImage.Image = Nothing
                Loadproerty()
                propSum()

            Else
                MsgBox("Error Occured.Please Try Again", vbOKOnly + vbExclamation, "Error")


            End If


        End If
    End Sub
End Class