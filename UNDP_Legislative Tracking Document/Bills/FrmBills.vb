Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.UI.Page
Public Class FrmBills
    Dim max As Integer
    Dim cmdbuld As New SqlCommandBuilder
    Dim DAP As New SqlDataAdapter
    Dim TblUser As New DataTable
    Dim TblUser2 As New DataTable
    Dim CurrRow As DataRow
    Dim bytes As Byte() = Nothing
    Dim filename As String = ""
    Public ReadOnly Property UserName() As String
        Get
            Return TxtBilTextinPashto.Text
        End Get
    End Property

    Public ReadOnly Property UserName1() As String
        Get
            Return TxtBillinDari.Text
        End Get
    End Property
    Private Sub FrmBills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainModule.connectionopen()
        ComboFiller("Select * from Departments where DeptID !=" & 1, CmbDept, "DeptName", "DeptID")
        Call DataGridMemberSearch()
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
        TblUser = LoadTble("Select * From Bills", cmd, DAP)
    End Sub
    Private Sub DataGridFill()
        Try
            DatasetFill("select  *,(select DeptName  from Departments where Departments.Deptid=Bills.DeptID)as Department from Bills", "Bills")
            DGBills.Rows.Clear()
            For a As Integer = 0 To ds.Tables("Bills").Rows.Count - 1
                DGBills.Rows.Add()
                DGBills.Rows(a).Cells(0).Value = ds.Tables("Bills").Rows(a).Item("BlID")
                DGBills.Rows(a).Cells(1).Value = ds.Tables("Bills").Rows(a).Item("BlNumber")
                DGBills.Rows(a).Cells(2).Value = ds.Tables("Bills").Rows(a).Item("BlTitle")
                DGBills.Rows(a).Cells(3).Value = ds.Tables("Bills").Rows(a).Item("BlTextPashto")
                DGBills.Rows(a).Cells(4).Value = ds.Tables("Bills").Rows(a).Item("BlTextDari")
                DGBills.Rows(a).Cells(5).Value = ds.Tables("Bills").Rows(a).Item("BlIssuDate")
                DGBills.Rows(a).Cells(6).Value = ds.Tables("Bills").Rows(a).Item("DeptID")
                DGBills.Rows(a).Cells(7).Value = ds.Tables("Bills").Rows(a).Item("BlMembers")
                DGBills.Rows(a).Cells(8).Value = ds.Tables("Bills").Rows(a).Item("Comments")
                DGBills.Rows(a).Cells(9).Value = ds.Tables("Bills").Rows(a).Item("Department")
                DGBills.Rows(a).Cells(10).Value = ds.Tables("Bills").Rows(a).Item("FileName")
                DGBills.Rows(a).Cells(11).Value = ds.Tables("Bills").Rows(a).Item("Data")
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LockTextBoxes()
        TxtBillID.ReadOnly = True
        TxtBillTitle.ReadOnly = True
        TxtBillNumber.ReadOnly = True
        TxtBilTextinPashto.ReadOnly = True
        TxtBillinDari.ReadOnly = True
        TxtComments.ReadOnly = True
    End Sub
    Private Sub UnLockTextBoxes()
        TxtBillTitle.ReadOnly = False
        TxtBillNumber.ReadOnly = False
        TxtBilTextinPashto.ReadOnly = False
        TxtBillinDari.ReadOnly = False
        TxtComments.ReadOnly = False
    End Sub
    Private Sub ClearTextBoxes()
        TxtBillID.Text = ""
        TxtBillTitle.Clear()
        TxtBillNumber.Clear()
        TxtBilTextinPashto.Clear()
        TxtBillinDari.Clear()
        TxtComments.Clear()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        UnLockTextBoxes()
        ClearTextBoxes()
        max = GetMax("BlID", "Bills")
        TxtBillID.Text = max
        BtnAdd.Enabled = False
        BtnSave.Enabled = True
        LblShowText.Visible = True
        LblShowText.Text = "Enter Proper Record"
        TxtBillNumber.Focus()
    End Sub

    Private Sub RadDept_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDept.CheckedChanged
        If RadDept.Checked = True Then
            LblDept.Visible = True
            CmbDept.Visible = True
            CmbDept.Focus()
        Else
            LblDept.Visible = False
            CmbDept.Visible = False
        End If
    End Sub
    Private Sub SearchMembers()
        Try
            Dim tbl As New DataTable
            cmd.Connection = con
            cmd.CommandText = "SELECT MemberID, MemberName FROM Members where MemberName like '%" & TxtMemberSrc.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(tbl)
            DGMemb.Rows.Clear()
            For i As Integer = 0 To tbl.Rows.Count - 1
                DGMemb.Rows.Add()
                DGMemb.Rows.Item(i).Cells(0).Value = tbl.Rows(i).Item(0).ToString
                DGMemb.Rows.Item(i).Cells(1).Value = tbl.Rows(i).Item(1).ToString
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMember.CheckedChanged
        If RadMember.Checked = True Then
            GrBoxMember.Visible = True

            DGMemb.Focus()
        Else
            GrBoxMember.Visible = False
        End If
    End Sub
    Private Sub DataGridMemberSearch()
        Try
            Dim tbl As New DataTable
            cmd.Connection = con
            cmd.CommandText = "SELECT MemberID, MemberName FROM Members"
            da.SelectCommand = cmd
            da.Fill(tbl)
            DGMemb.Rows.Clear()
            For i As Integer = 0 To tbl.Rows.Count - 1
                DGMemb.Rows.Add()
                DGMemb.Rows.Item(i).Cells(0).Value = tbl.Rows(i).Item(0).ToString
                DGMemb.Rows.Item(i).Cells(1).Value = tbl.Rows(i).Item(1).ToString
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridMember()
        Try
            Dim tbl As New DataTable
            cmd.Connection = con
            cmd.CommandText = "SELECT Bills.BlID,Members.MemberID,  Members.MemberName FROM BillMembers INNER JOIN Bills ON  BillMembers.BilID =  Bills.BlID INNER JOIN Members ON  BillMembers.MemberID =  Members.MemberID where Bills.BlNumber=" & DGBills.CurrentRow.Cells(1).Value
            da.SelectCommand = cmd
            da.Fill(tbl)
            DGMembers.Rows.Clear()
            If tbl.Rows.Count = 0 Then
                BtnUpdate.Enabled = True
                BtnDelete.Enabled = True
                Exit Sub
            End If
            For i As Integer = 0 To tbl.Rows.Count - 1
                DGMembers.Rows.Add()
                DGMembers.Rows.Item(i).Cells(0).Value = tbl.Rows(i).Item(0).ToString
                DGMembers.Rows.Item(i).Cells(1).Value = tbl.Rows(i).Item(1).ToString
                DGMembers.Rows.Item(i).Cells(2).Value = tbl.Rows(i).Item(2).ToString
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        ' Try
        connectionopen()
        cmd.Connection = con
        If RadDept.Checked = True Then
            Dim CmdBuld As New SqlCommandBuilder(DAP)
            Dim NewRow As DataRow
            NewRow = TblUser.NewRow
            NewRow(0) = TxtBillID.Text
            NewRow(1) = TxtBillNumber.Text
            NewRow(2) = TxtBillTitle.Text
            NewRow(3) = TxtBilTextinPashto.Text
            NewRow(4) = TxtBillinDari.Text
            NewRow(5) = Format(IssueDate.Value, "MM/dd/yy")
            NewRow(6) = CmbDept.SelectedValue
            NewRow(7) = "False"
            NewRow(8) = TxtComments.Text & "'"
            NewRow(9) = filename
            NewRow(10) = bytes
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            TblUser.Rows.Add(NewRow)
            DAP.Update(TblUser)
            ' cmd.CommandText = "Insert into Bills values(" & TxtBillID.Text & "," & TxtBillNumber.Text & ",N'" & TxtBillTitle.Text & "',N'" & TxtBilTextinPashto.Text & "',N'" & TxtBillinDari.Text & "','" & Format(IssueDate.Value, "MM/dd/yy") & "'," & CmbDept.SelectedValue & ",'False',N'" & TxtComments.Text & "','" & filename & "','" & bytes & "')"
            'cmd.ExecuteNonQuery()
        ElseIf RadMember.Checked = True Then
            'cmd.CommandText = "Insert into Bills values(" & TxtBillID.Text & "," & TxtBillNumber.Text & ",N'" & TxtBillTitle.Text & "',N'" & TxtBilTextinPashto.Text & "',N'" & TxtBillinDari.Text & "','" & Format(IssueDate.Value, "MM/dd/yy") & "'," & 1 & ",'True',N'" & TxtComments.Text & "')"
            'cmd.ExecuteNonQuery()
            Dim CmdBuld As New SqlCommandBuilder(DAP)
            Dim NewRow As DataRow
            NewRow = TblUser.NewRow
            NewRow(0) = TxtBillID.Text
            NewRow(1) = TxtBillNumber.Text
            NewRow(2) = TxtBillTitle.Text
            NewRow(3) = TxtBilTextinPashto.Text
            NewRow(4) = TxtBillinDari.Text
            NewRow(5) = Format(IssueDate.Value, "MM/dd/yy")
            NewRow(6) = "1"
            NewRow(7) = "True"
            NewRow(8) = TxtComments.Text
            NewRow(9) = filename
            NewRow(10) = bytes
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            TblUser.Rows.Add(NewRow)
            DAP.Update(TblUser)
            'cmd.CommandText = "Insert into BillMembers values(" & TxtBillID.Text & "," & DGMemb.CurrentRow.Cells(0).Value & ",N'" & TxtComments.Text & "') "
            'cmd.ExecuteNonQuery()
        End If
        LblShowText.Visible = True
        LblShowText.Text = "Record Saved Successfully"
        ClearTextBoxes()
        LockTextBoxes()
        DataGridFill()
        BtnSave.Enabled = False
        BtnAdd.Enabled = True
        BtnAdMembers.Visible = True
        Call DataGridMemberSearch()
        'Catch ex As Exception
        ' End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Saving Records in Bills Form','Saving','" & vUserName & "','Bills')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnAdMembers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdMembers.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            Dim tbl As New DataTable
            DatasetFill("Select * from BillMembers where BilID=" & DGBills.CurrentRow.Cells(0).Value & " and MemberID=" & DGMemb.CurrentRow.Cells(0).Value, "CheckMember")
            If ds.Tables("CheckMember").Rows.Count = 0 Then
                cmd.CommandText = "Insert into BillMembers values(" & TxtBillID.Text & "," & DGMemb.CurrentRow.Cells(0).Value & ",N'" & TxtComments.Text & "') "
                cmd.ExecuteNonQuery()
            Else
                ' cmd.CommandText = "Update BillMembers Set MemberID=" & DGMemb.CurrentRow.Cells(0).Value & ",Comments=N'" & TxtComments.Text & "' where BilID=" & TxtBillID.Text & " and MemberID=" & DGMembers.CurrentRow.Cells(1).Value & ""
                'cmd.ExecuteNonQuery()
                LblShowText.Visible = True
                LblShowText.Text = "Members already Added"
                Exit Sub
            End If
            LblShowText.Visible = True
            LblShowText.Text = "Members Added Successfully"
            'ClearTextBoxes()
            'LockTextBoxes()
            'DataGridFill()
            DataGridMember()
            BtnSave.Enabled = False
            BtnAdd.Enabled = True
        Catch ex As Exception
        End Try
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Add Members in Bills Form','Saving','" & vUserName & "','Bills')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub DGBills_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGBills.Click
        DGMembers.Rows.Clear()
        Dim members As String
        Try
            UnLockTextBoxes()
            BtnAdMembers.Visible = True
            BtnUpdate.Enabled = True
            BtnDelete.Enabled = True
           

            '  If DGBills.CurrentRow.Cells(7).Value = "False" Then
           
            ' ComboFiller("Select * from Departments where DeptID !=" & 1, CmbDept, "DeptName", "DeptID")
            TxtBillID.Text = DGBills.CurrentRow.Cells(0).Value
            TxtBillNumber.Text = DGBills.CurrentRow.Cells(1).Value
            TxtBillTitle.Text = DGBills.CurrentRow.Cells(2).Value
            TxtBilTextinPashto.Text = DGBills.CurrentRow.Cells(3).Value
            TxtBillinDari.Text = DGBills.CurrentRow.Cells(4).Value
            IssueDate.Value = DGBills.CurrentRow.Cells(5).Value
            members = DGBills.CurrentRow.Cells(7).Value
            If members = "True" Then
                RadMember.Checked = True
                Call DataGridMember()
            Else
                RadDept.Checked = True
            End If
            TxtComments.Text = DGBills.CurrentRow.Cells(8).Value
            CmbDept.Text = DGBills.CurrentRow.Cells(9).Value
            TblUser2 = LoadTble("select * from Bills where BlID=" & DGBills.CurrentRow.Cells(0).Value, cmd, DAP)
            CurrRow = TblUser2.Rows(0)
            filename = DGBills.CurrentRow.Cells(10).Value
            bytes = CType(DGBills.CurrentRow.Cells(11).Value, Byte())
            'ElseIf DGBills.CurrentRow.Cells(7).Value = "True" Then

            'Dim tbl As New DataTable
            'DGMemb.CurrentRow.Cells(1).Value = DGMembers.CurrentRow.Cells(2).Value
            ' End If
           

        Catch ex As Exception
            bytes = Nothing
        End Try
        LblShowText.Visible = True
        LblShowText.Text = "Record Selected From List"
        'cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Format(Date.Today, "MM/dd/yy") & "','Old Records Before Updation in Bills Form','Updation','" & vUserName & "','Bills')"
        'cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim dept As String
        Dim memb As String
        If RadDept.Checked = True Then
            dept = CmbDept.SelectedValue
            memb = "False"
        Else
            dept = "1"
            memb = "True"
        End If
        ' Try
        connectionopen()
        cmd.Connection = con
        ' If RadDept.Checked = True Then
        Dim CmdBuld As New SqlCommandBuilder(DAP)
        CurrRow(0) = TxtBillID.Text
        CurrRow(0) = TxtBillID.Text
        CurrRow(1) = TxtBillNumber.Text
        CurrRow(2) = TxtBillTitle.Text
        CurrRow(3) = TxtBilTextinPashto.Text
        CurrRow(4) = TxtBillinDari.Text
        CurrRow(5) = Format(IssueDate.Value, "MM/dd/yy")
        CurrRow(6) = dept
        CurrRow(7) = memb
        CurrRow(8) = TxtComments.Text
        CurrRow(9) = filename
        CurrRow(10) = bytes
        DAP.Update(TblUser2)
        'cmd.CommandText = "Update Bills Set BlNumber='" & TxtBillNumber.Text & "',BlTitle=N'" & TxtBillTitle.Text & "',BlTextPashto=N'" & TxtBilTextinPashto.Text & "',BlTextDari=N'" & TxtBillinDari.Text & "',BlIssuDate='" & Format(IssueDate.Value, "MM/dd/yy") & "',DeptID=" & CmbDept.SelectedValue & ",BlMembers='False',Comments=N'" & TxtComments.Text & "' where BlID=" & TxtBillID.Text & ""
        'cmd.ExecuteNonQuery()
        'ElseIf RadMember.Checked = True Then
        ''DatasetFill("select * from Bills where BlMembers='False'", "UpdMem")
        ''If ds.Tables("UpdMem").Rows.Count = 0 Then
        ''End If
        'Dim CmdBuld As New SqlCommandBuilder(DAP)
        'CurrRow(0) = TxtBillID.Text
        'CurrRow(1) = TxtBillNumber.Text
        'CurrRow(2) = "N" & TxtBillTitle.Text
        'CurrRow(3) = "N" & TxtBilTextinPashto.Text
        'CurrRow(4) = "N" & TxtBillinDari.Text
        'CurrRow(5) = Format(IssueDate.Value, "MM/dd/yy")
        'CurrRow(6) = "1"
        'CurrRow(7) = "True"
        'CurrRow(8) = "N" & TxtComments.Text
        'CurrRow(9) = filename
        'CurrRow(10) = bytes
        'DAP.Update(TblUser1)
        ''cmd.CommandText = "Update Bills  Set BlNumber='" & TxtBillNumber.Text & "',BlTitle=N'" & TxtBillTitle.Text & "',BlTextPashto=N'" & TxtBilTextinPashto.Text & "',BlTextDari=N'" & TxtBillinDari.Text & "',BlIssuDate='" & Format(IssueDate.Value, "MM/dd/yy") & "',DeptID=" & 1 & ",BlMembers='True',Comments=N'" & TxtComments.Text & "' where BlID=" & TxtBillID.Text & " "
        '' cmd.ExecuteNonQuery()
        'cmd.CommandText = "Update BillMembers Set Comments=N'" & TxtComments.Text & "' where BilID=" & TxtBillID.Text & " and MemberID=" & DGMembers.CurrentRow.Cells(0).Value & ""
        'cmd.ExecuteNonQuery()
        'End If
        LblShowText.Visible = True
        LblShowText.Text = "Record Updated Successfully"
        'ClearTextBoxes()
        'Catch ex As Exception
        'End Try
        DataGridFill()
        'Call DataGridMember()
        'cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Updation of Records in Bills Form','Updation','" & vUserName & "','Bills')"
        'cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim chi As String
        chi = MsgBox("Do You Want To Delete Current Record", MsgBoxStyle.YesNo)
        If chi = MsgBoxResult.Yes Then
            Call Delete()
        ElseIf chi = MsgBoxResult.No Then
            Me.Show()
        End If
    End Sub
    Private Sub Delete()
        Try
            connectionopen()
            cmd.Connection = con
            If RadDept.Checked = True Then
                cmd.CommandText = "Delete From Bills where BlID=" & TxtBillID.Text & ""
                cmd.ExecuteNonQuery()
            ElseIf RadMember.Checked = True Then
                cmd.CommandText = "Delete From BillMembers where BilID=" & TxtBillID.Text & ""
                cmd.ExecuteNonQuery()
                cmd.CommandText = "Delete From Bills where BlID=" & TxtBillID.Text & ""
                cmd.ExecuteNonQuery()
            End If
            LblShowText.Visible = True
            LblShowText.Text = "Record Deleted"
            ClearTextBoxes()
        Catch ex As Exception
        End Try
        DataGridFill()
        Call DataGridMember()
        cmd.CommandText = "Insert into LogSheet Values (" & GetMax("LogID", "LogSheet") & ",'" & Date.Today & "','Deletion of Records in Bills Form','Updation','" & vUserName & "','Bills')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Dim frm As New FrmBillsPrint
        frm.ShowDialog()
    End Sub

    Private Sub TxtMemberSrc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMemberSrc.GotFocus
        If TxtMemberSrc.Text = "Search Member(s)" Then
            TxtMemberSrc.Text = ""
            TxtMemberSrc.ForeColor = Color.Black
        Else
            TxtMemberSrc.SelectAll()
            TxtMemberSrc.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtMemberSrc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMemberSrc.KeyDown
        If TxtMemberSrc.Text.Length > 0 And e.KeyCode = Keys.Enter Then
            Call SearchMembers()
        End If
    End Sub

    Private Sub TxtMemberSrc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMemberSrc.LostFocus
        If TxtMemberSrc.Text = "" Then
            TxtMemberSrc.Text = "Search Member(s)"
            TxtMemberSrc.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TxtMemberSrc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMemberSrc.TextChanged
        Call SearchMembers()
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
    Private Sub Search()
        Try
            DatasetFill("select  *,(select DeptName  from Departments where Departments.Deptid=Bills.DeptID)as Department from Bills where Bills.BlNumber =" & TxtSearchRecord.Text & "", "Bills")
            DGBills.Rows.Clear()
            For a As Integer = 0 To ds.Tables("Bills").Rows.Count - 1
                DGBills.Rows.Add()
                DGBills.Rows(a).Cells(0).Value = ds.Tables("Bills").Rows(a).Item("BlID")
                DGBills.Rows(a).Cells(1).Value = ds.Tables("Bills").Rows(a).Item("BlNumber")
                DGBills.Rows(a).Cells(2).Value = ds.Tables("Bills").Rows(a).Item("BlTitle")
                DGBills.Rows(a).Cells(3).Value = ds.Tables("Bills").Rows(a).Item("BlTextPashto")
                DGBills.Rows(a).Cells(4).Value = ds.Tables("Bills").Rows(a).Item("BlTextDari")
                DGBills.Rows(a).Cells(5).Value = ds.Tables("Bills").Rows(a).Item("BlIssuDate")
                DGBills.Rows(a).Cells(6).Value = ds.Tables("Bills").Rows(a).Item("DeptID")
                DGBills.Rows(a).Cells(7).Value = ds.Tables("Bills").Rows(a).Item("BlMembers")
                DGBills.Rows(a).Cells(8).Value = ds.Tables("Bills").Rows(a).Item("Comments")
                DGBills.Rows(a).Cells(9).Value = ds.Tables("Bills").Rows(a).Item("Department")
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtSearchRecord_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchRecord.LostFocus
        If TxtSearchRecord.Text = "" Then
            TxtSearchRecord.Text = "Search Record(s)"
            TxtSearchRecord.ForeColor = Color.Gray
        End If
    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    LblShowText.Text = ""
    'End Sub

    Private Sub TxtBillNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBillNumber.KeyPress
        If Asc(e.KeyChar) = Keys.Back Then
            TxtBillNumber.ReadOnly = False
            LblShowText.Visible = False
        ElseIf (e.KeyChar < "0" Or e.KeyChar > "9") Then
            TxtBillNumber.ReadOnly = True
            LblShowText.Visible = True
            LblShowText.Text = "Enter Wrong Bill Number"
        Else
            TxtBillNumber.ReadOnly = False
        End If
    End Sub

    Private Sub DGMemb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGMemb.Click
        BtnAdMembers.Visible = True
    End Sub

    Private Sub DGMemb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGMemb.KeyPress
        BtnAdMembers.Visible = True
        BtnAdMembers.Focus()
    End Sub
    Private Sub DGBills_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGBills.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Then
                Dim a As Object
                a = DGBills.CurrentRow.Index
                a = a - 1
                DGBills.ClearSelection()
                DGBills.CurrentCell = DGBills.Rows(a).Cells(0)
                DGBills.Rows(a).Selected = True
                DGBills_Click(sender, e)
            End If
        Catch ex As Exception
        End Try
        LblShowText.Visible = True
        LblShowText.Text = "Record Selected from List"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Obj As New FrmView
        'Obj.PassedText = TxtPashto.Text
        'Obj.Textbox = "TxtPashto"
        Obj.Show()
        Obj.T.Text = TxtBilTextinPashto.Text
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
        Obj.T.Text = TxtBillinDari.Text
        Obj.T2.Text = "TextDari"

    End Sub

    Private Sub Button1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.LostFocus
        If ab = "TextPashto" Then
            TxtBilTextinPashto.Text = bc
            ab = ""
            bc = ""
        ElseIf ab = "TextDari" Then
            TxtBillinDari.Text = bc
            ab = ""
            bc = ""
        End If
    End Sub
    Private Sub Button2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.LostFocus
        Button1_LostFocus(sender, e)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            MainModule.connectionopen()
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  BillMembers where BilID=" & TxtBillID.Text & " and MemberID=" & DGMembers.CurrentRow.Cells(1).Value
                cmd.ExecuteNonQuery()
                LblShowText.Visible = True
                LblShowText.Text = "Record Deleted "
                Call DataGridMember()
            End If
        Catch ex As Exception
            LblShowText.Visible = True
            LblShowText.Text = "Select Record First "
        End Try
    End Sub

    Private Sub DGMemb_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGMemb.MouseDoubleClick
        BtnAdMembers_Click(sender, e)
    End Sub
 
    Private Sub BtnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpload.Click
        Dim file As String
        Dim Pic As OpenFileDialog = New OpenFileDialog()
        Pic.Title = "Open File Dialog"
        Pic.InitialDirectory = "c:\Mydocuments"
        Pic.Filter = "Pictures (*.bmp,*.jpg,*.gif,*.png)|*.bmp;*.jpg;*.gif;*.jpeg;*.png|All files (*.*)|*.*"
        Pic.FilterIndex = 1
        Pic.RestoreDirectory = True
        If Pic.ShowDialog() = DialogResult.OK Then
            file = Pic.FileName
            Dim filePath As String = file 'Server.MapPath("APP_DATA/Testxls.xlsx")
            filename = Path.GetFileName(filePath)
            Dim fs As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
            Dim br As BinaryReader = New BinaryReader(fs)
            bytes = br.ReadBytes(Convert.ToInt32(fs.Length))
            br.Close()
            fs.Close()
        End If
    End Sub

    Private Sub BtnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDownload.Click
        Try
            '    'Get image data from gridview column. 
            '    strSql = "Select ImageData from FileStore WHERE FileId=" & iFileId

            '    Dim sqlCmd As New SqlCommand(strSql, connection)

            '    'Get image data from DB
            'Dim fileData As Byte() = CType (bytes )

            Dim sTempFileName As String = filename

            If Not bytes Is Nothing Then

                'Read image data into a file stream 
                Using fs As New FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write)
                    fs.Write(bytes, 0, bytes.Length)
                    'Set image variable value using memory stream. 
                    fs.Flush()
                    fs.Close()
                End Using

                'Open File

                Process.Start(filename)
            Else

                LblShowText.Visible = True
                LblShowText.Text = "NO File Available "
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class