<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserInformation
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserInformation))
        Me.Label1 = New System.Windows.Forms.Label
        Me.gb = New System.Windows.Forms.GroupBox
        Me.raddisable = New System.Windows.Forms.RadioButton
        Me.radenable = New System.Windows.Forms.RadioButton
        Me.dgview = New System.Windows.Forms.DataGridView
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoginName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContactName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TxtUserId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtUserName = New System.Windows.Forms.TextBox
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.TxtFullName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbGroupName = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtContactNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblMessage = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.txtSearchRecord = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gb.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(558, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Status"
        '
        'gb
        '
        Me.gb.BackColor = System.Drawing.Color.Transparent
        Me.gb.Controls.Add(Me.raddisable)
        Me.gb.Controls.Add(Me.radenable)
        Me.gb.Location = New System.Drawing.Point(558, 73)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(166, 27)
        Me.gb.TabIndex = 5
        Me.gb.TabStop = False
        '
        'raddisable
        '
        Me.raddisable.AutoSize = True
        Me.raddisable.Location = New System.Drawing.Point(94, 6)
        Me.raddisable.Name = "raddisable"
        Me.raddisable.Size = New System.Drawing.Size(60, 17)
        Me.raddisable.TabIndex = 1
        Me.raddisable.TabStop = True
        Me.raddisable.Text = "Disable"
        Me.raddisable.UseVisualStyleBackColor = True
        '
        'radenable
        '
        Me.radenable.AutoSize = True
        Me.radenable.Location = New System.Drawing.Point(15, 7)
        Me.radenable.Name = "radenable"
        Me.radenable.Size = New System.Drawing.Size(58, 17)
        Me.radenable.TabIndex = 0
        Me.radenable.TabStop = True
        Me.radenable.Text = "Enable"
        Me.radenable.UseVisualStyleBackColor = True
        '
        'dgview
        '
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserName, Me.LoginName, Me.ContactName, Me.Email, Me.GroupName, Me.Status, Me.UserID, Me.Password})
        Me.dgview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgview.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgview.Location = New System.Drawing.Point(0, 0)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgview.Size = New System.Drawing.Size(745, 162)
        Me.dgview.TabIndex = 10
        '
        'UserName
        '
        Me.UserName.HeaderText = "User Name"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        Me.UserName.Width = 125
        '
        'LoginName
        '
        Me.LoginName.HeaderText = "FullName"
        Me.LoginName.Name = "LoginName"
        Me.LoginName.ReadOnly = True
        Me.LoginName.Width = 135
        '
        'ContactName
        '
        Me.ContactName.HeaderText = "Contact No"
        Me.ContactName.Name = "ContactName"
        Me.ContactName.ReadOnly = True
        Me.ContactName.Width = 120
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 145
        '
        'GroupName
        '
        Me.GroupName.HeaderText = "GroupName"
        Me.GroupName.Name = "GroupName"
        Me.GroupName.ReadOnly = True
        Me.GroupName.Width = 130
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 90
        '
        'UserID
        '
        Me.UserID.HeaderText = "User ID"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        Me.UserID.Width = 105
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        '
        'TxtUserId
        '
        Me.TxtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserId.Location = New System.Drawing.Point(15, 38)
        Me.TxtUserId.Name = "TxtUserId"
        Me.TxtUserId.Size = New System.Drawing.Size(166, 20)
        Me.TxtUserId.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "UserName"
        '
        'TxtUserName
        '
        Me.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserName.Location = New System.Drawing.Point(15, 80)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(166, 20)
        Me.TxtUserName.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Location = New System.Drawing.Point(193, 38)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(166, 20)
        Me.TxtPassword.TabIndex = 2
        '
        'TxtFullName
        '
        Me.TxtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFullName.Location = New System.Drawing.Point(193, 80)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.Size = New System.Drawing.Size(166, 20)
        Me.TxtFullName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(376, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Contact No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(194, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(556, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Group Name"
        '
        'CmbGroupName
        '
        Me.CmbGroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGroupName.FormattingEnabled = True
        Me.CmbGroupName.Location = New System.Drawing.Point(556, 38)
        Me.CmbGroupName.Name = "CmbGroupName"
        Me.CmbGroupName.Size = New System.Drawing.Size(166, 21)
        Me.CmbGroupName.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(194, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Full Name"
        '
        'TxtContactNo
        '
        Me.TxtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtContactNo.Location = New System.Drawing.Point(374, 38)
        Me.TxtContactNo.Name = "TxtContactNo"
        Me.TxtContactNo.Size = New System.Drawing.Size(166, 20)
        Me.TxtContactNo.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(378, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Location = New System.Drawing.Point(374, 80)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(166, 20)
        Me.TxtEmail.TabIndex = 39
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 432)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(766, 65)
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(655, 465)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(76, 23)
        Me.BtnDelete.TabIndex = 45
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(574, 465)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(76, 23)
        Me.BtnSave.TabIndex = 44
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(493, 465)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(76, 23)
        Me.BtnUpdate.TabIndex = 43
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(412, 465)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(76, 23)
        Me.BtnAdd.TabIndex = 42
        Me.BtnAdd.Text = "&New Entry"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 321)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgview)
        Me.SplitContainer1.Size = New System.Drawing.Size(745, 302)
        Me.SplitContainer1.SplitterDistance = 136
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblMessage)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtUserId)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtUserName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtPassword)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.gb)
        Me.GroupBox2.Controls.Add(Me.TxtFullName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtContactNo)
        Me.GroupBox2.Controls.Add(Me.TxtEmail)
        Me.GroupBox2.Controls.Add(Me.CmbGroupName)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 131)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record (Entry / Edit)"
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.BackColor = System.Drawing.Color.Transparent
        Me.LblMessage.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.LblMessage.Location = New System.Drawing.Point(438, 111)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(0, 14)
        Me.LblMessage.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(18, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "User ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(766, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(733, 439)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox3.TabIndex = 48
        Me.PictureBox3.TabStop = False
        '
        'txtSearchRecord
        '
        Me.txtSearchRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchRecord.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSearchRecord.Location = New System.Drawing.Point(412, 440)
        Me.txtSearchRecord.Name = "txtSearchRecord"
        Me.txtSearchRecord.Size = New System.Drawing.Size(315, 20)
        Me.txtSearchRecord.TabIndex = 49
        Me.txtSearchRecord.Text = "Search Record(s) by User Name"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'FrmUserInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(762, 499)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtSearchRecord)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "FrmUserInformation"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Information"
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents raddisable As System.Windows.Forms.RadioButton
    Friend WithEvents radenable As System.Windows.Forms.RadioButton
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents TxtUserId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbGroupName As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchRecord As System.Windows.Forms.TextBox
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoginName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
