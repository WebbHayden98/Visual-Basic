<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchoolForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchoolForm))
        Me.SchoolNameButton = New System.Windows.Forms.Button()
        Me.MascotButton = New System.Windows.Forms.Button()
        Me.DepartmentNameButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'SchoolNameButton
        '
        Me.SchoolNameButton.Location = New System.Drawing.Point(393, 12)
        Me.SchoolNameButton.Name = "SchoolNameButton"
        Me.SchoolNameButton.Size = New System.Drawing.Size(102, 23)
        Me.SchoolNameButton.TabIndex = 0
        Me.SchoolNameButton.Text = "School Name"
        Me.SchoolNameButton.UseVisualStyleBackColor = True
        '
        'MascotButton
        '
        Me.MascotButton.Location = New System.Drawing.Point(393, 70)
        Me.MascotButton.Name = "MascotButton"
        Me.MascotButton.Size = New System.Drawing.Size(102, 23)
        Me.MascotButton.TabIndex = 2
        Me.MascotButton.Text = "Mascot"
        Me.MascotButton.UseVisualStyleBackColor = True
        '
        'DepartmentNameButton
        '
        Me.DepartmentNameButton.Location = New System.Drawing.Point(393, 41)
        Me.DepartmentNameButton.Name = "DepartmentNameButton"
        Me.DepartmentNameButton.Size = New System.Drawing.Size(102, 23)
        Me.DepartmentNameButton.TabIndex = 3
        Me.DepartmentNameButton.Text = "Department Name"
        Me.DepartmentNameButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(393, 99)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(102, 23)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(393, 128)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(102, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OutputLabel
        '
        Me.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OutputLabel.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputLabel.Location = New System.Drawing.Point(12, 41)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(375, 23)
        Me.OutputLabel.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Programmed by: Hayden Webb"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'SchoolForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 165)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DepartmentNameButton)
        Me.Controls.Add(Me.MascotButton)
        Me.Controls.Add(Me.SchoolNameButton)
        Me.Name = "SchoolForm"
        Me.Text = "School Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SchoolNameButton As System.Windows.Forms.Button
    Friend WithEvents MascotButton As System.Windows.Forms.Button
    Friend WithEvents DepartmentNameButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents OutputLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
