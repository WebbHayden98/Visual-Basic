<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listForm
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
        Me.meatListBox = New System.Windows.Forms.ListBox()
        Me.drinkListBox = New System.Windows.Forms.ListBox()
        Me.fruitListBox = New System.Windows.Forms.ListBox()
        Me.fruitLabel = New System.Windows.Forms.Label()
        Me.schoolsComboBox = New System.Windows.Forms.ComboBox()
        Me.majorComboBox = New System.Windows.Forms.ComboBox()
        Me.occupationComboBox = New System.Windows.Forms.ComboBox()
        Me.addMajorButton = New System.Windows.Forms.Button()
        Me.occupationLabel = New System.Windows.Forms.Label()
        Me.clearMajorButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'meatListBox
        '
        Me.meatListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meatListBox.FormattingEnabled = True
        Me.meatListBox.ItemHeight = 20
        Me.meatListBox.Items.AddRange(New Object() {"Chicken", "Turkey"})
        Me.meatListBox.Location = New System.Drawing.Point(34, 41)
        Me.meatListBox.Name = "meatListBox"
        Me.meatListBox.Size = New System.Drawing.Size(137, 44)
        Me.meatListBox.TabIndex = 0
        '
        'drinkListBox
        '
        Me.drinkListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drinkListBox.FormattingEnabled = True
        Me.drinkListBox.ItemHeight = 20
        Me.drinkListBox.Items.AddRange(New Object() {"Orange Juice", "Water", "Soda", "Tea", "Milk"})
        Me.drinkListBox.Location = New System.Drawing.Point(34, 124)
        Me.drinkListBox.Name = "drinkListBox"
        Me.drinkListBox.Size = New System.Drawing.Size(133, 44)
        Me.drinkListBox.TabIndex = 2
        '
        'fruitListBox
        '
        Me.fruitListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fruitListBox.FormattingEnabled = True
        Me.fruitListBox.ItemHeight = 20
        Me.fruitListBox.Items.AddRange(New Object() {"Blueberries", "Cantelope ", "Cherries", "Kiwi", "Peaches", "Plums ", "Strawberries"})
        Me.fruitListBox.Location = New System.Drawing.Point(34, 218)
        Me.fruitListBox.Name = "fruitListBox"
        Me.fruitListBox.Size = New System.Drawing.Size(129, 144)
        Me.fruitListBox.TabIndex = 3
        '
        'fruitLabel
        '
        Me.fruitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fruitLabel.Location = New System.Drawing.Point(43, 399)
        Me.fruitLabel.Name = "fruitLabel"
        Me.fruitLabel.Size = New System.Drawing.Size(287, 33)
        Me.fruitLabel.TabIndex = 4
        '
        'schoolsComboBox
        '
        Me.schoolsComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schoolsComboBox.FormattingEnabled = True
        Me.schoolsComboBox.Location = New System.Drawing.Point(266, 49)
        Me.schoolsComboBox.Name = "schoolsComboBox"
        Me.schoolsComboBox.Size = New System.Drawing.Size(359, 28)
        Me.schoolsComboBox.TabIndex = 5
        '
        'majorComboBox
        '
        Me.majorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.majorComboBox.FormattingEnabled = True
        Me.majorComboBox.Items.AddRange(New Object() {"Business Information Systems", "Computer Science", "Engineering Technology", "Health Information Management", "Industrial Technology"})
        Me.majorComboBox.Location = New System.Drawing.Point(264, 137)
        Me.majorComboBox.Name = "majorComboBox"
        Me.majorComboBox.Size = New System.Drawing.Size(298, 28)
        Me.majorComboBox.TabIndex = 6
        '
        'occupationComboBox
        '
        Me.occupationComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.occupationComboBox.FormattingEnabled = True
        Me.occupationComboBox.Items.AddRange(New Object() {"Database Manager", "Network Manager", "Network Engineer", "Programmer Analyst", "PC-Support Specialist"})
        Me.occupationComboBox.Location = New System.Drawing.Point(264, 240)
        Me.occupationComboBox.Name = "occupationComboBox"
        Me.occupationComboBox.Size = New System.Drawing.Size(218, 28)
        Me.occupationComboBox.TabIndex = 7
        '
        'addMajorButton
        '
        Me.addMajorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMajorButton.Location = New System.Drawing.Point(629, 109)
        Me.addMajorButton.Name = "addMajorButton"
        Me.addMajorButton.Size = New System.Drawing.Size(127, 59)
        Me.addMajorButton.TabIndex = 8
        Me.addMajorButton.Text = "Add Major"
        Me.addMajorButton.UseVisualStyleBackColor = True
        '
        'occupationLabel
        '
        Me.occupationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.occupationLabel.Location = New System.Drawing.Point(357, 367)
        Me.occupationLabel.Name = "occupationLabel"
        Me.occupationLabel.Size = New System.Drawing.Size(221, 65)
        Me.occupationLabel.TabIndex = 9
        '
        'clearMajorButton
        '
        Me.clearMajorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearMajorButton.Location = New System.Drawing.Point(636, 189)
        Me.clearMajorButton.Name = "clearMajorButton"
        Me.clearMajorButton.Size = New System.Drawing.Size(119, 62)
        Me.clearMajorButton.TabIndex = 10
        Me.clearMajorButton.Text = "Clear Majors"
        Me.clearMajorButton.UseVisualStyleBackColor = True
        '
        'listForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 468)
        Me.Controls.Add(Me.clearMajorButton)
        Me.Controls.Add(Me.occupationLabel)
        Me.Controls.Add(Me.addMajorButton)
        Me.Controls.Add(Me.occupationComboBox)
        Me.Controls.Add(Me.majorComboBox)
        Me.Controls.Add(Me.schoolsComboBox)
        Me.Controls.Add(Me.fruitLabel)
        Me.Controls.Add(Me.fruitListBox)
        Me.Controls.Add(Me.drinkListBox)
        Me.Controls.Add(Me.meatListBox)
        Me.Name = "listForm"
        Me.Text = "List Boxes and Combo Boxes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents meatListBox As System.Windows.Forms.ListBox
    Friend WithEvents drinkListBox As System.Windows.Forms.ListBox
    Friend WithEvents fruitListBox As System.Windows.Forms.ListBox
    Friend WithEvents fruitLabel As System.Windows.Forms.Label
    Friend WithEvents schoolsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents majorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents occupationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents addMajorButton As System.Windows.Forms.Button
    Friend WithEvents occupationLabel As System.Windows.Forms.Label
    Friend WithEvents clearMajorButton As System.Windows.Forms.Button

End Class
