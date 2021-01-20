Imports System.Data.SqlClient
Imports System.IO
Public Class FrmLogin
    Private Sub cmbservername_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbservername.LostFocus
        ComboSetting()
    End Sub
    Private Sub ComboSetting()
        cmbservername.Items.Add(cmbservername.Text)
        For i = 0 To cmbservername.Items.Count - 1
            For b = i + 1 To cmbservername.Items.Count - 1
                If cmbservername.Items(i) = cmbservername.Items(b) Then
                    cmbservername.Items.RemoveAt(b)
                End If
            Next
        Next
    End Sub
    Private Sub FrmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            DeleteSetting(Application.ProductName, cmbservername.Name)
            Dim b As Integer = cmbservername.Items.Count
            Dim i As Integer
            For i = 0 To cmbservername.Items.Count - 1
                Dim a As Object = cmbservername.Items(i).ToString
                SaveSetting(Application.ProductName, cmbservername.Name, "Item " & i, cmbservername.Items(i).ToString)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub filecheck()
        Dim sFileName As String
        sFileName = "c:\Windows\Config.cfg\bitlocker.inf"
        Dim fFile As New FileInfo(sFileName)
        If Not fFile.Exists Then
            'MessageBox.Show("Software is Locked Please contact the Provider 'Getnput Technology Integrator'")
            MsgBox("     Software is Locked Please contact the Provider " & ControlChars.NewLine & "     Getnput Technology Integrator" & ControlChars.NewLine & "     Web site: http://www.getnput.com" & ControlChars.NewLine & "     Email:      kifayat@(getnput.com)" & ControlChars.NewLine & "     Phone: +93 - 775051201", MsgBoxStyle.Critical, "Client License key not found")
            Me.Close()
        End If
    End Sub
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'filecheck()
        VServerPassword = DecryptString128Bit(GetSetting(Application.ProductName, txtpassword.Name, "Password"), 2)
        VAdminUserName = GetSetting(Application.ProductName, txtloginname.Name, "LoginName")
        If VServerPassword.Length - 1 = 0 And VAdminUserName.Length = 0 Then
            'Dim frm As New FrmSetting
            'frm.ShowDialog()
            'Me.Close()
            SaveSetting(Application.ProductName, txtloginname.Name, "Item1", "SERVER")
            SaveSetting(Application.ProductName, txtpassword.Name, "Item2", "SERVER1")
            DeleteSetting(Application.ProductName, txtloginname.Name)
            DeleteSetting(Application.ProductName, txtpassword.Name)
            SaveSetting(Application.ProductName, txtpassword.Name, "Password", EncryptString128Bit("UNDP_2009", 2))
            SaveSetting(Application.ProductName, txtloginname.Name, "LoginName", "UNDP_2009")
        End If
        ' MsgBox(DecryptString128Bit(VServerPassword, 5))
        'FrmSetting.Close()
        SaveSetting(Application.ProductName, cmbservername.Name, "Item 0", "SERVER")
        Dim i As Long
        Dim sItem As String
        cmbservername.Items.Clear()
        While Len(GetSetting(Application.ProductName, cmbservername.Name, "Item " & i))
            sItem = GetSetting(Application.ProductName, cmbservername.Name, "Item " & i)
            cmbservername.Items.Add(sItem)
            i = i + 1
        End While
        cmbservername.SelectedIndex = cmbservername.Items.Count - 1
    End Sub

    Private Sub btnok_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        vServerName = cmbservername.Text
        'MainModule.connectionopen()
        'Try
        '    DatasetFill("select ActivationKey,Condition from Activation where IsCurrent='True'", "ExpiryCheck")
        '    If ds.Tables("ExpiryCheck").Rows.Count = 0 Then
        '        Dim frm As New FrmSoftwareActivation
        '        frm.Show()
        '        Exit Sub
        '    End If
        'Catch ex As Exception
        '    Exit Sub
        'End Try
        'Dim str As String = DecryptString128Bit(ds.Tables("ExpiryCheck").Rows(0).Item(0).Substring(0, 24), 5)
        'Dim year As String = str.Substring(3, 2)
        'Dim month As String = str.Substring(7, 2)
        'Dim day As String = str.Substring(11, 2)
        'Dim expiry As Date = New Date(2000 + year, month, day)
        'Dim current As Date = Date.Today
        'Dim dated As String = DecryptString128Bit(ds.Tables("ExpiryCheck").Rows(0).Item("Condition"), 4)
        'Dim condition As Date = New Date(2000 + dated.Substring(6, 2), dated.Substring(3, 2), dated.Substring(0, 2))
        'Dim tsTimeSpan As TimeSpan
        'Dim iNumberOfDays As Integer
        'tsTimeSpan = Now.Subtract(condition)
        'iNumberOfDays = tsTimeSpan.Days
        'If current > expiry Or condition = expiry Then
        '    cmd.CommandText = "Update Activation set IsCurrent='False' where IsCurrent='True'"
        '    cmd.ExecuteNonQuery()
        '    MsgBox("Your Software  Registeration is Expired Plesae contact the Providers 'www.getnput.com' ", MsgBoxStyle.Information, "Registeration Expire")
        '    Dim form As New FrmSoftwareActivation
        '    form.Show()
        '    Exit Sub
        'Else
        '    If condition < expiry Then
        '        If iNumberOfDays > 2 Or current < condition Then
        '            MsgBox("Conflict occur with the Server Date Please Match date to the server", MsgBoxStyle.Information, "Error in Date")
        '            Exit Sub
        '        ElseIf Not iNumberOfDays = 0 Then
        '            cmd.Connection = con
        '            cmd.CommandText = "Update Activation set Condition='" & EncryptString128Bit(Format(Date.Today, "dd/MM/yy"), 4) & "' where IsCurrent='True'"
        '            cmd.ExecuteNonQuery()
        '        End If
        '    End If

        'End If
        cmd.Connection = con
        Dim saved_hash As String
        Dim test_hash As String
        Try
            ' txtloginname.Text = ("SELECT UserAccounts.UserID, UserAccounts.UserName, UserAccounts.Password, UserAccounts.Status, UserAccounts.GroupID, UserGroups.GroupName FROM UserAccounts INNER JOIN UserGroups ON UserAccounts.GroupID = UserGroups.GroupID where UserAccounts.UserName='" & txtloginname.Text & "' and UserAccounts.Password='" & EncryptString128Bit(txtpassword.Text, 2) & "'")
            MainModule.DatasetFill("SELECT UserAccounts.UserID, UserAccounts.UserName, UserAccounts.Password, UserAccounts.Status, UserAccounts.GroupID, UserGroups.GroupName FROM UserAccounts INNER JOIN UserGroups ON UserAccounts.GroupID = UserGroups.GroupID where UserAccounts.UserName='" & txtloginname.Text & "' and UserAccounts.Password='" & EncryptString128Bit(txtpassword.Text, 2) & "'", "UserAccounts")
            If ds.Tables("UserAccounts").Rows(0).Item("Status") = "False" Then
                MsgBox("Your Account is blocked Please Contact Administrator.", MsgBoxStyle.Information, "Account Blocked")
                Exit Sub
            End If
            saved_hash = ds.Tables("UserAccounts").Rows(0).Item("Password")
            ' Hash the password entered by the user.
            test_hash = EncryptString128Bit(txtpassword.Text, 2)
        Catch ex As Exception
            MsgBox("Invalid User Name or Password")
            txtloginname.Focus()
            Exit Sub
        End Try
        If test_hash = saved_hash Then
            vUserId = CInt(ds.Tables("UserAccounts").Rows(0).Item("UserID"))
            vUserName = ds.Tables("UserAccounts").Rows(0).Item("UserName")
            vGroupId = ds.Tables("UserAccounts").Rows(0).Item("GroupID")
            vGroupName = ds.Tables("UserAccounts").Rows(0).Item("GroupName")
            Dim mdi As New FrmMainMdi
            mdi.Show()
            Me.Close()
        Else
            MessageBox.Show("Get lost, ya bum!")
        End If
    End Sub

    Private Sub btncancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        'DeleteSetting(Application.ProductName, txtpassword.Name)
        'DeleteSetting(Application.ProductName, txtloginname.Name)
    End Sub
    Private Sub BtnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetting.Click
        Dim frm As New FrmSetting
        frm.ShowDialog()
        Me.Close()
    End Sub
End Class