
Imports MySql.Data.MySqlClient

Public Class test
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Loadcustomer()
        '  DBconnect()

        'Dim DT As New DataTable



        'Dim query As String = "SELECT `ID`,`Name`, `Address`, `Email`, `Phone_Number`, `Agreement_ID`  FROM `customer` WHERE 1"

        'adapter = New MySqlDataAdapter(query, DbConnection)



        'adapter.Fill(DT)

        'For i = 0 To DT.Rows.Count - 1


        '    DataGridView1.ColumnCount = 6
        '    DataGridView1.Columns(0).Name = "id"
        '    DataGridView1.Columns(1).Name = " name"
        '    DataGridView1.Columns(2).Name = "address"
        '    DataGridView1.Columns(3).Name = "email"
        '    DataGridView1.Columns(4).Name = "phone number"
        '    DataGridView1.Columns(5).Name = "agreement_id"


        '    DataGridView1.Rows.Add()
        '    DataGridView1.Rows(i).Cells(0).Value = DT.Rows(i).Item(0).ToString
        '    DataGridView1.Rows(i).Cells(1).Value = DT.Rows(i).Item(1).ToString
        '    DataGridView1.Rows(i).Cells(2).Value = DT.Rows(i).Item(2).ToString
        '    DataGridView1.Rows(i).Cells(3).Value = DT.Rows(i).Item(3).ToString
        '    DataGridView1.Rows(i).Cells(4).Value = DT.Rows(i).Item(4).ToString
        '    DataGridView1.Rows(i).Cells(5).Value = DT.Rows(i).Item(5).ToString



        'Next


        'adapter.Dispose()
        'DbConnection.Close()
        'datagrid2.ClearSelection()























    End Sub
End Class