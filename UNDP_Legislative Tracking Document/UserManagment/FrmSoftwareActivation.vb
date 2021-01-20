Public Class FrmSoftwareActivation
    Dim count As Integer
    Private Sub txtfirst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfirst.TextChanged
        If txtfirst.Text.Length = 5 Then
            txtsecond.Focus()
        End If
    End Sub
    Private Sub txtsecond_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsecond.TextChanged
        If txtsecond.Text.Length = 5 Then
            txtthird.Focus()
        End If
    End Sub
    Private Sub txtthird_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtthird.TextChanged
        If txtthird.Text.Length = 5 Then
            txtfourth.Focus()
        End If
    End Sub
    Private Sub txtfourth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfourth.TextChanged
        If txtfourth.Text.Length = 5 Then
            txtfifth.Focus()
        End If
    End Sub
    Private Sub txtfifth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfifth.TextChanged
        If txtfifth.Text.Length = 5 Then
            btnregister.Focus()
        End If
    End Sub
    Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregister.Click
        MainModule.connectionopen()
        cmd.Connection = con
        Dim expiry As Date
        Try
            Dim key As String = txtfirst.Text & txtsecond.Text & txtthird.Text & txtfourth.Text & txtfifth.Text
            Dim str As String = DecryptString128Bit(key.Substring(0, 24), 5)
            Dim year As String = str.Substring(3, 2)
            Dim month As String = str.Substring(7, 2)
            Dim day As String = str.Substring(11, 2)
            expiry = New Date(2000 + year, month, day)
        Catch ex As Exception
            MsgBox("Incorrect Key Please verify ...", MsgBoxStyle.Information, "Wrong Key")
            txtfirst.Focus()
            Exit Sub
        End Try
        DatasetFill("select * from Activation where IsCurrent='True'", "Activation")
        Try
            If ds.Tables("Activation").Rows(0).Item("ActivationKey") = txtfirst.Text & txtsecond.Text & txtthird.Text & txtfourth.Text & txtfifth.Text Then
                MsgBox("Software is already Registered with this key", MsgBoxStyle.Information, "Used Key")
                Exit Sub
            End If
        Catch ex As Exception
        End Try
        Dim current As Date = Date.Today
        If current <= expiry Or ds.Tables("Activation").Rows.Count = 0 Then
            cmd.CommandText = "insert into Activation Values (" & GetMax("ID", "Activation") & ",'" & txtcompanyName.Text & "','" & txtfirst.Text & txtsecond.Text & txtthird.Text & txtfourth.Text & txtfifth.Text & "','" & EncryptString128Bit(Format(Date.Today, "dd/MM/yy"), 4) & "','True' )"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "Update Activation set IsCurrent='False' where ID=" & GetMax("ID", "Activation") - 2
            cmd.ExecuteNonQuery()
            MsgBox("Software is Registered Successfully", MsgBoxStyle.Information, "Registered")
        Else
            MsgBox("The Provided key is expired or not correct", MsgBoxStyle.Information, "Attention")
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub gb_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gb.MouseClick
        count += 1
        If count = 14 Then
            FrmGenerateKey.Show()
        End If
    End Sub
End Class