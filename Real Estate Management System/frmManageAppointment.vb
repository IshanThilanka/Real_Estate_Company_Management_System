
Public Class frmManageAppointment
        Public AppID As Integer = 0

        Private Sub frmManageAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            btnDelete.Visible = AppID <> 0
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            If String.IsNullOrWhiteSpace(txtName.Text) Then
                MsgBox("Customer or Contact name is required.")
                Return
            End If

            If IsConfirm("Do you want to save ?") Then

                If AppID = 0 Then
                Dim sql As String = $"insert into appointments(AppDate, ContactName, Address, Comment) 
                                values('{ConvertDateToString(dtpDate.Value)}', '{txtName.Text}', '{txtAddress.Text}', '{txtComment.Text}')"

                If InsertUpdateDelete(sql) Then
                        MsgBox("Inserted")
                        Close()
                    Else
                        MsgBox("Failed")
                    End If
                Else
                Dim sql As String = $"update appointments set AppDate = '{ConvertDateToString(dtpDate.Value)}', 
                                                ContactName = '{txtName.Text}', Address = '{txtAddress.Text}', 
                                                Comment = '{txtComment.Text}'
                                      where ID = {AppID}"
                If InsertUpdateDelete(sql) Then
                        MsgBox("Updated")
                        Close()
                    Else
                        MsgBox("Update Failed")
                    End If
                End If
            End If

        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            If IsConfirm("Do you want to delete this appointment ?") Then
            Dim sql As String = $"delete from appointments where ID = {AppID}"
            If InsertUpdateDelete(sql) Then
                    MsgBox("Deleted")
                    Close()
                Else
                    MsgBox("Delete Failed")
                End If
            End If
        End Sub
    End Class

