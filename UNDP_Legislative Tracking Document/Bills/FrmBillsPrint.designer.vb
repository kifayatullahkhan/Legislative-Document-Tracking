<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBillsPrint
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
        Me.RadDept = New System.Windows.Forms.RadioButton
        Me.RadBillNo = New System.Windows.Forms.RadioButton
        Me.RadBillTitle = New System.Windows.Forms.RadioButton
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.TxtBillNumber = New System.Windows.Forms.TextBox
        Me.CmbDept = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'RadDept
        '
        Me.RadDept.AutoSize = True
        Me.RadDept.Location = New System.Drawing.Point(13, 42)
        Me.RadDept.Name = "RadDept"
        Me.RadDept.Size = New System.Drawing.Size(80, 17)
        Me.RadDept.TabIndex = 1
        Me.RadDept.TabStop = True
        Me.RadDept.Text = "Department"
        Me.RadDept.UseVisualStyleBackColor = True
        '
        'RadBillNo
        '
        Me.RadBillNo.AutoSize = True
        Me.RadBillNo.Location = New System.Drawing.Point(328, 42)
        Me.RadBillNo.Name = "RadBillNo"
        Me.RadBillNo.Size = New System.Drawing.Size(78, 17)
        Me.RadBillNo.TabIndex = 2
        Me.RadBillNo.TabStop = True
        Me.RadBillNo.Text = "Bill Number"
        Me.RadBillNo.UseVisualStyleBackColor = True
        '
        'RadBillTitle
        '
        Me.RadBillTitle.AutoSize = True
        Me.RadBillTitle.Location = New System.Drawing.Point(180, 42)
        Me.RadBillTitle.Name = "RadBillTitle"
        Me.RadBillTitle.Size = New System.Drawing.Size(61, 17)
        Me.RadBillTitle.TabIndex = 3
        Me.RadBillTitle.TabStop = True
        Me.RadBillTitle.Text = "Bill Title"
        Me.RadBillTitle.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(360, 66)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(76, 23)
        Me.BtnPrint.TabIndex = 65
        Me.BtnPrint.Text = "Pr&int"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'TxtBillNumber
        '
        Me.TxtBillNumber.Location = New System.Drawing.Point(141, 67)
        Me.TxtBillNumber.Name = "TxtBillNumber"
        Me.TxtBillNumber.Size = New System.Drawing.Size(131, 20)
        Me.TxtBillNumber.TabIndex = 67
        '
        'CmbDept
        '
        Me.CmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDept.FormattingEnabled = True
        Me.CmbDept.Location = New System.Drawing.Point(6, 66)
        Me.CmbDept.Name = "CmbDept"
        Me.CmbDept.Size = New System.Drawing.Size(118, 21)
        Me.CmbDept.TabIndex = 68
        Me.CmbDept.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Select Option For Print"
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(278, 67)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(76, 23)
        Me.BtnClose.TabIndex = 70
        Me.BtnClose.Text = "Cl&ose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmBillsPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 103)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbDept)
        Me.Controls.Add(Me.TxtBillNumber)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.RadBillTitle)
        Me.Controls.Add(Me.RadBillNo)
        Me.Controls.Add(Me.RadDept)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBillsPrint"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bills Print Option"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadDept As System.Windows.Forms.RadioButton
    Friend WithEvents RadBillNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadBillTitle As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents TxtBillNumber As System.Windows.Forms.TextBox
    Friend WithEvents CmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
