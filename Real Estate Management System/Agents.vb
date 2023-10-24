

Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging


Public Class Agents
    Public command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Private Sub Agents_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadaAgents()

        lbltime.Text = System.DateTime.Now.ToShortTimeString
        lbldate.Text = System.DateTime.Now.ToLongDateString


    End Sub

    'Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
    '    Add_Customers.Show()
    'End Sub


    Public Function getImage(ByVal ID As String) As System.IO.MemoryStream
        Try
            DBconnect()


            Dim query As String = "SELECT `Image` FROM `agent` WHERE Agent_ID=@ID"
            command = New MySqlCommand(query, DbConnection)
            command.Parameters.AddWithValue("@ID", ID)
            dr = command.ExecuteReader()
            dr.Read()
            Dim imgArray() As Byte = dr.Item("Image")
            Dim ms As New IO.MemoryStream(imgArray)

            command.Dispose()
            DbConnection.Close()
            dr.Close()
            Return ms
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function


    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs)
        Dashboard.Show()
        Me.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub btnAddAgent_Click_1(sender As Object, e As EventArgs) Handles btnAddAgent.Click
        AddAgent.Show()
    End Sub

    Private Sub btnAgeEdit_Click_1(sender As Object, e As EventArgs) Handles btnAgeEdit.Click

        DBconnect()
        Agent_Details.Show()
        Dim ID = AgentDataGrid.SelectedRows.Item(0).Cells(0).Value
        Dim query As String = "SELECT `Image` FROM `agent` WHERE `Agent_ID`=@ID"
        command = New MySqlCommand(query, DbConnection)
        command.Parameters.AddWithValue("@ID", ID)
        dr = command.ExecuteReader()





        DbConnection.Dispose()
        dr.Dispose()

        Try
            If AgentDataGrid.SelectedRows.Count > 0 Then
                ' CustomerDataGrid.Show()
                Agent_Details.pcBoxEditAgeImage.Image = Image.FromStream(getImage(AgentDataGrid.SelectedRows.Item(0).Cells(0).Value))
                Agent_Details.txtname.Text = lblAgename.Text
                Agent_Details.txtaddress.Text = lblAgeaddress.Text
                Agent_Details.txtemail.Text = lblAgeemail.Text
                Agent_Details.txtphone.Text = lblAgemobile.Text


                command.Dispose()
                DbConnection.Close()
                dr.Close()

            End If

        Finally
        End Try


    End Sub

    Private Sub AgentDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AgentDataGrid.CellContentClick


        DBconnect()

        Dim ID = AgentDataGrid.SelectedRows.Item(0).Cells(0).Value
        Dim query As String = "SELECT * FROM `agent` WHERE `Agent_ID`=@ID"
        command = New MySqlCommand(query, DbConnection)
        command.Parameters.AddWithValue("@ID", ID)
        dr = command.ExecuteReader()


        While dr.Read()

            lblAgename.Text = dr.Item("Name")
            lblAgeemail.Text = dr.Item("Email")
            lblAgemobile.Text = dr.Item("Phone_Number")
            lblAgeaddress.Text = dr.Item("Address")


        End While


        command.Dispose()
        DbConnection.Close()


        If AgentDataGrid.SelectedRows.Count > 0 Then
            ' CustomerDataGrid.Show()
            picboxAgentimg.Image = Image.FromStream(getImage(AgentDataGrid.SelectedRows.Item(0).Cells(0).Value))
            'lblAgename.Text = AgentDataGrid.SelectedRows.Item(0).Cells(1).Value
            'lblAgeemail.Text = AgentDataGrid.SelectedRows.Item(0).Cells(2).Value
            'lblAgemobile.Text = AgentDataGrid.SelectedRows.Item(0).Cells(3).Value
            'lblAgeaddress.Text = AgentDataGrid.SelectedRows.Item(0).Cells(4).Value


            btnAgeEdit.Visible = True
            lblAgeaddress.Visible = True
            lblAgename.Visible = True
            lblAgeemail.Visible = True
            lblAgemobile.Visible = True


        End If
        Me.Refresh()
        command.Dispose()
        DbConnection.Close()
        dr.Close()



    End Sub
End Class