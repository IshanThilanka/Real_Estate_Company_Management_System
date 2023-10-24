Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Dashboard

    Dim PropertyName As String
    Dim Picture As Image
    Dim command As New MySqlCommand
    Dim dr As MySqlDataReader



    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim name As String
        name = lblpropname.Text
        lbladmin.Text = Login.txtUsername.Text














        SalesSum()
        propSum()

        dashboarddata()

    End Sub


    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles btnProperties.Click
        Properties.Show()
    End Sub

    Private Sub btnAdvertisements_Click(sender As Object, e As EventArgs) Handles btnAgents.Click
        Agents.Show()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Sales.Show()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Customers.Show()
    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnAgreement.Click
        Agreements.Show()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        About.Show()
    End Sub



    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Sales.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Guna2Panel5.Visible = True
        btnaddadmin.Visible = True
        btnsignout.Visible = True
        Timer1.Interval = 5000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2Panel5.Visible = False
        btnaddadmin.Visible = False
        btnsignout.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub btnaddadmin_Click(sender As Object, e As EventArgs) Handles btnaddadmin.Click

        CreateAccount.Show()
    End Sub

    Private Sub btnsignout_Click(sender As Object, e As EventArgs) Handles btnsignout.Click
        Close()

    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        PastSales.Show()
    End Sub


End Class