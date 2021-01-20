Imports System.Data.SqlClient
Public Class FrmUserInformation
    Dim status1 As String
    Private Sub FrmUserInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call gridfill("select *,(select GroupName from UserGroups where GroupID=UserAccounts.GroupID)as GroupName from UserAccounts")
        ComboFiller("select GroupID,GroupName from UserGroups", CmbGroupName, "GroupName", "GroupID")
        LockTextBoxes()
        TxtUserId.ReadOnly = True
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then
                ctl.BackColor = Color.White
            End If
        Next
        BtnUpdate.Enabled = False
        gb.Enabled = False
        LblMessage.Visible = False
    End Sub
    Private Sub LockTextBoxes()
        TxtUserName.ReadOnly = True
        TxtPassword.ReadOnly = True
        TxtFullName.ReadOnly = True
        TxtContactNo.ReadOnly = True
        TxtEmail.ReadOnly = True
        CmbGroupName.Enabled = False
    End Sub
    Private Sub UnlockTextBoxes()
        TxtUserName.ReadOnly = False
        TxtPassword.ReadOnly = False
        TxtFullName.ReadOnly = False
        TxtContactNo.ReadOnly = False
        TxtEmail.ReadOnly = False
        CmbGroupName.Enabled = True
    End Sub
    Private Sub ClearTextBoxes()
        TxtUserId.Clear()
        TxtUserName.Clear()
        TxtPassword.Clear()
        TxtFullName.Clear()
        TxtContactNo.Clear()
        TxtEmail.Clear()
        CmbGroupName.SelectedIndex = -1
    End Sub
    Private Sub gridfill(ByVal query As String)
        DatasetFill(query, "Users")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("Users").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("Users").Rows(a).Item("UserName")
            dgview.Rows(a).Cells(1).Value = ds.Tables("Users").Rows(a).Item("FullName")
            dgview.Rows(a).Cells(2).Value = ds.Tables("Users").Rows(a).Item("ContactNo")
            dgview.Rows(a).Cells(3).Value = ds.Tables("Users").Rows(a).Item("Email")
            dgview.Rows(a).Cells(4).Value = ds.Tables("Users").Rows(a).Item("GroupName")
            dgview.Rows(a).Cells(5).Value = ds.Tables("Users").Rows(a).Item("Status")
            dgview.Rows(a).Cells(6).Value = ds.Tables("Users").Rows(a).Item("UserID")
            dgview.Rows(a).Cells(7).Value = ds.Tables("Users").Rows(a).Item("Password")
        Next
    End Sub

    Private Sub dgview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.Click
        Dim str As String
        UnlockTextBoxes()
        gb.Enabled = True
        Try
            TxtUserId.Text = dgview.CurrentRow.Cells(6).Value
            CmbGroupName.Text = dgview.CurrentRow.Cells(4).Value
            TxtUserName.Text = dgview.CurrentRow.Cells(0).Value
            TxtFullName.Text = dgview.CurrentRow.Cells(1).Value
            TxtContactNo.Text = dgview.CurrentRow.Cells(2).Value
            TxtEmail.Text = dgview.CurrentRow.Cells(3).Value
            str = dgview.CurrentRow.Cells(5).Value
            If str = True Then
                radenable.Checked = True
            Else
                raddisable.Checked = True
            End If
            TxtPassword.Text = DecryptString128Bit((dgview.CurrentRow.Cells(7).Value), 2)
        Catch ex As Exception
            TxtPassword.Clear()
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
    Private Sub cmbrollname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbGroupName.GotFocus
        CmbGroupName.SelectedIndex = 1
    End Sub
    Private Sub cmbrollname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbGroupName.LostFocus
        radenable.Focus()
    End Sub

    Private Sub BtnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        ClearTextBoxes()
        UnlockTextBoxes()
        gb.Enabled = True
        BtnUpdate.Enabled = False
        BtnSave.Enabled = True
        TxtUserName.Focus()
        With radenable
            .Enabled = True
            .Checked = False
        End With
        With raddisable
            .Enabled = True
            .Checked = False
        End With
        TxtUserId.Text = GetMax("UserID", "UserAccounts")
    End Sub
    Private Function CheckInputData() As Boolean
        If TxtUserName.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "User Name must be Entered "
            TxtUserName.Focus()
            Exit Function
        End If
        If TxtPassword.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Minimum Password length is one Character "
            TxtPassword.Focus()
            Exit Function
        End If
        If CmbGroupName.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Group Name must be mention "
            CmbGroupName.Focus()
            Exit Function
        End If
        If radenable.Checked = True Then
            status1 = "True"
        ElseIf raddisable.Checked = True Then
            status1 = "False"
        Else
            LblMessage.Visible = True
            LblMessage.Text = "User Status is not Defined "
            Exit Function
        End If
        Return True
    End Function
    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If CheckInputData() = False Then
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update UserAccounts set UserName='" & TxtUserName.Text.Trim & "',FullName='" & TxtFullName.Text & "',ContactNo='" & TxtContactNo.Text & "',Password='" & EncryptString128Bit(TxtPassword.Text, 2) & "',Email='" & TxtEmail.Text & "',GroupID=" & CmbGroupName.SelectedValue & ",Status='" & status1 & "' where UserID=" & TxtUserId.Text
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Updated "
            LockTextBoxes()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        gridfill("select *,(select GroupName from UserGroups where GroupID=UserAccounts.GroupID)as GroupName from UserAccounts")
    End Sub

    Private Sub BtnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If CheckInputData() = False Then
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into UserAccounts values(" & TxtUserId.Text & ",'" & TxtUserName.Text.Trim & "','" & EncryptString128Bit(TxtPassword.Text, 2) & "','" & TxtFullName.Text & "','" & TxtContactNo.Text & "','" & TxtEmail.Text & "'," & CmbGroupName.SelectedValue & ",'" & status1 & "')"
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

        raddisable.Checked = False
        radenable.Checked = False
        gridfill("select *,(select GroupName from UserGroups where GroupID=UserAccounts.GroupID)as GroupName from UserAccounts")
    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  UserAccounts where UserID=" & TxtUserId.Text & ""
                cmd.ExecuteNonQuery()
                LblMessage.Visible = True
                LblMessage.Text = "Record Deleted "
                Call gridfill("select *,(select GroupName from UserGroups where GroupID=UserAccounts.GroupID)as GroupName from UserAccounts")
                ClearTextBoxes()
                LockTextBoxes()
            End If
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "First select Record "
        End Try

        raddisable.Checked = False
        radenable.Checked = False
    End Sub
    Private Sub txtSearchRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.GotFocus
        If txtSearchRecord.Text = "Search Record(s) by User Name" Then
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
            gridfill("select *,(select GroupName from UserGroups where GroupID=UserAccounts.GroupID)as GroupName from UserAccounts where UserName like '%" & txtSearchRecord.Text & "%'")
        End If
    End Sub

    Private Sub txtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.LostFocus
        If txtSearchRecord.Text = "" Then
            txtSearchRecord.Text = "Search Record(s) by User Name"
            txtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblMessage.Text = ""
    End Sub
End Class