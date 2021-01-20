Imports System.Data.SqlClient

Public Class FrmSetOwnPassword

    Private Sub btnsetpassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsetpassword.Click
        MainModule.DatasetFill("select UserName,Password from UserAccounts where UserName='" & vUserName & "' and Password='" & EncryptString128Bit(tstoldpassword.Text, 2) & "'", "Check")
        If ds.Tables("Check").Rows.Count = 0 Then
            MsgBox("User not exist oR Old Password is not Valid", MsgBoxStyle.Information, "Invalid Attempt")
            Exit Sub
        End If
        If Not txtnewpassword.Text = txtconfirmpassword.Text Then
            MsgBox("Retry New Password Conformation", MsgBoxStyle.Information, "Not Confirmed")
            txtconfirmpassword.Clear()
            txtconfirmpassword.Focus()
            Exit Sub
        Else
            cmd.CommandText = "Update UserAccounts set UserName='" & vUserName & "' ,Password='" & EncryptString128Bit(txtnewpassword.Text, 2) & "' where UserName='" & vUserName & "' and Password='" & EncryptString128Bit(tstoldpassword.Text, 2) & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Password is Updated Successfully", MsgBoxStyle.Information, "Confirmed")
        End If
        Call txtclear()
    End Sub
    Private Sub txtclear()
        tstoldpassword.Clear()
        txtnewpassword.Clear()
        txtconfirmpassword.Clear()
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class