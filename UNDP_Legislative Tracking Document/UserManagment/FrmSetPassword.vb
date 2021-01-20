Imports System.Data.SqlClient

Public Class FrmSetPassword
    Private Sub btnsetpassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsetpassword.Click
        'Dim query As String = "select UserName,Password from UserAccounts where UserName='" & txtusername.Text & "' and Password='" & HashPassword(tstoldpassword.Text) & "'"
        'Dim table As String = "Check"
        'MainModule.DatasetFill(query, table)
        'If ds.Tables("Check").Rows.Count = 0 Then
        '    MsgBox("User not exist oR Old Password is not Valid", MsgBoxStyle.Information, "Invalid Attempt")
        '    Exit Sub
        'End If
        'If Not txtnewpassword.Text = txtconfirmpassword.Text Then
        '    MsgBox("Retry New Password Conformation", MsgBoxStyle.Information, "Not Confirmed")
        '    txtconfirmpassword.Clear()
        '    txtconfirmpassword.Focus()
        '    Exit Sub
        'Else
        ' Allow Admin to Reset Password for any User
        cmd.CommandText = "Update UserAccounts set UserName='" & txtusername.Text & "' ,Password='" & EncryptString128Bit(txtnewpassword.Text, 2) & "' where UserName='" & txtusername.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Password is Updated Successfully", MsgBoxStyle.Information, "Confirmed")
        ' End If
        Call txtclear()
    End Sub
    Private Sub txtclear()
        txtusername.Clear()
        ''tstoldpassword.Clear()
        txtnewpassword.Clear()
        'txtconfirmpassword.Clear()
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class