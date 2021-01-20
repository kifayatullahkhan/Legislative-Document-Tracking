Imports System.Data.SqlClient
Public Class FrmLogSheet

    Private Sub FrmLogSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainModule.connectionopen()
        Call DataGridFill("Select * from LogSheet ORDER BY CurrDatTime ASC")

    End Sub
    Private Sub DataGridFill(ByVal query As String)
        Try
            DatasetFill(query, "LogSheet")
            dgview.Rows.Clear()
            For a As Integer = 0 To ds.Tables("LogSheet").Rows.Count - 1
                dgview.Rows.Add()
                dgview.Rows(a).Cells(0).Value = ds.Tables("LogSheet").Rows(a).Item("LogID")
                dgview.Rows(a).Cells(1).Value = ds.Tables("LogSheet").Rows(a).Item("CurrDatTime")
                dgview.Rows(a).Cells(2).Value = ds.Tables("LogSheet").Rows(a).Item("Description")
                dgview.Rows(a).Cells(3).Value = ds.Tables("LogSheet").Rows(a).Item("Type")
                dgview.Rows(a).Cells(4).Value = ds.Tables("LogSheet").Rows(a).Item("UserName")
                dgview.Rows(a).Cells(5).Value = ds.Tables("LogSheet").Rows(a).Item("Category")
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Try
            Dim tbl As New DataTable
            cmd.Connection = con
            If RadSpecificDate.Checked = True Then
                cmd.CommandText = "Select * from LogSheet where CurrDatTime = '" & Format(DateTime1.Value, "MM/dd/yy") & "'"
            ElseIf RadRangeDate.Checked = True Then
                cmd.CommandText = "Select * from LogSheet where CurrDatTime >= '" & Format(DateTime1.Value, "MM/dd/yy") & "'and CurrDatTime <= '" & Format(DateTime2.Value, "MM/dd/yy") & "'"
            Else
                cmd.CommandText = "Select * from LogSheet"
            End If
            da.SelectCommand = cmd
            da.Fill(tbl)
            If tbl.Rows.Count = 0 Then
                Exit Sub
            End If
            Dim rpt As New RptLogSheet
            rpt.SetDataSource(tbl)
            FrmReportViewer.CrViewer.ReportSource = rpt
            FrmReportViewer.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadSpecificDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadSpecificDate.CheckedChanged
        If RadSpecificDate.Checked = True Then
            LblStart.Visible = True
            DateTime1.Visible = True
            LblStart.Text = "Select Date"
        Else
            LblStart.Visible = False
            DateTime1.Visible = False
        End If
    End Sub

    Private Sub RadRangeDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadRangeDate.CheckedChanged
        If RadRangeDate.Checked = True Then
            LblStart.Visible = True
            LblEnd.Visible = True
            DateTime1.Visible = True
            DateTime2.Visible = True
            LblStart.Text = "Start Date"
        Else
            LblEnd.Visible = False
            DateTime2.Visible = False
        End If
    End Sub

    Private Sub DateTime1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTime1.ValueChanged
        Call DataGridFill("Select * from LogSheet where CurrDatTime='" & Format(DateTime1.Value, "MM/dd/yy") & "'")
    End Sub

    Private Sub DateTime2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTime2.ValueChanged
        Call DataGridFill("Select * from LogSheet where CurrDatTime >= '" & Format(DateTime1.Value, "MM/dd/yy") & "'and CurrDatTime <= '" & Format(DateTime2.Value, "MM/dd/yy") & "'")
    End Sub
End Class