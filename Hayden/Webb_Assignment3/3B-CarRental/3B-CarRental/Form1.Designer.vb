<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carRentalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(carRentalForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChargeBusinessOfficeLabel = New System.Windows.Forms.Label()
        Me.MilesDrivenLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AverageCostPerMileLabel = New System.Windows.Forms.Label()
        Me.AverageCostPerUseLabel = New System.Windows.Forms.Label()
        Me.TotalMilesLabel = New System.Windows.Forms.Label()
        Me.NumCarsLabel = New System.Windows.Forms.Label()
        Me.TotalRevenueLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.printFormButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.Label18S = New System.Windows.Forms.Label()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.LicenseTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdometerTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RentedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReturndedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "College Car Rental"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "License Plate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Beginning Odometer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ending Odometer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(719, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date Returnded"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(448, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date Rented"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChargeBusinessOfficeLabel)
        Me.GroupBox1.Controls.Add(Me.MilesDrivenLabel)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(252, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 158)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Departmental Charges"
        '
        'ChargeBusinessOfficeLabel
        '
        Me.ChargeBusinessOfficeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ChargeBusinessOfficeLabel.Location = New System.Drawing.Point(124, 115)
        Me.ChargeBusinessOfficeLabel.Name = "ChargeBusinessOfficeLabel"
        Me.ChargeBusinessOfficeLabel.Size = New System.Drawing.Size(149, 18)
        Me.ChargeBusinessOfficeLabel.TabIndex = 5
        '
        'MilesDrivenLabel
        '
        Me.MilesDrivenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MilesDrivenLabel.Location = New System.Drawing.Point(124, 73)
        Me.MilesDrivenLabel.Name = "MilesDrivenLabel"
        Me.MilesDrivenLabel.Size = New System.Drawing.Size(149, 18)
        Me.MilesDrivenLabel.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 103)
        Me.Label10.MaximumSize = New System.Drawing.Size(117, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 30)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Charge Due to Business Office"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Miles Driven"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(71, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "$15.00 per day plus $0.12 per mile"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AverageCostPerMileLabel)
        Me.GroupBox2.Controls.Add(Me.AverageCostPerUseLabel)
        Me.GroupBox2.Controls.Add(Me.TotalMilesLabel)
        Me.GroupBox2.Controls.Add(Me.NumCarsLabel)
        Me.GroupBox2.Controls.Add(Me.TotalRevenueLabel)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(262, 457)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 182)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daily Summary"
        '
        'AverageCostPerMileLabel
        '
        Me.AverageCostPerMileLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AverageCostPerMileLabel.Location = New System.Drawing.Point(349, 95)
        Me.AverageCostPerMileLabel.Name = "AverageCostPerMileLabel"
        Me.AverageCostPerMileLabel.Size = New System.Drawing.Size(149, 18)
        Me.AverageCostPerMileLabel.TabIndex = 9
        '
        'AverageCostPerUseLabel
        '
        Me.AverageCostPerUseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AverageCostPerUseLabel.Location = New System.Drawing.Point(349, 46)
        Me.AverageCostPerUseLabel.Name = "AverageCostPerUseLabel"
        Me.AverageCostPerUseLabel.Size = New System.Drawing.Size(149, 18)
        Me.AverageCostPerUseLabel.TabIndex = 8
        '
        'TotalMilesLabel
        '
        Me.TotalMilesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalMilesLabel.Location = New System.Drawing.Point(101, 140)
        Me.TotalMilesLabel.Name = "TotalMilesLabel"
        Me.TotalMilesLabel.Size = New System.Drawing.Size(149, 18)
        Me.TotalMilesLabel.TabIndex = 7
        '
        'NumCarsLabel
        '
        Me.NumCarsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NumCarsLabel.Location = New System.Drawing.Point(101, 45)
        Me.NumCarsLabel.Name = "NumCarsLabel"
        Me.NumCarsLabel.Size = New System.Drawing.Size(149, 18)
        Me.NumCarsLabel.TabIndex = 6
        '
        'TotalRevenueLabel
        '
        Me.TotalRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalRevenueLabel.Location = New System.Drawing.Point(101, 87)
        Me.TotalRevenueLabel.Name = "TotalRevenueLabel"
        Me.TotalRevenueLabel.Size = New System.Drawing.Size(149, 18)
        Me.TotalRevenueLabel.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(253, 96)
        Me.Label15.MaximumSize = New System.Drawing.Size(93, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 30)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Average Cost Per Mile"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(253, 46)
        Me.Label14.MaximumSize = New System.Drawing.Size(93, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 30)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Average Cost Per Use"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Total Miles"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 87)
        Me.Label12.MaximumSize = New System.Drawing.Size(117, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 30)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Total Revenue Generated"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Number of Cars"
        '
        'printFormButton
        '
        Me.printFormButton.Location = New System.Drawing.Point(433, 674)
        Me.printFormButton.Name = "printFormButton"
        Me.printFormButton.Size = New System.Drawing.Size(105, 36)
        Me.printFormButton.TabIndex = 9
        Me.printFormButton.Text = "Print &Form"
        Me.printFormButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(722, 674)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(122, 36)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(919, 381)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(122, 36)
        Me.calculateButton.TabIndex = 11
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(919, 520)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(122, 36)
        Me.clearButton.TabIndex = 12
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Label18S
        '
        Me.Label18S.AutoSize = True
        Me.Label18S.Location = New System.Drawing.Point(22, 637)
        Me.Label18S.Name = "Label18S"
        Me.Label18S.Size = New System.Drawing.Size(0, 15)
        Me.Label18S.TabIndex = 13
        Me.Label18S.Visible = False
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Location = New System.Drawing.Point(169, 85)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(119, 21)
        Me.DepartmentTextBox.TabIndex = 14
        '
        'LicenseTextBox
        '
        Me.LicenseTextBox.Location = New System.Drawing.Point(169, 123)
        Me.LicenseTextBox.Name = "LicenseTextBox"
        Me.LicenseTextBox.Size = New System.Drawing.Size(119, 21)
        Me.LicenseTextBox.TabIndex = 15
        '
        'BeginningOdometerTextBox
        '
        Me.BeginningOdometerTextBox.Location = New System.Drawing.Point(169, 162)
        Me.BeginningOdometerTextBox.Name = "BeginningOdometerTextBox"
        Me.BeginningOdometerTextBox.Size = New System.Drawing.Size(119, 21)
        Me.BeginningOdometerTextBox.TabIndex = 16
        '
        'EndingOdometerTextBox
        '
        Me.EndingOdometerTextBox.Location = New System.Drawing.Point(169, 200)
        Me.EndingOdometerTextBox.Name = "EndingOdometerTextBox"
        Me.EndingOdometerTextBox.Size = New System.Drawing.Size(119, 21)
        Me.EndingOdometerTextBox.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 15)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Label16"
        '
        'RentedDateTimePicker
        '
        Me.RentedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RentedDateTimePicker.Location = New System.Drawing.Point(396, 85)
        Me.RentedDateTimePicker.Name = "RentedDateTimePicker"
        Me.RentedDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.RentedDateTimePicker.TabIndex = 19
        '
        'ReturndedDateTimePicker
        '
        Me.ReturndedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReturndedDateTimePicker.Location = New System.Drawing.Point(653, 85)
        Me.ReturndedDateTimePicker.Name = "ReturndedDateTimePicker"
        Me.ReturndedDateTimePicker.Size = New System.Drawing.Size(200, 21)
        Me.ReturndedDateTimePicker.TabIndex = 20
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'carRentalForm
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(1115, 733)
        Me.Controls.Add(Me.ReturndedDateTimePicker)
        Me.Controls.Add(Me.RentedDateTimePicker)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.EndingOdometerTextBox)
        Me.Controls.Add(Me.BeginningOdometerTextBox)
        Me.Controls.Add(Me.LicenseTextBox)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Me.Label18S)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printFormButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "carRentalForm"
        Me.Text = "Campus Car Depot"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents printFormButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18S As System.Windows.Forms.Label
    Friend WithEvents MilesDrivenLabel As System.Windows.Forms.Label
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LicenseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BeginningOdometerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndingOdometerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ChargeBusinessOfficeLabel As System.Windows.Forms.Label
    Friend WithEvents AverageCostPerUseLabel As System.Windows.Forms.Label
    Friend WithEvents TotalMilesLabel As System.Windows.Forms.Label
    Friend WithEvents NumCarsLabel As System.Windows.Forms.Label
    Friend WithEvents TotalRevenueLabel As System.Windows.Forms.Label
    Friend WithEvents AverageCostPerMileLabel As System.Windows.Forms.Label
    Friend WithEvents RentedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReturndedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
