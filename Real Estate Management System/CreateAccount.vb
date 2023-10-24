
Imports MySql.Data.MySqlClient
Imports BCrypt.Net.BCrypt
Imports System.Text
Public Class CreateAccount



    Public command As New MySqlCommand
    Dim adapter As New MySqlDataAdapter(command)

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2Panel1.BackColor = Color.FromArgb(120, 0, 0, 0)
        'Panel2.BackColor = Color.FromArgb(120, 0, 0, 0)
        'Guna2HtmlLabel1.ForeColor = Color.FromArgb(0, 120, 120, 0)

    End Sub

    Dim table As New DataTable

    Public Sub btnCAccount_Click(sender As Object, e As EventArgs) Handles btnCAccount.Click
        Dim Name, Email, Phone_no, Username, Password, RPassword As String
        Name = Trim(txtadminname.Text)
        Email = Trim(txtadminemail.Text)
        Phone_no = Trim(txtadminPno.Text)
        Username = Trim(txtadminusernam.Text)
        Password = Trim(txtadminrpassword.Text)
        RPassword = Trim(txtadminrpassword.Text)
        Dim HashedPasword = Encryption.HashString(Password)
        Dim salt = Encryption.GenereateSalt
        Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", HashedPasword, salt))

        DBconnect()


        table.Clear()


        If IsEmpty(Name) Or IsEmpty(Email) Or IsEmpty(Phone_no) Or IsEmpty(Username) Or IsEmpty(Password) Then
            MessageBox.Show("All field are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)



        ElseIf Not Validename(Name) Or Not Validmail(Email) Then
            MessageBox.Show("Please Check the Name and Email", "Error Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not Validphone(Phone_no) Then
            MessageBox.Show("Please Check the Phone Number", "Error Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DuplicateUser(Username) Then
            MessageBox.Show("Username Alrady Taken", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DuplicateMail(Email) Then
            MessageBox.Show("Email is used by another User", "Email is Used ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Password <> RPassword Then

            MessageBox.Show("Password and Repeat Password Does Not Match", "Field Matching Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf DBconnect() Then


            Dim sql As String
            Dim result As Integer

            Dim command As New MySqlCommand("INSERT INTO `admin`(`Name`,`Email`,`Phone_Number`,`Username`,`Password`,`Salt`) VALUES (@name,@email,@phone,@username,@password,@salt)", DbConnection)


            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Name
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = Phone_no
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username
            command.Parameters.AddWithValue("@password", hashedAndSalted)
            command.Parameters.AddWithValue("@salt", salt)




            result = command.ExecuteNonQuery()
            adapter.Dispose()

            If result = 1 Then
                MsgBox("New Admin Added", vbOKOnly + vbInformation, "Success")



                txtadminrpassword.Text = ""
                txtadminPno.Text = ""

                txtadminpassword.Text = ""
                txtadminusernam.Text = ""
                txtadminemail.Text = ""

                Loadproerty()


            Else
                MsgBox("Error Occured.Please Try Again", vbOKOnly + vbExclamation, "Error")


            End If


            Login.Show()
            Me.Hide()

        End If




    End Sub
    Private Shared Function DuplicateUser(Username As String) As Boolean
        DBconnect()
        Dim query As String = "SELECT COUNT(Username) FROM admin WHERE Username=@user "
        Dim Command As New MySqlCommand(query, DbConnection)
        Command.Parameters.AddWithValue("@user", Username)
        Command.ExecuteNonQuery()

        Dim result As Integer = Convert.ToInt32(Command.ExecuteScalar())
            If result > 0 Then
                Return True

            Else
                Return False
            End If

        Return True
    End Function

    Private Shared Function DuplicateMail(Email As String) As Boolean
        DBconnect()
        Dim query As String = "SELECT COUNT(Email) FROM admin WHERE Email=@mail "
        Dim Command As New MySqlCommand(query, DbConnection)
        Command.Parameters.AddWithValue("@mail", Email)
        Command.ExecuteNonQuery()

        Dim result As Integer = Convert.ToInt32(Command.ExecuteScalar())
        If result > 0 Then
            Return True

        Else
            Return False
        End If

        Return True
    End Function

    Private Shared Function DuplicateID(Email As String) As Boolean
        DBconnect()
        Dim query As String = "SELECT COUNT(Email) FROM admin WHERE Email=@mail "
        Dim Command As New MySqlCommand(query, DbConnection)
        Command.Parameters.AddWithValue("@mail", Email)
        Command.ExecuteNonQuery()

        Dim result As Integer = Convert.ToInt32(Command.ExecuteScalar())
        If result > 0 Then
            Return True

        Else
            Return False
        End If

        Return True
    End Function



End Class