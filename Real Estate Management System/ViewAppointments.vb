Public Class ViewAppointments
    Private Sub ViewAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadappointments()
    End Sub

    Private Sub btnViewAppDetails_Click(sender As Object, e As EventArgs) Handles btnViewAppDetails.Click


        Try
            If AppointmentDataGrid.SelectedRows.Count > 0 Then
                AppoinmentDetails.Show()



                AppoinmentDetails.lblAppointCusName.Text = AppointmentDataGrid.SelectedRows.Item(0).Cells(0).Value
                AppoinmentDetails.lblAppointPropID.Text = AppointmentDataGrid.SelectedRows.Item(0).Cells(1).Value
                AppoinmentDetails.lblAppointAgentID.Text = AppointmentDataGrid.SelectedRows.Item(0).Cells(2).Value
                AppoinmentDetails.lblAppointAppDate.Text = AppointmentDataGrid.SelectedRows.Item(0).Cells(3).Value
                AppoinmentDetails.lblappontStatus.Text = AppointmentDataGrid.SelectedRows.Item(0).Cells(4).Value


            End If

            DbConnection.Close()
        Finally
        End Try
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Properties.Show()
        Me.Hide()

    End Sub
End Class