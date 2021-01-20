Imports System.Data.SqlClient
Public Class FrmHouses
    Private Sub FrmHouses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LockTextBoxes()
        TxtHouseID.Enabled = False
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then
                ctl.BackColor = Color.White
            End If
        Next
        Call gridfill("select * from Houses where not HouseID=0")
        BtnUpdate.Enabled = False
        LblMessage.Visible = False
    End Sub

    Private Sub LockTextBoxes()
        TxtHouseName.ReadOnly = True
    End Sub
    Private Sub UnlockTextBoxes()
        TxtHouseName.ReadOnly = False
    End Sub
    Private Sub ClearTextBoxes()
        TxtHouseID.Clear()
        TxtHouseName.Clear()
    End Sub
    Private Sub gridfill(ByVal query As String)
        DatasetFill(query, "Houses")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("Houses").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("Houses").Rows(a).Item("HouseID")
            dgview.Rows(a).Cells(1).Value = ds.Tables("Houses").Rows(a).Item("HouseName")
        Next
    End Sub
    Private Sub dgview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.Click
        UnlockTextBoxes()
        Try
            TxtHouseID.Text = dgview.CurrentRow.Cells(0).Value
            TxtHouseName.Text = dgview.CurrentRow.Cells(1).Value
        Catch ex As Exception

        End Try
        BtnUpdate.Enabled = True
        BtnSave.Enabled = False
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Old Records Before Updation in Houses Form','Updation','" & vUserName & "','Houses')"
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
        TxtHouseName.Focus()
        TxtHouseID.Text = GetMax("HouseID", "Houses")
    End Sub

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If TxtHouseName.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "House Name is not Entered "
            TxtHouseName.Focus()
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update Houses set HouseName=N'" & TxtHouseName.Text & "' where HouseID=" & TxtHouseID.Text
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Updated "
            UnlockTextBoxes()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input"
            Exit Sub
        End Try
        Call gridfill("select * from Houses where not HouseID=0")
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Updation of Records in Houses Form','Updation','" & vUserName & "','Houses')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtHouseName.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "House Name is not Entered "
            TxtHouseName.Focus()
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into Houses values(" & TxtHouseID.Text & ",N'" & TxtHouseName.Text & "')"
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Saved "
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        ClearTextBoxes()
        Call gridfill("select * from Houses where not HouseID=0")
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Saving of Records in Houses Form','Saving','" & vUserName & "','Houses')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  Houses where HouseID=" & TxtHouseID.Text
                cmd.ExecuteNonQuery()
                LblMessage.Visible = True
                LblMessage.Text = "Record Deleted "
                Call gridfill("select * from Houses where not HouseID=0")
            End If
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "You cannot delete it " & ControlChars.NewLine & "it is used by other Process"
        End Try
        ClearTextBoxes()
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Deletion of Records in Houses Form','Deletion','" & vUserName & "','Houses')"
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub txtSearchRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.GotFocus
        If txtSearchRecord.Text = "Search Record(s) by House Name" Then
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
            gridfill("select * from Houses where HouseName like N'%" & txtSearchRecord.Text & "%' and not HouseID=0")
        End If
    End Sub

    Private Sub txtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.LostFocus
        If txtSearchRecord.Text = "" Then
            txtSearchRecord.Text = "Search Record(s) by House Name"
            txtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblMessage.Text = ""
    End Sub
End Class