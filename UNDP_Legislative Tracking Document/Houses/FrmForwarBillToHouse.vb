Imports System.Data.SqlClient
Public Class FrmForwarBillToHouse
    Dim BlHouseID As String
    Dim BliD As String
    Private Sub FrmForwarBillToHouse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboFiller("select HouseID,HouseName from Houses where not HouseID=0", CmbHouse, "HouseName", "HouseID")
        ComboFiller("select StatusID,StatusTitle from Status", CmbStatus, "StatusTitle", "StatusID")
        If vGroupId = 1 Then
            gridfill("SELECT   BillHouse.BlHouseID, Bills.BlTitle, Houses.HouseName, BillHouse.HouseIssuDate, BillHouse.HouseReturnDate, Status.StatusTitle, BillHouse.Comments FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID INNER JOIN Status ON BillHouse.StatusID = Status.StatusID")
        Else
            gridfill("SELECT   BillHouse.BlHouseID, Bills.BlTitle, Houses.HouseName, BillHouse.HouseIssuDate, BillHouse.HouseReturnDate, Status.StatusTitle, BillHouse.Comments FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID INNER JOIN Status ON BillHouse.StatusID = Status.StatusID WHERE Houses.HouseName = '" & vGroupName & "'")
        End If
       LblMessage.Visible = False
        If Not vGroupId = 1 Then
            BtnDelete.Enabled = False
            BtnSave.Enabled = False
            CmbHouse.Enabled = False
            DtpIssueDate.Enabled = False
            DgBill.Enabled = False
            TxtSearchBill.ReadOnly = True
        End If
    End Sub

   
    Private Sub gridfill(ByVal query As String)
        DatasetFill(query, "BillHouse")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("BillHouse").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("BillHouse").Rows(a).Item("BlTitle")
            dgview.Rows(a).Cells(1).Value = ds.Tables("BillHouse").Rows(a).Item("HouseName")
            dgview.Rows(a).Cells(2).Value = ds.Tables("BillHouse").Rows(a).Item("HouseIssuDate")
            dgview.Rows(a).Cells(3).Value = ds.Tables("BillHouse").Rows(a).Item("HouseReturnDate")
            dgview.Rows(a).Cells(4).Value = ds.Tables("BillHouse").Rows(a).Item("StatusTitle")
            dgview.Rows(a).Cells(5).Value = ds.Tables("BillHouse").Rows(a).Item("Comments")
            dgview.Rows(a).Cells(6).Value = ds.Tables("BillHouse").Rows(a).Item("BlHouseID")
        Next
    End Sub
    Private Sub GridBillFill(ByVal query As String)
        DatasetFill(query, "Bills")
        DgBill.Rows.Clear()
        Try
            If Not ds.Tables("Bills").Rows.Count = 0 Then
                For a As Integer = 0 To ds.Tables("Bills").Rows.Count - 1
                    DgBill.Rows.Add()
                    DgBill.Rows(a).Cells(0).Value = ds.Tables("Bills").Rows(a).Item("BlTitle")
                    DgBill.Rows(a).Cells(1).Value = ds.Tables("Bills").Rows(a).Item("BlID")
                    BliD = ds.Tables("Bills").Rows(a).Item("BlID")
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dgview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.Click
        Try
            ' CmbBill.Text = dgview.CurrentRow.Cells(0).Value

            CmbHouse.Text = dgview.CurrentRow.Cells(1).Value
            CmbStatus.Text = dgview.CurrentRow.Cells(4).Value
            TxtComments.Text = dgview.CurrentRow.Cells(5).Value
            BlHouseID = dgview.CurrentRow.Cells(6).Value
            GridBillFill("select BlID,BlTitle from Bills where BlTitle='" & dgview.CurrentRow.Cells(0).Value & "'")
            DtpIssueDate.Value = dgview.CurrentRow.Cells(2).Value
            DtpReturnDate.Text = dgview.CurrentRow.Cells(3).Value
        
        Catch ex As Exception
        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Old Records Before Updation in Forward Bill to Houses Form','Updation','" & vUserName & "','Forward Bill to Houses')"
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
        If CmbHouse.Text = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "House is not Selected "
            CmbHouse.Focus()
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
        DatasetFill("select * from BillHouse where BlID=" & BliD & " and HouseID=" & CmbHouse.SelectedValue, "BillChecking")
        If Not ds.Tables("BillChecking").Rows.Count = 0 Then
            LblMessage.Visible = True
            LblMessage.Text = "Bill is already Forwarded "
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into BillHouse values(" & GetMax("BlHouseID", "BillHouse") & ",'" & BliD & "','" & CmbHouse.SelectedValue & "','" & Format(DtpIssueDate.Value, "MM/dd/yy") & "','" & Format(DtpReturnDate.Value, "MM/dd/yy") & "','" & CmbStatus.SelectedValue & "',N'" & TxtComments.Text & "')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "Insert into BillTraker values(" & GetMax("BlTrakerID", "BillTraker") & ",'" & BliD & "','" & Format(Date.Today, "MM/dd/yy") & "',0,'" & CmbHouse.SelectedValue & "','" & CmbStatus.SelectedValue & "',N'" & TxtComments.Text & "')"
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Saved "
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        If vGroupId = 1 Then
            gridfill("SELECT   BillHouse.BlHouseID, Bills.BlTitle, Houses.HouseName, BillHouse.HouseIssuDate, BillHouse.HouseReturnDate, Status.StatusTitle, BillHouse.Comments FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID INNER JOIN Status ON BillHouse.StatusID = Status.StatusID ")
        Else
            gridfill("SELECT   BillHouse.BlHouseID, Bills.BlTitle, Houses.HouseName, BillHouse.HouseIssuDate, BillHouse.HouseReturnDate, Status.StatusTitle, BillHouse.Comments FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID INNER JOIN Status ON BillHouse.StatusID = Status.StatusID WHERE Houses.HouseName = '" & vGroupName & "'")
        End If
        CmbHouse.SelectedIndex = -1
        CmbStatus.SelectedIndex = -1
        TxtComments.Clear()
        DtpIssueDate.Value = Date.Now
        DtpReturnDate.Value = Date.Now
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Saving Records in Forward Bill to Houses Form','Saving','" & vUserName & "','Forward Bill to Houses')"
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        CheckInput()
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update BillHouse set BlID='" & BliD & "',HouseID='" & CmbHouse.SelectedValue & "',HouseIssuDate='" & Format(DtpIssueDate.Value, "MM/dd/yy") & "',HouseReturnDate='" & Format(DtpReturnDate.Value, "MM/dd/yy") & "',StatusID='" & CmbStatus.SelectedValue & "',Comments=N'" & TxtComments.Text & "' where BlHouseID=" & BlHouseID
            cmd.ExecuteNonQuery()
            cmd.CommandText = "Update BillTraker set BlID='" & BliD & "',HouseID='" & CmbHouse.SelectedValue & "',StatusID='" & CmbStatus.SelectedValue & "',Comments=N'" & TxtComments.Text & "' where BlID=" & BliD & " and HouseID=" & CmbHouse.SelectedValue
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Updated "
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        If vGroupId = 1 Then
            gridfill("SELECT   BillHouse.BlHouseID, Bills.BlTitle, Houses.HouseName, BillHouse.HouseIssuDate, BillHouse.HouseReturnDate, Status.StatusTitle, BillHouse.Comments FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID INNER JOIN Status ON BillHouse.StatusID = Status.StatusID ")
        Else
            gridfill("SELECT   BillHouse.BlHouseID, Bills.BlTitle, Houses.HouseName, BillHouse.HouseIssuDate, BillHouse.HouseReturnDate, Status.StatusTitle, BillHouse.Comments FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID INNER JOIN Status ON BillHouse.StatusID = Status.StatusID WHERE Houses.HouseName = '" & vGroupName & "'")
        End If
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Updation of Records in Forward Bill to Houses Form','Updation','" & vUserName & "','Forward Bill To Houses')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  BillHouse where BlHouseID=" & BlHouseID
                cmd.ExecuteNonQuery()
                LblMessage.Visible = True
                LblMessage.Text = "Record Deleted "
                If vGroupId = 1 Then
                    gridfill("SELECT   BillHouse.BlHouseID, Bills.BlTitle, Houses.HouseName, BillHouse.HouseIssuDate, BillHouse.HouseReturnDate, Status.StatusTitle, BillHouse.Comments FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID INNER JOIN Status ON BillHouse.StatusID = Status.StatusID ")
                Else
                    gridfill("SELECT   BillHouse.BlHouseID, Bills.BlTitle, Houses.HouseName, BillHouse.HouseIssuDate, BillHouse.HouseReturnDate, Status.StatusTitle, BillHouse.Comments FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID INNER JOIN Status ON BillHouse.StatusID = Status.StatusID WHERE Houses.HouseName = '" & vGroupName & "'")
                End If
                         End If
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "First Select Record"
        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Deletion of Records in Forward Bill to Houses Form','Deletion','" & vUserName & "','Forward Bill To Houses')"
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
                gridfill("SELECT   BillHouse.BlHouseID, Bills.BlTitle, Houses.HouseName, BillHouse.HouseIssuDate, BillHouse.HouseReturnDate, Status.StatusTitle, BillHouse.Comments FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID INNER JOIN Status ON BillHouse.StatusID = Status.StatusID where Bills.BlTitle like N'%" & txtSearchRecord.Text & "%' ")
            Else
                gridfill("SELECT   BillHouse.BlHouseID, Bills.BlTitle, Houses.HouseName, BillHouse.HouseIssuDate, BillHouse.HouseReturnDate, Status.StatusTitle, BillHouse.Comments FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID INNER JOIN Status ON BillHouse.StatusID = Status.StatusID where Bills.BlTitle like N'%" & txtSearchRecord.Text & "%' and Houses.HouseName = '" & vGroupName & "'")

            End If
        End If
    End Sub

    Private Sub txtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.LostFocus
        If txtSearchRecord.Text = "" Then
            txtSearchRecord.Text = "Search Record(s) by Bill Title"
            txtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub CmbHouse_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbHouse.GotFocus
        CmbHouse.SelectedIndex = 0
    End Sub

    Private Sub CmbStatus_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbStatus.GotFocus
        CmbStatus.SelectedIndex = 0
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
            Call GridBillFill("select BlID,BlTitle from Bills where BlTitle like N'%" & TxtSearchBill.Text & "%'")
        Else
            Call GridBillFill("SELECT  Bills.BlID, Bills.BlTitle FROM Bills INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID where Houses.HouseName=N'" & vGroupName & "' and Bills.BlTitle like N'%" & TxtSearchBill.Text & "%'")
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
End Class