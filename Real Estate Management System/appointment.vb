Imports System.Data.OleDb
Imports System.Globalization
Imports MySql.Data.MySqlClient

Module appointment

    Public cn As New MySqlConnection("Server=localhost;user=root;password=;database=ict221;Convert Zero Datetime=True")

    Public Sub Connect()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub

    Public Function InsertUpdateDelete(ByVal sql As String) As Boolean
        Connect()
        Dim cmd As New MySqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery() > 0
    End Function

    Public Function IsConfirm(ByVal message As String) As Boolean
        Return MessageBox.Show(message, "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Public Function QueryAsDataTable(ByVal sql As String) As DataTable
        Dim da As New MySqlDataAdapter(sql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "result")
        Return ds.Tables("result")
    End Function

    Public Function ConvertDateToString(ByVal dateVal As Date) As String
        Return dateVal.ToString("yyyy-dd-MM", CultureInfo.GetCultureInfo("en-US"))
    End Function

End Module