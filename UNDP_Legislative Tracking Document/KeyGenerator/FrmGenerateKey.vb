Public Class FrmGenerateKey
    Dim key As String
    Dim first As String
    Dim second As String
    Dim third As String
    Private Sub FrmGenerateKey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GbActivation.Visible = False
    End Sub
    Public Function GenerateRandomString(ByRef len As Integer) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "abcdefghighlmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As String = String.Empty

        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next
        Return final ' IIf(upper, final.ToUpper(), final)
    End Function
    Private Sub BtnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerate.Click
        first = GenerateRandomString(3) & Format(DtpExpiryDate.Value, "yy")
        second = GenerateRandomString(2) & Format(DtpExpiryDate.Value, "MM")
        third = GenerateRandomString(2) & Format(DtpExpiryDate.Value, "dd") & GenerateRandomString(2)
        key = EncryptString128Bit(first & second & third, 5) & GenerateRandomString(1)
        key = key.Substring(0, 5) & " - " & key.Substring(5, 5) & " - " & key.Substring(10, 5) & " - " & key.Substring(15, 5) & " - " & key.Substring(20, 5)
        TextBox3.Text = key
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If EncryptString128Bit(txtmasterPassword.Text, 3) = "4RpisVES6EbWv/762tw/MUSH5mrMTczN60+2Yh522Io=" Then
            GbActivation.Visible = True
        Else
            GbActivation.Visible = False
            txtmasterPassword.Clear()
            txtmasterPassword.Focus()
            MsgBox("Master Password is incorrect ...", MsgBoxStyle.Information, "Wrong Attempt")
        End If
    End Sub
End Class