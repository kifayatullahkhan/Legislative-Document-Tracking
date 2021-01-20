Public Class FrmSetting

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        SaveSetting(Application.ProductName, txtloginname.Name, "Item1", "SERVER")
        SaveSetting(Application.ProductName, txtpassword.Name, "Item2", "SERVER1")
        DeleteSetting(Application.ProductName, txtloginname.Name)
        DeleteSetting(Application.ProductName, txtpassword.Name)
        SaveSetting(Application.ProductName, txtpassword.Name, "Password", EncryptString128Bit(txtpassword.Text, 2))
        SaveSetting(Application.ProductName, txtloginname.Name, "LoginName", txtloginname.Text)
        'If Not GetSetting(Application.ProductName, txtpassword.Name, "Password") = "" Then
        '   
        'End If
        Dim frm As New FrmLogin
        frm.Show()
        Me.Close()
    End Sub
End Class