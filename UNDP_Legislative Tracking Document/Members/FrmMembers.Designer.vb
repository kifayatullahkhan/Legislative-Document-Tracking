<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMembers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMembers))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblMessage = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtMemberId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtMemberName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtMemberDetail = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtMemberParty = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtMemberSession = New System.Windows.Forms.TextBox
        Me.TxtComments = New System.Windows.Forms.TextBox
        Me.dgview = New System.Windows.Forms.DataGridView
        Me.MemberName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MemberDetail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MemeberParty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MemberSession = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MemberID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.txtSearchRecord = New System.Windows.Forms.TextBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 320)
        Me.GroupBox1.TabIndex = 0
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
        Me.SplitContainer1.Size = New System.Drawing.Size(740, 301)
        Me.SplitContainer1.SplitterDistance = 121
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblMessage)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtMemberId)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtMemberName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtMemberDetail)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtMemberParty)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtMemberSession)
        Me.GroupBox2.Controls.Add(Me.TxtComments)
        Me.GroupBox2.Location = New System.Drawing.Point(9, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(721, 117)
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
        Me.LblMessage.Location = New System.Drawing.Point(544, 98)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(0, 14)
        Me.LblMessage.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(48, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Member ID"
        '
        'TxtMemberId
        '
        Me.TxtMemberId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMemberId.Location = New System.Drawing.Point(45, 35)
        Me.TxtMemberId.Name = "TxtMemberId"
        Me.TxtMemberId.Size = New System.Drawing.Size(166, 20)
        Me.TxtMemberId.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(45, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "MemberName"
        '
        'TxtMemberName
        '
        Me.TxtMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMemberName.Location = New System.Drawing.Point(45, 72)
        Me.TxtMemberName.Name = "TxtMemberName"
        Me.TxtMemberName.Size = New System.Drawing.Size(166, 20)
        Me.TxtMemberName.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(510, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Comments"
        '
        'TxtMemberDetail
        '
        Me.TxtMemberDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMemberDetail.Location = New System.Drawing.Point(275, 35)
        Me.TxtMemberDetail.Name = "TxtMemberDetail"
        Me.TxtMemberDetail.Size = New System.Drawing.Size(166, 20)
        Me.TxtMemberDetail.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(508, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Member Session"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(276, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Member Party"
        '
        'TxtMemberParty
        '
        Me.TxtMemberParty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMemberParty.Location = New System.Drawing.Point(275, 72)
        Me.TxtMemberParty.Name = "TxtMemberParty"
        Me.TxtMemberParty.Size = New System.Drawing.Size(166, 20)
        Me.TxtMemberParty.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(276, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Member Detail"
        '
        'TxtMemberSession
        '
        Me.TxtMemberSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMemberSession.Location = New System.Drawing.Point(506, 35)
        Me.TxtMemberSession.Name = "TxtMemberSession"
        Me.TxtMemberSession.Size = New System.Drawing.Size(166, 20)
        Me.TxtMemberSession.TabIndex = 4
        '
        'TxtComments
        '
        Me.TxtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComments.Location = New System.Drawing.Point(506, 72)
        Me.TxtComments.Name = "TxtComments"
        Me.TxtComments.Size = New System.Drawing.Size(166, 20)
        Me.TxtComments.TabIndex = 5
        '
        'dgview
        '
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberName, Me.MemberDetail, Me.MemeberParty, Me.MemberSession, Me.Comments, Me.MemberID})
        Me.dgview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgview.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgview.Location = New System.Drawing.Point(0, 0)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgview.Size = New System.Drawing.Size(740, 176)
        Me.dgview.TabIndex = 0
        '
        'MemberName
        '
        Me.MemberName.HeaderText = "Member Name"
        Me.MemberName.Name = "MemberName"
        Me.MemberName.ReadOnly = True
        Me.MemberName.Width = 120
        '
        'MemberDetail
        '
        Me.MemberDetail.HeaderText = "Member Detail"
        Me.MemberDetail.Name = "MemberDetail"
        Me.MemberDetail.ReadOnly = True
        Me.MemberDetail.Width = 200
        '
        'MemeberParty
        '
        Me.MemeberParty.HeaderText = "Member Party"
        Me.MemeberParty.Name = "MemeberParty"
        Me.MemeberParty.ReadOnly = True
        Me.MemeberParty.Width = 130
        '
        'MemberSession
        '
        Me.MemberSession.HeaderText = "Member Session"
        Me.MemberSession.Name = "MemberSession"
        Me.MemberSession.ReadOnly = True
        Me.MemberSession.Width = 110
        '
        'Comments
        '
        Me.Comments.HeaderText = "Comments"
        Me.Comments.Name = "Comments"
        Me.Comments.ReadOnly = True
        Me.Comments.Width = 200
        '
        'MemberID
        '
        Me.MemberID.HeaderText = "Member ID"
        Me.MemberID.Name = "MemberID"
        Me.MemberID.ReadOnly = True
        Me.MemberID.Width = 125
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 434)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(768, 65)
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(768, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(730, 440)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'txtSearchRecord
        '
        Me.txtSearchRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchRecord.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSearchRecord.Location = New System.Drawing.Point(409, 441)
        Me.txtSearchRecord.Name = "txtSearchRecord"
        Me.txtSearchRecord.Size = New System.Drawing.Size(315, 20)
        Me.txtSearchRecord.TabIndex = 1
        Me.txtSearchRecord.Text = "Search Record(s) by Member Name"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(652, 466)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(76, 23)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(571, 466)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(76, 23)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(490, 466)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(76, 23)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(409, 466)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(76, 23)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "&New Entry"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'FrmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(762, 499)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtSearchRecord)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmMembers"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Members"
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtMemberDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMemberParty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMemberSession As System.Windows.Forms.TextBox
    Friend WithEvents TxtComments As System.Windows.Forms.TextBox
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MemberName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberDetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemeberParty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberSession As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchRecord As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
