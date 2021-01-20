Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.UI.Page
Public Class Form2
    Dim cmdbuld As New SqlCommandBuilder
    Dim DAP As New SqlDataAdapter
    Dim TblUser As New DataTable
    Dim TblUser1 As New DataTable
    Dim CurrRow As DataRow
    Dim picture As Array
    Dim ImageByte() As Byte
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TblUser = LoadTble("Select * From files", cmd, DAP)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim file As String
        Dim Pic As OpenFileDialog = New OpenFileDialog()
        Pic.Title = "Open File Dialog"
        Pic.InitialDirectory = "c:\Mydocuments"
        Pic.Filter = "Pictures (*.bmp,*.jpg,*.gif,*.png)|*.bmp;*.jpg;*.gif;*.jpeg;*.png|All files (*.*)|*.*"
        Pic.FilterIndex = 1
        Pic.RestoreDirectory = True
        If Pic.ShowDialog() = DialogResult.OK Then
            file = Pic.FileName
            '' pict.Image = Image.FromFile(file)
            'Dim ms As New MemoryStream
            '' ms = Convert(Image.FromFile(file).RawFormat)
            'Me.pict.Image.Save(ms, Image.FromFile(file).RawFormat)
            'ImageByte = (ms.GetBuffer)
            'picture .
            Dim filePath As String = file 'Server.MapPath("APP_DATA/Testxls.xlsx")
            Dim filename As String = Path.GetFileName(filePath)
            Dim fs As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
            Dim br As BinaryReader = New BinaryReader(fs)
            Dim bytes As Byte() = br.ReadBytes(Convert.ToInt32(fs.Length))
            br.Close()
            fs.Close()
            connectionopen()
            cmd.Connection = con
            Dim CmdBuld As New SqlCommandBuilder(DAP)
            Dim NewRow As DataRow
            NewRow = TblUser.NewRow
            NewRow(0) = "1"
            NewRow(1) = filename
            NewRow(2) = bytes
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            TblUser.Rows.Add(NewRow)
            DAP.Update(TblUser)
            'Dim strQuery As String = "insert into file (ID, Name,ContentType,Data) values(@ID, @Name, @ContentType, @Data)"

            'cmd = New SqlCommand(strQuery)

            'cmd.Parameters.AddWithValue("@ID", "1")

            'cmd.Parameters.AddWithValue("@Name", "ABC")
            'cmd.Parameters.AddWithValue("@ContentType", "1")

            'cmd.Parameters.AddWithValue("@Data", "ABC")
            ' ''Dim strQuery As String = "insert into file(Name, ContentType, Data) values (@Name, @ContentType, @Data)"

            ' ''Dim cmd As SqlCommand = New SqlCommand(strQuery)
            ' ''cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = filename
            ' ''cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value = "application/vnd.ms-excel"
            ' ''cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes
            ' InsertUpdateData(cmd)
            'cmd.ExecuteNonQuery()
        End If
    End Sub
    Public Function InsertUpdateData(ByVal cmd As SqlCommand) As Boolean
        'Dim strConnString As String = System.Configuration.ConfigurationManager.ConnectionStrings("conString").ConnectionString()
        'Dim con As New SqlConnection(strConnString)
        connectionopen()
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        Try
            'con.Open()
            cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("error")
            Return False
        Finally
            con.Close()
            con.Dispose()
        End Try

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim cmd As SqlCommand = New SqlCommand("InsertFile", con)
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add(New SqlParameter("@FileName", ""))
        'cmd.Parameters.Add(New SqlParameter("@Extension", "Extension of Uploaded File"))
        'cmd.Parameters.Add(New SqlParameter("@Content", "byte array (byte[]) of uploaded file"))
        Dim strQuery As String = "select Name, Data from files where ID=@id"
        Dim cmd As SqlCommand = New SqlCommand(strQuery)
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = 5
        Dim dt As DataTable = GetData(cmd)
        If dt IsNot Nothing Then
            downLoadFile(dt)
        End If
    End Sub
    Public Function GetData(ByVal cmd As SqlCommand) As DataTable
        Dim dt As New DataTable
        'Dim strConnString As String = System.Configuration.ConfigurationManager.ConnectionStrings("conString").ConnectionString()
        'Dim con As New SqlConnection(strConnString)
        connectionopen()
        Dim sda As New SqlDataAdapter
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        Try
            'con.Open()
            sda.SelectCommand = cmd
            sda.Fill(dt)
            Return dt
        Catch ex As Exception
            'Response.Write(ex.Message)
            Return Nothing
        Finally
            con.Close()
            sda.Dispose()
            con.Dispose()
        End Try

    End Function
    'Protected Sub download(ByVal dt As DataTable)
    '    'Dim Response As Stream
    '    Dim Response1 As BinaryWriter
    '    Dim bytes() As Byte = CType(dt.Rows(0)("Data"), Byte())
    '    Response1.Flush()
    '    'Response.Buffer = True
    '    'Response.Charset = ""
    '    'Response.Cache.SetCacheability(HttpCacheability.NoCache)
    '    'Response.ContentType = dt.Rows(0)("ContentType").ToString()
    '    'Response.AddHeader("content-disposition", "attachment;filename=" & dt.Rows(0)("Name").ToString())
    '    'Response.BinaryWrite(bytes)
    '    'Response.Flush()
    '    'Response.End()
    '    'Response
    'End Sub
    Private Sub downLoadFile(ByVal dt As DataTable)

        'Dim strSql As String
        ''For Document
        Try
            '    'Get image data from gridview column. 
            '    strSql = "Select ImageData from FileStore WHERE FileId=" & iFileId

            '    Dim sqlCmd As New SqlCommand(strSql, connection)

            '    'Get image data from DB
            Dim fileData As Byte() = CType(dt.Rows(0)("Data"), Byte())

            Dim sTempFileName As String = dt.Rows(0)("Name")

            If Not fileData Is Nothing Then

                'Read image data into a file stream 
                Using fs As New FileStream(dt.Rows(0)("Name"), FileMode.OpenOrCreate, FileAccess.Write)
                    fs.Write(fileData, 0, fileData.Length)
                    'Set image variable value using memory stream. 
                    fs.Flush()
                    fs.Close()
                End Using

                'Open File

                Process.Start(dt.Rows(0)("Name"))

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class