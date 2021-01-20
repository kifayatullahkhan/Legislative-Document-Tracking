Imports System.Data.SqlClient
Public Class FrmDailyAgenda
    Public ReadOnly Property UserName() As String
        Get
            Return TxtAgendatextPashto.Text
        End Get
    End Property

    Public ReadOnly Property UserName1() As String
        Get
            Return TxtAgendaTextDari.Text
        End Get
    End Property
    Private Sub FrmDailyAgenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call gridfill("select * from DailyAgenda")
        LockTextBoxes()
        TxtAgendaId.ReadOnly = True
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
        TxtAgendatextPashto.ReadOnly = True
        TxtAgendaTextDari.ReadOnly = True
        TxtComments.ReadOnly = True
        DtpAgDate.Enabled = False
    End Sub
    Private Sub UnlockTextBoxes()
        TxtAgendatextPashto.ReadOnly = False
        TxtAgendaTextDari.ReadOnly = False
        TxtComments.ReadOnly = False
        DtpAgDate.Enabled = True
    End Sub
    Private Sub ClearTextBoxes()
        TxtAgendaId.Clear()
        TxtAgendatextPashto.Clear()
        TxtAgendaTextDari.Clear()
        TxtComments.Clear()
        DtpAgDate.Value = Date.Now
    End Sub
    Private Sub gridfill(ByVal query As String)
        DatasetFill(query, "DailyAgenda")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("DailyAgenda").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("DailyAgenda").Rows(a).Item("DATextPashto")
            dgview.Rows(a).Cells(1).Value = ds.Tables("DailyAgenda").Rows(a).Item("DATextDari")
            dgview.Rows(a).Cells(2).Value = ds.Tables("DailyAgenda").Rows(a).Item("DADated")
            dgview.Rows(a).Cells(3).Value = ds.Tables("DailyAgenda").Rows(a).Item("Comments")
            dgview.Rows(a).Cells(4).Value = ds.Tables("DailyAgenda").Rows(a).Item("DAID")
        Next
    End Sub
    Private Sub dgview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.Click
        UnlockTextBoxes()
        Try
            TxtAgendaId.Text = dgview.CurrentRow.Cells(4).Value
            TxtAgendatextPashto.Text = dgview.CurrentRow.Cells(0).Value
            TxtAgendaTextDari.Text = dgview.CurrentRow.Cells(1).Value
            DtpAgDate.Value = dgview.CurrentRow.Cells(2).Value
            TxtComments.Text = dgview.CurrentRow.Cells(3).Value
        Catch ex As Exception

        End Try
        BtnUpdate.Enabled = True
        BtnSave.Enabled = False
        Try
            cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Old Records Before Updation in Daily Agenda Form','Updation','" & vUserName & "','Daily Agenda')"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
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
        TxtAgendatextPashto.Focus()
        TxtAgendaId.Text = GetMax("DAID", "DailyAgenda")
    End Sub

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update DailyAgenda set DATextPashto=N'" & TxtAgendatextPashto.Text & "',DATextDari=N'" & TxtAgendaTextDari.Text & "',DADated='" & DtpAgDate.Value & "',Comments=N'" & TxtComments.Text & "' where DAID=" & TxtAgendaId.Text
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Updated "
            LockTextBoxes()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in input Data"
            Exit Sub
        End Try
        Call gridfill("select * from DailyAgenda")
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Updation of Records in Daily Agenda Form','Updation','" & vUserName & "','Daily Agenda')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into DailyAgenda values(" & TxtAgendaId.Text & ",N'" & TxtAgendatextPashto.Text & "',N'" & TxtAgendaTextDari.Text & "','" & Format(DtpAgDate.Value, "MM/dd/yyyy") & "',N'" & TxtComments.Text & "')"
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Inserted"
            ClearTextBoxes()
            LockTextBoxes()
        Catch ex As Exception
            MsgBox("Error in input Data......")
            Exit Sub
        End Try
        Call gridfill("select * from DailyAgenda")
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Saving in Daily Agenda Form','Saving','" & vUserName & "','Daily Agenda')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  DailyAgenda where DAID=" & TxtAgendaId.Text & ""
                cmd.ExecuteNonQuery()
                LblMessage.Visible = True
                LblMessage.Text = "Record Deleted"
                Call gridfill("select * from DailyAgenda")
                ClearTextBoxes()
                LockTextBoxes()
            End If
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Record is not selected"
        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Deletion From Daily Agenda Form','Deletion','" & vUserName & "','Daily Agenda')"
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub txtSearchRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.GotFocus
        If txtSearchRecord.Text = "Search Record(s) by Agenda ID" Then
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
            gridfill("select * from DailyAgenda where DAID=" & txtSearchRecord.Text)
        End If
    End Sub

    Private Sub txtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.LostFocus
        If txtSearchRecord.Text = "" Then
            txtSearchRecord.Text = "Search Record(s) by Agenda ID"
            txtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub
    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    LblMessage.Text = ""
    'End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        FrmAgendaPrint.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Obj As New FrmView
        'Obj.PassedText = TxtPashto.Text
        'Obj.Textbox = "TxtPashto"
        Obj.Show()
        Obj.T.Text = TxtAgendatextPashto.Text
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
        Obj.T.Text = TxtAgendaTextDari.Text
        Obj.T2.Text = "TextDari"

    End Sub

    Private Sub Button1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.LostFocus
        If ab = "TextPashto" Then
            TxtAgendatextPashto.Text = bc
            ab = ""
            bc = ""
        ElseIf ab = "TextDari" Then
            TxtAgendaTextDari.Text = bc
            ab = ""
            bc = ""
        End If
    End Sub
    Private Sub Button2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.LostFocus
        Button1_LostFocus(sender, e)

    End Sub

   
End Class