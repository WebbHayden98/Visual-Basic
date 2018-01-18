<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BooksButton = New System.Windows.Forms.Button()
        Me.MusicButton = New System.Windows.Forms.Button()
        Me.PeriodicalsButton = New System.Windows.Forms.Button()
        Me.CoffeeBarButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PromotionLabel = New System.Windows.Forms.Label()
        Me.PromotionCodeLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'BooksButton
        '
        Me.BooksButton.Location = New System.Drawing.Point(12, 12)
        Me.BooksButton.Name = "BooksButton"
        Me.BooksButton.Size = New System.Drawing.Size(75, 23)
        Me.BooksButton.TabIndex = 0
        Me.BooksButton.Text = "Books"
        Me.BooksButton.UseVisualStyleBackColor = True
        '
        'MusicButton
        '
        Me.MusicButton.Location = New System.Drawing.Point(12, 41)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(75, 23)
        Me.MusicButton.TabIndex = 1
        Me.MusicButton.Text = "Music"
        Me.MusicButton.UseVisualStyleBackColor = True
        '
        'PeriodicalsButton
        '
        Me.PeriodicalsButton.Location = New System.Drawing.Point(12, 70)
        Me.PeriodicalsButton.Name = "PeriodicalsButton"
        Me.PeriodicalsButton.Size = New System.Drawing.Size(75, 23)
        Me.PeriodicalsButton.TabIndex = 2
        Me.PeriodicalsButton.Text = "Periodicals"
        Me.PeriodicalsButton.UseVisualStyleBackColor = True
        '
        'CoffeeBarButton
        '
        Me.CoffeeBarButton.Location = New System.Drawing.Point(12, 99)
        Me.CoffeeBarButton.Name = "CoffeeBarButton"
        Me.CoffeeBarButton.Size = New System.Drawing.Size(75, 23)
        Me.CoffeeBarButton.TabIndex = 3
        Me.CoffeeBarButton.Text = "Coffee Bar"
        Me.CoffeeBarButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(12, 128)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(12, 157)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Current Promotion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Promotion Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Programmed by Hayden Webb"
        '
        'PromotionLabel
        '
        Me.PromotionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PromotionLabel.Location = New System.Drawing.Point(199, 41)
        Me.PromotionLabel.Name = "PromotionLabel"
        Me.PromotionLabel.Size = New System.Drawing.Size(310, 23)
        Me.PromotionLabel.TabIndex = 9
        '
        'PromotionCodeLabel
        '
        Me.PromotionCodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PromotionCodeLabel.Location = New System.Drawing.Point(199, 70)
        Me.PromotionCodeLabel.Name = "PromotionCodeLabel"
        Me.PromotionCodeLabel.Size = New System.Drawing.Size(150, 23)
        Me.PromotionCodeLabel.TabIndex = 10
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 193)
        Me.Controls.Add(Me.PromotionCodeLabel)
        Me.Controls.Add(Me.PromotionLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.CoffeeBarButton)
        Me.Controls.Add(Me.PeriodicalsButton)
        Me.Controls.Add(Me.MusicButton)
        Me.Controls.Add(Me.BooksButton)
        Me.Name = "MainForm"
        Me.Text = "R n' R--For Reading and Refreshment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BooksButton As System.Windows.Forms.Button
    Friend WithEvents MusicButton As System.Windows.Forms.Button
    Friend WithEvents PeriodicalsButton As System.Windows.Forms.Button
    Friend WithEvents CoffeeBarButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PromotionLabel As System.Windows.Forms.Label
    Friend WithEvents PromotionCodeLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
