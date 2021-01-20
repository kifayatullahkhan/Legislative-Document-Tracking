<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmForwarBillToHouse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmForwarBillToHouse))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblMessage = New System.Windows.Forms.Label
        Me.TxtSearchBill = New System.Windows.Forms.TextBox
        Me.DgBill = New System.Windows.Forms.DataGridView
        Me.BillTitle1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbStatus = New System.Windows.Forms.ComboBox
        Me.DtpReturnDate = New System.Windows.Forms.DateTimePicker
        Me.DtpIssueDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbHouse = New System.Windows.Forms.ComboBox
        Me.TxtComments = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgview = New System.Windows.Forms.DataGridView
        Me.BillTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HouseName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReturnDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Status1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillHouseID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.txtSearchRecord = New System.Windows.Forms.TextBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 324)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(746, 305)
        Me.SplitContainer1.SplitterDistance = 138
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblMessage)
        Me.GroupBox2.Controls.Add(Me.TxtSearchBill)
        Me.GroupBox2.Controls.Add(Me.DgBill)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CmbStatus)
        Me.GroupBox2.Controls.Add(Me.DtpReturnDate)
        Me.GroupBox2.Controls.Add(Me.DtpIssueDate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CmbHouse)
        Me.GroupBox2.Controls.Add(Me.TxtComments)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(10, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(727, 136)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record (Entry / Edit)"
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.BackColor = System.Drawing.Color.Transparent
        Me.LblMessage.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.LblMessage.Location = New System.Drawing.Point(557, 116)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(0, 14)
        Me.LblMessage.TabIndex = 67
        '
        'TxtSearchBill
        '
        Me.TxtSearchBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchBill.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtSearchBill.Location = New System.Drawing.Point(30, 19)
        Me.TxtSearchBill.Name = "TxtSearchBill"
        Me.TxtSearchBill.Size = New System.Drawing.Size(193, 20)
        Me.TxtSearchBill.TabIndex = 53
        Me.TxtSearchBill.Text = "Search Record(s) by Bill Title"
        '
        'DgBill
        '
        Me.DgBill.AllowUserToDeleteRows = False
        Me.DgBill.BackgroundColor = System.Drawing.Color.White
        Me.DgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillTitle1, Me.BillID})
        Me.DgBill.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DgBill.Location = New System.Drawing.Point(30, 40)
        Me.DgBill.Name = "DgBill"
        Me.DgBill.ReadOnly = True
        Me.DgBill.RowHeadersVisible = False
        Me.DgBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgBill.Size = New System.Drawing.Size(193, 90)
        Me.DgBill.TabIndex = 52
        '
        'BillTitle1
        '
        Me.BillTitle1.HeaderText = "Bill Title"
        Me.BillTitle1.Name = "BillTitle1"
        Me.BillTitle1.ReadOnly = True
        Me.BillTitle1.Width = 190
        '
        'BillID
        '
        Me.BillID.HeaderText = "BillID"
        Me.BillID.Name = "BillID"
        Me.BillID.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(263, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Return Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(263, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Issue Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(507, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Status"
        '
        'CmbStatus
        '
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(507, 29)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(196, 21)
        Me.CmbStatus.TabIndex = 4
        '
        'DtpReturnDate
        '
        Me.DtpReturnDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpReturnDate.Location = New System.Drawing.Point(266, 108)
        Me.DtpReturnDate.Name = "DtpReturnDate"
        Me.DtpReturnDate.Size = New System.Drawing.Size(196, 20)
        Me.DtpReturnDate.TabIndex = 3
        '
        'DtpIssueDate
        '
        Me.DtpIssueDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpIssueDate.Location = New System.Drawing.Point(266, 69)
        Me.DtpIssueDate.Name = "DtpIssueDate"
        Me.DtpIssueDate.Size = New System.Drawing.Size(196, 20)
        Me.DtpIssueDate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(266, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "House"
        '
        'CmbHouse
        '
        Me.CmbHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbHouse.FormattingEnabled = True
        Me.CmbHouse.Location = New System.Drawing.Point(266, 29)
        Me.CmbHouse.Name = "CmbHouse"
        Me.CmbHouse.Size = New System.Drawing.Size(196, 21)
        Me.CmbHouse.TabIndex = 1
        '
        'TxtComments
        '
        Me.TxtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComments.Location = New System.Drawing.Point(507, 69)
        Me.TxtComments.Multiline = True
        Me.TxtComments.Name = "TxtComments"
        Me.TxtComments.Size = New System.Drawing.Size(196, 39)
        Me.TxtComments.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(508, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Comments"
        '
        'dgview
        '
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillTitle, Me.HouseName, Me.IssueDate, Me.ReturnDate, Me.Status1, Me.Comments, Me.BillHouseID})
        Me.dgview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgview.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgview.Location = New System.Drawing.Point(0, 0)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgview.Size = New System.Drawing.Size(746, 163)
        Me.dgview.TabIndex = 0
        '
        'BillTitle
        '
        Me.BillTitle.HeaderText = "Bill Title"
        Me.BillTitle.Name = "BillTitle"
        Me.BillTitle.ReadOnly = True
        Me.BillTitle.Width = 150
        '
        'HouseName
        '
        Me.HouseName.HeaderText = "House Name"
        Me.HouseName.Name = "HouseName"
        Me.HouseName.ReadOnly = True
        Me.HouseName.Width = 150
        '
        'IssueDate
        '
        Me.IssueDate.HeaderText = "Issue Date"
        Me.IssueDate.Name = "IssueDate"
        Me.IssueDate.ReadOnly = True
        '
        'ReturnDate
        '
        Me.ReturnDate.HeaderText = "Return Date"
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.ReadOnly = True
        '
        'Status1
        '
        Me.Status1.HeaderText = "Status"
        Me.Status1.Name = "Status1"
        Me.Status1.ReadOnly = True
        Me.Status1.Width = 120
        '
        'Comments
        '
        Me.Comments.HeaderText = "Comments"
        Me.Comments.Name = "Comments"
        Me.Comments.ReadOnly = True
        Me.Comments.Width = 130
        '
        'BillHouseID
        '
        Me.BillHouseID.HeaderText = "Bill House ID"
        Me.BillHouseID.Name = "BillHouseID"
        Me.BillHouseID.ReadOnly = True
        Me.BillHouseID.Width = 120
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(769, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 434)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(769, 65)
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(733, 442)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'txtSearchRecord
        '
        Me.txtSearchRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchRecord.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSearchRecord.Location = New System.Drawing.Point(412, 443)
        Me.txtSearchRecord.Name = "txtSearchRecord"
        Me.txtSearchRecord.Size = New System.Drawing.Size(315, 20)
        Me.txtSearchRecord.TabIndex = 4
        Me.txtSearchRecord.Text = "Search Record(s) by Bill Title"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(594, 468)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 23)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(411, 468)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 23)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "&Save/Forward"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(502, 468)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 23)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'FrmForwarBillToHouse
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
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "FrmForwarBillToHouse"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forward Bill To House"
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtComments As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbHouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents DtpReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchRecord As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BillTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HouseName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillHouseID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtSearchBill As System.Windows.Forms.TextBox
    Friend WithEvents DgBill As System.Windows.Forms.DataGridView
    Friend WithEvents BillTitle1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
