Imports System.Data.SqlClient
Public Class FrmDepartment
    Dim max As Integer
    Private Sub FrmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainModule.connectionopen()
        LockTextBoxes()
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then
                ctl.BackColor = Color.White
            End If
        Next
        BtnUpdate.Enabled = False
        BtnDelete.Enabled = False
        BtnSave.Enabled = False
        DataGridFill()
        LblShowText.Visible = False
    End Sub
    Private Sub LockTextBoxes()
        TxtDeptID.ReadOnly = True
        TxtDeptName.ReadOnly = True
        TxtComments.ReadOnly = True
    End Sub
    Private Sub UnLockTextBoxes()
        TxtDeptName.ReadOnly = False
        TxtComments.ReadOnly = False
    End Sub
    Private Sub ClearTextBoxes()
        TxtDeptName.Clear()
        TxtDeptID.Text = ""
        TxtComments.Clear()
    End Sub
    Private Sub DataGridFill()
        Try

        
            DatasetFill("Select * from Departments where Not DeptID=1", "Dept")
            DGDepartment.Rows.Clear()
            For a As Integer = 0 To ds.Tables("Dept").Rows.Count - 1
                DGDepartment.Rows.Add()
                DGDepartment.Rows(a).Cells(0).Value = ds.Tables("Dept").Rows(a).Item("DeptID")
                DGDepartment.Rows(a).Cells(1).Value = ds.Tables("Dept").Rows(a).Item("DeptName")
                DGDepartment.Rows(a).Cells(2).Value = ds.Tables("Dept").Rows(a).Item("Comments")
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        UnLockTextBoxes()
        ClearTextBoxes()
        max = GetMax("DeptID", "Departments")
        TxtDeptID.Text = max
        BtnAdd.Enabled = False
        BtnSave.Enabled = True
        LblShowText.Visible = True
        LblShowText.Text = "Enter Proper Record"
        TxtDeptName.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into Departments values(" & TxtDeptID.Text & ",N'" & TxtDeptName.Text & "',N'" & TxtComments.Text & "')"
            cmd.ExecuteNonQuery()
            LblShowText.Visible = True
            LblShowText.Text = "Record Saved Successfully"
            ClearTextBoxes()
            LockTextBoxes()
        Catch ex As Exception
            MsgBox("Error in input Data......")
            Exit Sub
        End Try
        DataGridFill()
        BtnSave.Enabled = False
        BtnAdd.Enabled = True
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Saving in Department Form','Saving','" & vUserName & "','Department')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update Departments Set DeptName=N'" & TxtDeptName.Text & "',Comments=N'" & TxtComments.Text & "' where DeptID=" & TxtDeptID.Text & ""
            cmd.ExecuteNonQuery()
            LblShowText.Visible = True
            LblShowText.Text = "Record Updated Successfully"
            ClearTextBoxes()
        Catch ex As Exception
            MsgBox("Error in input Data......")
            Exit Sub
        End Try
        DataGridFill()
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Updating of Records in Department Form','Updation','" & vUserName & "','Department')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim chi As String
        chi = MsgBox("Do You Want To Delete Current Record", MsgBoxStyle.YesNo)
        If chi = MsgBoxResult.Yes Then
            Call Delete()
        ElseIf chi = MsgBoxResult.No Then
            LblShowText.Visible = True
            LblShowText.Text = "You cannot delete it " & ControlChars.NewLine & "it is used by other Process"
        End If
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Deletion of Records in Department Form','Deletion','" & vUserName & "','Bills')"
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub Delete()
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Delete From Departments where DeptID=" & TxtDeptID.Text & ""
            cmd.ExecuteNonQuery()
            LblShowText.Visible = True
            LblShowText.Text = "Record Deleted "
            ClearTextBoxes()
        Catch ex As Exception
            LblShowText.Visible = True
            LblShowText.Text = "You cannot delete it " & ControlChars.NewLine & "it is used by other Process"
            Exit Sub
        End Try
        DataGridFill()
    End Sub

    Private Sub TxtSearchRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchRecord.GotFocus
        If TxtSearchRecord.Text = "Search Record(s)" Then
            TxtSearchRecord.Text = ""
            TxtSearchRecord.ForeColor = Color.Black
        Else
            TxtSearchRecord.SelectAll()
            TxtSearchRecord.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtSearchRecord_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchRecord.KeyDown
        If TxtSearchRecord.Text.Length > 0 And e.KeyCode = Keys.Enter Then
            Call Search()
        End If
    End Sub

    Private Sub TxtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchRecord.LostFocus
        If TxtSearchRecord.Text = "" Then
            TxtSearchRecord.Text = "Search Record(s)"
            TxtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Search()
        Try
            Dim tbl As New DataTable
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "Select * from Departments where DeptName like N'%" & TxtSearchRecord.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
                LblShowText.Visible = True
                LblShowText.Text = "Record Not Exist"
                DGDepartment.Rows.Clear()
                Exit Sub
            End If
            DGDepartment.Rows.Clear()
            For a As Integer = 0 To tbl.Rows.Count - 1
                DGDepartment.Rows.Add()
                DGDepartment.Rows(a).Cells(0).Value = tbl.Rows(a).Item(0).ToString
                DGDepartment.Rows(a).Cells(1).Value = tbl.Rows(a).Item(1).ToString
                DGDepartment.Rows(a).Cells(2).Value = tbl.Rows(a).Item(2).ToString
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DGDepartment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGDepartment.Click
        Try
            TxtDeptID.Text = DGDepartment.CurrentRow.Cells(0).Value
            TxtDeptName.Text = DGDepartment.CurrentRow.Cells(1).Value
            TxtComments.Text = DGDepartment.CurrentRow.Cells(2).Value
            UnLockTextBoxes()
            BtnUpdate.Enabled = True
            BtnAdd.Enabled = True
            BtnDelete.Enabled = True
        Catch ex As Exception
        End Try
        LblShowText.Visible = True
        LblShowText.Text = "Record Selected From List"
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Old Record Before Updation in Department Form','Updation','" & vUserName & "','Department')"
        cmd.ExecuteNonQuery()
    End Sub

    'Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim tbl As New DataTable
    '        Dim cmd As New SqlCommand
    '        cmd.Connection = con
    '        cmd.CommandText = "Select * from Departments where DeptName !='Null'"
    '        da.SelectCommand = cmd
    '        da.Fill(tbl)
    '        Dim rpt As New RptDepartment
    '        rpt.SetDataSource(tbl)
    '        FrmReportViewer.CrViewer.ReportSource = rpt
    '        FrmReportViewer.ShowDialog()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub DGDepartment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGDepartment.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                Dim a As Object
                a = DGDepartment.CurrentRow.Index
                a = a - 1
                DGDepartment.ClearSelection()
                DGDepartment.CurrentCell = DGDepartment.Rows(a).Cells(0)
                DGDepartment.Rows(a).Selected = True
                DGDepartment_Click(sender, e)
            End If
        Catch ex As Exception
        End Try
        LblShowText.Visible = True
        LblShowText.Text = "Record Selected from List"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblShowText.Text = ""
    End Sub
End Class