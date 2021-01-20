<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBills
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBills))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnDownload = New System.Windows.Forms.Button
        Me.BtnUpload = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.LblShowText = New System.Windows.Forms.Label
        Me.GrBoxMember = New System.Windows.Forms.GroupBox
        Me.DGMemb = New System.Windows.Forms.DataGridView
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TxtMemberSrc = New System.Windows.Forms.TextBox
        Me.BtnAdMembers = New System.Windows.Forms.Button
        Me.TxtComments = New System.Windows.Forms.TextBox
        Me.CmbDept = New System.Windows.Forms.ComboBox
        Me.RadMember = New System.Windows.Forms.RadioButton
        Me.RadDept = New System.Windows.Forms.RadioButton
        Me.IssueDate = New System.Windows.Forms.DateTimePicker
        Me.TxtBillinDari = New System.Windows.Forms.TextBox
        Me.TxtBilTextinPashto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblDept = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtBillNumber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtBillTitle = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtBillID = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.DGMembers = New System.Windows.Forms.DataGridView
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DGBills = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.TxtSearchRecord = New System.Windows.Forms.TextBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FileName1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrBoxMember.SuspendLayout()
        CType(Me.DGMemb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGBills, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 333)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 19)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGMembers)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGBills)
        Me.SplitContainer1.Size = New System.Drawing.Size(736, 342)
        Me.SplitContainer1.SplitterDistance = 217
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnDownload)
        Me.GroupBox2.Controls.Add(Me.BtnUpload)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.LblShowText)
        Me.GroupBox2.Controls.Add(Me.GrBoxMember)
        Me.GroupBox2.Controls.Add(Me.TxtComments)
        Me.GroupBox2.Controls.Add(Me.CmbDept)
        Me.GroupBox2.Controls.Add(Me.RadMember)
        Me.GroupBox2.Controls.Add(Me.RadDept)
        Me.GroupBox2.Controls.Add(Me.IssueDate)
        Me.GroupBox2.Controls.Add(Me.TxtBillinDari)
        Me.GroupBox2.Controls.Add(Me.TxtBilTextinPashto)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.LblDept)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtBillNumber)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtBillTitle)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtBillID)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(715, 215)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record(Edit/Entry)"
        '
        'BtnDownload
        '
        Me.BtnDownload.Location = New System.Drawing.Point(604, 165)
        Me.BtnDownload.Name = "BtnDownload"
        Me.BtnDownload.Size = New System.Drawing.Size(92, 23)
        Me.BtnDownload.TabIndex = 69
        Me.BtnDownload.Text = "Download File"
        Me.BtnDownload.UseVisualStyleBackColor = True
        '
        'BtnUpload
        '
        Me.BtnUpload.Location = New System.Drawing.Point(523, 165)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(76, 23)
        Me.BtnUpload.TabIndex = 68
        Me.BtnUpload.Text = "&Upload File"
        Me.BtnUpload.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(173, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 20)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "......"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(650, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 20)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "......"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblShowText
        '
        Me.LblShowText.AutoSize = True
        Me.LblShowText.BackColor = System.Drawing.Color.Transparent
        Me.LblShowText.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.LblShowText.Location = New System.Drawing.Point(483, 197)
        Me.LblShowText.Name = "LblShowText"
        Me.LblShowText.Size = New System.Drawing.Size(0, 16)
        Me.LblShowText.TabIndex = 67
        '
        'GrBoxMember
        '
        Me.GrBoxMember.Controls.Add(Me.DGMemb)
        Me.GrBoxMember.Controls.Add(Me.TxtMemberSrc)
        Me.GrBoxMember.Controls.Add(Me.BtnAdMembers)
        Me.GrBoxMember.Location = New System.Drawing.Point(17, 99)
        Me.GrBoxMember.Name = "GrBoxMember"
        Me.GrBoxMember.Size = New System.Drawing.Size(314, 111)
        Me.GrBoxMember.TabIndex = 8
        Me.GrBoxMember.TabStop = False
        Me.GrBoxMember.Text = "Members List"
        Me.GrBoxMember.Visible = False
        '
        'DGMemb
        '
        Me.DGMemb.AllowUserToDeleteRows = False
        Me.DGMemb.BackgroundColor = System.Drawing.Color.White
        Me.DGMemb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGMemb.ColumnHeadersHeight = 20
        Me.DGMemb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column13, Me.Column14})
        Me.DGMemb.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DGMemb.Location = New System.Drawing.Point(6, 37)
        Me.DGMemb.Name = "DGMemb"
        Me.DGMemb.ReadOnly = True
        Me.DGMemb.RowHeadersVisible = False
        Me.DGMemb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGMemb.Size = New System.Drawing.Size(208, 68)
        Me.DGMemb.TabIndex = 1
        '
        'Column13
        '
        Me.Column13.HeaderText = "MemberID"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        '
        'Column14
        '
        Me.Column14.HeaderText = "Member Name"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 204
        '
        'TxtMemberSrc
        '
        Me.TxtMemberSrc.Location = New System.Drawing.Point(6, 16)
        Me.TxtMemberSrc.Name = "TxtMemberSrc"
        Me.TxtMemberSrc.Size = New System.Drawing.Size(208, 20)
        Me.TxtMemberSrc.TabIndex = 0
        Me.TxtMemberSrc.Text = "Search Member(s)"
        '
        'BtnAdMembers
        '
        Me.BtnAdMembers.Location = New System.Drawing.Point(217, 77)
        Me.BtnAdMembers.Name = "BtnAdMembers"
        Me.BtnAdMembers.Size = New System.Drawing.Size(94, 23)
        Me.BtnAdMembers.TabIndex = 2
        Me.BtnAdMembers.Text = "&Add Members"
        Me.BtnAdMembers.UseVisualStyleBackColor = True
        Me.BtnAdMembers.Visible = False
        '
        'TxtComments
        '
        Me.TxtComments.Location = New System.Drawing.Point(554, 115)
        Me.TxtComments.Multiline = True
        Me.TxtComments.Name = "TxtComments"
        Me.TxtComments.Size = New System.Drawing.Size(150, 38)
        Me.TxtComments.TabIndex = 11
        '
        'CmbDept
        '
        Me.CmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDept.FormattingEnabled = True
        Me.CmbDept.Location = New System.Drawing.Point(554, 75)
        Me.CmbDept.Name = "CmbDept"
        Me.CmbDept.Size = New System.Drawing.Size(150, 21)
        Me.CmbDept.TabIndex = 10
        Me.CmbDept.Visible = False
        '
        'RadMember
        '
        Me.RadMember.AutoSize = True
        Me.RadMember.Location = New System.Drawing.Point(476, 76)
        Me.RadMember.Name = "RadMember"
        Me.RadMember.Size = New System.Drawing.Size(68, 17)
        Me.RadMember.TabIndex = 9
        Me.RadMember.TabStop = True
        Me.RadMember.Text = "Members"
        Me.RadMember.UseVisualStyleBackColor = True
        '
        'RadDept
        '
        Me.RadDept.AutoSize = True
        Me.RadDept.Location = New System.Drawing.Point(394, 76)
        Me.RadDept.Name = "RadDept"
        Me.RadDept.Size = New System.Drawing.Size(80, 17)
        Me.RadDept.TabIndex = 8
        Me.RadDept.TabStop = True
        Me.RadDept.Text = "Department"
        Me.RadDept.UseVisualStyleBackColor = True
        '
        'IssueDate
        '
        Me.IssueDate.CustomFormat = "dd/MM/yy"
        Me.IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.IssueDate.Location = New System.Drawing.Point(226, 74)
        Me.IssueDate.Name = "IssueDate"
        Me.IssueDate.Size = New System.Drawing.Size(150, 20)
        Me.IssueDate.TabIndex = 7
        '
        'TxtBillinDari
        '
        Me.TxtBillinDari.Location = New System.Drawing.Point(17, 72)
        Me.TxtBillinDari.MaxLength = 1000000
        Me.TxtBillinDari.Name = "TxtBillinDari"
        Me.TxtBillinDari.Size = New System.Drawing.Size(150, 20)
        Me.TxtBillinDari.TabIndex = 5
        '
        'TxtBilTextinPashto
        '
        Me.TxtBilTextinPashto.Location = New System.Drawing.Point(492, 34)
        Me.TxtBilTextinPashto.MaxLength = 1000000
        Me.TxtBilTextinPashto.Name = "TxtBilTextinPashto"
        Me.TxtBilTextinPashto.Size = New System.Drawing.Size(150, 20)
        Me.TxtBilTextinPashto.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(557, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Comments"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Bill Issue Date"
        '
        'LblDept
        '
        Me.LblDept.AutoSize = True
        Me.LblDept.Location = New System.Drawing.Point(557, 59)
        Me.LblDept.Name = "LblDept"
        Me.LblDept.Size = New System.Drawing.Size(137, 13)
        Me.LblDept.TabIndex = 9
        Me.LblDept.Text = "Select Department from List"
        Me.LblDept.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Bill Title"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bill Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Bill ID"
        '
        'TxtBillNumber
        '
        Me.TxtBillNumber.Location = New System.Drawing.Point(175, 34)
        Me.TxtBillNumber.Name = "TxtBillNumber"
        Me.TxtBillNumber.Size = New System.Drawing.Size(150, 20)
        Me.TxtBillNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Bill Text in Dari"
        '
        'TxtBillTitle
        '
        Me.TxtBillTitle.Location = New System.Drawing.Point(334, 34)
        Me.TxtBillTitle.Name = "TxtBillTitle"
        Me.TxtBillTitle.Size = New System.Drawing.Size(150, 20)
        Me.TxtBillTitle.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(495, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bill Text in Pashto"
        '
        'TxtBillID
        '
        Me.TxtBillID.Location = New System.Drawing.Point(17, 32)
        Me.TxtBillID.Name = "TxtBillID"
        Me.TxtBillID.Size = New System.Drawing.Size(150, 20)
        Me.TxtBillID.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(637, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "&Delete Member"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DGMembers
        '
        Me.DGMembers.AllowUserToDeleteRows = False
        Me.DGMembers.BackgroundColor = System.Drawing.Color.White
        Me.DGMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGMembers.ColumnHeadersHeight = 25
        Me.DGMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column15, Me.Column11})
        Me.DGMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGMembers.Location = New System.Drawing.Point(429, 4)
        Me.DGMembers.Name = "DGMembers"
        Me.DGMembers.ReadOnly = True
        Me.DGMembers.RowHeadersVisible = False
        Me.DGMembers.Size = New System.Drawing.Size(205, 90)
        Me.DGMembers.TabIndex = 1
        '
        'Column10
        '
        Me.Column10.HeaderText = "BillID"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column15
        '
        Me.Column15.HeaderText = "Member id"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Visible = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "Members"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 200
        '
        'DGBills
        '
        Me.DGBills.AllowUserToDeleteRows = False
        Me.DGBills.BackgroundColor = System.Drawing.Color.White
        Me.DGBills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGBills.ColumnHeadersHeight = 25
        Me.DGBills.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column12, Me.FileName1, Me.Data})
        Me.DGBills.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGBills.Location = New System.Drawing.Point(0, 4)
        Me.DGBills.Name = "DGBills"
        Me.DGBills.ReadOnly = True
        Me.DGBills.RowHeadersVisible = False
        Me.DGBills.Size = New System.Drawing.Size(420, 90)
        Me.DGBills.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(772, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(672, 470)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(76, 23)
        Me.BtnPrint.TabIndex = 5
        Me.BtnPrint.Text = "Pr&int"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(590, 470)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(76, 23)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'TxtSearchRecord
        '
        Me.TxtSearchRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchRecord.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtSearchRecord.Location = New System.Drawing.Point(342, 444)
        Me.TxtSearchRecord.Name = "TxtSearchRecord"
        Me.TxtSearchRecord.Size = New System.Drawing.Size(381, 20)
        Me.TxtSearchRecord.TabIndex = 6
        Me.TxtSearchRecord.Text = "Search Record(s)"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(729, 444)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox3.TabIndex = 67
        Me.PictureBox3.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(424, 470)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(76, 23)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(507, 470)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(76, 23)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(342, 470)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(76, 23)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add&New"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-2, 435)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(776, 62)
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Column1
        '
        Me.Column1.HeaderText = "BillID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Bill Number"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Bill Title"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Bill Text In Pashto"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Bill Text In Dari"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Bill Issue Date"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Dept ID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "Bill Members"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Comments"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Department"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'FileName1
        '
        Me.FileName1.HeaderText = "FileName"
        Me.FileName1.Name = "FileName1"
        Me.FileName1.ReadOnly = True
        Me.FileName1.Visible = False
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        Me.Data.Visible = False
        '
        'FrmBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(762, 499)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.TxtSearchRecord)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBills"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bills"
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GrBoxMember.ResumeLayout(False)
        Me.GrBoxMember.PerformLayout()
        CType(Me.DGMemb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGBills, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtBillNumber As System.Windows.Forms.TextBox
    Friend WithEvents TxtBillTitle As System.Windows.Forms.TextBox
    Friend WithEvents TxtBillID As System.Windows.Forms.TextBox
    Friend WithEvents DGBills As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents TxtSearchRecord As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblDept As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents IssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtBillinDari As System.Windows.Forms.TextBox
    Friend WithEvents TxtBilTextinPashto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RadMember As System.Windows.Forms.RadioButton
    Friend WithEvents RadDept As System.Windows.Forms.RadioButton
    Friend WithEvents TxtComments As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdMembers As System.Windows.Forms.Button
    Friend WithEvents DGMembers As System.Windows.Forms.DataGridView
    Friend WithEvents DGMemb As System.Windows.Forms.DataGridView
    Friend WithEvents TxtMemberSrc As System.Windows.Forms.TextBox
    Friend WithEvents GrBoxMember As System.Windows.Forms.GroupBox
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblShowText As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnDownload As System.Windows.Forms.Button
    Friend WithEvents BtnUpload As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
