Imports System.Data.SqlClient
Public Class FrmAgendaPrint

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Dim query As String = "select * from DailyAgenda where DADated='" & Format(DtpAgDate.Value, "MM/dd/yy") & "'"
        Try
            Dim tab As New DataTable
            con.Close()
            MainModule.connectionopen()
            cmd.CommandText = query
            cmd.Connection = con
            da.SelectCommand = cmd
            da.Fill(tab)
            Dim rpt As New RptDailyAgenda
            rpt.SetDataSource(tab)
            'rpt.SetDataSource(tab)
            FrmReportViewer.CrViewer.ReportSource = rpt
            FrmReportViewer.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class