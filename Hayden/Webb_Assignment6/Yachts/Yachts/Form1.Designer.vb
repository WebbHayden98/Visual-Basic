<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearForNextCharterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCountOfYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.YachtTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.PrintSummaryDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintYachtTypeDocument = New System.Drawing.Printing.PrintDocument()
        Me.YachtSizeListBox = New System.Windows.Forms.ListBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResponsiblePartyTextBox = New System.Windows.Forms.TextBox()
        Me.HoursCharteredTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CharterPriceLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(525, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSummaryToolStripMenuItem, Me.PrintYachtTypesToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PrintSummaryToolStripMenuItem.Text = "Print &Summary"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print P&review"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintYachtTypesToolStripMenuItem
        '
        Me.PrintYachtTypesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPreviewToolStripMenuItem1, Me.PrintToolStripMenuItem1})
        Me.PrintYachtTypesToolStripMenuItem.Name = "PrintYachtTypesToolStripMenuItem"
        Me.PrintYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PrintYachtTypesToolStripMenuItem.Text = "Print &Yacht Types"
        '
        'PrintPreviewToolStripMenuItem1
        '
        Me.PrintPreviewToolStripMenuItem1.Name = "PrintPreviewToolStripMenuItem1"
        Me.PrintPreviewToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem1.Text = "Print P&review"
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItem1.Text = "&Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearForNextCharterToolStripMenuItem, Me.ToolStripSeparator2, Me.AddYachtTypeToolStripMenuItem, Me.RemoveYachtTypeToolStripMenuItem, Me.DisplayCountOfYachtTypesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearForNextCharterToolStripMenuItem
        '
        Me.ClearForNextCharterToolStripMenuItem.Name = "ClearForNextCharterToolStripMenuItem"
        Me.ClearForNextCharterToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ClearForNextCharterToolStripMenuItem.Text = "&Clear for Next Charter"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(226, 6)
        '
        'AddYachtTypeToolStripMenuItem
        '
        Me.AddYachtTypeToolStripMenuItem.Name = "AddYachtTypeToolStripMenuItem"
        Me.AddYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.AddYachtTypeToolStripMenuItem.Text = "&Add Yacht Type"
        '
        'RemoveYachtTypeToolStripMenuItem
        '
        Me.RemoveYachtTypeToolStripMenuItem.Name = "RemoveYachtTypeToolStripMenuItem"
        Me.RemoveYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.RemoveYachtTypeToolStripMenuItem.Text = "&Remove Yacht Type"
        '
        'DisplayCountOfYachtTypesToolStripMenuItem
        '
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Name = "DisplayCountOfYachtTypesToolStripMenuItem"
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.DisplayCountOfYachtTypesToolStripMenuItem.Text = "&Display Count of Yacht Types"
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
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(380, 392)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(62, 23)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(448, 392)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(62, 23)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'YachtTypeComboBox
        '
        Me.YachtTypeComboBox.FormattingEnabled = True
        Me.YachtTypeComboBox.Items.AddRange(New Object() {"Ranger", "Wavelength", "Catalina", "Coronado", "Hobie", "C & C", "Hans Christian", "Excalibur"})
        Me.YachtTypeComboBox.Location = New System.Drawing.Point(65, 249)
        Me.YachtTypeComboBox.Name = "YachtTypeComboBox"
        Me.YachtTypeComboBox.Size = New System.Drawing.Size(145, 21)
        Me.YachtTypeComboBox.TabIndex = 3
        '
        'PrintSummaryDocument
        '
        '
        'PrintYachtTypeDocument
        '
        '
        'YachtSizeListBox
        '
        Me.YachtSizeListBox.FormattingEnabled = True
        Me.YachtSizeListBox.Items.AddRange(New Object() {"22", "24", "30", "32", "36", "38", "45"})
        Me.YachtSizeListBox.Location = New System.Drawing.Point(65, 320)
        Me.YachtSizeListBox.Name = "YachtSizeListBox"
        Me.YachtSizeListBox.Size = New System.Drawing.Size(120, 95)
        Me.YachtSizeListBox.TabIndex = 4
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Yacht Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Yacht Size"
        '
        'ResponsiblePartyTextBox
        '
        Me.ResponsiblePartyTextBox.Location = New System.Drawing.Point(65, 127)
        Me.ResponsiblePartyTextBox.Name = "ResponsiblePartyTextBox"
        Me.ResponsiblePartyTextBox.Size = New System.Drawing.Size(127, 20)
        Me.ResponsiblePartyTextBox.TabIndex = 7
        '
        'HoursCharteredTextBox
        '
        Me.HoursCharteredTextBox.Location = New System.Drawing.Point(316, 127)
        Me.HoursCharteredTextBox.Name = "HoursCharteredTextBox"
        Me.HoursCharteredTextBox.Size = New System.Drawing.Size(126, 20)
        Me.HoursCharteredTextBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Responsible Party"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Hours Chartered"
        '
        'CharterPriceLabel
        '
        Me.CharterPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CharterPriceLabel.Location = New System.Drawing.Point(316, 249)
        Me.CharterPriceLabel.Name = "CharterPriceLabel"
        Me.CharterPriceLabel.Size = New System.Drawing.Size(112, 19)
        Me.CharterPriceLabel.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Calculated Charter Price"
        '
        'Form1
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(525, 427)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CharterPriceLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HoursCharteredTextBox)
        Me.Controls.Add(Me.ResponsiblePartyTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.YachtSizeListBox)
        Me.Controls.Add(Me.YachtTypeComboBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintYachtTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearForNextCharterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveYachtTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayCountOfYachtTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents YachtTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PrintSummaryDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintYachtTypeDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents YachtSizeListBox As System.Windows.Forms.ListBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ResponsiblePartyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursCharteredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CharterPriceLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
