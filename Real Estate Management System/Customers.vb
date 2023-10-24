
Imports MySql.Data.MySqlClient



Public Class Customers
    Public command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Loadcustomer()

        lbltime.Text = System.DateTime.Now.ToShortTimeString
        lbldate.Text = System.DateTime.Now.ToLongDateString


    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs)
        Add_Customers.Show()
    End Sub


    Public Function getimage(ByVal id As String) As System.IO.MemoryStream
        Try
            DBconnect()


            Dim query As String = "select `cus_image` from `customer` where `id`=@id"
            command = New MySqlCommand(query, DbConnection)
            command.Parameters.AddWithValue("@id", id)
            dr = command.ExecuteReader()
            dr.Read()
            Dim imgarray() As Byte = dr.Item("cus_image")
            Dim ms As New IO.MemoryStream(imgarray)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub




    Private Sub CustomerDataGridView_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellContentClick
        Try
            If CustomerDataGridView.SelectedRows.Count > 0 Then
                ' customerdatagrid.show()
                picboxcustomer.Image = Image.FromStream(getimage(CustomerDataGridView.SelectedRows.Item(0).Cells(0).Value))
                lblCusname.Text = CustomerDataGridView.SelectedRows.Item(0).Cells(1).Value
                lblcusemail.Text = CustomerDataGridView.SelectedRows.Item(0).Cells(3).Value
                lblcusmobile.Text = CustomerDataGridView.SelectedRows.Item(0).Cells(4).Value
                lblcutaddress.Text = CustomerDataGridView.SelectedRows.Item(0).Cells(2).Value


                btncusEdit.Visible = True
                lblcutaddress.Visible = True
                lblCusname.Visible = True
                lblcusemail.Visible = True
                lblcusmobile.Visible = True

                Me.Refresh()
                command.Dispose()
                DbConnection.Close()
                dr.Close()

            End If

        Finally
        End Try
    End Sub

    Private Sub btncusEdit_Click_1(sender As Object, e As EventArgs) Handles btncusEdit.Click

        Edit_Customer.Show()


        Try
            If CustomerDataGridView.SelectedRows.Count > 0 Then
                ' customerdatagrid.show()
                Edit_Customer.pcBoxEditcusImage.Image = Image.FromStream(getimage(CustomerDataGridView.SelectedRows.Item(0).Cells(0).Value))
                Edit_Customer.txtname.Text = CustomerDataGridView.SelectedRows.Item(0).Cells(1).Value
                Edit_Customer.txtaddress.Text = CustomerDataGridView.SelectedRows.Item(0).Cells(2).Value
                Edit_Customer.txtemail.Text = CustomerDataGridView.SelectedRows.Item(0).Cells(3).Value
                Edit_Customer.txtphone.Text = CustomerDataGridView.SelectedRows.Item(0).Cells(4).Value
                Edit_Customer.txtagreement.Text = CustomerDataGridView.SelectedRows.Item(0).Cells(5).Value

                command.Dispose()
                DbConnection.Close()
                dr.Close()

            End If

        Finally
        End Try
    End Sub

    Private Sub btnreset_Click_1(sender As Object, e As EventArgs) Handles btnreset.Click
        txtSearchBox.Text = ""
        Loadcustomer()

    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        Dim datagrid2 As DataGridView = CustomerDataGridView
        CustomerDataGridView.Rows.Clear()

        Try
            DBconnect()


            adapter = New MySqlDataAdapter("Select * from customer where  Name Like '%" & txtSearchBox.Text & "%'", DbConnection)



            Dim dt As New DataTable
            adapter.Fill(dt)




            For i = 0 To dt.Rows.Count - 1



                datagrid2.Rows.Add()
                datagrid2.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
                datagrid2.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
                datagrid2.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
                datagrid2.Rows(i).Cells(3).Value = dt.Rows(i).Item(3).ToString
                datagrid2.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
                datagrid2.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString
                datagrid2.Rows(i).Cells(6).Value = dt.Rows(i).Item(6).ToString

            Next




            command.Dispose()
            DbConnection.Close()
            dt.Dispose()


        Catch
        End Try

    End Sub
End Class