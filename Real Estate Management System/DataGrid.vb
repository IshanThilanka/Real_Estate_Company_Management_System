Imports MySql.Data.MySqlClient
Module DataGrid





    Public datagrid As DataGridView = Properties.PropertyDataGridView
    Public datagrid2 As DataGridView = Customers.CustomerDataGridView
    Public datagrid3 As DataGridView = ViewAppointments.AppointmentDataGrid
    Public datagrid4 As DataGridView = Agents.AgentDataGrid
    Public datagrid5 As DataGridView = PastSales.PastsalesDataGrid
    Public datagrid6 As DataGridView = Agreements.AgreementDataGrid



    Public Sub Loadproerty()

        Dim adapter As New MySqlDataAdapter
        Dim command As New MySqlCommand
        Dim dt As New DataTable

        Try

            DBconnect()




            Dim query As String = "SELECT `ID`, `Type`, `Name`, `Description`, `Price`, `Status`, `AgentID` FROM `property` WHERE 1"
            adapter = New MySqlDataAdapter(query, DbConnection)



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

            dt.Clear()
            adapter.Dispose()
            DbConnection.Close()



        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Public Sub Loadcustomer()

        Dim Cadapter As New MySqlDataAdapter
        Dim cmd As New MySqlCommand



        Try

            DBconnect()

            Dim DT As New DataTable



            Dim query As String = "SELECT `ID`,`Name`, `Address`, `Email`, `Phone_Number`, `Agreement_Number`  FROM `customer` WHERE 1"

            Cadapter = New MySqlDataAdapter(query, DbConnection)



            Cadapter.Fill(DT)


            For i = 0 To DT.Rows.Count - 1



                datagrid2.Rows.Add()
                datagrid2.Rows(i).Cells(0).Value = DT.Rows(i).Item(0).ToString
                datagrid2.Rows(i).Cells(1).Value = DT.Rows(i).Item(1).ToString
                datagrid2.Rows(i).Cells(2).Value = DT.Rows(i).Item(2).ToString
                datagrid2.Rows(i).Cells(3).Value = DT.Rows(i).Item(3).ToString
                datagrid2.Rows(i).Cells(4).Value = DT.Rows(i).Item(4).ToString
                datagrid2.Rows(i).Cells(5).Value = DT.Rows(i).Item(5).ToString



            Next

            DT.Clear()
            Cadapter.Dispose()
            DbConnection.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub Loadappointments()
        Dim commnd As New MySqlCommand
        Dim DA As New MySqlDataAdapter
        Try

            DBconnect()

            Dim table As New DataTable



            Dim query As String = "SELECT  `CustomerName`, `PropertyID`, `AgentID`, `AppointmentDate`,`AppointmentStatus` FROM `appointment` WHERE 1"

            DA = New MySqlDataAdapter(query, DbConnection)



            DA.Fill(table)






            For i = 0 To table.Rows.Count - 1




                datagrid3.Rows.Add()
                datagrid3.Rows(i).Cells(0).Value = table.Rows(i).Item(0).ToString
                datagrid3.Rows(i).Cells(1).Value = table.Rows(i).Item(1).ToString
                datagrid3.Rows(i).Cells(2).Value = table.Rows(i).Item(2).ToString
                datagrid3.Rows(i).Cells(3).Value = table.Rows(i).Item(3).ToString
                datagrid3.Rows(i).Cells(4).Value = table.Rows(i).Item(4).ToString
                'datagrid3.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString



            Next


            table.Clear()
            DA.Dispose()
            DbConnection.Close()




        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub


    Public Sub LoadaAgents()
        Dim commnd As New MySqlCommand
        Dim dataadapter As New MySqlDataAdapter
        Try

            DBconnect()

            Dim datatable As New DataTable



            Dim query As String = "SELECT  `Agent_ID`,`Name` FROM `agent` WHERE 1"

            dataadapter = New MySqlDataAdapter(query, DbConnection)



            dataadapter.Fill(datatable)






            For i = 0 To datatable.Rows.Count - 1




                datagrid4.Rows.Add()
                datagrid4.Rows(i).Cells(0).Value = datatable.Rows(i).Item(0).ToString
                datagrid4.Rows(i).Cells(1).Value = datatable.Rows(i).Item(1).ToString
                'datagrid4.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
                ' datagrid4.Rows(i).Cells(3).Value = dt.Rows(i).Item(3).ToString
                ' datagrid4.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
                'datagrid4.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString



            Next


            datatable.Clear()
            dataadapter.Dispose()
            DbConnection.Close()




        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub LoadaSales()
        Dim newcommnd As New MySqlCommand
        Dim newdataadapter As New MySqlDataAdapter
        Try

            DBconnect()

            Dim newdatatable As New DataTable



            Dim query As String = "SELECT `Property_ID`, `Property_Name`, `Customer_Name`, `Price`, `Date` FROM `sales` WHERE 1"

            newdataadapter = New MySqlDataAdapter(query, DbConnection)

            newdataadapter.Fill(newdatatable)






            For i = 0 To newdatatable.Rows.Count - 1




                datagrid5.Rows.Add()
                datagrid5.Rows(i).Cells(0).Value = newdatatable.Rows(i).Item(0).ToString
                datagrid5.Rows(i).Cells(1).Value = newdatatable.Rows(i).Item(1).ToString
                datagrid5.Rows(i).Cells(2).Value = newdatatable.Rows(i).Item(2).ToString
                datagrid5.Rows(i).Cells(3).Value = newdatatable.Rows(i).Item(3).ToString
                datagrid5.Rows(i).Cells(4).Value = newdatatable.Rows(i).Item(4).ToString
                'datagrid4.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString



            Next


            newdatatable.Clear()
            newdataadapter.Dispose()
            DbConnection.Close()




        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub LoadAgreements()
        Dim Acommnd As New MySqlCommand
        Dim Adataadapter As New MySqlDataAdapter
        Try

            DBconnect()

            Dim Adatatable As New DataTable



            Dim query As String = "SELECT  `Agreemenr_Number`, `Name`, `Property_Name`, `Agreement_Link` FROM `agreement` WHERE 1"

            Adataadapter = New MySqlDataAdapter(query, DbConnection)

            Adataadapter.Fill(Adatatable)






            For i = 0 To Adatatable.Rows.Count - 1




                datagrid6.Rows.Add()
                datagrid6.Rows(i).Cells(0).Value = Adatatable.Rows(i).Item(0).ToString
                datagrid6.Rows(i).Cells(1).Value = Adatatable.Rows(i).Item(2).ToString
                datagrid6.Rows(i).Cells(2).Value = Adatatable.Rows(i).Item(1).ToString
                datagrid6.Rows(i).Cells(3).Value = Adatatable.Rows(i).Item(3).ToString
                ' datagrid5.Rows(i).Cells(4).Value = newdatatable.Rows(i).Item(4).ToString
                'datagrid4.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString



            Next


            Adatatable.Clear()
            Adataadapter.Dispose()
            DbConnection.Close()




        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try






























    End Sub


























End Module



