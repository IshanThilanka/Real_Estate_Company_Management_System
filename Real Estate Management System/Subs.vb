Imports MySql.Data.MySqlClient
Imports System.IO



Module Subs
    Public command As New MySqlCommand
    Public Sub dashboarddata()

        Try
            Dim newdr As MySqlDataReader
            DBconnect()


            Dim query As String = "select `Property_Name`,`Price` from `sales`ORDER BY ID DESC LIMIT 1"
            command = New MySqlCommand(query, DbConnection)

            newdr = command.ExecuteReader()
            While newdr.Read()
                Dashboard.lblpropname.Text = newdr.Item("Property_Name")
                Dashboard.lblpropprice1.Text = newdr.Item("Price")
            End While

            newdr.Dispose()
            command.Dispose()
            DbConnection.Dispose()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            Dim dr As MySqlDataReader
            DBconnect()


            Dim query As String = "select `Property_Name`,`Price` from `sales`ORDER BY ID DESC LIMIT 1,1"
            command = New MySqlCommand(query, DbConnection)

            dr = command.ExecuteReader()
            While dr.Read()
                Dashboard.lblpropname2.Text = dr.Item("Property_Name")
                Dashboard.lblprop2price.Text = dr.Item("Price")
            End While
            dr.Dispose()
            command.Dispose()
            DbConnection.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        If DBconnect() Then
            Dim cmd As New MySqlCommand
            cmd.CommandText = "Select `Image` from property where Name= '" + Dashboard.lblpropname.Text + "'"
            cmd.Connection = DbConnection
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds, "property")
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim bytBLOBData() As Byte =
    ds.Tables(0).Rows(c - 1)("Image")
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                Dashboard.picboxpropimage.Image = Image.FromStream(stmBLOBData)


                da.Dispose()
                ds.Dispose()
                cmd.Dispose()
            End If
        End If

        If DBconnect() Then
            Dim cmd As New MySqlCommand
            cmd.CommandText = "Select `Image` from property where Name= '" + Dashboard.lblpropname2.Text + "'"
            cmd.Connection = DbConnection
            Dim da As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds, "property")
            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim bytBLOBData() As Byte =
                ds.Tables(0).Rows(c - 1)("Image")
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                Dashboard.picboxpropimage2.Image = Image.FromStream(stmBLOBData)


                da.Dispose()
                ds.Dispose()
                cmd.Dispose()
            End If
        End If


    End Sub


    Public Sub salescombo()
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader
        Dim Name As String


        If DBconnect() Then
            Dim query As String = "SELECT * FROM property WHERE  Status='Unsold'"
            command = New MySqlCommand(query, DbConnection)

            reader = command.ExecuteReader()



            While reader.Read()
                Name = reader("Name")


                Sales.ComboBoxPropID.Items.Add(Name)
            End While
            reader.Close()
        End If



    End Sub



















End Module
