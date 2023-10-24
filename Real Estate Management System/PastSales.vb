Imports MySql.Data.MySqlClient

Public Class PastSales
    Private Sub PastSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadaSales()
        lbltime.Text = System.DateTime.Now.ToShortTimeString
        lbldate.Text = System.DateTime.Now.ToLongDateString
    End Sub

    Private Sub btncusfrmclose_Click(sender As Object, e As EventArgs) Handles btncusfrmclose.Click
        Me.Hide()

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub








End Class