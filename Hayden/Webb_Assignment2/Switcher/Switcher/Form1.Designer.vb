<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SwitcherForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SwitcherForm))
        Me.ColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.GreenRadioButton = New System.Windows.Forms.RadioButton()
        Me.RedRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlackRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LightOnPictureBox = New System.Windows.Forms.PictureBox()
        Me.LightOffPictureBox = New System.Windows.Forms.PictureBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorGroupBox.SuspendLayout()
        CType(Me.LightOnPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LightOffPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorGroupBox
        '
        Me.ColorGroupBox.Controls.Add(Me.GreenRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.RedRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.BlueRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.BlackRadioButton)
        Me.ColorGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.ColorGroupBox.Name = "ColorGroupBox"
        Me.ColorGroupBox.Size = New System.Drawing.Size(93, 109)
        Me.ColorGroupBox.TabIndex = 0
        Me.ColorGroupBox.TabStop = False
        Me.ColorGroupBox.Text = "Choose a color"
        '
        'GreenRadioButton
        '
        Me.GreenRadioButton.AutoSize = True
        Me.GreenRadioButton.Location = New System.Drawing.Point(6, 88)
        Me.GreenRadioButton.Name = "GreenRadioButton"
        Me.GreenRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.GreenRadioButton.TabIndex = 4
        Me.GreenRadioButton.TabStop = True
        Me.GreenRadioButton.Text = "&Green"
        Me.GreenRadioButton.UseVisualStyleBackColor = True
        '
        'RedRadioButton
        '
        Me.RedRadioButton.AutoSize = True
        Me.RedRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.RedRadioButton.Name = "RedRadioButton"
        Me.RedRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.RedRadioButton.TabIndex = 3
        Me.RedRadioButton.TabStop = True
        Me.RedRadioButton.Text = "&Red"
        Me.RedRadioButton.UseVisualStyleBackColor = True
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.AutoSize = True
        Me.BlueRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.BlueRadioButton.TabIndex = 2
        Me.BlueRadioButton.TabStop = True
        Me.BlueRadioButton.Text = "B&lue"
        Me.BlueRadioButton.UseVisualStyleBackColor = True
        '
        'BlackRadioButton
        '
        Me.BlackRadioButton.AutoSize = True
        Me.BlackRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.BlackRadioButton.Name = "BlackRadioButton"
        Me.BlackRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.BlackRadioButton.TabIndex = 1
        Me.BlackRadioButton.TabStop = True
        Me.BlackRadioButton.Text = "&Black"
        Me.BlackRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(188, 23)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(160, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'MessageLabel
        '
        Me.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MessageLabel.Location = New System.Drawing.Point(192, 184)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(160, 17)
        Me.MessageLabel.TabIndex = 3
        Me.MessageLabel.Text = "Click the Light Bulb"
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(192, 227)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 5
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(273, 227)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Programmed by Hayden Webb"
        '
        'LightOnPictureBox
        '
        Me.LightOnPictureBox.Image = Global.Switcher.My.Resources.Resources.LIGHTON
        Me.LightOnPictureBox.Location = New System.Drawing.Point(192, 54)
        Me.LightOnPictureBox.Name = "LightOnPictureBox"
        Me.LightOnPictureBox.Size = New System.Drawing.Size(160, 118)
        Me.LightOnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LightOnPictureBox.TabIndex = 7
        Me.LightOnPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LightOnPictureBox, "Click me")
        Me.LightOnPictureBox.Visible = False
        '
        'LightOffPictureBox
        '
        Me.LightOffPictureBox.Image = Global.Switcher.My.Resources.Resources.LIGHTOFF
        Me.LightOffPictureBox.Location = New System.Drawing.Point(192, 55)
        Me.LightOffPictureBox.Name = "LightOffPictureBox"
        Me.LightOffPictureBox.Size = New System.Drawing.Size(160, 117)
        Me.LightOffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LightOffPictureBox.TabIndex = 8
        Me.LightOffPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LightOffPictureBox, "Click me")
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'SwitcherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(372, 262)
        Me.Controls.Add(Me.LightOffPictureBox)
        Me.Controls.Add(Me.LightOnPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ColorGroupBox)
        Me.Name = "SwitcherForm"
        Me.Text = "The Switcher"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ColorGroupBox.ResumeLayout(False)
        Me.ColorGroupBox.PerformLayout()
        CType(Me.LightOnPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LightOffPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GreenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BlueRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BlackRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LightOnPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LightOffPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
