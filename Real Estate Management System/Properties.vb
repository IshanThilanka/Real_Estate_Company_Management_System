
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class Properties

    Public command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public datagrid As DataGridView = PropertyDataGridView

    Public Sub properties_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As String
        Loadproerty()
        PropertyDataGridView.ClearSelection()


    End Sub

    Private Function getImage(ByVal ID As String) As System.IO.MemoryStream
        Try
            DBconnect()


            Dim query As String = "SELECT `Image` FROM `property` WHERE `ID`=@ID"
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


    Private Sub btnviewappointments_Click_2(sender As Object, e As EventArgs)

        'frmDisplayAppointment.Show()
    End Sub



    Private Sub btncusfrmclose_Click(sender As Object, e As EventArgs)
        Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Dim datagrid As DataGridView = PropertyDataGridView

        Try
            DBconnect()


            adapter = New MySqlDataAdapter("  Select * from Property where  Status = 'Sold' ", DbConnection)



            Dim dt As New DataTable
            adapter.Fill(dt)




            For i = 0 To dt.Rows.Count - 1



                datagrid.Rows.Add()
                datagrid.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
                datagrid.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
                datagrid.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
                datagrid.Rows(i).Cells(3).Value = dt.Rows(i).Item(3).ToString
                datagrid.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
                datagrid.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString
                datagrid.Rows(i).Cells(6).Value = dt.Rows(i).Item(6).ToString

            Next


            command.Dispose()
            DbConnection.Close()
            dt.Dispose()
        Catch

        End Try
    End Sub



    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        Dim datagrid As DataGridView = PropertyDataGridView

        PropertyDataGridView.Rows.Clear()

        Try
            DBconnect()


            adapter = New MySqlDataAdapter("Select * from property where  Name Like '%" & txtSearchBox.Text & "%' or 
            Status like '%" & txtSearchBox.Text & "%' or 
            AgentID like '%" & txtSearchBox.Text & "%'Or Type like '%" & txtSearchBox.Text & "%'", DbConnection)



            Dim dt As New DataTable
            adapter.Fill(dt)




            For i = 0 To dt.Rows.Count - 1



                datagrid.Rows.Add()
                datagrid.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
                datagrid.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
                datagrid.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
                datagrid.Rows(i).Cells(3).Value = dt.Rows(i).Item(3).ToString
                datagrid.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
                datagrid.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString
                datagrid.Rows(i).Cells(6).Value = dt.Rows(i).Item(6).ToString

            Next

            command.Dispose()
            DbConnection.Close()
            dt.Dispose()
        Catch


        End Try
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub PropertyDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnViewProperty_Click_2(sender As Object, e As EventArgs) Handles btnViewProperty.Click
        PropertyData.Show()

        Try
            If PropertyDataGridView.SelectedRows.Count > 0 Then
                PropertyData.Show()
                PropertyData.pcEditBoxAddImage.Image = Image.FromStream(getImage(PropertyDataGridView.SelectedRows.Item(0).Cells(0).Value))
                PropertyData.txtPropertyID.Text = PropertyDataGridView.SelectedRows.Item(0).Cells(0).Value
                PropertyData.txtEditPropertyType.Text = PropertyDataGridView.SelectedRows.Item(0).Cells(1).Value
                PropertyData.txtEditPropertyName.Text = PropertyDataGridView.SelectedRows.Item(0).Cells(2).Value
                PropertyData.txtEditDescription.Text = PropertyDataGridView.SelectedRows.Item(0).Cells(3).Value
                PropertyData.txtEditPrice.Text = PropertyDataGridView.SelectedRows.Item(0).Cells(4).Value
                PropertyData.lblstatus.Text = PropertyDataGridView.SelectedRows.Item(0).Cells(5).Value
                PropertyData.txtEditAgentID.Text = PropertyDataGridView.SelectedRows.Item(0).Cells(6).Value

            End If
            command.Dispose()
            DbConnection.Close()

        Finally
        End Try


    End Sub

    Private Sub cmbAgentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAgentID.SelectedIndexChanged
        Dim datagrid As DataGridView = PropertyDataGridView

        PropertyDataGridView.Rows.Clear()

        Try
            DBconnect()

            adapter = New MySqlDataAdapter("Select * from property where  AgentID Like  '%" & cmbAgentID.Text & "%'", DbConnection)


            Dim dt As New DataTable
            adapter.Fill(dt)



            For i = 0 To dt.Rows.Count - 1



                datagrid.Rows.Add()
                datagrid.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
                datagrid.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
                datagrid.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
                datagrid.Rows(i).Cells(3).Value = dt.Rows(i).Item(3).ToString
                datagrid.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
                datagrid.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString
                datagrid.Rows(i).Cells(6).Value = dt.Rows(i).Item(6).ToString

            Next



            command.Dispose()
            DbConnection.Close()
            dt.Dispose()
        Catch

        End Try
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        Dim datagrid As DataGridView = PropertyDataGridView

        PropertyDataGridView.Rows.Clear()

        Try
            DBconnect()

            adapter = New MySqlDataAdapter("  Select * from Property where  Status ='" & cmbStatus.Text & "'", DbConnection)

            Dim dt As New DataTable
            adapter.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                datagrid.Rows.Add()
                datagrid.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
                datagrid.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
                datagrid.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
                datagrid.Rows(i).Cells(3).Value = dt.Rows(i).Item(3).ToString
                datagrid.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
                datagrid.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString
                datagrid.Rows(i).Cells(6).Value = dt.Rows(i).Item(6).ToString

            Next

            command.Dispose()
            DbConnection.Close()
            dt.Dispose()
        Catch

        End Try
    End Sub

    Private Sub btnclearFilter_Click_1(sender As Object, e As EventArgs) Handles btnclearFilter.Click
        cmbAgentID.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1

        Loadproerty()

    End Sub

    Private Sub btnviewappointments_Click_1(sender As Object, e As EventArgs) Handles btnviewappointments.Click
        ViewAppointments.Show()
    End Sub


    Private Sub btnAddProperty_Click_2(sender As Object, e As EventArgs) Handles btnAddProperty.Click
        Add_Property.Show()
    End Sub
End Class