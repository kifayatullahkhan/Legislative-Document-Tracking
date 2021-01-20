Public Class FrmCommission
    Private Sub FrmCommission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LockTextBoxes()
        TxtCommessionID.Enabled = False
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then
                ctl.BackColor = Color.White
            End If
        Next
        Call gridfill("select * from Commissions where not CommID=0")
        BtnUpdate.Enabled = False
        LblMessage.Visible = False
    End Sub

    Private Sub LockTextBoxes()
        TxtCommissionName.ReadOnly = True
        TxtComments.ReadOnly = True
    End Sub
    Private Sub UnlockTextBoxes()
        TxtCommissionName.ReadOnly = False
        TxtComments.ReadOnly = False
    End Sub
    Private Sub ClearTextBoxes()
        TxtCommessionID.Clear()
        TxtCommissionName.Clear()
        TxtComments.Clear()
    End Sub
    Private Sub gridfill(ByVal query As String)
        DatasetFill(query, "Commissions")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("Commissions").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("Commissions").Rows(a).Item("CommID")
            dgview.Rows(a).Cells(1).Value = ds.Tables("Commissions").Rows(a).Item("CommName")
            dgview.Rows(a).Cells(2).Value = ds.Tables("Commissions").Rows(a).Item("Comments")
        Next
    End Sub
    Private Sub dgview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.Click
        UnlockTextBoxes()
        Try
            TxtCommessionID.Text = dgview.CurrentRow.Cells(0).Value
            TxtCommissionName.Text = dgview.CurrentRow.Cells(1).Value
            TxtComments.Text = dgview.CurrentRow.Cells(2).Value
            DatasetFill("select GroupID from UserGroups where GroupName=N'" & dgview.CurrentRow.Cells(1).Value & "'", "GroupID")
        Catch ex As Exception

        End Try
        BtnUpdate.Enabled = True
        BtnSave.Enabled = False
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Old Records Before Updation in Commission Form','Updation','" & vUserName & "','Commission')"
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
        TxtCommissionName.Focus()
        TxtCommessionID.Text = GetMax("CommID", "Commissions")
    End Sub

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If TxtCommissionName.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Commission Name Missing "
            TxtCommissionName.Focus()
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update Commissions set CommName=N'" & TxtCommissionName.Text & "',Comments=N'" & TxtComments.Text & "' where CommID=" & TxtCommessionID.Text
            cmd.ExecuteNonQuery()
            'MsgBox(ds.Tables("GroupID").Rows(0).Item(0))
            cmd.CommandText = "Update UserGroups set GroupName=N'" & TxtCommissionName.Text & "' where GroupID=" & ds.Tables("GroupID").Rows(0).Item(0)
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Updated "
            UnlockTextBoxes()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        Call gridfill("select * from Commissions where not CommID=0")
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Updation of Records in Commission Form','Updation','" & vUserName & "','Commissions')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtCommissionName.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Commission Name Missing "
            TxtCommissionName.Focus()
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into Commissions values(" & TxtCommessionID.Text & ",N'" & TxtCommissionName.Text & "',N'" & TxtComments.Text & "')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "insert into UserGroups values(" & GetMax("GroupID", "UserGroups") & ",N'" & TxtCommissionName.Text & "','')"
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Inserted "
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        ClearTextBoxes()
        LockTextBoxes()
        Call gridfill("select * from Commissions where not CommID=0")
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Saving of Records in Commission Form','Saving','" & vUserName & "','Commission')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  Commissions where CommID=" & TxtCommessionID.Text
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete from  UserGroups where GroupName='" & TxtCommissionName.Text & "'"
                cmd.ExecuteNonQuery()
                LblMessage.Visible = True
                LblMessage.Text = "Record Deleted "
                Call gridfill("select * from Commissions where not CommID=0")
            End If
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "You cannot delete it " & ControlChars.NewLine & "it is used by other Process"
        End Try
        ClearTextBoxes()
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Deletion of Records From Commission Form','Deletion','" & vUserName & "','Commission')"
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub txtSearchRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.GotFocus
        If txtSearchRecord.Text = "Search Record(s) by Commission Name" Then
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
            gridfill("select * from Commissions where CommName like N'%" & txtSearchRecord.Text & "%' and not CommID=0")
        End If
    End Sub

    Private Sub txtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.LostFocus
        If txtSearchRecord.Text = "" Then
            txtSearchRecord.Text = "Search Record(s) by Commission Name"
            txtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblMessage.Text = ""
    End Sub
End Class