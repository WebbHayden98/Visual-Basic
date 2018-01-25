<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookSalesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookSalesForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DiscountedPriceLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.ExtendedPriceLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AverageDiscountLabel = New System.Windows.Forms.Label()
        Me.TotalDiscountedAmountsLabel = New System.Windows.Forms.Label()
        Me.TotalDiscountsGivenLabel = New System.Windows.Forms.Label()
        Me.TotalNumBooksLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.LabelS18 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Sales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 60)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(570, 191)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(126, 127)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(148, 24)
        Me.PriceTextBox.TabIndex = 5
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(126, 79)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(419, 24)
        Me.TitleTextBox.TabIndex = 4
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(126, 30)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(136, 24)
        Me.QuantityTextBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "&Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Quantity"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DiscountedPriceLabel)
        Me.GroupBox2.Controls.Add(Me.DiscountLabel)
        Me.GroupBox2.Controls.Add(Me.ExtendedPriceLabel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(55, 281)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(567, 173)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'DiscountedPriceLabel
        '
        Me.DiscountedPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DiscountedPriceLabel.Location = New System.Drawing.Point(354, 130)
        Me.DiscountedPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DiscountedPriceLabel.Name = "DiscountedPriceLabel"
        Me.DiscountedPriceLabel.Size = New System.Drawing.Size(166, 32)
        Me.DiscountedPriceLabel.TabIndex = 5
        '
        'DiscountLabel
        '
        Me.DiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DiscountLabel.Location = New System.Drawing.Point(354, 79)
        Me.DiscountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(166, 32)
        Me.DiscountLabel.TabIndex = 4
        '
        'ExtendedPriceLabel
        '
        Me.ExtendedPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ExtendedPriceLabel.Location = New System.Drawing.Point(354, 22)
        Me.ExtendedPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ExtendedPriceLabel.Name = "ExtendedPriceLabel"
        Me.ExtendedPriceLabel.Size = New System.Drawing.Size(166, 32)
        Me.ExtendedPriceLabel.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(186, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "15% Discount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(186, 128)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Discounted Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Extended Price"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AverageDiscountLabel)
        Me.GroupBox3.Controls.Add(Me.TotalDiscountedAmountsLabel)
        Me.GroupBox3.Controls.Add(Me.TotalDiscountsGivenLabel)
        Me.GroupBox3.Controls.Add(Me.TotalNumBooksLabel)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(55, 479)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(570, 216)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Summary"
        '
        'AverageDiscountLabel
        '
        Me.AverageDiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AverageDiscountLabel.Location = New System.Drawing.Point(354, 160)
        Me.AverageDiscountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AverageDiscountLabel.Name = "AverageDiscountLabel"
        Me.AverageDiscountLabel.Size = New System.Drawing.Size(163, 32)
        Me.AverageDiscountLabel.TabIndex = 7
        '
        'TotalDiscountedAmountsLabel
        '
        Me.TotalDiscountedAmountsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalDiscountedAmountsLabel.Location = New System.Drawing.Point(354, 110)
        Me.TotalDiscountedAmountsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalDiscountedAmountsLabel.Name = "TotalDiscountedAmountsLabel"
        Me.TotalDiscountedAmountsLabel.Size = New System.Drawing.Size(163, 32)
        Me.TotalDiscountedAmountsLabel.TabIndex = 6
        '
        'TotalDiscountsGivenLabel
        '
        Me.TotalDiscountsGivenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalDiscountsGivenLabel.Location = New System.Drawing.Point(354, 66)
        Me.TotalDiscountsGivenLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalDiscountsGivenLabel.Name = "TotalDiscountsGivenLabel"
        Me.TotalDiscountsGivenLabel.Size = New System.Drawing.Size(163, 32)
        Me.TotalDiscountsGivenLabel.TabIndex = 5
        '
        'TotalNumBooksLabel
        '
        Me.TotalNumBooksLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalNumBooksLabel.Location = New System.Drawing.Point(354, 22)
        Me.TotalNumBooksLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalNumBooksLabel.Name = "TotalNumBooksLabel"
        Me.TotalNumBooksLabel.Size = New System.Drawing.Size(163, 32)
        Me.TotalNumBooksLabel.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(58, 160)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 18)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Average Discount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(58, 110)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Total Discounted Amounts"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 66)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Discounts Given"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Number of Books"
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(31, 703)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(130, 37)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print &Form"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(189, 703)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(130, 37)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(346, 703)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(130, 37)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "Clear &Sale"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(504, 703)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 37)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'LabelS18
        '
        Me.LabelS18.AutoSize = True
        Me.LabelS18.Location = New System.Drawing.Point(666, 718)
        Me.LabelS18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelS18.Name = "LabelS18"
        Me.LabelS18.Size = New System.Drawing.Size(0, 18)
        Me.LabelS18.TabIndex = 8
        Me.LabelS18.Visible = False
        '
        'bookSalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 745)
        Me.Controls.Add(Me.LabelS18)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "bookSalesForm"
        Me.Text = "R 'n R for Reading 'n Refreshment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DiscountedPriceLabel As System.Windows.Forms.Label
    Friend WithEvents DiscountLabel As System.Windows.Forms.Label
    Friend WithEvents ExtendedPriceLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents AverageDiscountLabel As System.Windows.Forms.Label
    Friend WithEvents TotalDiscountedAmountsLabel As System.Windows.Forms.Label
    Friend WithEvents TotalDiscountsGivenLabel As System.Windows.Forms.Label
    Friend WithEvents TotalNumBooksLabel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents LabelS18 As System.Windows.Forms.Label

End Class
