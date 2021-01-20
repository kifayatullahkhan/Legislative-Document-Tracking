Imports System.Data.SqlClient

Public Class FrmGroupRights
    Dim File As String
    Dim Setup As String
    Dim LegislativeDepartment As String
    Dim Houses As String
    Dim Commission As String
    Dim Administrator As String
    Dim Reports As String
    Dim Password As String
    Dim Help As String

    Private Sub FrmGroupRights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboFiller("select * from UserGroups", cmbgroupname, "GroupName", "GroupID")
        cmbgroupname.SelectedIndex = -1
    End Sub
    Private Function GetNextID() As String
        Dim str As String
        cmd.CommandText = "select isnull(max(RightID),0) from GroupRights"
        str = Val(cmd.ExecuteScalar) + 1
        Return str
    End Function

    Private Sub cmbgroupname_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgroupname.DropDownClosed
        MainModule.DatasetFill("select * from GroupRights where GroupID=" & cmbgroupname.SelectedValue, "RightsStatus")
        Try
            btndenyfull_Click(sender, e)
            ChkFile.Checked = ds.Tables("RightsStatus").Rows(0).Item("MnuFile")
            ChkSetup.Checked = ds.Tables("RightsStatus").Rows(0).Item("MnuSetup")
            ChkLegislativeDepartment.Checked = ds.Tables("RightsStatus").Rows(0).Item("MnuLegislativeDept")
            ChkHouses.Checked = ds.Tables("RightsStatus").Rows(0).Item("MnuHouses")
            ChkCommissions.Checked = ds.Tables("RightsStatus").Rows(0).Item("MnuCommissions")
            ChkAdministrator1.Checked = ds.Tables("RightsStatus").Rows(0).Item("MnuAdministrator")
            ChkReports.Checked = ds.Tables("RightsStatus").Rows(0).Item("MnuReport")
            ChkPassword.Checked = ds.Tables("RightsStatus").Rows(0).Item("MnuPassword")
            ChkHelp.Checked = ds.Tables("RightsStatus").Rows(0).Item("MnuHelp")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnallowfull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallowfull.Click
        ChkFile.Checked = True
        ChkSetup.Checked = True
        ChkLegislativeDepartment.Checked = True
        ChkHouses.Checked = True
        ChkCommissions.Checked = True
        ChkAdministrator1.Checked = True
        ChkReports.Checked = True
        ChkPassword.Checked = True
        ChkHelp.Checked = True
    End Sub

    Private Sub btndenyfull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndenyfull.Click
        ChkFile.Checked = False
        ChkSetup.Checked = False
        ChkLegislativeDepartment.Checked = False
        ChkHouses.Checked = False
        ChkCommissions.Checked = False
        ChkAdministrator1.Checked = False
        ChkReports.Checked = False
        ChkPassword.Checked = False
        ChkHelp.Checked = False
    End Sub
    Private Sub btnnormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnormal.Click
        ChkFile.Checked = True
        ChkHelp.Checked = True
        ChkSetup.Checked = False
        ChkLegislativeDepartment.Checked = False
        ChkHouses.Checked = False
        ChkCommissions.Checked = False
        ChkReports.Checked = False
        ChkAdministrator1.Checked = False
    End Sub
    Private Sub CheckRights()
        If ChkFile.Checked = True Then
            File = "True"
        Else
            File = "False"
        End If
        If ChkSetup.Checked = True Then
            Setup = "True"
        Else
            Setup = "False"
        End If
        If ChkLegislativeDepartment.Checked = True Then
            LegislativeDepartment = "True"
        Else
            LegislativeDepartment = "False"
        End If
        If ChkHouses.Checked = True Then
            Houses = "True"
        Else
            Houses = "False"
        End If
        If ChkCommissions.Checked = True Then
            Commission = "True"
        Else
            Commission = "False"
        End If
        If ChkAdministrator1.Checked = True Then
            Administrator = "True"
        Else
            Administrator = "False"
        End If
        If ChkReports.Checked = True Then
            Reports = "True"
        Else
            Reports = "False"
        End If
        If ChkPassword.Checked = True Then
            Password = "True"
        Else
            Password = "False"

        End If
        If ChkHelp.Checked = True Then
            Help = "True"
        Else
            Help = "False"
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        CheckRights()
        MainModule.connectionopen()
        cmd.Connection = con
        Try
            MainModule.DatasetFill("select GroupID from GroupRights where GroupID=" & cmbgroupname.SelectedValue, "Check")
            If ds.Tables("Check").Rows.Count = 0 Then
                cmd.CommandText = "insert into GroupRights values(" & GetNextID() & "," & cmbgroupname.SelectedValue & ",'" & File & "','" & Setup & "','" & LegislativeDepartment & "','" & Houses & "','" & Commission & "','" & Administrator & "','" & Reports & "','" & Password & "','" & Help & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Rights is given Successfully", MsgBoxStyle.Information)
            Else
                MsgBox("Rights for this Group is Already Given You Only Update it ", MsgBoxStyle.Question)
                Call cmbgroupname_DropDownClosed(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If cmbgroupname.SelectedValue = 1 Then
            MsgBox("You cannot change the Right of Administrator", MsgBoxStyle.Question, "Error")
            cmbgroupname_DropDownClosed(sender, e)
            Exit Sub
        End If
        CheckRights()
        Try
            cmd.CommandText = "Update GroupRights set MnuFile='" & File & "',MnuSetup='" & Setup & "',MnuLegislativeDept='" & LegislativeDepartment & "', MnuHouses='" & Houses & "',MnuCommissions='" & Commission & "',MnuAdministrator='" & Administrator & "',MnuReport='" & Reports & "',MnuPassword='" & Password & "',MnuHelp='" & Help & "' where GroupID=" & cmbgroupname.SelectedValue
            cmd.ExecuteNonQuery()
            MsgBox("Rights is updated Successfully", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If cmbgroupname.SelectedValue = 1 Then
            MsgBox("You cannot delete the Administrator Group", MsgBoxStyle.Question, "Error")
            Exit Sub

        End If
        MainModule.connectionopen()
        Try
            If MsgBox(" Are you want to delete .?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                cmd.CommandText = "Delete from  GroupRights where GroupID=" & cmbgroupname.SelectedValue
                cmd.ExecuteNonQuery()
                MsgBox("Your record has been Deleted successfully.", MsgBoxStyle.Information)
                Call cmbgroupname_DropDownClosed(sender, e)
            End If
        Catch ex As Exception
            MsgBox("No Group is selected  ... ?", MsgBoxStyle.Information, "Wrong Attempt")
            cmbgroupname.Focus()
        End Try
    End Sub
End Class