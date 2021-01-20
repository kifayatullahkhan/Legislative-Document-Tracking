Imports System.Data.SqlClient
Public Class FrmBillAmmendments
    Dim BlAmmendmentID As String
    Dim BlId As String
    'Public _TextBox1 As String
    'Private _Text1 As String
    'Public Property [Text1]() As String
    '    Get
    '        Return _Text1
    '    End Get
    '    Set(ByVal Value As String)
    '        _Text1 = Value
    '        ab = _Text1
    '    End Set
    'End Property
    'Public Property [Textbox1]() As String
    '    Get
    '        Return _TextBox1
    '    End Get
    '    Set(ByVal Value As String)
    '        _TextBox1 = Value
    '        bc = _TextBox1
    '        TxtPashto.Text = bc
    '        Call fun()
    '    End Set
    'End Property
    'Private Sub fun()
    '    TxtPashto.Text = bc
    'End Sub
    ' Private _ As String
    Public ReadOnly Property UserName() As String
        Get
            Return TxtPashto.Text
        End Get
    End Property

    Public ReadOnly Property UserName1() As String
        Get
            Return TxtDari.Text
        End Get
    End Property

    Private Sub FrmBillAmmendments_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlAdded
        If ab = "TextPashto" Then
            TxtPashto.Text = bc
            ab = ""
            bc = ""
        Else
            TxtDari.Text = bc
            ab = ""
            bc = ""
        End If
    End Sub

    Private Sub FrmUserInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If vGroupId = 1 Then
            Call gridfill("SELECT BillAmmendments.BlAmID, Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM BillAmmendments INNER JOIN Bills ON BillAmmendments.BlID = Bills.BlID")
        Else
            Call gridfill("SELECT BillAmmendments.BlAmID, Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM BillAmmendments INNER JOIN Bills ON BillAmmendments.BlID = Bills.BlID where BillAmmendments.AmBy=N'" & vGroupName & "'")
        End If
          LockTextBoxes()
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
        TxtPashto.ReadOnly = True
        TxtDari.ReadOnly = True
        TxtComments.ReadOnly = True
        DgBill.Enabled = False
        TxtSearchBill.ReadOnly = True
    End Sub
    Private Sub UnlockTextBoxes()
        TxtPashto.ReadOnly = False
        TxtDari.ReadOnly = False
        TxtComments.ReadOnly = False
        DgBill.Enabled = True
        TxtSearchBill.ReadOnly = False
    End Sub
    Private Sub ClearTextBoxes()
        TxtPashto.Clear()
        TxtDari.Clear()
        TxtComments.Clear()
        DgBill.Rows.Clear()
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
    Private Sub gridfill(ByVal query As String)
        DatasetFill(query, "BillAmmendments")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("BillAmmendments").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("BillAmmendments").Rows(a).Item("BlTitle")
            dgview.Rows(a).Cells(1).Value = ds.Tables("BillAmmendments").Rows(a).Item("BlTextPashto")
            dgview.Rows(a).Cells(2).Value = ds.Tables("BillAmmendments").Rows(a).Item("BlTextDari")
            dgview.Rows(a).Cells(3).Value = ds.Tables("BillAmmendments").Rows(a).Item("Comments")
            dgview.Rows(a).Cells(4).Value = ds.Tables("BillAmmendments").Rows(a).Item("AmBy")
            dgview.Rows(a).Cells(5).Value = ds.Tables("BillAmmendments").Rows(a).Item("BlAmID")
        Next
    End Sub
    Private Sub dgview_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgview.Click

        UnlockTextBoxes()
        Try
            ' CmbBill.Text = dgview.CurrentRow.Cells(0).Value

            GridBillFill("select BlID,BlTitle from Bills where BlTitle='" & dgview.CurrentRow.Cells(0).Value & "'")
            TxtPashto.Text = dgview.CurrentRow.Cells(1).Value
            TxtDari.Text = dgview.CurrentRow.Cells(2).Value
            TxtComments.Text = dgview.CurrentRow.Cells(3).Value
            BlAmmendmentID = dgview.CurrentRow.Cells(5).Value
        Catch ex As Exception

        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Old Record Before Updation in Bill Ammendments Form','Updation','" & vUserName & "','Bill Ammendment')"
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
        TxtSearchBill.Focus()
        BlId = ""
    End Sub

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If BlId = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Bill is not selected "
            TxtSearchBill.Focus()
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Update BillAmmendments set BlID='" & BlId & "',BlTextPashto=N'" & TxtPashto.Text & "',BlTextDari=N'" & TxtDari.Text & "',Comments=N'" & TxtComments.Text & "',AmBy=N'" & vGroupName & "' where BlAmID=" & BlAmmendmentID
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record Updated "
            LockTextBoxes()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input "
            Exit Sub
        End Try
        If vGroupId = 1 Then
            Call gridfill("SELECT BillAmmendments.BlAmID, Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM BillAmmendments INNER JOIN Bills ON BillAmmendments.BlID = Bills.BlID")
        Else
            Call gridfill("SELECT BillAmmendments.BlAmID, Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM BillAmmendments INNER JOIN Bills ON BillAmmendments.BlID = Bills.BlID where BillAmmendments.AmBy=N'" & vGroupName & "'")
        End If
        Dim Data = TxtSearchBill.Text + " " + TxtDari.Text + " " + TxtPashto.Text + " " + TxtComments.Text
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Updation of Records in Bill Ammendments Form','Updation','" & vUserName & "','Bill Ammendments')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If BlId = "" Then
            LblMessage.Visible = True
            LblMessage.Text = "Bill is not selected "
            TxtSearchBill.Focus()
            Exit Sub
        End If
        Try
            connectionopen()
            cmd.Connection = con
            cmd.CommandText = "Insert into BillAmmendments values(" & GetMax("BlAmID", "BillAmmendments") & ",'" & BlId & "',N'" & TxtPashto.Text & "',N'" & TxtDari.Text & "',N'" & TxtComments.Text & "',N'" & vGroupName & "')"
            cmd.ExecuteNonQuery()
            LblMessage.Visible = True
            LblMessage.Text = "Record inserted "
            ClearTextBoxes()
            LockTextBoxes()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Error in Input"
            Exit Sub
        End Try
        If vGroupId = 1 Then
            Call gridfill("SELECT BillAmmendments.BlAmID, Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM BillAmmendments INNER JOIN Bills ON BillAmmendments.BlID = Bills.BlID")
        Else
            Call gridfill("SELECT BillAmmendments.BlAmID, Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM BillAmmendments INNER JOIN Bills ON BillAmmendments.BlID = Bills.BlID where BillAmmendments.AmBy=N'" & vGroupName & "'")
        End If
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Saving in Bill Ammendments Form','Saving','" & vUserName & "','Bill Ammendments')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  BillAmmendments where BlAmID=" & BlAmmendmentID
                cmd.ExecuteNonQuery()
                LblMessage.Visible = True
                LblMessage.Text = "Record Deleted "
                If vGroupId = 1 Then
                    Call gridfill("SELECT BillAmmendments.BlAmID, Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM BillAmmendments INNER JOIN Bills ON BillAmmendments.BlID = Bills.BlID")
                Else
                    Call gridfill("SELECT BillAmmendments.BlAmID, Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM BillAmmendments INNER JOIN Bills ON BillAmmendments.BlID = Bills.BlID where BillAmmendments.AmBy=N'" & vGroupName & "'")
                End If
                ClearTextBoxes()
                LockTextBoxes()
            End If
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = "Select Record First "
        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Deletion of Records in Bill Ammendments Form','Deletion','" & vUserName & "','Bill Ammendments')"
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
                Call gridfill("SELECT BillAmmendments.BlAmID, Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM BillAmmendments INNER JOIN Bills ON BillAmmendments.BlID = Bills.BlID where Bills.BlTitle like N'%" & txtSearchRecord.Text & "%'")
            Else
                Call gridfill("SELECT BillAmmendments.BlAmID, Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM BillAmmendments INNER JOIN Bills ON BillAmmendments.BlID = Bills.BlID where Bills.BlTitle like N'%" & txtSearchRecord.Text & "%' and BillAmmendments.AmBy=N'" & vGroupName & "'")
            End If
        End If
    End Sub

    Private Sub txtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRecord.LostFocus
        If txtSearchRecord.Text = "" Then
            txtSearchRecord.Text = "Search Record(s) by Bill Title"
            txtSearchRecord.ForeColor = Color.Gray
        End If
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
            Exit Sub
        End If
        If vGroupId = 1 Then
            Call GridBillFill("SELECT  Bills.BlID, Bills.BlTitle FROM   Bills  where BlTitle like N'%" & TxtSearchBill.Text & "%'")
        Else
            Call GridBillFill("SELECT Bills.BlID, Bills.BlTitle FROM Bills INNER JOIN BillCommissions ON Bills.BlID = BillCommissions.BlID INNER JOIN Commissions ON BillCommissions.CommID = Commissions.CommID INNER JOIN BillHouse ON Bills.BlID = BillHouse.BlID INNER JOIN Houses ON BillHouse.HouseID = Houses.HouseID WHERE Commissions.CommName = N'" & vGroupName & "' OR Houses.HouseName = N'" & vGroupName & "' AND Bills.BlTitle LIKE N'%" & TxtSearchBill.Text & "%'")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Obj As New FrmView
        'Obj.PassedText = TxtPashto.Text
        'Obj.Textbox = "TxtPashto"
        Obj.Show()
        Obj.T.Text = TxtPashto.Text
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
        Obj.T.Text = TxtDari.Text
        Obj.T2.Text = "TextDari"

    End Sub

    Private Sub Button1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.LostFocus
        If ab = "TextPashto" Then
            TxtPashto.Text = bc
            ab = ""
            bc = ""
        ElseIf ab = "TextDari" Then
            TxtDari.Text = bc
            ab = ""
            bc = ""
        End If
    End Sub
    Private Sub Button2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.LostFocus
        Button1_LostFocus(sender, e)

    End Sub
End Class