Public Class FrmResolution
    Public ReadOnly Property UserName() As String
        Get
            Return TxtRTextPashto.Text
        End Get
    End Property

    Public ReadOnly Property UserName1() As String
        Get
            Return TxtTextDari.Text
        End Get
    End Property
    Private Sub FrmResolution_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call gridfill("select * from Resolution")
        LockTextBoxes()
        TxtRid.ReadOnly = True
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then
                ctl.BackColor = Color.White
            End If
        Next
        BtnUpdate.Enabled = False
        LblMessage.Visible = False
    End Sub
    Private Sub LockTextBoxes()
        TxtTextDari.ReadOnly = True
        TxtRTextPashto.ReadOnly = True
        TxtComments.ReadOnly = True
        DtpIssueDate.Enabled = False
    End Sub
    Private Sub UnlockTextBoxes()
        TxtTextDari.ReadOnly = False
        TxtRTextPashto.ReadOnly = False
        TxtComments.ReadOnly = False
        DtpIssueDate.Enabled = True
    End Sub
    Private Sub ClearTextBoxes()
        TxtRid.Clear()
        TxtTextDari.Clear()
        TxtRTextPashto.Clear()
        TxtComments.Clear()
        DtpIssueDate.Value = Date.Now
    End Sub
    Private Sub gridfill(ByVal query As String)
        DatasetFill(query, "Resolution")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("Resolution").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("Resolution").Rows(a).Item("RID")
            dgview.Rows(a).Cells(1).Value = ds.Tables("Resolution").Rows(a).Item("RTextPashto")
            dgview.Rows(a).Cells(2).Value = ds.Tables("Resolution").Rows(a).Item("RTextDari")
            dgview.Rows(a).Cells(3).Value = ds.Tables("Resolution").Rows(a).Item("RDate")
            dgview.Rows(a).Cells(4).Value = ds.Tables("Resolution").Rows(a).Item("Comments")
        Next
    End Sub
    Private Sub dgview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.Click

        UnlockTextBoxes()
        Try
            TxtRid.Text = dgview.CurrentRow.Cells(0).Value
            TxtRTextPashto.Text = dgview.CurrentRow.Cells(1).Value
            TxtTextDari.Text = dgview.CurrentRow.Cells(2).Value
            DtpIssueDate.Value = dgview.CurrentRow.Cells(3).Value
            TxtComments.Text = dgview.CurrentRow.Cells(4).Value
        Catch ex As Exception

        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Old Records Before Updation in Resolution Form','Updation','" & vUserName & "','Resolution')"
        cmd.ExecuteNonQuery()
        BtnUpdate.Enabled = True
        BtnSave.Enabled = False
    End Sub
    Private Sub dgview_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgview.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Dim a As Object
            a = dgview.CurrentRow.Index
            a = a - 1
            dgview.ClearSelection()
            dgview.CurrentCell = dgview.Rows(a).Cells(0)
            dgview.Rows(a).Selected = True
            dgview_Click(sender, e)
        End If
    End Sub
    Private Sub BtnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        ClearTextBoxes()
        UnlockTextBoxes()
        BtnUpdate.Enabled = False
        BtnSave.Enabled = True
        TxtRTextPashto.Focus()
        TxtRid.Text = GetMax("RID", "Resolution")
    End Sub

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update Resolution set RTextPashto=N'" & TxtRTextPashto.Text & "',RTextDari=N'" & TxtTextDari.Text & "',Comments=N'" & TxtComments.Text & "',RDate='" & Format(DtpIssueDate.Value, "MM/dd/yy") & "' where RID=" & TxtRid.Text
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Updated "
            LockTextBoxes()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        Call gridfill("select * from Resolution")
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Updation Records in Resolution Form','Updation','" & vUserName & "','Resolution')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into Resolution values(" & TxtRid.Text & ",N'" & TxtRTextPashto.Text & "',N'" & TxtTextDari.Text & "',N'" & TxtComments.Text & "','" & Format(DtpIssueDate.Value, "MM/dd/yy") & "')"
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Saved "
            ClearTextBoxes()
            LockTextBoxes()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        Call gridfill("select * from Resolution")
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Saving Records in Resolution Form','Saving','" & vUserName & "','Resolution')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  Resolution where RID=" & TxtRid.Text & ""
                cmd.ExecuteNonQuery()
                LblMessage.Visible = True
                LblMessage.Text = "Record Deleted "
                Call gridfill("select * from Resolution")
                ClearTextBoxes()
                LockTextBoxes()
            End If
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "First select Record "
        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Deletion of Records in Resolution Form','Deletion','" & vUserName & "','Resolution')"
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub txtSearchRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.GotFocus
        If txtSearchRecord.Text = "Search Record(s) by Resolution Name" Then
            txtSearchRecord.Text = ""
            txtSearchRecord.ForeColor = Color.Black
        Else
            txtSearchRecord.SelectAll()
            txtSearchRecord.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchRecord_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchRecord.KeyDown
        If txtSearchRecord.Text.Length > 0 And e.KeyCode = Keys.Enter Then
            ' Code for Searching the Database Records
            gridfill("select * from Resolution where RID=" & txtSearchRecord.Text)
        End If
    End Sub

    Private Sub txtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.LostFocus
        If txtSearchRecord.Text = "" Then
            txtSearchRecord.Text = "Search Record(s) by Resolution Name"
            txtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblMessage.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Obj As New FrmView
        'Obj.PassedText = TxtPashto.Text
        'Obj.Textbox = "TxtPashto"
        Obj.Show()
        Obj.T.Text = TxtRTextPashto.Text
        Obj.T2.Text = "TextPashto"
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'MsgBox(Me.TxtPashto.Text)
        'TxtPashto.Text = bc

        ' TxtPashto.Text = FrmView.T.Text
        Dim Obj As New FrmView
        'Obj.PassedText = TxtPashto.Text
        'Obj.Textbox = "TxtPashto"
        Obj.Show()
        Obj.T.Text = TxtTextDari.Text
        Obj.T2.Text = "TextDari"

    End Sub

    Private Sub Button1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.LostFocus
        If ab = "TextPashto" Then
            TxtRTextPashto.Text = bc
            ab = ""
            bc = ""
        ElseIf ab = "TextDari" Then
            TxtTextDari.Text = bc
            ab = ""
            bc = ""
        End If
    End Sub
    Private Sub Button2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.LostFocus
        Button1_LostFocus(sender, e)

    End Sub
End Class
