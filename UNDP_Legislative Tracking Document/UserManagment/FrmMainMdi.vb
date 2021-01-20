Public Class FrmMainMdi
    Dim File As String
    Dim Setup As String
    Dim LegislativeDept As String
    Dim Houses As String
    Dim Commission As String
    Dim Administrator As String
    Dim Report As String
    Dim Password As String
    Dim Help As String
    Private Sub MnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFileExit.Click
        Me.Close()
    End Sub
    Private Sub FrmMainMdi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainModule.DatasetFill("Select * from GroupRights where GroupID=" & vGroupId, "Rights")
        Call SetRights()
    End Sub
    Private Sub SetRights()
        MnuFile.Visible = False
        MnuSetup.Visible = False
        MnuBill.Visible = False
        MnuCommission.Visible = False
        MnuHouses.Visible = False
        MnuAdministrator.Visible = False
        MnuPassword.Visible = False
        MnuHelp.Visible = False
        MnuReports.Visible = False
        File = ds.Tables("Rights").Rows(0).Item("MnuFile")
        Setup = ds.Tables("Rights").Rows(0).Item("MnuSetup")
        LegislativeDept = ds.Tables("Rights").Rows(0).Item("MnuLegislativeDept")
        Houses = ds.Tables("Rights").Rows(0).Item("MnuHouses")
        Commission = ds.Tables("Rights").Rows(0).Item("MnuCommissions")
        Administrator = ds.Tables("Rights").Rows(0).Item("MnuAdministrator")
        Password = ds.Tables("Rights").Rows(0).Item("MnuPassword")
        Help = ds.Tables("Rights").Rows(0).Item("MnuHelp")
        Report = ds.Tables("Rights").Rows(0).Item("MnuReport")
        If File = "True" Then
            MnuFile.Visible = True
        End If
        If Setup = "True" Then
            MnuSetup.Visible = True
        End If
        If LegislativeDept = "True" Then
            MnuBill.Visible = True
        End If
        If Houses = "True" Then
            MnuHouses.Visible = True
        End If
        If Commission = "True" Then
            MnuCommission.Visible = True
        End If
        If Administrator = "True" Then
            MnuAdministrator.Visible = True
        End If
        If Report = "True" Then
            MnuReports.Visible = True
        End If
        If Password = "True" Then
            MnuPassword.Visible = True
        End If
        If Help = "True" Then
            MnuHelp.Visible = True
        End If
    End Sub

    Private Sub MnuFileGetnput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFileGetnput.Click
        System.Diagnostics.Process.Start("http://www.getnput.com")
    End Sub

    Private Sub MnuSetupHouses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSetupHouses.Click
        Dim Houses As New FrmHouses
        Houses.MdiParent = Me
        Houses.Show()
    End Sub

    Private Sub MnuSetupCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSetupCommission.Click
        Dim Commissions As New FrmCommission
        Commissions.MdiParent = Me
        Commissions.Show()
    End Sub

    Private Sub MnuSetupDepartments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSetupDepartments.Click
        Dim Department As New FrmDepartment
        Department.MdiParent = Me
        Department.Show()
    End Sub

    Private Sub MnuSetupStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSetupStatus.Click
        Dim Status As New FrmStatus
        Status.MdiParent = Me
        Status.Show()
    End Sub

    Private Sub MnuBillBills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBillBills.Click
        Dim Bills As New FrmBills
        Bills.MdiParent = Me
        Bills.Show()
    End Sub

    Private Sub MnuBillBillHouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBillBillHouse.Click
        Dim BillstoHouse As New FrmForwarBillToHouse
        BillstoHouse.MdiParent = Me
        BillstoHouse.Show()
    End Sub

    Private Sub MnuBillBillCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBillBillCommission.Click
        Dim BillCommission As New FrmForwardBillToCommission
        BillCommission.MdiParent = Me
        BillCommission.Show()
    End Sub

    Private Sub MnuBillBillPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBillBillPosition.Click
        Dim BillTraker As New FrmBillTraker
        BillTraker.MdiParent = Me
        BillTraker.Show()
    End Sub

    Private Sub MnuBillBillAmmendments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBillBillAmmendments.Click
        Dim BillAmmendments As New FrmBillAmmendments
        BillAmmendments.MdiParent = Me
        BillAmmendments.Show()
    End Sub
    Private Sub MnuBillResolution_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuBillResolution.Click
        Dim BillResolution As New FrmResolution
        BillResolution.MdiParent = Me
        BillResolution.Show()
    End Sub
    Private Sub MnuBillDailyAgenda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuBillDailyAgenda.Click
        Dim Agenda As New FrmDailyAgenda
        Agenda.MdiParent = Me
        Agenda.Show()
    End Sub

    Private Sub MnuAdminUserAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAdminUserAccount.Click
        Dim Users As New FrmUserInformation
        Users.MdiParent = Me
        Users.Show()
    End Sub

    Private Sub MnuUserGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuUserGroup.Click
        Dim UserGroups As New FrmUserGroups
        UserGroups.MdiParent = Me
        UserGroups.Show()
    End Sub

    Private Sub MnuAdminGroupRights_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAdminGroupRights.Click
        Dim GroupRights As New FrmGroupRights
        GroupRights.MdiParent = Me
        GroupRights.Show()
    End Sub

    Private Sub MnuAdminChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAdminChangePassword.Click
        Dim SetPassword As New FrmSetPassword
        SetPassword.MdiParent = Me
        SetPassword.Show()
    End Sub

    Private Sub MnuPasswordChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuPasswordChange.Click
        Dim SetOwnPassword As New FrmSetOwnPassword
        SetOwnPassword.MdiParent = Me
        SetOwnPassword.Show()
    End Sub

    Private Sub MnuPasswordSwitchUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuPasswordSwitchUser.Click
        FrmLogin.Show()
        Me.Close()
    End Sub

    Private Sub MnuHelpAboutUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHelpAboutUs.Click
        Dim AboutUs As New FrmHelp
        AboutUs.MdiParent = Me
        AboutUs.Show()
    End Sub

    Private Sub MnuReportsBills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuReportsBills.Click
        Dim BillPrint As New FrmBillsPrint
        BillPrint.MdiParent = Me
        BillPrint.Show()
    End Sub

    Private Sub MnuReportBillAmmendments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuReportBillAmmendments.Click
        Dim BillAmmendments As New FrmPrintBillAmmendments
        BillAmmendments.MdiParent = Me
        BillAmmendments.Show()
    End Sub

    Private Sub MnuReportDailyAgenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuReportDailyAgenda.Click
        Dim AgendaPrint As New FrmAgendaPrint
        AgendaPrint.MdiParent = Me
        AgendaPrint.Show()
    End Sub
    Private Sub MnuCommissionBills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCommissionBills.Click
        MnuBillBillCommission_Click(sender, e)
    End Sub

    Private Sub MnuCommissionbillAmmendments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCommissionbillAmmendments.Click
        MnuBillBillAmmendments_Click(sender, e)
    End Sub

    Private Sub MnuHousesbillsAmmendments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHousesbillsAmmendments.Click
        MnuBillBillAmmendments_Click(sender, e)
    End Sub

    Private Sub MnuHousebills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHousebills.Click
        MnuBillBillHouse_Click(sender, e)
    End Sub
    Private Sub MnuSetupMembers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuSetupMembers.Click
        Dim Members As New FrmMembers
        Members.MdiParent = Me
        Members.Show()
    End Sub

    Private Sub MnuAdminLogSheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAdminLogSheet.Click
        Dim LogSheet As New FrmLogSheet
        LogSheet.MdiParent = Me
        LogSheet.Show()
    End Sub
End Class