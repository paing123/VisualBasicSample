Public Class DBConnection
    Public Sub connect(ByVal sql As String, ByVal dataGrid As DataGridView)
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\oasm\Desktop\VB project testing\customer.mdb'")
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()

            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)

            dataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub connect2(ByVal sql As String, ByRef dataGrid As DataGridView)
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\oasm\Desktop\VB project testing\customer.mdb'")
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()

            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)

            dataGrid.DataSource = dt
            dataGrid.Columns(0).HeaderText = "メ確日"
            dataGrid.Columns(1).HeaderText = "総メ確件数"
            dataGrid.Columns(2).HeaderText = "センターメ確件数"
            dataGrid.Columns(3).HeaderText = "センター未メ確件数"
            dataGrid.Columns(4).HeaderText = "支店メ確件数"
            dataGrid.Columns(5).HeaderText = "支店未メ確件数"
            dataGrid.Columns(6).HeaderText = "状態"
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub checkStoreSectionCode(ByRef storeSectionCode As String, ByRef storeSectionName As String)
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\oasm\Desktop\VB project testing\customer.mdb'")
        Dim sql As String = "Select person_name from customer where person_code = " + storeSectionCode
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dt As New DataTable
            con.Open()

            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                storeSectionName = "****"
            Else
                storeSectionName = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
