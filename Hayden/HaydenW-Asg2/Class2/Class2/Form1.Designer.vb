<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exampleForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.okButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.phoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.blackRadioButton = New System.Windows.Forms.RadioButton()
        Me.redRadioButton = New System.Windows.Forms.RadioButton()
        Me.closePictureBox = New System.Windows.Forms.PictureBox()
        Me.openPictureBox = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.closePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.openPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Phone Number"
        '
        'messageLabel
        '
        Me.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.messageLabel.Location = New System.Drawing.Point(101, 98)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(171, 36)
        Me.messageLabel.TabIndex = 2
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(197, 205)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 3
        Me.okButton.Text = "&OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(197, 234)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(101, 29)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(171, 20)
        Me.nameTextBox.TabIndex = 5
        Me.nameTextBox.Text = "Watson"
        Me.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'phoneMaskedTextBox
        '
        Me.phoneMaskedTextBox.Location = New System.Drawing.Point(101, 61)
        Me.phoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.phoneMaskedTextBox.Name = "phoneMaskedTextBox"
        Me.phoneMaskedTextBox.Size = New System.Drawing.Size(171, 20)
        Me.phoneMaskedTextBox.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.blackRadioButton)
        Me.GroupBox1.Controls.Add(Me.redRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(95, 68)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color"
        '
        'blackRadioButton
        '
        Me.blackRadioButton.AutoSize = True
        Me.blackRadioButton.Checked = True
        Me.blackRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.blackRadioButton.Name = "blackRadioButton"
        Me.blackRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.blackRadioButton.TabIndex = 1
        Me.blackRadioButton.TabStop = True
        Me.blackRadioButton.Text = "B&lack"
        Me.blackRadioButton.UseVisualStyleBackColor = True
        '
        'redRadioButton
        '
        Me.redRadioButton.AutoSize = True
        Me.redRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.redRadioButton.Name = "redRadioButton"
        Me.redRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.redRadioButton.TabIndex = 0
        Me.redRadioButton.Text = "&Red"
        Me.redRadioButton.UseVisualStyleBackColor = True
        '
        'closePictureBox
        '
        Me.closePictureBox.Image = Global.Class2.My.Resources.Resources.NOTE05
        Me.closePictureBox.Location = New System.Drawing.Point(39, 173)
        Me.closePictureBox.Name = "closePictureBox"
        Me.closePictureBox.Size = New System.Drawing.Size(95, 84)
        Me.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closePictureBox.TabIndex = 8
        Me.closePictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.closePictureBox, "Click Me")
        Me.closePictureBox.Visible = False
        '
        'openPictureBox
        '
        Me.openPictureBox.Image = Global.Class2.My.Resources.Resources.book06
        Me.openPictureBox.Location = New System.Drawing.Point(39, 173)
        Me.openPictureBox.Name = "openPictureBox"
        Me.openPictureBox.Size = New System.Drawing.Size(95, 84)
        Me.openPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.openPictureBox.TabIndex = 10
        Me.openPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.openPictureBox, "Click Me")
        '
        'exampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 269)
        Me.Controls.Add(Me.openPictureBox)
        Me.Controls.Add(Me.closePictureBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.phoneMaskedTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "exampleForm"
        Me.Text = "Keyboard or Mouse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.closePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.openPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents messageLabel As System.Windows.Forms.Label
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents phoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents blackRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents redRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents closePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents openPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
