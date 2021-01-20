Imports System.Data.SqlClient
Public Class FrmForwardBillToCommission
    Dim BlCommissionID As String
    Dim BlId As String
   
    Private Sub gridfill(ByVal query As String)
        DatasetFill(query, "BillCommission")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("BillCommission").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("BillCommission").Rows(a).Item("BlTitle")
            dgview.Rows(a).Cells(1).Value = ds.Tables("BillCommission").Rows(a).Item("CommName")
            dgview.Rows(a).Cells(2).Value = ds.Tables("BillCommission").Rows(a).Item("CommIssueDate")
            dgview.Rows(a).Cells(3).Value = ds.Tables("BillCommission").Rows(a).Item("CommReturnDate")
            dgview.Rows(a).Cells(4).Value = ds.Tables("BillCommission").Rows(a).Item("StatusTitle")
            dgview.Rows(a).Cells(5).Value = ds.Tables("BillCommission").Rows(a).Item("Comments")
            dgview.Rows(a).Cells(6).Value = ds.Tables("BillCommission").Rows(a).Item("BlCommID")
        Next
    End Sub
    Private Sub GridBillFill(ByVal query As String)
        DatasetFill(query, "Bills")
        DgBill.Rows.Clear()
        For a As Integer = 0 To ds.Tables("Bills").Rows.Count - 1
            DgBill.Rows.Add()
            DgBill.Rows(a).Cells(0).Value = ds.Tables("Bills").Rows(a).Item("BlTitle")
            DgBill.Rows(a).Cells(1).Value = ds.Tables("Bills").Rows(a).Item("BlID")
            BlId = ds.Tables("Bills").Rows(a).Item("BlID")
        Next
    End Sub
    Private Sub dgview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.Click
        Try
            ' CmbBill.Text = dgview.CurrentRow.Cells(0).Value

            CmbCommission.Text = dgview.CurrentRow.Cells(1).Value
            CmbStatus.Text = dgview.CurrentRow.Cells(4).Value
            TxtComments.Text = dgview.CurrentRow.Cells(5).Value
            BlCommissionID = dgview.CurrentRow.Cells(6).Value
            GridBillFill("select BlID,BlTitle from Bills where BlTitle=N'" & dgview.CurrentRow.Cells(0).Value & "'")
            DtpIssueDate.Value = dgview.CurrentRow.Cells(2).Value
            DtpReturnDate.Text = dgview.CurrentRow.Cells(3).Value
          
        Catch ex As Exception
        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Old Records Before Updation in Forward Bill to Commission Form','Updation','" & vUserName & "','Forward Bill To Commmission')"
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
    Private Sub CheckInput()
        If BlId = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Bill is Not Selected "
            TxtSearchBill.Focus()
            Exit Sub
        End If
        If CmbCommission.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Commission is not Selected "
            CmbCommission.Focus()
            Exit Sub
        End If
        If CmbStatus.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Status is not Selected "
            CmbStatus.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        CheckInput()
        DatasetFill("select * from BillCommissions where BlID=" & BlId & " and CommID=" & CmbCommission.SelectedValue, "BillChecking")
        If Not ds.Tables("BillChecking").Rows.Count = 0 Then
            LblMessage.Visible = True
            LblMessage.Text = "Bill is Already Forwarded "
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into BillCommissions values(" & GetMax("BlCommID", "BillCommissions") & ",'" & BlId & "','" & CmbCommission.SelectedValue & "','" & CmbStatus.SelectedValue & "','" & Format(DtpIssueDate.Value, "MM/dd/yy") & "','" & Format(DtpReturnDate.Value, "MM/dd/yy") & "',N'" & TxtComments.Text & "')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "Insert into BillTraker values(" & GetMax("BlTrakerID", "BillTraker") & ",'" & BlId & "','" & Format(Date.Today, "MM/dd/yy") & "','" & CmbCommission.SelectedValue & "',0,'" & CmbStatus.SelectedValue & "',N'" & TxtComments.Text & "')"
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Saved  "
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input  "
            Exit Sub
        End Try
        If vGroupId = 1 Then
            gridfill("SELECT  BillCommissions.BlCommID, Bills.BlTitle, Commissions.CommName, BillCommissions.CommIssueDate, BillCommissions.CommReturnDate, Status.StatusTitle, BillCommissions.Comments FROM BillCommissions INNER JOIN Bills ON BillCommissions.BlID = Bills.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN Status ON BillCommissions.StatusID = Status.StatusID  ")
        Else
            gridfill("SELECT  BillCommissions.BlCommID, Bills.BlTitle, Commissions.CommName, BillCommissions.CommIssueDate, BillCommissions.CommReturnDate, Status.StatusTitle, BillCommissions.Comments FROM BillCommissions INNER JOIN Bills ON BillCommissions.BlID = Bills.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN Status ON BillCommissions.StatusID = Status.StatusID WHERE  Commissions.CommName  = N'" & vGroupName & "'")
        End If
        CmbCommission.SelectedIndex = -1
        CmbStatus.SelectedIndex = -1
        TxtComments.Clear()
        DtpIssueDate.Value = Date.Now
        DtpReturnDate.Value = Date.Now
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Saving Records in Forward Bill to Commission Form','Saving','" & vUserName & "','Forward Bill to Commission')"
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        CheckInput()
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update BillCommissions set BlID='" & BlId & "',CommID='" & CmbCommission.SelectedValue & "',CommIssueDate='" & Format(DtpIssueDate.Value, "MM/dd/yy") & "',CommReturnDate='" & Format(DtpReturnDate.Value, "MM/dd/yy") & "',StatusID='" & CmbStatus.SelectedValue & "',Comments=N'" & TxtComments.Text & "' where BlCommID=" & BlCommissionID
            cmd.ExecuteNonQuery()
            cmd.CommandText = "Update BillTraker set BlID='" & BlId & "',BlCommID='" & CmbCommission.SelectedValue & "',StatusID='" & CmbStatus.SelectedValue & "',Comments=N'" & TxtComments.Text & "' where BlID=" & BlId & " and BlCommID=" & CmbCommission.SelectedValue
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Updated "
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        If vGroupId = 1 Then
            gridfill("SELECT  BillCommissions.BlCommID, Bills.BlTitle, Commissions.CommName, BillCommissions.CommIssueDate, BillCommissions.CommReturnDate, Status.StatusTitle, BillCommissions.Comments FROM BillCommissions INNER JOIN Bills ON BillCommissions.BlID = Bills.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN Status ON BillCommissions.StatusID = Status.StatusID  ")
        Else
            gridfill("SELECT  BillCommissions.BlCommID, Bills.BlTitle, Commissions.CommName, BillCommissions.CommIssueDate, BillCommissions.CommReturnDate, Status.StatusTitle, BillCommissions.Comments FROM BillCommissions INNER JOIN Bills ON BillCommissions.BlID = Bills.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN Status ON BillCommissions.StatusID = Status.StatusID WHERE  Commissions.CommName  = N'" & vGroupName & "'")
        End If
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Updation of Records in Forward Bill to Commission Form','Updation','" & vUserName & "','Forward Bill to Commission')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  BillCommissions where BlCommID=" & BlCommissionID
                cmd.ExecuteNonQuery()
                LblMessage.Visible = True
                LblMessage.Text = "Record Deleted "
                If vGroupId = 1 Then
                    gridfill("SELECT  BillCommissions.BlCommID, Bills.BlTitle, Commissions.CommName, BillCommissions.CommIssueDate, BillCommissions.CommReturnDate, Status.StatusTitle, BillCommissions.Comments FROM BillCommissions INNER JOIN Bills ON BillCommissions.BlID = Bills.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN Status ON BillCommissions.StatusID = Status.StatusID  ")
                Else
                    gridfill("SELECT  BillCommissions.BlCommID, Bills.BlTitle, Commissions.CommName, BillCommissions.CommIssueDate, BillCommissions.CommReturnDate, Status.StatusTitle, BillCommissions.Comments FROM BillCommissions INNER JOIN Bills ON BillCommissions.BlID = Bills.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN Status ON BillCommissions.StatusID = Status.StatusID WHERE  Commissions.CommName  = N'" & vGroupName & "'")
                End If
            End If
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "First select Record "
        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Deletion of Records in Forward Bill to Commission Form','Deletion','" & vUserName & "','Forward Bill to Commission')"
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub txtSearchRecord_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.GotFocus
        If txtSearchRecord.Text = "Search Record(s) by Bill Title" Then
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
            If vGroupId = 1 Then
                gridfill("SELECT  BillCommissions.BlCommID, Bills.BlTitle, Commissions.CommName, BillCommissions.CommIssueDate, BillCommissions.CommReturnDate, Status.StatusTitle, BillCommissions.Comments FROM BillCommissions INNER JOIN Bills ON BillCommissions.BlID = Bills.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN Status ON BillCommissions.StatusID = Status.StatusID WHERE  Bills.BlTitle like N'%" & txtSearchRecord.Text & "%'")
            Else
                gridfill("SELECT  BillCommissions.BlCommID, Bills.BlTitle, Commissions.CommName, BillCommissions.CommIssueDate, BillCommissions.CommReturnDate, Status.StatusTitle, BillCommissions.Comments FROM BillCommissions INNER JOIN Bills ON BillCommissions.BlID = Bills.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN Status ON BillCommissions.StatusID = Status.StatusID WHERE  Commissions.CommName  = N'" & vGroupName & "' and  Bills.BlTitle like N'%" & txtSearchRecord.Text & "%'")
            End If
              End If
    End Sub

    Private Sub txtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.LostFocus
        If txtSearchRecord.Text = "" Then
            txtSearchRecord.Text = "Search Record(s) by Bill Title"
            txtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub CmbStatus_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbStatus.GotFocus
        CmbStatus.SelectedIndex = 0
    End Sub

    Private Sub CmbCommission_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCommission.GotFocus
        CmbCommission.SelectedIndex = 0
    End Sub
    Private Sub TxtSearchBill_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchBill.GotFocus
        If TxtSearchBill.Text = "Search Record(s) by Bill Title" Then
            TxtSearchBill.Text = ""
            TxtSearchBill.ForeColor = Color.Black
        Else
            TxtSearchBill.SelectAll()
            TxtSearchBill.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TxtSearchBill_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchBill.LostFocus
        If TxtSearchBill.Text = "" Then
            TxtSearchBill.Text = "Search Record(s) by Bill Title"
            TxtSearchBill.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TxtSearchBill_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchBill.TextChanged
        If TxtSearchBill.Text = "" Then
            DgBill.Rows.Clear()
            Exit Sub
        End If
        If vGroupId = 1 Then
            Call GridBillFill("SELECT  Bills.BlID, Bills.BlTitle FROM   Bills  where BlTitle like N'%" & TxtSearchBill.Text & "%'")

        Else
            Call GridBillFill("SELECT  Bills.BlID, Bills.BlTitle FROM Bills INNER JOIN BillCommissions ON Bills.BlID = BillCommissions.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID WHERE Commissions.CommName = N'" & vGroupName & "' AND Bills.BlTitle LIKE N'%" & TxtSearchBill.Text & "%'")

        End If
           End Sub

    Private Sub DgBill_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgBill.Click
        Try
            BlId = DgBill.CurrentRow.Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgBill_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DgBill.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Dim a As Object
            a = DgBill.CurrentRow.Index
            a = a - 1
            DgBill.ClearSelection()
            DgBill.CurrentCell = DgBill.Rows(a).Cells(0)
            DgBill.Rows(a).Selected = True
            DgBill_Click(sender, e)
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblMessage.Text = ""
    End Sub

    Private Sub FrmForwardBillToCommission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not vGroupId = 1 Then
            BtnDelete.Enabled = False
            BtnSave.Enabled = False
            CmbCommission.Enabled = False
            DtpIssueDate.Enabled = False
            DgBill.Enabled = False
            TxtSearchBill.ReadOnly = True
        End If
        ComboFiller("select CommID,CommName from Commissions where not CommID=0", CmbCommission, "CommName", "CommID")
        ComboFiller("select StatusID,StatusTitle from Status", CmbStatus, "StatusTitle", "StatusID")
        If vGroupId = 1 Then
            gridfill("SELECT  BillCommissions.BlCommID, Bills.BlTitle, Commissions.CommName, BillCommissions.CommIssueDate, BillCommissions.CommReturnDate, Status.StatusTitle, BillCommissions.Comments FROM BillCommissions INNER JOIN Bills ON BillCommissions.BlID = Bills.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN Status ON BillCommissions.StatusID = Status.StatusID  ")
        Else
            gridfill("SELECT  BillCommissions.BlCommID, Bills.BlTitle, Commissions.CommName, BillCommissions.CommIssueDate, BillCommissions.CommReturnDate, Status.StatusTitle, BillCommissions.Comments FROM BillCommissions INNER JOIN Bills ON BillCommissions.BlID = Bills.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN Status ON BillCommissions.StatusID = Status.StatusID WHERE  Commissions.CommName  = N'" & vGroupName & "'")
        End If
        LblMessage.Visible = False
     
    End Sub

    
End Class