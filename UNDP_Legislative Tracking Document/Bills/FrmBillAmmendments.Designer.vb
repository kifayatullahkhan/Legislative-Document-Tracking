<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBillAmmendments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBillAmmendments))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dgview = New System.Windows.Forms.DataGridView
        Me.BillTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TextinPashto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TextinDari = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AmmBy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BlAmmID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.LblMessage = New System.Windows.Forms.Label
        Me.TxtSearchBill = New System.Windows.Forms.TextBox
        Me.DgBill = New System.Windows.Forms.DataGridView
        Me.BillTitle1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtComments = New System.Windows.Forms.TextBox
        Me.TxtDari = New System.Windows.Forms.TextBox
        Me.TxtPashto = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.txtSearchRecord = New System.Windows.Forms.TextBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(771, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'dgview
        '
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillTitle, Me.TextinPashto, Me.TextinDari, Me.Comments, Me.AmmBy, Me.BlAmmID})
        Me.dgview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgview.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgview.Location = New System.Drawing.Point(0, 0)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgview.Size = New System.Drawing.Size(751, 168)
        Me.dgview.TabIndex = 0
        '
        'BillTitle
        '
        Me.BillTitle.HeaderText = "Bill Title"
        Me.BillTitle.Name = "BillTitle"
        Me.BillTitle.ReadOnly = True
        Me.BillTitle.Width = 150
        '
        'TextinPashto
        '
        Me.TextinPashto.HeaderText = "Text in Pashto"
        Me.TextinPashto.Name = "TextinPashto"
        Me.TextinPashto.ReadOnly = True
        Me.TextinPashto.Width = 150
        '
        'TextinDari
        '
        Me.TextinDari.HeaderText = "Text in Dari"
        Me.TextinDari.Name = "TextinDari"
        Me.TextinDari.ReadOnly = True
        Me.TextinDari.Width = 150
        '
        'Comments
        '
        Me.Comments.HeaderText = "Comments"
        Me.Comments.Name = "Comments"
        Me.Comments.ReadOnly = True
        Me.Comments.Width = 200
        '
        'AmmBy
        '
        Me.AmmBy.HeaderText = "Ammendment By"
        Me.AmmBy.Name = "AmmBy"
        Me.AmmBy.ReadOnly = True
        Me.AmmBy.Width = 120
        '
        'BlAmmID
        '
        Me.BlAmmID.HeaderText = "Bill Ammendment ID"
        Me.BlAmmID.Name = "BlAmmID"
        Me.BlAmmID.ReadOnly = True
        Me.BlAmmID.Width = 140
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
        Me.SplitContainer1.Size = New System.Drawing.Size(751, 306)
        Me.SplitContainer1.SplitterDistance = 134
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.LblMessage)
        Me.GroupBox2.Controls.Add(Me.TxtSearchBill)
        Me.GroupBox2.Controls.Add(Me.DgBill)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtComments)
        Me.GroupBox2.Controls.Add(Me.TxtDari)
        Me.GroupBox2.Controls.Add(Me.TxtPashto)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(740, 131)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record (Entry / Edit)"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(684, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 20)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "......"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(424, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "......"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.BackColor = System.Drawing.Color.Transparent
        Me.LblMessage.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.LblMessage.Location = New System.Drawing.Point(589, 113)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(0, 14)
        Me.LblMessage.TabIndex = 64
        '
        'TxtSearchBill
        '
        Me.TxtSearchBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchBill.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtSearchBill.Location = New System.Drawing.Point(21, 17)
        Me.TxtSearchBill.Name = "TxtSearchBill"
        Me.TxtSearchBill.Size = New System.Drawing.Size(158, 20)
        Me.TxtSearchBill.TabIndex = 0
        Me.TxtSearchBill.Text = "Search Record(s) by Bill Title"
        '
        'DgBill
        '
        Me.DgBill.BackgroundColor = System.Drawing.Color.White
        Me.DgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillTitle1, Me.BillID})
        Me.DgBill.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DgBill.Location = New System.Drawing.Point(21, 38)
        Me.DgBill.Name = "DgBill"
        Me.DgBill.RowHeadersVisible = False
        Me.DgBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgBill.Size = New System.Drawing.Size(158, 87)
        Me.DgBill.TabIndex = 1
        '
        'BillTitle1
        '
        Me.BillTitle1.HeaderText = "Bill Title"
        Me.BillTitle1.Name = "BillTitle1"
        Me.BillTitle1.Width = 155
        '
        'BillID
        '
        Me.BillID.HeaderText = "BillID"
        Me.BillID.Name = "BillID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(216, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Comments"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(485, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Text in Dari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(216, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Text in Pashto"
        '
        'TxtComments
        '
        Me.TxtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComments.Location = New System.Drawing.Point(216, 85)
        Me.TxtComments.Name = "TxtComments"
        Me.TxtComments.Size = New System.Drawing.Size(512, 20)
        Me.TxtComments.TabIndex = 6
        '
        'TxtDari
        '
        Me.TxtDari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDari.Location = New System.Drawing.Point(485, 42)
        Me.TxtDari.MaxLength = 1000000
        Me.TxtDari.Name = "TxtDari"
        Me.TxtDari.Size = New System.Drawing.Size(193, 20)
        Me.TxtDari.TabIndex = 4
        '
        'TxtPashto
        '
        Me.TxtPashto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPashto.Location = New System.Drawing.Point(216, 42)
        Me.TxtPashto.MaxLength = 1000000
        Me.TxtPashto.Name = "TxtPashto"
        Me.TxtPashto.Size = New System.Drawing.Size(202, 20)
        Me.TxtPashto.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 325)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 434)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(771, 65)
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(739, 442)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox3.TabIndex = 61
        Me.PictureBox3.TabStop = False
        '
        'txtSearchRecord
        '
        Me.txtSearchRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchRecord.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSearchRecord.Location = New System.Drawing.Point(420, 443)
        Me.txtSearchRecord.Name = "txtSearchRecord"
        Me.txtSearchRecord.Size = New System.Drawing.Size(315, 20)
        Me.txtSearchRecord.TabIndex = 5
        Me.txtSearchRecord.Text = "Search Record(s) by Bill Title"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(663, 468)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(76, 23)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(582, 468)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(76, 23)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(501, 468)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(76, 23)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(420, 468)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(76, 23)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "&New Entry"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'FrmBillAmmendments
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "FrmBillAmmendments"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill Ammendments"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtComments As System.Windows.Forms.TextBox
    Friend WithEvents TxtDari As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchRecord As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BillTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextinPashto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextinDari As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmmBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BlAmmID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgBill As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSearchBill As System.Windows.Forms.TextBox
    Friend WithEvents BillTitle1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents TxtPashto As System.Windows.Forms.TextBox
End Class
