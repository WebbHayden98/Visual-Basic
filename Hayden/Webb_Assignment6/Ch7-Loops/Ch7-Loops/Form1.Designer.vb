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
        Me.outputListBox = New System.Windows.Forms.ListBox()
        Me.numSquaredButton = New System.Windows.Forms.Button()
        Me.upperLeftButton = New System.Windows.Forms.Button()
        Me.upperRightButton = New System.Windows.Forms.Button()
        Me.lowerLeftButton = New System.Windows.Forms.Button()
        Me.lowerRightButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'outputListBox
        '
        Me.outputListBox.FormattingEnabled = True
        Me.outputListBox.Location = New System.Drawing.Point(12, 16)
        Me.outputListBox.Name = "outputListBox"
        Me.outputListBox.Size = New System.Drawing.Size(299, 433)
        Me.outputListBox.TabIndex = 0
        '
        'numSquaredButton
        '
        Me.numSquaredButton.Location = New System.Drawing.Point(357, 41)
        Me.numSquaredButton.Name = "numSquaredButton"
        Me.numSquaredButton.Size = New System.Drawing.Size(75, 23)
        Me.numSquaredButton.TabIndex = 1
        Me.numSquaredButton.Text = "Numbers Squared"
        Me.numSquaredButton.UseVisualStyleBackColor = True
        '
        'upperLeftButton
        '
        Me.upperLeftButton.Location = New System.Drawing.Point(357, 121)
        Me.upperLeftButton.Name = "upperLeftButton"
        Me.upperLeftButton.Size = New System.Drawing.Size(75, 23)
        Me.upperLeftButton.TabIndex = 2
        Me.upperLeftButton.Text = "Upper Left"
        Me.upperLeftButton.UseVisualStyleBackColor = True
        '
        'upperRightButton
        '
        Me.upperRightButton.Location = New System.Drawing.Point(357, 183)
        Me.upperRightButton.Name = "upperRightButton"
        Me.upperRightButton.Size = New System.Drawing.Size(75, 23)
        Me.upperRightButton.TabIndex = 3
        Me.upperRightButton.Text = "Upper Right"
        Me.upperRightButton.UseVisualStyleBackColor = True
        '
        'lowerLeftButton
        '
        Me.lowerLeftButton.Location = New System.Drawing.Point(357, 250)
        Me.lowerLeftButton.Name = "lowerLeftButton"
        Me.lowerLeftButton.Size = New System.Drawing.Size(75, 23)
        Me.lowerLeftButton.TabIndex = 4
        Me.lowerLeftButton.Text = "Lower Left"
        Me.lowerLeftButton.UseVisualStyleBackColor = True
        '
        'lowerRightButton
        '
        Me.lowerRightButton.Location = New System.Drawing.Point(357, 315)
        Me.lowerRightButton.Name = "lowerRightButton"
        Me.lowerRightButton.Size = New System.Drawing.Size(75, 23)
        Me.lowerRightButton.TabIndex = 5
        Me.lowerRightButton.Text = "Lower Right"
        Me.lowerRightButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 463)
        Me.Controls.Add(Me.lowerRightButton)
        Me.Controls.Add(Me.lowerLeftButton)
        Me.Controls.Add(Me.upperRightButton)
        Me.Controls.Add(Me.upperLeftButton)
        Me.Controls.Add(Me.numSquaredButton)
        Me.Controls.Add(Me.outputListBox)
        Me.Name = "Form1"
        Me.Text = "Chapter 7  For-Next Loops"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents outputListBox As System.Windows.Forms.ListBox
    Friend WithEvents numSquaredButton As System.Windows.Forms.Button
    Friend WithEvents upperLeftButton As System.Windows.Forms.Button
    Friend WithEvents upperRightButton As System.Windows.Forms.Button
    Friend WithEvents lowerLeftButton As System.Windows.Forms.Button
    Friend WithEvents lowerRightButton As System.Windows.Forms.Button

End Class
