<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IcedCappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.IcedLatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.LatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.EspressoRadioButton = New System.Windows.Forms.RadioButton()
        Me.CappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.itemAmountLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.taxCheckBox = New System.Windows.Forms.CheckBox()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OrderTotalLabel = New System.Windows.Forms.Label()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.subTotalLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.newOrderButton = New System.Windows.Forms.Button()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.itemAmountLabel)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.calculateButton)
        Me.GroupBox1.Controls.Add(Me.taxCheckBox)
        Me.GroupBox1.Controls.Add(Me.quantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 49)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(697, 241)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IcedCappuccinoRadioButton)
        Me.GroupBox2.Controls.Add(Me.IcedLatteRadioButton)
        Me.GroupBox2.Controls.Add(Me.LatteRadioButton)
        Me.GroupBox2.Controls.Add(Me.EspressoRadioButton)
        Me.GroupBox2.Controls.Add(Me.CappuccinoRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(351, 34)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(325, 199)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee Selections"
        '
        'IcedCappuccinoRadioButton
        '
        Me.IcedCappuccinoRadioButton.AutoSize = True
        Me.IcedCappuccinoRadioButton.Location = New System.Drawing.Point(41, 161)
        Me.IcedCappuccinoRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton"
        Me.IcedCappuccinoRadioButton.Size = New System.Drawing.Size(127, 20)
        Me.IcedCappuccinoRadioButton.TabIndex = 4
        Me.IcedCappuccinoRadioButton.TabStop = True
        Me.IcedCappuccinoRadioButton.Text = "Iced Ca&ppuccino"
        Me.IcedCappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'IcedLatteRadioButton
        '
        Me.IcedLatteRadioButton.AutoSize = True
        Me.IcedLatteRadioButton.Location = New System.Drawing.Point(41, 127)
        Me.IcedLatteRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.IcedLatteRadioButton.Name = "IcedLatteRadioButton"
        Me.IcedLatteRadioButton.Size = New System.Drawing.Size(84, 20)
        Me.IcedLatteRadioButton.TabIndex = 3
        Me.IcedLatteRadioButton.TabStop = True
        Me.IcedLatteRadioButton.Text = "&Iced Latte"
        Me.IcedLatteRadioButton.UseVisualStyleBackColor = True
        '
        'LatteRadioButton
        '
        Me.LatteRadioButton.AutoSize = True
        Me.LatteRadioButton.Location = New System.Drawing.Point(41, 92)
        Me.LatteRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.LatteRadioButton.Name = "LatteRadioButton"
        Me.LatteRadioButton.Size = New System.Drawing.Size(55, 20)
        Me.LatteRadioButton.TabIndex = 2
        Me.LatteRadioButton.TabStop = True
        Me.LatteRadioButton.Text = "La&tte"
        Me.LatteRadioButton.UseVisualStyleBackColor = True
        '
        'EspressoRadioButton
        '
        Me.EspressoRadioButton.AutoSize = True
        Me.EspressoRadioButton.Location = New System.Drawing.Point(41, 58)
        Me.EspressoRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EspressoRadioButton.Name = "EspressoRadioButton"
        Me.EspressoRadioButton.Size = New System.Drawing.Size(84, 20)
        Me.EspressoRadioButton.TabIndex = 1
        Me.EspressoRadioButton.TabStop = True
        Me.EspressoRadioButton.Text = "Espress&o"
        Me.EspressoRadioButton.UseVisualStyleBackColor = True
        '
        'CappuccinoRadioButton
        '
        Me.CappuccinoRadioButton.AutoSize = True
        Me.CappuccinoRadioButton.Checked = True
        Me.CappuccinoRadioButton.Location = New System.Drawing.Point(41, 23)
        Me.CappuccinoRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CappuccinoRadioButton.Name = "CappuccinoRadioButton"
        Me.CappuccinoRadioButton.Size = New System.Drawing.Size(98, 20)
        Me.CappuccinoRadioButton.TabIndex = 0
        Me.CappuccinoRadioButton.TabStop = True
        Me.CappuccinoRadioButton.Text = "C&appuccino"
        Me.CappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'itemAmountLabel
        '
        Me.itemAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.itemAmountLabel.Location = New System.Drawing.Point(123, 191)
        Me.itemAmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.itemAmountLabel.Name = "itemAmountLabel"
        Me.itemAmountLabel.Size = New System.Drawing.Size(153, 28)
        Me.itemAmountLabel.TabIndex = 6
        '
        'ClearButton
        '
        Me.ClearButton.Enabled = False
        Me.ClearButton.Location = New System.Drawing.Point(176, 119)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(101, 55)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&C&lear for Next Item"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(35, 119)
        Me.calculateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(101, 55)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "&Calculate Selection"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'taxCheckBox
        '
        Me.taxCheckBox.AutoSize = True
        Me.taxCheckBox.Location = New System.Drawing.Point(60, 79)
        Me.taxCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.taxCheckBox.Name = "taxCheckBox"
        Me.taxCheckBox.Size = New System.Drawing.Size(84, 20)
        Me.taxCheckBox.TabIndex = 3
        Me.taxCheckBox.Text = "Takeout?"
        Me.taxCheckBox.UseVisualStyleBackColor = True
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(87, 36)
        Me.quantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(113, 22)
        Me.quantityTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 191)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantity"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OrderTotalLabel)
        Me.GroupBox3.Controls.Add(Me.TaxLabel)
        Me.GroupBox3.Controls.Add(Me.subTotalLabel)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 298)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(697, 169)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'OrderTotalLabel
        '
        Me.OrderTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OrderTotalLabel.Location = New System.Drawing.Point(152, 123)
        Me.OrderTotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OrderTotalLabel.Name = "OrderTotalLabel"
        Me.OrderTotalLabel.Size = New System.Drawing.Size(139, 36)
        Me.OrderTotalLabel.TabIndex = 5
        '
        'TaxLabel
        '
        Me.TaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaxLabel.Location = New System.Drawing.Point(152, 73)
        Me.TaxLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(139, 36)
        Me.TaxLabel.TabIndex = 4
        '
        'subTotalLabel
        '
        Me.subTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.subTotalLabel.Location = New System.Drawing.Point(152, 20)
        Me.subTotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.subTotalLabel.Name = "subTotalLabel"
        Me.subTotalLabel.Size = New System.Drawing.Size(139, 36)
        Me.subTotalLabel.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Oder Total Due"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tax (if Takeout)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SubTotal"
        '
        'newOrderButton
        '
        Me.newOrderButton.Enabled = False
        Me.newOrderButton.Location = New System.Drawing.Point(69, 505)
        Me.newOrderButton.Margin = New System.Windows.Forms.Padding(4)
        Me.newOrderButton.Name = "newOrderButton"
        Me.newOrderButton.Size = New System.Drawing.Size(139, 47)
        Me.newOrderButton.TabIndex = 2
        Me.newOrderButton.Text = "&New Order"
        Me.newOrderButton.UseVisualStyleBackColor = True
        '
        'summaryButton
        '
        Me.summaryButton.Location = New System.Drawing.Point(267, 505)
        Me.summaryButton.Margin = New System.Windows.Forms.Padding(4)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(139, 47)
        Me.summaryButton.TabIndex = 3
        Me.summaryButton.Text = "&Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(464, 505)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(139, 47)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(685, 572)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Spring18"
        '
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 585)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.summaryButton)
        Me.Controls.Add(Me.newOrderButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BillingForm"
        Me.Text = "R 'n R--for Reading ' Refreshment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents IcedCappuccinoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IcedLatteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LatteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EspressoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CappuccinoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents itemAmountLabel As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents taxCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents quantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OrderTotalLabel As System.Windows.Forms.Label
    Friend WithEvents TaxLabel As System.Windows.Forms.Label
    Friend WithEvents subTotalLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents newOrderButton As System.Windows.Forms.Button
    Friend WithEvents summaryButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
