<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintBillAmmendments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrintBillAmmendments))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TxtSearchBill = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DgBill = New System.Windows.Forms.DataGridView
        Me.BillTitle1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dgview = New System.Windows.Forms.DataGridView
        Me.BillTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Textpashto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TextDari = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ammenby = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnPrint = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(766, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'TxtSearchBill
        '
        Me.TxtSearchBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchBill.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtSearchBill.Location = New System.Drawing.Point(211, 20)
        Me.TxtSearchBill.Name = "TxtSearchBill"
        Me.TxtSearchBill.Size = New System.Drawing.Size(314, 20)
        Me.TxtSearchBill.TabIndex = 55
        Me.TxtSearchBill.Text = "Search Record(s) by Bill Title"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgBill)
        Me.GroupBox2.Controls.Add(Me.TxtSearchBill)
        Me.GroupBox2.Location = New System.Drawing.Point(6, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(740, 162)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record (Entry / Edit)"
        '
        'DgBill
        '
        Me.DgBill.AllowUserToDeleteRows = False
        Me.DgBill.BackgroundColor = System.Drawing.Color.White
        Me.DgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillTitle1, Me.BillID})
        Me.DgBill.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DgBill.Location = New System.Drawing.Point(212, 41)
        Me.DgBill.Name = "DgBill"
        Me.DgBill.ReadOnly = True
        Me.DgBill.RowHeadersVisible = False
        Me.DgBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgBill.Size = New System.Drawing.Size(313, 115)
        Me.DgBill.TabIndex = 0
        '
        'BillTitle1
        '
        Me.BillTitle1.HeaderText = "Bill Title"
        Me.BillTitle1.Name = "BillTitle1"
        Me.BillTitle1.ReadOnly = True
        Me.BillTitle1.Width = 320
        '
        'BillID
        '
        Me.BillID.HeaderText = "BillID"
        Me.BillID.Name = "BillID"
        Me.BillID.ReadOnly = True
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
        Me.SplitContainer1.Size = New System.Drawing.Size(751, 295)
        Me.SplitContainer1.SplitterDistance = 167
        Me.SplitContainer1.TabIndex = 0
        '
        'dgview
        '
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillTitle, Me.Textpashto, Me.TextDari, Me.Comments, Me.Ammenby})
        Me.dgview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgview.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgview.Location = New System.Drawing.Point(0, 0)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.Size = New System.Drawing.Size(751, 124)
        Me.dgview.TabIndex = 0
        '
        'BillTitle
        '
        Me.BillTitle.HeaderText = "Bill Title"
        Me.BillTitle.Name = "BillTitle"
        Me.BillTitle.ReadOnly = True
        Me.BillTitle.Width = 150
        '
        'Textpashto
        '
        Me.Textpashto.HeaderText = "Text in Pashto"
        Me.Textpashto.Name = "Textpashto"
        Me.Textpashto.ReadOnly = True
        Me.Textpashto.Width = 190
        '
        'TextDari
        '
        Me.TextDari.HeaderText = "Text in Dari"
        Me.TextDari.Name = "TextDari"
        Me.TextDari.ReadOnly = True
        Me.TextDari.Width = 190
        '
        'Comments
        '
        Me.Comments.HeaderText = "Comments"
        Me.Comments.Name = "Comments"
        Me.Comments.ReadOnly = True
        Me.Comments.Width = 160
        '
        'Ammenby
        '
        Me.Ammenby.HeaderText = "Ammendment By"
        Me.Ammenby.Name = "Ammenby"
        Me.Ammenby.ReadOnly = True
        Me.Ammenby.Width = 120
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 433)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(766, 65)
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 314)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(648, 459)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(89, 27)
        Me.BtnPrint.TabIndex = 60
        Me.BtnPrint.Text = "&Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'FrmPrintBillAmmendments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(762, 499)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPrintBillAmmendments"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Bill Ammendments"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtSearchBill As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgBill As System.Windows.Forms.DataGridView
    Friend WithEvents BillTitle1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Textpashto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextDari As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ammenby As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
End Class
