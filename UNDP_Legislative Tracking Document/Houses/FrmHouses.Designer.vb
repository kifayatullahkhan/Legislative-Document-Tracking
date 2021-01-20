<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHouses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHouses))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblMessage = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtHouseName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtHouseID = New System.Windows.Forms.TextBox
        Me.dgview = New System.Windows.Forms.DataGridView
        Me.HouseID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HouseName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.txtSearchRecord = New System.Windows.Forms.TextBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(486, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 373)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(488, 63)
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 84)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgview)
        Me.SplitContainer1.Size = New System.Drawing.Size(486, 286)
        Me.SplitContainer1.SplitterDistance = 96
        Me.SplitContainer1.TabIndex = 55
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblMessage)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtHouseName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtHouseID)
        Me.GroupBox1.Location = New System.Drawing.Point(13, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Record (Entry / Edit)"
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.BackColor = System.Drawing.Color.Transparent
        Me.LblMessage.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.LblMessage.Location = New System.Drawing.Point(261, 58)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(0, 14)
        Me.LblMessage.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(247, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "House Name"
        '
        'TxtHouseName
        '
        Me.TxtHouseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHouseName.Location = New System.Drawing.Point(246, 33)
        Me.TxtHouseName.Name = "TxtHouseName"
        Me.TxtHouseName.Size = New System.Drawing.Size(166, 20)
        Me.TxtHouseName.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "HouseID"
        '
        'TxtHouseID
        '
        Me.TxtHouseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHouseID.Location = New System.Drawing.Point(39, 33)
        Me.TxtHouseID.Name = "TxtHouseID"
        Me.TxtHouseID.Size = New System.Drawing.Size(166, 20)
        Me.TxtHouseID.TabIndex = 29
        '
        'dgview
        '
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.BackgroundColor = System.Drawing.Color.White
        Me.dgview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HouseID, Me.HouseName})
        Me.dgview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgview.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgview.Location = New System.Drawing.Point(0, 0)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowHeadersVisible = False
        Me.dgview.Size = New System.Drawing.Size(486, 186)
        Me.dgview.TabIndex = 11
        '
        'HouseID
        '
        Me.HouseID.Frozen = True
        Me.HouseID.HeaderText = "House ID"
        Me.HouseID.Name = "HouseID"
        Me.HouseID.ReadOnly = True
        Me.HouseID.Width = 160
        '
        'HouseName
        '
        Me.HouseName.Frozen = True
        Me.HouseName.HeaderText = "House Name"
        Me.HouseName.Name = "HouseName"
        Me.HouseName.ReadOnly = True
        Me.HouseName.Width = 330
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(454, 381)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox3.TabIndex = 60
        Me.PictureBox3.TabStop = False
        '
        'txtSearchRecord
        '
        Me.txtSearchRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchRecord.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSearchRecord.Location = New System.Drawing.Point(184, 382)
        Me.txtSearchRecord.Name = "txtSearchRecord"
        Me.txtSearchRecord.Size = New System.Drawing.Size(264, 20)
        Me.txtSearchRecord.TabIndex = 61
        Me.txtSearchRecord.Text = "Search Record(s) by House Name"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(397, 406)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(70, 23)
        Me.BtnDelete.TabIndex = 59
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(326, 406)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(70, 23)
        Me.BtnSave.TabIndex = 58
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(256, 406)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(70, 23)
        Me.BtnUpdate.TabIndex = 57
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(184, 406)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(70, 23)
        Me.BtnAdd.TabIndex = 56
        Me.BtnAdd.Text = "&New Entry"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'FrmHouses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(486, 436)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtSearchRecord)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "FrmHouses"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Houses"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchRecord As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtHouseName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtHouseID As System.Windows.Forms.TextBox
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents HouseID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HouseName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblMessage As System.Windows.Forms.Label
End Class
