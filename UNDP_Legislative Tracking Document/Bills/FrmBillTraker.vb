Imports System.Data.SqlClient
Public Class FrmBillTraker
    Dim BlId As String
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

    Private Sub DgBill_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgBill.Click
        Try
            BlId = DgBill.CurrentRow.Cells(1).Value
            RadCurrent.Checked = False
            RadOverall.Checked = False
            dgview.Rows.Clear()
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
    Private Sub GridBillFill(ByVal query As String)
        DatasetFill(query, "Bills")
        DgBill.Rows.Clear()
        For a As Integer = 0 To ds.Tables("Bills").Rows.Count - 1
            DgBill.Rows.Add()
            DgBill.Rows(a).Cells(0).Value = ds.Tables("Bills").Rows(a).Item("BlTitle")
            DgBill.Rows(a).Cells(1).Value = ds.Tables("Bills").Rows(a).Item("BlID")
        Next
    End Sub

    Private Sub RadCurrent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCurrent.CheckedChanged
        If RadCurrent.Checked = True Then
            GridFill("SELECT  BillTraker.BlTrakerID, Bills.BlTitle, Commissions.CommName,BillTraker.BlTrakerDate, Status.StatusTitle, BillTraker.Comments,Houses.HouseName FROM BillTraker INNER JOIN Bills ON BillTraker.BlID = Bills.BlID INNER JOIN Status ON BillTraker.StatusID = Status.StatusID INNER JOIN Commissions ON BillTraker.BlCommID = Commissions.CommID INNER JOIN Houses ON BillTraker.HouseID = Houses.HouseID where BillTraker.BlTrakerID=(select max(BlTrakerID) from BillTraker where BlID=" & BlId & ") and BillTraker.BlID=" & BlId)
        ElseIf RadOverall.Checked = True Then
            GridFill("SELECT  BillTraker.BlTrakerID, Bills.BlTitle, Commissions.CommName,BillTraker.BlTrakerDate, Status.StatusTitle, BillTraker.Comments,Houses.HouseName FROM BillTraker INNER JOIN Bills ON BillTraker.BlID = Bills.BlID INNER JOIN Status ON BillTraker.StatusID = Status.StatusID INNER JOIN Commissions ON BillTraker.BlCommID = Commissions.CommID INNER JOIN Houses ON BillTraker.HouseID = Houses.HouseID where BillTraker.BlID=" & BlId)
        End If
    End Sub
    Private Sub GridFill(ByVal query As String)
        Dim str As String

        DatasetFill(query, "Tracking")
        dgview.Rows.Clear()
        For a As Integer = 0 To ds.Tables("Tracking").Rows.Count - 1
            dgview.Rows.Add()
            dgview.Rows(a).Cells(0).Value = ds.Tables("Tracking").Rows(a).Item("BlTitle")
            dgview.Rows(a).Cells(1).Value = ds.Tables("Tracking").Rows(a).Item("BlTrakerDate")
            str = ds.Tables("Tracking").Rows(a).Item("CommName")
            If str = "None" Then
                dgview.Rows(a).Cells(2).Value = ""
            Else
                dgview.Rows(a).Cells(2).Value = ds.Tables("Tracking").Rows(a).Item("CommName")
            End If
            str = ds.Tables("Tracking").Rows(a).Item("HouseName")
            If str = "None" Then
                dgview.Rows(a).Cells(3).Value = ""
            Else
                dgview.Rows(a).Cells(3).Value = ds.Tables("Tracking").Rows(a).Item("HouseName")
            End If
            dgview.Rows(a).Cells(4).Value = ds.Tables("Tracking").Rows(a).Item("StatusTitle")
            dgview.Rows(a).Cells(5).Value = ds.Tables("Tracking").Rows(a).Item("Comments")
        Next
    End Sub

    Private Sub RadOverall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadOverall.CheckedChanged
        If RadCurrent.Checked = True Then
            GridFill("SELECT  BillTraker.BlTrakerID, Bills.BlTitle, Commissions.CommName,BillTraker.BlTrakerDate, Status.StatusTitle, BillTraker.Comments,Houses.HouseName FROM BillTraker INNER JOIN Bills ON BillTraker.BlID = Bills.BlID INNER JOIN Status ON BillTraker.StatusID = Status.StatusID INNER JOIN Commissions ON BillTraker.BlCommID = Commissions.CommID INNER JOIN Houses ON BillTraker.HouseID = Houses.HouseID where BillTraker.BlTrakerID=(select max(BlTrakerID) from BillTraker where BlID=" & BlId & ") and BillTraker.BlID=" & BlId)
        ElseIf RadOverall.Checked = True Then
            GridFill("SELECT  BillTraker.BlTrakerID, Bills.BlTitle, Commissions.CommName,BillTraker.BlTrakerDate, Status.StatusTitle, BillTraker.Comments,Houses.HouseName FROM BillTraker INNER JOIN Bills ON BillTraker.BlID = Bills.BlID INNER JOIN Status ON BillTraker.StatusID = Status.StatusID INNER JOIN Commissions ON BillTraker.BlCommID = Commissions.CommID INNER JOIN Houses ON BillTraker.HouseID = Houses.HouseID where BillTraker.BlID=" & BlId)
        End If
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Dim query As String = ""
        If RadCurrent.Checked = True Then
            query = "SELECT  BillTraker.BlTrakerID, Bills.BlTitle, Commissions.CommName,BillTraker.BlTrakerDate, Status.StatusTitle, BillTraker.Comments,Houses.HouseName FROM BillTraker INNER JOIN Bills ON BillTraker.BlID = Bills.BlID INNER JOIN Status ON BillTraker.StatusID = Status.StatusID INNER JOIN Commissions ON BillTraker.BlCommID = Commissions.CommID INNER JOIN Houses ON BillTraker.HouseID = Houses.HouseID where BillTraker.BlTrakerID=(select max(BlTrakerID) from BillTraker where BlID=" & BlId & ") and BillTraker.BlID=" & BlId
        ElseIf RadOverall.Checked = True Then
            query = "SELECT  BillTraker.BlTrakerID, Bills.BlTitle, Commissions.CommName,BillTraker.BlTrakerDate, Status.StatusTitle, BillTraker.Comments,Houses.HouseName FROM BillTraker INNER JOIN Bills ON BillTraker.BlID = Bills.BlID INNER JOIN Status ON BillTraker.StatusID = Status.StatusID INNER JOIN Commissions ON BillTraker.BlCommID = Commissions.CommID INNER JOIN Houses ON BillTraker.HouseID = Houses.HouseID where BillTraker.BlID=" & BlId
        End If
        Try
            MainModule.connectionopen()
            cmd.CommandText = query
            cmd.Connection = con
            da.SelectCommand = cmd
            Dim tab As New DataTable
            da.Fill(tab)
            Dim rpt As New RptBillTraker
            rpt.SetDataSource(tab)
            rpt.SetDataSource(tab)
            FrmReportViewer.CrViewer.ReportSource = rpt
            FrmReportViewer.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class