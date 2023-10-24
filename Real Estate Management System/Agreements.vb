Imports MySql.Data.MySqlClient
Public Class Agreements
    Private Sub Agreements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAgreements()

        lbltime.Text = System.DateTime.Now.ToShortTimeString
        lbldate.Text = System.DateTime.Now.ToLongDateString
    End Sub

    Private Sub btncusfrmclose_Click(sender As Object, e As EventArgs) Handles btncusfrmclose.Click
        Me.Hide()

    End Sub

    Private Sub txtSearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBox.TextChanged
        Dim datagrid2 As DataGridView = AgreementDataGrid
        AgreementDataGrid.Rows.Clear()
        Dim adapter As MySqlDataAdapter
        Dim cmd As New MySqlCommand
        Try
            DBconnect()


            adapter = New MySqlDataAdapter("Select * from Agreement where  Name Like '%" & txtSearchBox.Text & "%' 
or Property_Name Like '%" & txtSearchBox.Text & "%' or Agreemenr_Number Like '%" & txtSearchBox.Text & "%'", DbConnection)



            Dim dt As New DataTable
            adapter.Fill(dt)




            For i = 0 To dt.Rows.Count - 1



                datagrid2.Rows.Add()
                datagrid2.Rows(i).Cells(0).Value = dt.Rows(i).Item(1).ToString
                datagrid2.Rows(i).Cells(1).Value = dt.Rows(i).Item(3).ToString
                datagrid2.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
                datagrid2.Rows(i).Cells(3).Value = dt.Rows(i).Item(4).ToString


            Next





            DbConnection.Close()
            dt.Dispose()


        Catch

            '  MessageBox.Show("No Information", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Loadproerty()

        End Try
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtSearchBox.Text = ""
        LoadAgreements()
    End Sub
End Class