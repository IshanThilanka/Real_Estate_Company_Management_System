Imports MySql.Data.MySqlClient
Imports System.IO


Public Class PropertyData


    Dim adapter As New MySqlDataAdapter
    Dim table As New DataTable



    Private Sub btnEditPropertyImage_Click(sender As Object, e As EventArgs) Handles btnEditPropertyImage.Click

        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            pcEditBoxAddImage.Image = Image.FromFile(opf.FileName)

        End If


    End Sub

    Public Sub btnUpdateProperty_Click(sender As Object, e As EventArgs) Handles btnUpdateProperty.Click



        Dim PropertyType, Pname, Description, Price, AgentID, PropertyID, status, result As String
        Dim picture As Image

        PropertyID = txtPropertyID.Text
        PropertyType = txtEditPropertyType.Text
        Pname = txtEditPropertyName.Text
        Description = txtEditDescription.Text
        Price = txtEditPrice.Text
        status = lblstatus.Text
        AgentID = txtEditAgentID.Text
        picture = pcEditBoxAddImage.Image


        table.Clear()
        If IsEmpty(PropertyID) Or IsEmpty(PropertyType) Or IsEmpty(Pname) Or IsEmpty(Description) Or IsEmpty(Price) Or IsEmpty(status) Or IsEmpty(AgentID) Then

            MessageBox.Show("All field are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf MessageBox.Show("Are You sure you want to update the data? ", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            DBconnect()




            Dim query As String = "UPDATE `property` SET `Type`=@type,`Name`=@name,`Description`=@desc,`Price`=@price,`Status`=@status,`AgentID`=@agent, `Image`=@image WHERE `ID`=@id"
            Dim command As MySqlCommand
            command = New MySqlCommand(query, DbConnection)



            Dim fsize As UInt32
            Dim ms As New System.IO.MemoryStream()
            pcEditBoxAddImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim imgArray() As Byte = ms.GetBuffer
            fsize = ms.Length
            ms.Close()



            command.Parameters.AddWithValue("@type", PropertyType)
            command.Parameters.AddWithValue("@name", Pname)
            command.Parameters.AddWithValue("@desc", Description)
            command.Parameters.AddWithValue("@price", Price)
            command.Parameters.AddWithValue("@status", status)
            command.Parameters.AddWithValue("@agent", AgentID)
            command.Parameters.AddWithValue("@image", imgArray)
            command.Parameters.AddWithValue("@id", PropertyID)


            If command.ExecuteNonQuery() Then

                MsgBox("Updated Successfully", vbOKOnly + vbInformation, "Success")
                Loadproerty()


                txtPropertyID.Text = ""
                txtEditPropertyName.Text = ""
                txtEditDescription.Text = ""
                txtEditPrice.Text = ""
                txtEditAgentID.Text = ""
                lblstatus.Text = ""
                txtEditPropertyType.Text = ""
                pcEditBoxAddImage.Image = Nothing


            Else
                MsgBox("Update Error", vbOKOnly + vbInformation, "Success")


            End If
        End If





    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Properties.Show()


    End Sub

    Private Sub btnRemoveProperty_Click(sender As Object, e As EventArgs) Handles btnRemoveProperty.Click
        If MessageBox.Show("Are You sure you want to delete the data? ", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If DBconnect() Then

                Dim query As String = "DELETE FROM `property` WHERE `ID`=@ID;"

                Dim command As MySqlCommand
                command = New MySqlCommand(query, DbConnection)
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = txtPropertyID.Text

                command.ExecuteNonQuery()

                txtPropertyID.Text = ""
                txtEditPropertyName.Text = ""
                txtEditDescription.Text = ""
                txtEditPrice.Text = ""
                txtEditAgentID.Text = ""
                lblstatus.Text = ""
                txtEditPropertyType.Text = ""
                pcEditBoxAddImage.Image = Nothing

                If Properties.PropertyDataGridView.SelectedRows.Count > 0 Then
                    For i As Integer = Properties.PropertyDataGridView.SelectedRows.Count - 1 To 0 Step -1
                        Properties.PropertyDataGridView.Rows.RemoveAt(Properties.PropertyDataGridView.SelectedRows(i).Index)
                        MsgBox("Property Deleted Successfully", vbOKOnly + vbInformation, "Success")
                    Next
                Else
                    MessageBox.Show("User Not Removed")
                End If


                Me.Hide()



            End If

        End If
    End Sub



    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs)
        Properties.Show()
        Me.Close()

    End Sub


    Private Sub btncusfrmclose_Click(sender As Object, e As EventArgs) Handles btncusfrmclose.Click
        Properties.Show()
        Me.Hide()

    End Sub

    'Private Sub ComboBoxStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxStatus.SelectedIndexChanged
    '    If MessageBox.Show("Are You sure you want to Add A sale? ", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        Sales_Prompt.Show()

    '        DBconnect()

    '        Dim command As New MySqlCommand(" INSERT INTO `sales`( `Property_Name`, `Customer_ID`, `Price`,  `Agreemenr_ID`) VALUES (@name,@CusID,@price,@agreemnt", DbConnection)


    '        command.Parameters.Add("@name", MySqlDbType.Int32).Value = txtEditPropertyName.Text
    '        command.Parameters.Add("@CusID", MySqlDbType.Int32).Value = Sales_Prompt.txtCusID.Text
    '        command.Parameters.Add("@price", MySqlDbType.Int32).Value = Sales_Prompt.txtPrice.Text
    '        command.Parameters.Add("@agreemnt", MySqlDbType.Int32).Value = Sales_Prompt.txtAgrementID.Text

    '        ' command.Parameters.Add("@DATE", MySqlDbType.DateTime).Value = order_date


    '        If command.ExecuteNonQuery() = 1 Then

    '            MsgBox("Success")
    '        End If
    '        Me.Hide()



    '    End If

    'End Sub
End Class