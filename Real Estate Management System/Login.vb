
Imports MySql.Data.MySqlClient
Imports BCrypt.Net.BCrypt


Public Class Login
    Dim command As MySqlCommand
    Dim table As DataTable



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Username, Password As String
        Username = txtUsername.Text
        Password = txtPassword.Text


        If IsEmpty(Username) Or IsEmpty(Password) Then
            MessageBox.Show("All field are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Encryptedlogin(Username, Password)

        End If



    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) 
        CreateAccount.Show()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If CheckBox1.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            txtPassword.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        GetCode.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub
End Class