Imports System.Data.SqlClient
Public Class FrmBillsPrint
    Private Sub FrmBillsPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainModule.connectionopen()
        RadDept.Checked = False
        RadBillNo.Checked = False
        RadBillTitle.Checked = False
        CmbDept.Visible = False
        TxtBillNumber.Visible = False
    End Sub
    Private Sub RadDept_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDept.CheckedChanged
        If RadDept.Checked = True Then
            CmbDept.Visible = True
            TxtBillNumber.Visible = False
            ComboFiller("Select * from Departments where DeptID !=" & 1, CmbDept, "DeptName", "DeptID")
        Else
            CmbDept.Visible = False
        End If
    End Sub

    Private Sub RadBillTitle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBillTitle.CheckedChanged
        If RadBillTitle.Checked = True Then
            TxtBillNumber.Visible = True
            CmbDept.Visible = False
        Else
            TxtBillNumber.Visible = False
        End If
    End Sub

    Private Sub RadBillNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBillNo.CheckedChanged
        If RadBillNo.Checked = True Then
            CmbDept.Visible = False
            TxtBillNumber.Visible = True
        Else
            TxtBillNumber.Visible = False
        End If
    End Sub


    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Try
            Dim tbl As New DataTable
            Dim cmd As New SqlCommand
            cmd.Connection = con
            If RadDept.Checked = True Then
                cmd.CommandText = "SELECT     Bills.BlID, Bills.BlNumber, Bills.BlTitle, Bills.BlTextPashto, Bills.BlTextDari, Bills.BlIssuDate, Departments.DeptName, Bills.BlMembers, Bills.Comments FROM         Bills INNER JOIN Departments ON Bills.DeptID = Departments.DeptID where Departments.DeptID !=" & 1 & " and Bills.DeptID=" & CmbDept.SelectedValue & ""
            ElseIf RadBillNo.Checked = True Then
                cmd.CommandText = "SELECT     Bills.BlID, Bills.BlNumber, Bills.BlTitle, Bills.BlTextPashto, Bills.BlTextDari, Bills.BlIssuDate, Departments.DeptName, Bills.BlMembers, Bills.Comments FROM         Bills INNER JOIN Departments ON Bills.DeptID = Departments.DeptID where Departments.DeptID !=" & 1 & " and BlNumber=" & TxtBillNumber.Text & ""
            ElseIf RadBillTitle.Checked = True Then
                cmd.CommandText = "SELECT     Bills.BlID, Bills.BlNumber, Bills.BlTitle, Bills.BlTextPashto, Bills.BlTextDari, Bills.BlIssuDate, Departments.DeptName, Bills.BlMembers, Bills.Comments FROM         Bills INNER JOIN Departments ON Bills.DeptID = Departments.DeptID where Departments.DeptID !=" & 1 & " and BlTitle=N'" & TxtBillNumber.Text & "'"
            End If
            da.SelectCommand = cmd
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
                Dim tbl2 As New DataTable
                If RadBillNo.Checked = True Then
                    cmd.CommandText = "SELECT Bills.BlID, Bills.BlNumber, Bills.BlTitle, Bills.BlTextPashto, Bills.BlTextDari, Bills.BlIssuDate, Bills.Comments, Members.MemberName FROM Bills INNER JOIN BillMembers ON Bills.BlID = BillMembers.BilID INNER JOIN Members ON BillMembers.MemberID = Members.MemberID where Bills.BlNumber=" & TxtBillNumber.Text & ""
                ElseIf RadBillTitle.Checked = True Then
                    cmd.CommandText = "SELECT Bills.BlID, Bills.BlNumber, Bills.BlTitle, Bills.BlTextPashto, Bills.BlTextDari, Bills.BlIssuDate, Bills.Comments, Members.MemberName FROM Bills INNER JOIN BillMembers ON Bills.BlID = BillMembers.BilID INNER JOIN Members ON BillMembers.MemberID = Members.MemberID where Bills.BlTitle=N'" & TxtBillNumber.Text & "'"
                End If
                da.SelectCommand = cmd
                da.Fill(tbl2)
                Dim rpt2 As New RptBills2
                rpt2.SetDataSource(tbl2)
                FrmReportViewer.CrViewer.ReportSource = rpt2
                FrmReportViewer.ShowDialog()
                Exit Sub
            End If
            Dim rpt As New RptBills
            rpt.SetDataSource(tbl)
            FrmReportViewer.CrViewer.ReportSource = rpt
            FrmReportViewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class