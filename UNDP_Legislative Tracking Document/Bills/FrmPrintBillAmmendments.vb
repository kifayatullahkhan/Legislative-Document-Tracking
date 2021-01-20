Imports System.Data.SqlClient
Public Class FrmPrintBillAmmendments
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
        Call GridBillFill("select BlID,BlTitle from Bills where BlTitle like N'%" & TxtSearchBill.Text & "%'")
    End Sub
    Private Sub GridBillFill(ByVal query As String)
        DatasetFill(query, "Bills")
        DgBill.Rows.Clear()
        For a As Integer = 0 To ds.Tables("Bills").Rows.Count - 1
            DgBill.Rows.Add()
            DgBill.Rows(a).Cells(0).Value = ds.Tables("Bills").Rows(a).Item("BlTitle")
            DgBill.Rows(a).Cells(1).Value = ds.Tables("Bills").Rows(a).Item("BlID")
        Next
    End Sub
    Private Sub DgBill_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgBill.Click
        Try
            Call GridAmmendmentsFill()

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
    Private Sub GridAmmendmentsFill()
        DatasetFill("SELECT Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments,BillAmmendments.AmBy FROM Bills INNER JOIN BillAmmendments ON Bills.BlID = BillAmmendments.BlID  where BillAmmendments.BlID=" & DgBill.CurrentRow.Cells(1).Value, "BillAmmendments")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("BillAmmendments").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("BillAmmendments").Rows(a).Item("BlTitle")
            dgview.Rows(a).Cells(1).Value = ds.Tables("BillAmmendments").Rows(a).Item("BlTextPashto")
            dgview.Rows(a).Cells(2).Value = ds.Tables("BillAmmendments").Rows(a).Item("BlTextDari")
            dgview.Rows(a).Cells(3).Value = ds.Tables("BillAmmendments").Rows(a).Item("Comments")
            dgview.Rows(a).Cells(4).Value = ds.Tables("BillAmmendments").Rows(a).Item("AmBy")
        Next
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Dim query As String = "SELECT  Bills.BlTitle, BillAmmendments.BlTextPashto, BillAmmendments.BlTextDari, BillAmmendments.Comments, BillAmmendments.AmBy FROM Bills INNER JOIN BillAmmendments ON Bills.BlID = BillAmmendments.BlID where BillAmmendments.BlID=" & DgBill.CurrentRow.Cells(1).Value
        Try
            MainModule.connectionopen()
            cmd.CommandText = query
            cmd.Connection = con
            da.SelectCommand = cmd
            Dim tab As New DataTable
            da.Fill(tab)
            Dim rpt As New RptBillAmmendments
            rpt.SetDataSource(tab)
            rpt.SetDataSource(tab)
            FrmReportViewer.CrViewer.ReportSource = rpt
            FrmReportViewer.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmPrintBillAmmendments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not vGroupId = 1 Then
            BtnPrint.Enabled = False
        End If
    End Sub
End Class