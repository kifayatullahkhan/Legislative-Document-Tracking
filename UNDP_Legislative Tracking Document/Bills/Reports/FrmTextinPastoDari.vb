Public Class FrmTextinPastoDari
    'Private _txtpashto As String

    'Public Property [Textpashto]() As String
    '    Get
    '        Return _txtpashto
    '    End Get
    '    Set(ByVal Value As String)
    '        _txtpashto = Value
    '    End Set
    'End Property
    Public ReadOnly Property UserName() As String
        Get
            Return TextBox1.Text
        End Get
    End Property

    Private Sub FrmTextinPastoDari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        'Dim obj As New FrmBills
        'obj.TxtBilTextinPashto.Text = TextBox1.Text
        'MsgBox(TextBox1.Text)
        ''Me.Close()
        'obj.TxtBilTextinPashto.Text = Me.TextBox1.Text
        Me.Hide()
        FrmBills.TxtBilTextinPashto.Text = TextBox1.Text
    End Sub
End Class