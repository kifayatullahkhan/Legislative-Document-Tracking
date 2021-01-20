Public Class FrmView
    Public ReadOnly Property UserName() As String
        Get
            Return T.Text
        End Get
    End Property
    Public ReadOnly Property UserName1() As String
        Get
            Return T2.Text
        End Get
    End Property
    'Private _passedText As String
    'Private _Textbox As String

    'Public Property [PassedText]() As String
    '    Get
    '        Return _passedText
    '    End Get
    '    Set(ByVal Value As String)
    '        _passedText = Value
    '    End Set
    'End Property
    'Public Property [Textbox]() As String
    '    Get
    '        Return _Textbox
    '    End Get
    '    Set(ByVal Value As String)
    '        _Textbox = Value
    '    End Set
    'End Property

    Private Sub FrmView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'T.Text = _passedText
        ' MsgBox(_Textbox)
        T.ShortcutsEnabled = True
        'Form1.Show()

    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        'Me.Hide()
        'FrmBillAmmendments.Show()
        Try

  
            bc = T.Text
            ab = T2.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
        'FrmBillAmmendments.TxtPashto.Text = T.Text
        'FrmBillAmmendments.Refresh()
        'Me.Close()
        'FrmBillAmmendments.TxtPashto.Text = T.Text


    End Sub

    'Private Sub T_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T.TextChanged
    '    Form1.TextBox1.Text = T.Text
    '    FrmDailyAgenda.Focus()
    '    FrmDailyAgenda.Controls.SetChildIndex(FrmDailyAgenda.TxtAgendatextPashto, 1)
    '    FrmDailyAgenda.TxtAgendatextPashto.Text = T.Text
    'End Sub
End Class