<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGroupRights
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGroupRights))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.ChkReports = New System.Windows.Forms.CheckBox
        Me.ChkHelp = New System.Windows.Forms.CheckBox
        Me.ChkPassword = New System.Windows.Forms.CheckBox
        Me.ChkAdministrator1 = New System.Windows.Forms.CheckBox
        Me.ChkLegislativeDepartment = New System.Windows.Forms.CheckBox
        Me.ChkSetup = New System.Windows.Forms.CheckBox
        Me.ChkFile = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnnormal = New System.Windows.Forms.Button
        Me.btndenyfull = New System.Windows.Forms.Button
        Me.btnallowfull = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbgroupname = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.ChkHouses = New System.Windows.Forms.CheckBox
        Me.ChkCommissions = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 266)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ChkHouses)
        Me.GroupBox7.Controls.Add(Me.ChkCommissions)
        Me.GroupBox7.Controls.Add(Me.ChkReports)
        Me.GroupBox7.Controls.Add(Me.ChkHelp)
        Me.GroupBox7.Controls.Add(Me.ChkPassword)
        Me.GroupBox7.Controls.Add(Me.ChkAdministrator1)
        Me.GroupBox7.Controls.Add(Me.ChkLegislativeDepartment)
        Me.GroupBox7.Controls.Add(Me.ChkSetup)
        Me.GroupBox7.Controls.Add(Me.ChkFile)
        Me.GroupBox7.Location = New System.Drawing.Point(11, 127)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(551, 125)
        Me.GroupBox7.TabIndex = 48
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Give Rights"
        '
        'ChkReports
        '
        Me.ChkReports.AutoSize = True
        Me.ChkReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkReports.Location = New System.Drawing.Point(377, 43)
        Me.ChkReports.Name = "ChkReports"
        Me.ChkReports.Size = New System.Drawing.Size(63, 17)
        Me.ChkReports.TabIndex = 62
        Me.ChkReports.Text = "Reports"
        Me.ChkReports.UseVisualStyleBackColor = True
        '
        'ChkHelp
        '
        Me.ChkHelp.AutoSize = True
        Me.ChkHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkHelp.Location = New System.Drawing.Point(470, 43)
        Me.ChkHelp.Name = "ChkHelp"
        Me.ChkHelp.Size = New System.Drawing.Size(48, 17)
        Me.ChkHelp.TabIndex = 61
        Me.ChkHelp.Text = "Help"
        Me.ChkHelp.UseVisualStyleBackColor = True
        '
        'ChkPassword
        '
        Me.ChkPassword.AutoSize = True
        Me.ChkPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkPassword.Location = New System.Drawing.Point(377, 74)
        Me.ChkPassword.Name = "ChkPassword"
        Me.ChkPassword.Size = New System.Drawing.Size(72, 17)
        Me.ChkPassword.TabIndex = 60
        Me.ChkPassword.Text = "Password"
        Me.ChkPassword.UseVisualStyleBackColor = True
        '
        'ChkAdministrator1
        '
        Me.ChkAdministrator1.AutoSize = True
        Me.ChkAdministrator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkAdministrator1.Location = New System.Drawing.Point(111, 76)
        Me.ChkAdministrator1.Name = "ChkAdministrator1"
        Me.ChkAdministrator1.Size = New System.Drawing.Size(86, 17)
        Me.ChkAdministrator1.TabIndex = 51
        Me.ChkAdministrator1.Text = "Administrator"
        Me.ChkAdministrator1.UseVisualStyleBackColor = True
        '
        'ChkLegislativeDepartment
        '
        Me.ChkLegislativeDepartment.AutoSize = True
        Me.ChkLegislativeDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkLegislativeDepartment.Location = New System.Drawing.Point(111, 43)
        Me.ChkLegislativeDepartment.Name = "ChkLegislativeDepartment"
        Me.ChkLegislativeDepartment.Size = New System.Drawing.Size(134, 17)
        Me.ChkLegislativeDepartment.TabIndex = 50
        Me.ChkLegislativeDepartment.Text = "Legislative Department"
        Me.ChkLegislativeDepartment.UseVisualStyleBackColor = True
        '
        'ChkSetup
        '
        Me.ChkSetup.AutoSize = True
        Me.ChkSetup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkSetup.Location = New System.Drawing.Point(19, 76)
        Me.ChkSetup.Name = "ChkSetup"
        Me.ChkSetup.Size = New System.Drawing.Size(54, 17)
        Me.ChkSetup.TabIndex = 49
        Me.ChkSetup.Text = "Setup"
        Me.ChkSetup.UseVisualStyleBackColor = True
        '
        'ChkFile
        '
        Me.ChkFile.AutoSize = True
        Me.ChkFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkFile.Location = New System.Drawing.Point(19, 43)
        Me.ChkFile.Name = "ChkFile"
        Me.ChkFile.Size = New System.Drawing.Size(42, 17)
        Me.ChkFile.TabIndex = 48
        Me.ChkFile.Text = "File"
        Me.ChkFile.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnnormal)
        Me.GroupBox3.Controls.Add(Me.btndenyfull)
        Me.GroupBox3.Controls.Add(Me.btnallowfull)
        Me.GroupBox3.Location = New System.Drawing.Point(292, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(270, 95)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Short Cuts"
        '
        'btnnormal
        '
        Me.btnnormal.Location = New System.Drawing.Point(171, 40)
        Me.btnnormal.Name = "btnnormal"
        Me.btnnormal.Size = New System.Drawing.Size(76, 23)
        Me.btnnormal.TabIndex = 2
        Me.btnnormal.Text = "&Normal"
        Me.btnnormal.UseVisualStyleBackColor = True
        '
        'btndenyfull
        '
        Me.btndenyfull.Location = New System.Drawing.Point(93, 41)
        Me.btndenyfull.Name = "btndenyfull"
        Me.btndenyfull.Size = New System.Drawing.Size(76, 23)
        Me.btndenyfull.TabIndex = 1
        Me.btndenyfull.Text = "&Deny Full"
        Me.btndenyfull.UseVisualStyleBackColor = True
        '
        'btnallowfull
        '
        Me.btnallowfull.Location = New System.Drawing.Point(15, 40)
        Me.btnallowfull.Name = "btnallowfull"
        Me.btnallowfull.Size = New System.Drawing.Size(76, 23)
        Me.btnallowfull.TabIndex = 0
        Me.btnallowfull.Text = "&Allow Full"
        Me.btnallowfull.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbgroupname)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 94)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Group To Give Rights"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Group Name"
        '
        'cmbgroupname
        '
        Me.cmbgroupname.FormattingEnabled = True
        Me.cmbgroupname.Location = New System.Drawing.Point(101, 45)
        Me.cmbgroupname.Name = "cmbgroupname"
        Me.cmbgroupname.Size = New System.Drawing.Size(153, 21)
        Me.cmbgroupname.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(595, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 375)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(595, 65)
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'btndelete
        '
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(500, 404)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(76, 23)
        Me.btndelete.TabIndex = 52
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupdate.Location = New System.Drawing.Point(418, 405)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(76, 23)
        Me.btnupdate.TabIndex = 51
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(334, 404)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(76, 23)
        Me.btnsave.TabIndex = 50
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'ChkHouses
        '
        Me.ChkHouses.AutoSize = True
        Me.ChkHouses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkHouses.Location = New System.Drawing.Point(264, 44)
        Me.ChkHouses.Name = "ChkHouses"
        Me.ChkHouses.Size = New System.Drawing.Size(62, 17)
        Me.ChkHouses.TabIndex = 64
        Me.ChkHouses.Text = "Houses"
        Me.ChkHouses.UseVisualStyleBackColor = True
        '
        'ChkCommissions
        '
        Me.ChkCommissions.AutoSize = True
        Me.ChkCommissions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkCommissions.Location = New System.Drawing.Point(264, 75)
        Me.ChkCommissions.Name = "ChkCommissions"
        Me.ChkCommissions.Size = New System.Drawing.Size(86, 17)
        Me.ChkCommissions.TabIndex = 63
        Me.ChkCommissions.Text = "Commissions"
        Me.ChkCommissions.UseVisualStyleBackColor = True
        '
        'FrmGroupRights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(589, 446)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmGroupRights"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Rights"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkAdministrator1 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLegislativeDepartment As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSetup As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFile As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbgroupname As System.Windows.Forms.ComboBox
    Friend WithEvents btnnormal As System.Windows.Forms.Button
    Friend WithEvents btndenyfull As System.Windows.Forms.Button
    Friend WithEvents btnallowfull As System.Windows.Forms.Button
    Friend WithEvents ChkHelp As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPassword As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents ChkReports As System.Windows.Forms.CheckBox
    Friend WithEvents ChkHouses As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCommissions As System.Windows.Forms.CheckBox
End Class
