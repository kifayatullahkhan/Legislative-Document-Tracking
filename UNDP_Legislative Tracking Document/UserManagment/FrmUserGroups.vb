Imports System.Data.SqlClient
Public Class FrmUserGroups
    Private Sub FrmUserGroups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LockTextBoxes()
        txtgroupid.Enabled = False
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then
                ctl.BackColor = Color.White
            End If
        Next
        Call gridfill("select * from UserGroups")
        BtnUpdate.Enabled = False
        LblMessage.Visible = False
    End Sub

    Private Sub LockTextBoxes()
        txtgroupname.ReadOnly = True
        txtremarks.ReadOnly = True
    End Sub
    Private Sub UnlockTextBoxes()
        txtgroupname.ReadOnly = False
        txtremarks.ReadOnly = False
    End Sub
    Private Sub ClearTextBoxes()
        txtgroupname.Clear()
        txtremarks.Clear()
        txtgroupid.Clear()
    End Sub
    Private Sub gridfill(ByVal query As String)
        DatasetFill(query, "UserGroup")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("UserGroup").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("UserGroup").Rows(a).Item("GroupID")
            dgview.Rows(a).Cells(1).Value = ds.Tables("UserGroup").Rows(a).Item("GroupName")
            dgview.Rows(a).Cells(2).Value = ds.Tables("UserGroup").Rows(a).Item("Remarks")
        Next
    End Sub
    Private Sub dgview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.Click
        UnlockTextBoxes()
        Try
            txtgroupid.Text = dgview.CurrentRow.Cells(0).Value
            txtgroupname.Text = dgview.CurrentRow.Cells(1).Value
            txtremarks.Text = dgview.CurrentRow.Cells(2).Value
        Catch ex As Exception

        End Try
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
        txtgroupname.Focus()
        txtgroupid.Text = GetMax("GroupID", "UserGroups")
    End Sub

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If txtgroupname.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Group Name is not Entered "
            txtgroupname.Focus()
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update UserGroups set GroupName=N'" & txtgroupname.Text & "',Remarks=N'" & txtremarks.Text & "' where GroupID=" & txtgroupid.Text
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Updated "
            UnlockTextBoxes()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        Call gridfill("select * from UserGroups")
    End Sub

    Private Sub BtnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If txtgroupname.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Group Name is not Entered "
            txtgroupname.Focus()
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into UserGroups values(" & txtgroupid.Text & ",N'" & txtgroupname.Text & "',N'" & txtremarks.Text & "')"
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Saved "
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        ClearTextBoxes()
        LockTextBoxes()
        Call gridfill("select * from UserGroups")
    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  UserGroups where GroupID=" & txtgroupid.Text
                cmd.ExecuteNonQuery()
                LblMessage.Visible = True
                LblMessage.Text = "Record Deleted "
                Call gridfill("select * from UserGroups")
            End If
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "You Can not Delete this Group"
        End Try
        ClearTextBoxes()
    End Sub
    Private Sub txtSearchRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.GotFocus
        If txtSearchRecord.Text = "Search Record(s) by Group Name" Then
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
            gridfill("select * from UserGroups where GroupName like '%" & txtSearchRecord.Text & "%'")
        End If
    End Sub

    Private Sub txtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.LostFocus
        If txtSearchRecord.Text = "" Then
            txtSearchRecord.Text = "Search Record(s) by Group Name"
            txtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblMessage.Text = ""
    End Sub

End Class


