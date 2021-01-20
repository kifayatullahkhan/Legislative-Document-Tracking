<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerateKey
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
        Me.DtpExpiryDate = New System.Windows.Forms.DateTimePicker
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.BtnGenerate = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GbActivation = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtmasterPassword = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GbActivation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtpExpiryDate
        '
        Me.DtpExpiryDate.CustomFormat = "dd/MM/yy"
        Me.DtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpExpiryDate.Location = New System.Drawing.Point(24, 34)
        Me.DtpExpiryDate.Name = "DtpExpiryDate"
        Me.DtpExpiryDate.Size = New System.Drawing.Size(200, 20)
        Me.DtpExpiryDate.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(19, 72)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(335, 39)
        Me.TextBox3.TabIndex = 2
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Location = New System.Drawing.Point(268, 31)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(86, 25)
        Me.BtnGenerate.TabIndex = 1
        Me.BtnGenerate.Text = "&Generate"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select Expiry Date"
        '
        'GbActivation
        '
        Me.GbActivation.BackColor = System.Drawing.Color.Transparent
        Me.GbActivation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GbActivation.Controls.Add(Me.TextBox3)
        Me.GbActivation.Controls.Add(Me.Label1)
        Me.GbActivation.Controls.Add(Me.DtpExpiryDate)
        Me.GbActivation.Controls.Add(Me.BtnGenerate)
        Me.GbActivation.Location = New System.Drawing.Point(33, 94)
        Me.GbActivation.Name = "GbActivation"
        Me.GbActivation.Size = New System.Drawing.Size(376, 120)
        Me.GbActivation.TabIndex = 1
        Me.GbActivation.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtmasterPassword)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Master Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtmasterPassword
        '
        Me.txtmasterPassword.Location = New System.Drawing.Point(24, 38)
        Me.txtmasterPassword.Name = "txtmasterPassword"
        Me.txtmasterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmasterPassword.Size = New System.Drawing.Size(200, 20)
        Me.txtmasterPassword.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(152, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 24)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Key Generation"
        Me.Label8.UseCompatibleTextRendering = True
        '
        'FrmGenerateKey
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(439, 220)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbActivation)
        Me.Name = "FrmGenerateKey"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Key"
        Me.GbActivation.ResumeLayout(False)
        Me.GbActivation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtpExpiryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents BtnGenerate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GbActivation As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtmasterPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
