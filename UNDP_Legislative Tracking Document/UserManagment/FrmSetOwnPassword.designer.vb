<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetOwnPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSetOwnPassword))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtconfirmpassword = New System.Windows.Forms.TextBox
        Me.txtnewpassword = New System.Windows.Forms.TextBox
        Me.tstoldpassword = New System.Windows.Forms.TextBox
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsetpassword = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtconfirmpassword)
        Me.GroupBox1.Controls.Add(Me.txtnewpassword)
        Me.GroupBox1.Controls.Add(Me.tstoldpassword)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 113)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Old Password"
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtconfirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtconfirmpassword.Location = New System.Drawing.Point(131, 77)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpassword.Size = New System.Drawing.Size(210, 20)
        Me.txtconfirmpassword.TabIndex = 3
        '
        'txtnewpassword
        '
        Me.txtnewpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnewpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnewpassword.Location = New System.Drawing.Point(131, 47)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpassword.Size = New System.Drawing.Size(210, 20)
        Me.txtnewpassword.TabIndex = 2
        '
        'tstoldpassword
        '
        Me.tstoldpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tstoldpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstoldpassword.Location = New System.Drawing.Point(131, 20)
        Me.tstoldpassword.Name = "tstoldpassword"
        Me.tstoldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tstoldpassword.Size = New System.Drawing.Size(210, 20)
        Me.tstoldpassword.TabIndex = 1
        '
        'btncancel
        '
        Me.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncancel.Location = New System.Drawing.Point(287, 189)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(95, 24)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsetpassword
        '
        Me.btnsetpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsetpassword.Location = New System.Drawing.Point(183, 189)
        Me.btnsetpassword.Name = "btnsetpassword"
        Me.btnsetpassword.Size = New System.Drawing.Size(95, 24)
        Me.btnsetpassword.TabIndex = 9
        Me.btnsetpassword.Text = "&Set Password"
        Me.btnsetpassword.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(397, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-7, 218)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(402, 48)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'FrmSetOwnPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 266)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsetpassword)
        Me.Name = "FrmSetOwnPassword"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtconfirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpassword As System.Windows.Forms.TextBox
    Friend WithEvents tstoldpassword As System.Windows.Forms.TextBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsetpassword As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
