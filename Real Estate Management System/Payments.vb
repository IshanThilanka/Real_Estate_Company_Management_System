Public Class Payments



    Dim aa, bb As Integer
    Dim sum As String
    Private Sub Payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aa = TextBox1.Text
        bb = TextBox2.Text


        sum = aa + bb
    End Sub
End Class