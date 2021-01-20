Imports System.Data.SqlClient
Public Class FrmMembers
    Private Sub FrmUserInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call gridfill("select * from Members")
         LockTextBoxes()
        TxtMemberId.ReadOnly = True
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
        TxtMemberName.ReadOnly = True
        TxtMemberDetail.ReadOnly = True
        TxtMemberParty.ReadOnly = True
        TxtMemberSession.ReadOnly = True
        TxtComments.ReadOnly = True
    End Sub
    Private Sub UnlockTextBoxes()
        TxtMemberName.ReadOnly = False
        TxtMemberDetail.ReadOnly = False
        TxtMemberParty.ReadOnly = False
        TxtMemberSession.ReadOnly = False
        TxtComments.ReadOnly = False
    End Sub
    Private Sub ClearTextBoxes()
        TxtMemberId.Clear()
        TxtMemberName.Clear()
        TxtMemberDetail.Clear()
        TxtMemberParty.Clear()
        TxtMemberSession.Clear()
        TxtComments.Clear()
    End Sub
    Private Sub gridfill(ByVal query As String)
        DatasetFill(query, "Members")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("Members").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("Members").Rows(a).Item("MemberName")
            dgview.Rows(a).Cells(1).Value = ds.Tables("Members").Rows(a).Item("MemberDetail")
            dgview.Rows(a).Cells(2).Value = ds.Tables("Members").Rows(a).Item("MemberParty")
            dgview.Rows(a).Cells(3).Value = ds.Tables("Members").Rows(a).Item("MemberSession")
            dgview.Rows(a).Cells(4).Value = ds.Tables("Members").Rows(a).Item("Comments")
            dgview.Rows(a).Cells(5).Value = ds.Tables("Members").Rows(a).Item("MemberID")
        Next
    End Sub
    Private Sub CheckInputData()
        If TxtMemberName.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Enter Member Name "
            TxtMemberName.Focus()
            Exit Sub
        End If
        If TxtMemberSession.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Enter Member Session "
            TxtMemberSession.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub dgview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.Click
        UnlockTextBoxes()
        Try
            TxtMemberId.Text = dgview.CurrentRow.Cells(5).Value
            TxtMemberName.Text = dgview.CurrentRow.Cells(0).Value
            TxtMemberDetail.Text = dgview.CurrentRow.Cells(1).Value
            TxtMemberParty.Text = dgview.CurrentRow.Cells(2).Value
            TxtMemberSession.Text = dgview.CurrentRow.Cells(3).Value
            TxtComments.Text = dgview.CurrentRow.Cells(4).Value
        Catch ex As Exception

        End Try
        BtnUpdate.Enabled = True
        BtnSave.Enabled = False
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Old Records Before Updation in Houses Form','Updation','" & vUserName & "','Members')"
        cmd.ExecuteNonQuery()
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
        TxtMemberName.Focus()
        TxtMemberId.Text = GetMax("MemberID", "Members")
    End Sub
    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        CheckInputData()
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update Members set MemberName=N'" & TxtMemberName.Text & "',MemberDetail=N'" & TxtMemberDetail.Text & "',MemberParty=N'" & TxtMemberParty.Text & "',MemberSession=N'" & TxtMemberSession.Text & "',Comments=N'" & TxtComments.Text & "' where MemberID=" & TxtMemberId.Text
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Updated "
            LockTextBoxes()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        Call gridfill("select * from Members")
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Updation of Records in Houses Form','Updation','" & vUserName & "','Members')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        CheckInputData()
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into Members values(" & TxtMemberId.Text & ",N'" & TxtMemberName.Text & "',N'" & TxtMemberDetail.Text & "',N'" & TxtMemberParty.Text & "',N'" & TxtMemberSession.Text & "',N'" & TxtComments.Text & "')"
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
        Call gridfill("select * from Members")
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Saving Records in Houses Form','Saving','" & vUserName & "','Members')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  Members where MemberID=" & TxtMemberId.Text & ""
                cmd.ExecuteNonQuery()
                LblMessage.Visible = True
                LblMessage.Text = "Record Deleted "
                Call gridfill("select * from Members")
                ClearTextBoxes()
                LockTextBoxes()
            End If
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Deletion of Records in Houses Form','Deletion','" & vUserName & "','Members')"
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub txtSearchRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.GotFocus
        If txtSearchRecord.Text = "Search Record(s) by Member Name" Then
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
            gridfill("select * from Members where MemberName like N'%" & txtSearchRecord.Text & "%'")
        End If
    End Sub

    Private Sub txtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.LostFocus
        If txtSearchRecord.Text = "" Then
            txtSearchRecord.Text = "Search Record(s) by Member Name"
            txtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblMessage.Text = ""
    End Sub
End Class