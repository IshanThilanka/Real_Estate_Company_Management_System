Imports MySql.Data.MySqlClient


Module SQLfunctions

    Public Sub SalesSum()


        If DBconnect() Then
            Dim cmd As New MySqlCommand
            cmd.CommandText = "select Sum(Price) As Total From sales"
            cmd.Connection = DbConnection
            Dim adapter As New MySqlDataAdapter
            Dim table As New DataTable()
            adapter.SelectCommand = cmd
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                Dashboard.lbloutputlTotalSales.Text = table.Rows(0)("Total").ToString()
            End If


        End If
    End Sub
    Public Sub propSum()
        If DBconnect() Then
            Dim cmd As New MySqlCommand
            cmd.CommandText = "select Sum(Price) As Total From property"
            cmd.Connection = DbConnection
            Dim adapter As New MySqlDataAdapter
            Dim table As New DataTable()
            adapter.SelectCommand = cmd
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                Dashboard.lblpropval.Text = table.Rows(0)("Total").ToString()
            End If


        End If








    End Sub







End Module
