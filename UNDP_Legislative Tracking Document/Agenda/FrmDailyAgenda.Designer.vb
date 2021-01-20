<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDailyAgenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDailyAgenda))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.LblMessage = New System.Windows.Forms.Label
        Me.DtpAgDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtAgendaId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtAgendatextPashto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtComments = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtAgendaTextDari = New System.Windows.Forms.TextBox
        Me.dgview = New System.Windows.Forms.DataGridView
        Me.AgendaTextPashto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AgendaTextDari = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AgendaDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AgendaID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.txtSearchRecord = New System.Windows.Forms.TextBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnPrint = New System.Windows.Forms.Button
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
        Me.GroupBox1.Location = New System.Drawing.Point(4, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(753, 323)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(747, 304)
        Me.SplitContainer1.SplitterDistance = 124
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.LblMessage)
        Me.GroupBox2.Controls.Add(Me.DtpAgDate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtAgendaId)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtAgendatextPashto)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtComments)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtAgendaTextDari)
        Me.GroupBox2.Location = New System.Drawing.Point(10, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 120)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Record (Entry / Edit)"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(659, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 20)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "......"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(389, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 20)
        Me.Button1.TabIndex = 2
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
        Me.LblMessage.Location = New System.Drawing.Point(560, 101)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(0, 14)
        Me.LblMessage.TabIndex = 63
        '
        'DtpAgDate
        '
        Me.DtpAgDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpAgDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpAgDate.Location = New System.Drawing.Point(15, 74)
        Me.DtpAgDate.Name = "DtpAgDate"
        Me.DtpAgDate.Size = New System.Drawing.Size(144, 20)
        Me.DtpAgDate.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(18, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Agenda ID"
        '
        'TxtAgendaId
        '
        Me.TxtAgendaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAgendaId.Location = New System.Drawing.Point(15, 35)
        Me.TxtAgendaId.Name = "TxtAgendaId"
        Me.TxtAgendaId.Size = New System.Drawing.Size(144, 20)
        Me.TxtAgendaId.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Date"
        '
        'TxtAgendatextPashto
        '
        Me.TxtAgendatextPashto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAgendatextPashto.Location = New System.Drawing.Point(173, 35)
        Me.TxtAgendatextPashto.MaxLength = 10000000
        Me.TxtAgendatextPashto.Name = "TxtAgendatextPashto"
        Me.TxtAgendatextPashto.Size = New System.Drawing.Size(209, 20)
        Me.TxtAgendatextPashto.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(447, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Agenda Text in Dari"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(174, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Comments"
        '
        'TxtComments
        '
        Me.TxtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComments.Location = New System.Drawing.Point(173, 74)
        Me.TxtComments.Name = "TxtComments"
        Me.TxtComments.Size = New System.Drawing.Size(539, 20)
        Me.TxtComments.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(174, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Agenda Text in Pashto"
        '
        'TxtAgendaTextDari
        '
        Me.TxtAgendaTextDari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAgendaTextDari.Location = New System.Drawing.Point(445, 35)
        Me.TxtAgendaTextDari.MaxLength = 10000000
        Me.TxtAgendaTextDari.Name = "TxtAgendaTextDari"
        Me.TxtAgendaTextDari.Size = New System.Drawing.Size(209, 20)
        Me.TxtAgendaTextDari.TabIndex = 3
        '
        'dgview
        '
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AgendaTextPashto, Me.AgendaTextDari, Me.AgendaDate, Me.Comments, Me.AgendaID})
        Me.dgview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgview.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgview.Location = New System.Drawing.Point(0, 0)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgview.Size = New System.Drawing.Size(747, 176)
        Me.dgview.TabIndex = 0
        '
        'AgendaTextPashto
        '
        Me.AgendaTextPashto.HeaderText = "Agenda Text in Pashto"
        Me.AgendaTextPashto.Name = "AgendaTextPashto"
        Me.AgendaTextPashto.ReadOnly = True
        Me.AgendaTextPashto.Width = 200
        '
        'AgendaTextDari
        '
        Me.AgendaTextDari.HeaderText = "Agenda Text in Dari"
        Me.AgendaTextDari.Name = "AgendaTextDari"
        Me.AgendaTextDari.ReadOnly = True
        Me.AgendaTextDari.Width = 200
        '
        'AgendaDate
        '
        Me.AgendaDate.HeaderText = "Date"
        Me.AgendaDate.Name = "AgendaDate"
        Me.AgendaDate.ReadOnly = True
        Me.AgendaDate.Width = 110
        '
        'Comments
        '
        Me.Comments.HeaderText = "Comments"
        Me.Comments.Name = "Comments"
        Me.Comments.ReadOnly = True
        Me.Comments.Width = 400
        '
        'AgendaID
        '
        Me.AgendaID.HeaderText = "Agenda ID"
        Me.AgendaID.Name = "AgendaID"
        Me.AgendaID.ReadOnly = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 434)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(771, 65)
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(771, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(734, 444)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox3.TabIndex = 61
        Me.PictureBox3.TabStop = False
        '
        'txtSearchRecord
        '
        Me.txtSearchRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchRecord.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSearchRecord.Location = New System.Drawing.Point(395, 445)
        Me.txtSearchRecord.Name = "txtSearchRecord"
        Me.txtSearchRecord.Size = New System.Drawing.Size(333, 20)
        Me.txtSearchRecord.TabIndex = 62
        Me.txtSearchRecord.Text = "Search Record(s) by Agenda ID"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(585, 470)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(76, 23)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(504, 470)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(76, 23)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(423, 470)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(76, 23)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(342, 470)
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
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(667, 470)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(76, 23)
        Me.BtnPrint.TabIndex = 5
        Me.BtnPrint.Text = "&Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'FrmDailyAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(762, 499)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtSearchRecord)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmDailyAgenda"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Agenda"
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
    Friend WithEvents TxtAgendaId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtAgendatextPashto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtComments As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtAgendaTextDari As System.Windows.Forms.TextBox
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DtpAgDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents AgendaTextPashto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgendaTextDari As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgendaDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgendaID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchRecord As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
