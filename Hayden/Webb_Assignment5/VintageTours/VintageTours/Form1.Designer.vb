<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payrollForm
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
        Me.components = New System.ComponentModel.Container()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.temporaryRadioButton = New System.Windows.Forms.RadioButton()
        Me.permanentEmployeeRadioButton = New System.Windows.Forms.RadioButton()
        Me.payRateTextBox = New System.Windows.Forms.TextBox()
        Me.hoursWorkedTextBox = New System.Windows.Forms.TextBox()
        Me.salesTextBox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.payChkGroupBox = New System.Windows.Forms.GroupBox()
        Me.employeePayLabel = New System.Windows.Forms.Label()
        Me.commissionLabel = New System.Windows.Forms.Label()
        Me.basePayLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearPayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CalcPayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.payChkGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Image = Global.VintageTours.My.Resources.Resources.Train
        Me.logoPictureBox.Location = New System.Drawing.Point(190, 34)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(307, 74)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPictureBox.TabIndex = 0
        Me.logoPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vintage Tours, Inc."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.temporaryRadioButton)
        Me.GroupBox1.Controls.Add(Me.permanentEmployeeRadioButton)
        Me.GroupBox1.Controls.Add(Me.payRateTextBox)
        Me.GroupBox1.Controls.Add(Me.hoursWorkedTextBox)
        Me.GroupBox1.Controls.Add(Me.salesTextBox)
        Me.GroupBox1.Controls.Add(Me.nameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Data"
        '
        'temporaryRadioButton
        '
        Me.temporaryRadioButton.AutoSize = True
        Me.temporaryRadioButton.Location = New System.Drawing.Point(39, 114)
        Me.temporaryRadioButton.Name = "temporaryRadioButton"
        Me.temporaryRadioButton.Size = New System.Drawing.Size(124, 17)
        Me.temporaryRadioButton.TabIndex = 9
        Me.temporaryRadioButton.TabStop = True
        Me.temporaryRadioButton.Text = "&Temporary Employee"
        Me.temporaryRadioButton.UseVisualStyleBackColor = True
        '
        'permanentEmployeeRadioButton
        '
        Me.permanentEmployeeRadioButton.AutoSize = True
        Me.permanentEmployeeRadioButton.Location = New System.Drawing.Point(39, 81)
        Me.permanentEmployeeRadioButton.Name = "permanentEmployeeRadioButton"
        Me.permanentEmployeeRadioButton.Size = New System.Drawing.Size(125, 17)
        Me.permanentEmployeeRadioButton.TabIndex = 8
        Me.permanentEmployeeRadioButton.TabStop = True
        Me.permanentEmployeeRadioButton.Text = "&Permanent Employee"
        Me.permanentEmployeeRadioButton.UseVisualStyleBackColor = True
        '
        'payRateTextBox
        '
        Me.payRateTextBox.Location = New System.Drawing.Point(367, 106)
        Me.payRateTextBox.Name = "payRateTextBox"
        Me.payRateTextBox.Size = New System.Drawing.Size(85, 20)
        Me.payRateTextBox.TabIndex = 3
        '
        'hoursWorkedTextBox
        '
        Me.hoursWorkedTextBox.Location = New System.Drawing.Point(366, 75)
        Me.hoursWorkedTextBox.Name = "hoursWorkedTextBox"
        Me.hoursWorkedTextBox.Size = New System.Drawing.Size(87, 20)
        Me.hoursWorkedTextBox.TabIndex = 2
        '
        'salesTextBox
        '
        Me.salesTextBox.Location = New System.Drawing.Point(365, 44)
        Me.salesTextBox.Name = "salesTextBox"
        Me.salesTextBox.Size = New System.Drawing.Size(89, 20)
        Me.salesTextBox.TabIndex = 1
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(61, 37)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(183, 20)
        Me.nameTextBox.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(249, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Pay Rate"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(249, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Hours Worked"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(250, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Dollar Value of Sales"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'payChkGroupBox
        '
        Me.payChkGroupBox.Controls.Add(Me.employeePayLabel)
        Me.payChkGroupBox.Controls.Add(Me.commissionLabel)
        Me.payChkGroupBox.Controls.Add(Me.basePayLabel)
        Me.payChkGroupBox.Controls.Add(Me.Label8)
        Me.payChkGroupBox.Controls.Add(Me.Label7)
        Me.payChkGroupBox.Controls.Add(Me.Label6)
        Me.payChkGroupBox.Location = New System.Drawing.Point(87, 366)
        Me.payChkGroupBox.Name = "payChkGroupBox"
        Me.payChkGroupBox.Size = New System.Drawing.Size(498, 118)
        Me.payChkGroupBox.TabIndex = 3
        Me.payChkGroupBox.TabStop = False
        Me.payChkGroupBox.Text = "Pay Check"
        '
        'employeePayLabel
        '
        Me.employeePayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.employeePayLabel.Location = New System.Drawing.Point(403, 69)
        Me.employeePayLabel.Name = "employeePayLabel"
        Me.employeePayLabel.Size = New System.Drawing.Size(82, 31)
        Me.employeePayLabel.TabIndex = 5
        '
        'commissionLabel
        '
        Me.commissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.commissionLabel.Location = New System.Drawing.Point(187, 66)
        Me.commissionLabel.Name = "commissionLabel"
        Me.commissionLabel.Size = New System.Drawing.Size(82, 31)
        Me.commissionLabel.TabIndex = 4
        '
        'basePayLabel
        '
        Me.basePayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.basePayLabel.Location = New System.Drawing.Point(31, 66)
        Me.basePayLabel.Name = "basePayLabel"
        Me.basePayLabel.Size = New System.Drawing.Size(82, 31)
        Me.basePayLabel.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(400, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Employee Pay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Commission"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Base Pay"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(14, 494)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Spr18"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(633, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcToolStripMenuItem, Me.ClearPayToolStripMenuItem})
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.PayrollToolStripMenuItem.Text = "&Payroll"
        '
        'CalcToolStripMenuItem
        '
        Me.CalcToolStripMenuItem.Name = "CalcToolStripMenuItem"
        Me.CalcToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CalcToolStripMenuItem.Text = "&Calc Pay"
        '
        'ClearPayToolStripMenuItem
        '
        Me.ClearPayToolStripMenuItem.Name = "ClearPayToolStripMenuItem"
        Me.ClearPayToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ClearPayToolStripMenuItem.Text = "C&lear Form"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem, Me.ToolStripSeparator1, Me.LogoToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'LogoToolStripMenuItem
        '
        Me.LogoToolStripMenuItem.Checked = True
        Me.LogoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LogoToolStripMenuItem.Name = "LogoToolStripMenuItem"
        Me.LogoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoToolStripMenuItem.Text = "&Logo"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcPayToolStripMenuItem, Me.ClearFormToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(133, 48)
        '
        'CalcPayToolStripMenuItem
        '
        Me.CalcPayToolStripMenuItem.Name = "CalcPayToolStripMenuItem"
        Me.CalcPayToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CalcPayToolStripMenuItem.Text = "&Calc Pay"
        '
        'ClearFormToolStripMenuItem
        '
        Me.ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem"
        Me.ClearFormToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ClearFormToolStripMenuItem.Text = "C&lear Form"
        '
        'payrollForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 510)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.payChkGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logoPictureBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "payrollForm"
        Me.Text = "Vintage Tours Employee Payroll"
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.payChkGroupBox.ResumeLayout(False)
        Me.payChkGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents temporaryRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents permanentEmployeeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents payRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents hoursWorkedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents salesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents payChkGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents employeePayLabel As System.Windows.Forms.Label
    Friend WithEvents commissionLabel As System.Windows.Forms.Label
    Friend WithEvents basePayLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearPayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CalcPayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
