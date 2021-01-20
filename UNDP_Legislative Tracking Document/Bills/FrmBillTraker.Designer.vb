<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBillTraker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBillTraker))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dgview = New System.Windows.Forms.DataGridView
        Me.BillTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillTrakerDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HouseName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadOverall = New System.Windows.Forms.RadioButton
        Me.RadCurrent = New System.Windows.Forms.RadioButton
        Me.TxtSearchBill = New System.Windows.Forms.TextBox
        Me.DgBill = New System.Windows.Forms.DataGridView
        Me.BillTitle1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnPrint = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(770, 102)
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
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillTitle, Me.BillTrakerDate, Me.CommName, Me.HouseName, Me.StatusTitle, Me.Comments})
        Me.dgview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgview.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgview.Location = New System.Drawing.Point(0, 0)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgview.Size = New System.Drawing.Size(749, 150)
        Me.dgview.TabIndex = 0
        '
        'BillTitle
        '
        Me.BillTitle.HeaderText = "Bill Title"
        Me.BillTitle.Name = "BillTitle"
        Me.BillTitle.ReadOnly = True
        Me.BillTitle.Width = 150
        '
        'BillTrakerDate
        '
        Me.BillTrakerDate.HeaderText = "Bill Traker Date"
        Me.BillTrakerDate.Name = "BillTrakerDate"
        Me.BillTrakerDate.ReadOnly = True
        Me.BillTrakerDate.Width = 105
        '
        'CommName
        '
        Me.CommName.HeaderText = "Commission Name"
        Me.CommName.Name = "CommName"
        Me.CommName.ReadOnly = True
        Me.CommName.Width = 140
        '
        'HouseName
        '
        Me.HouseName.HeaderText = "House Name"
        Me.HouseName.Name = "HouseName"
        Me.HouseName.ReadOnly = True
        '
        'StatusTitle
        '
        Me.StatusTitle.HeaderText = "Status Title"
        Me.StatusTitle.Name = "StatusTitle"
        Me.StatusTitle.ReadOnly = True
        Me.StatusTitle.Width = 95
        '
        'Comments
        '
        Me.Comments.HeaderText = "Comments"
        Me.Comments.Name = "Comments"
        Me.Comments.ReadOnly = True
        Me.Comments.Width = 160
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
        Me.SplitContainer1.Size = New System.Drawing.Size(749, 308)
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.TxtSearchBill)
        Me.GroupBox2.Controls.Add(Me.DgBill)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(723, 148)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record (Entry / Edit)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadOverall)
        Me.GroupBox3.Controls.Add(Me.RadCurrent)
        Me.GroupBox3.Location = New System.Drawing.Point(373, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(219, 116)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Option"
        '
        'RadOverall
        '
        Me.RadOverall.AutoSize = True
        Me.RadOverall.Location = New System.Drawing.Point(27, 72)
        Me.RadOverall.Name = "RadOverall"
        Me.RadOverall.Size = New System.Drawing.Size(83, 17)
        Me.RadOverall.TabIndex = 1
        Me.RadOverall.TabStop = True
        Me.RadOverall.Text = "Overall Flow"
        Me.RadOverall.UseVisualStyleBackColor = True
        '
        'RadCurrent
        '
        Me.RadCurrent.AutoSize = True
        Me.RadCurrent.Location = New System.Drawing.Point(27, 37)
        Me.RadCurrent.Name = "RadCurrent"
        Me.RadCurrent.Size = New System.Drawing.Size(99, 17)
        Me.RadCurrent.TabIndex = 0
        Me.RadCurrent.TabStop = True
        Me.RadCurrent.Text = "Current Position"
        Me.RadCurrent.UseVisualStyleBackColor = True
        '
        'TxtSearchBill
        '
        Me.TxtSearchBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchBill.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtSearchBill.Location = New System.Drawing.Point(141, 25)
        Me.TxtSearchBill.Name = "TxtSearchBill"
        Me.TxtSearchBill.Size = New System.Drawing.Size(193, 20)
        Me.TxtSearchBill.TabIndex = 55
        Me.TxtSearchBill.Text = "Search Record(s) by Bill Title"
        '
        'DgBill
        '
        Me.DgBill.AllowUserToDeleteRows = False
        Me.DgBill.BackgroundColor = System.Drawing.Color.White
        Me.DgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillTitle1, Me.BillID})
        Me.DgBill.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DgBill.Location = New System.Drawing.Point(141, 46)
        Me.DgBill.Name = "DgBill"
        Me.DgBill.ReadOnly = True
        Me.DgBill.RowHeadersVisible = False
        Me.DgBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgBill.Size = New System.Drawing.Size(193, 90)
        Me.DgBill.TabIndex = 54
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 327)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 438)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(770, 65)
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(634, 460)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(89, 27)
        Me.BtnPrint.TabIndex = 57
        Me.BtnPrint.Text = "&Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'FrmBillTraker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(762, 499)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "FrmBillTraker"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill Traker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtSearchBill As System.Windows.Forms.TextBox
    Friend WithEvents DgBill As System.Windows.Forms.DataGridView
    Friend WithEvents BillTitle1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadOverall As System.Windows.Forms.RadioButton
    Friend WithEvents RadCurrent As System.Windows.Forms.RadioButton
    Friend WithEvents BillTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillTrakerDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HouseName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
End Class
