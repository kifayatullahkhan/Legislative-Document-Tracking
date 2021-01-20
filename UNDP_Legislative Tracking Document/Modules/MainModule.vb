Imports System.Data.SqlClient

Module MainModule
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public ab As String
    Public bc As String
    Public vUserId As New Integer
    Public vUserName As String
    Public vGroupId As Integer
    Public vServerName As String
    Public VAdminUserName As String
    Public VServerPassword As String
    Public vGroupName As String
    Public Function connectionopen()
        Try
            If con.State = ConnectionState.Open Then
                Return True
                Exit Function
            End If
            'con.ConnectionString = "data Source=.;database=UNDP_Database;Integrated Security=True" ';User Instance=true"

            If vServerName.Length = 0 Then
                MsgBox("Please Enter ServerName or IP Address", MsgBoxStyle.OkOnly, "ServerName or IP Address Required")

                con.ConnectionString = "data Source=.;database=UNDP_Database;Persist Security Info=True;User Id=" & VAdminUserName & ";Password=" & VServerPassword  ';User Instance=true"
            Else
                con.ConnectionString = "data Source=" & vServerName & ";database=UNDP_Database;Persist Security Info=True;User Id=" & VAdminUserName & ";Password=" & VServerPassword  ';User Instance=true"
            End If

            con.Open()

            Return True

        Catch ex As Exception
            MsgBox("Unable to connected to the SQLServer " & vServerName & vbCrLf & "Please Try Correct ServerName or IP Address and Instant Name if required", MsgBoxStyle.Critical, "Connection not Found")
            Return False
        End Try
    End Function


    'Public Function LoadTble(ByVal Source As String, ByVal cmd As SqlCommand, ByVal DAP As SqlDataAdapter) As DataTable
    '    connectionopen()
    '    Dim tbl As New DataTable
    '    cmd.CommandText = Source
    '    cmd.Connection = Cn
    '    DAP.SelectCommand = cmd
    '    tbl.Clear()
    '    DAP.Fill(tbl)
    '    Return tbl
    'End Function
    'Public Sub ComboFiller(ByVal Query As String, ByVal table As String, ByVal Combo As Object, ByVal display As String, ByVal value As String)
    '    connectionopen()
    '    cmd.CommandText = Query
    '    da.SelectCommand = Cmd
    '    da.Fill(ds, table)
    '    'If ds.Rows.Count = 0 Then
    '    'Combo.DataSource = Nothing
    '    'Combo.Items.Clear()
    '    'Else
    '    Combo.DataSource = ds.Tables(table)
    '    Combo.DisplayMember = display
    '    Combo.ValueMember = value
    '    'End If
    'End Sub
    Public Sub DatasetFill(ByVal query As String, ByVal table As String)
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = query
            da.SelectCommand = cmd
            If ds.Tables.Contains(table) Then
                ds.Tables(table).Clear()
            End If
            da.Fill(ds, table)
        Catch ex As Exception

        End Try
    End Sub
   

    Public Function LoadTble(ByVal Source As String, ByVal cmd As SqlCommand, ByVal Dap As SqlDataAdapter) As DataTable

        Call connectionopen()
        Dim Tbl As New DataTable
        cmd.CommandText = Source
        cmd.Connection = con
        Dap.SelectCommand = cmd

        Tbl.Clear()
        Dap.Fill(Tbl)

        Return Tbl

    End Function

    Public Function GetMax(ByVal FieldName As String, ByVal TableName As String) As Integer

        Call connectionopen()
        Dim CMD As New SqlCommand
        CMD.CommandText = "Select  isnull(Max(" & FieldName & "),0) From " & TableName
        CMD.Connection = con
        GetMax = CMD.ExecuteScalar + 1

    End Function

    Public Sub ComboFiller(ByVal Query As String, ByVal Combo As Object, ByVal DispFld As String, ByVal ValFld As String)
        Dim lTable As New DataTable
        Call connectionopen()
        Dim da As New SqlDataAdapter
        Dim lCmd As New SqlCommand(Query, con)
        da.SelectCommand = lCmd
        da.Fill(lTable)

        If lTable.Rows.Count = 0 Then
            Combo.DataSource = Nothing
            Combo.Items.Clear()
        Else
            Combo.DataSource = lTable
            Combo.DisplayMember = DispFld
            Combo.ValueMember = ValFld
        End If
    End Sub
    Public Sub ClearFields(ByVal frm As Form)
        Dim ctl As Control
        For Each ctl In frm.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then
                ctl.Text = ""
            End If
        Next
    End Sub
    Public Sub LockFields(ByVal frm As Form)
        Dim ctl As Control
        For Each ctl In frm.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then
                ctl.Enabled = False
            End If
        Next
    End Sub
    Public Sub UnLockFields(ByVal frm As Form)
        Dim ctl As Control
        For Each ctl In frm.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then
                ctl.Enabled = True
            End If
        Next
    End Sub
End Module
