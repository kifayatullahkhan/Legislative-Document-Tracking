<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogSheet))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblEnd = New System.Windows.Forms.Label
        Me.LblStart = New System.Windows.Forms.Label
        Me.DateTime2 = New System.Windows.Forms.DateTimePicker
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker
        Me.RadRangeDate = New System.Windows.Forms.RadioButton
        Me.RadSpecificDate = New System.Windows.Forms.RadioButton
        Me.dgview = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(715, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-7, 429)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(721, 65)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(618, 455)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(76, 23)
        Me.BtnPrint.TabIndex = 53
        Me.BtnPrint.Text = "&Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 323)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'SplitContainer1
        '
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
        Me.SplitContainer1.Panel2MinSize = 10
        Me.SplitContainer1.Size = New System.Drawing.Size(685, 304)
        Me.SplitContainer1.SplitterDistance = 160
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblEnd)
        Me.GroupBox2.Controls.Add(Me.LblStart)
        Me.GroupBox2.Controls.Add(Me.DateTime2)
        Me.GroupBox2.Controls.Add(Me.DateTime1)
        Me.GroupBox2.Controls.Add(Me.RadRangeDate)
        Me.GroupBox2.Controls.Add(Me.RadSpecificDate)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(651, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Log"
        '
        'LblEnd
        '
        Me.LblEnd.AutoSize = True
        Me.LblEnd.Location = New System.Drawing.Point(243, 60)
        Me.LblEnd.Name = "LblEnd"
        Me.LblEnd.Size = New System.Drawing.Size(52, 13)
        Me.LblEnd.TabIndex = 6
        Me.LblEnd.Text = "End Date"
        Me.LblEnd.Visible = False
        '
        'LblStart
        '
        Me.LblStart.AutoSize = True
        Me.LblStart.Location = New System.Drawing.Point(243, 31)
        Me.LblStart.Name = "LblStart"
        Me.LblStart.Size = New System.Drawing.Size(55, 13)
        Me.LblStart.TabIndex = 5
        Me.LblStart.Text = "Start Date"
        Me.LblStart.Visible = False
        '
        'DateTime2
        '
        Me.DateTime2.CustomFormat = "dd/MM/yy"
        Me.DateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTime2.Location = New System.Drawing.Point(309, 57)
        Me.DateTime2.Name = "DateTime2"
        Me.DateTime2.Size = New System.Drawing.Size(96, 20)
        Me.DateTime2.TabIndex = 3
        Me.DateTime2.Visible = False
        '
        'DateTime1
        '
        Me.DateTime1.CustomFormat = "dd/MM/yy"
        Me.DateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTime1.Location = New System.Drawing.Point(309, 27)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(96, 20)
        Me.DateTime1.TabIndex = 2
        Me.DateTime1.Visible = False
        '
        'RadRangeDate
        '
        Me.RadRangeDate.AutoSize = True
        Me.RadRangeDate.Location = New System.Drawing.Point(18, 57)
        Me.RadRangeDate.Name = "RadRangeDate"
        Me.RadRangeDate.Size = New System.Drawing.Size(94, 17)
        Me.RadRangeDate.TabIndex = 1
        Me.RadRangeDate.TabStop = True
        Me.RadRangeDate.Text = "Date in Range"
        Me.RadRangeDate.UseVisualStyleBackColor = True
        '
        'RadSpecificDate
        '
        Me.RadSpecificDate.AutoSize = True
        Me.RadSpecificDate.Location = New System.Drawing.Point(18, 31)
        Me.RadSpecificDate.Name = "RadSpecificDate"
        Me.RadSpecificDate.Size = New System.Drawing.Size(89, 17)
        Me.RadSpecificDate.TabIndex = 0
        Me.RadSpecificDate.TabStop = True
        Me.RadSpecificDate.Text = "Specific Date"
        Me.RadSpecificDate.UseVisualStyleBackColor = True
        '
        'dgview
        '
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgview.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgview.Location = New System.Drawing.Point(0, 0)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.Size = New System.Drawing.Size(685, 140)
        Me.dgview.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "LogID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 77
        '
        'Column3
        '
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Type"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "User Name"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 140
        '
        'Column6
        '
        Me.Column6.HeaderText = "Category"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 180
        '
        'FrmLogSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(711, 490)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogSheet"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log Sheet"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadRangeDate As System.Windows.Forms.RadioButton
    Friend WithEvents RadSpecificDate As System.Windows.Forms.RadioButton
    Friend WithEvents DateTime2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTime1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblEnd As System.Windows.Forms.Label
    Friend WithEvents LblStart As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
