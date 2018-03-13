'Program Name:      Vintage Tours Payroll
'Programmer Name:   Hayden Webb
'Date:              3/13/18
Public Class payrollForm
    Private totalSalesInteger As Integer
    Private totalBasePayDecimal As Decimal
    Private totalCommissionsDecimal As Decimal
    Private totalPayAllEmployees As Decimal

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LogoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoToolStripMenuItem.Click
        If LogoToolStripMenuItem.Checked = True Then
            LogoToolStripMenuItem.Checked = False
            logoPictureBox.Visible = False
        Else : LogoToolStripMenuItem.Checked = False
            LogoToolStripMenuItem.Checked = True
            logoPictureBox.Visible = True

        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .ShowDialog()
            basePayLabel.ForeColor = .Color
            commissionLabel.ForeColor = .Color
            employeePayLabel.ForeColor = .Color
        End With
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .ShowDialog()
            basePayLabel.Font = .Font
            commissionLabel.Font = .Font
            employeePayLabel.Font = .Font
        End With
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        Dim messagestring As String

        messagestring = "Total Sales: " & totalSalesInteger.ToString("N") & Environment.NewLine & Environment.NewLine & "Total Base Pay: " &
            totalBasePayDecimal.ToString("C") & Environment.NewLine & Environment.NewLine & "Total Commissions: " & totalCommissionsDecimal.ToString("C") &
            Environment.NewLine & Environment.NewLine & "Total Pay for ALL Employees: " & totalPayAllEmployees.ToString("C")
        MessageBox.Show(messagestring, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CalcToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalcToolStripMenuItem.Click, CalcPayToolStripMenuItem1.Click
        'Define local variable
        Dim goodDataBoolean As Boolean = True
        Dim dollarValueSalesDecimal As Decimal
        Dim hoursWorkedDeciaml As Decimal
        Dim payRateDecimal As Decimal

        'Validate non-numeric text fields
        If nameTextBox.Text = "" Then
            MessageBox.Show("Please enter a name", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            nameTextBox.Focus()
            nameTextBox.SelectAll()
            goodDataBoolean = False
        ElseIf permanentEmployeeRadioButton.Checked = False Then
            If temporaryRadioButton.Checked = False Then
                MessageBox.Show("Select an Employment Type", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                permanentEmployeeRadioButton.Focus()
                goodDataBoolean = False
            End If
        Else
            Try
                dollarValueSalesDecimal = Decimal.Parse(salesTextBox.Text)
                If dollarValueSalesDecimal <= 0 Then

                    'pop up err msg
                    MessageBox.Show("Please enter a positive Sales Value", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    salesTextBox.Focus()
                    salesTextBox.SelectAll()
                    goodDataBoolean = False
                Else
                    Try
                        hoursWorkedDeciaml = Decimal.Parse(hoursWorkedTextBox.Text)
                        If hoursWorkedDeciaml <= 0 Then

                            'pop up err msg
                            MessageBox.Show("Please enter a positive Sales Value", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            hoursWorkedTextBox.Focus()
                            hoursWorkedTextBox.SelectAll()
                            goodDataBoolean = False
                        Else
                            Try
                                payRateDecimal = Decimal.Parse(payRateTextBox.Text)
                                If payRateDecimal <= 0 Then

                                    'pop up err msg
                                    MessageBox.Show("Please enter a valid zip code", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    payRateTextBox.Focus()
                                    payRateTextBox.SelectAll()
                                    goodDataBoolean = False
                                End If

                            Catch payrateex As FormatException
                                MessageBox.Show("Quantity must be a valid pay rate.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                payRateTextBox.Focus()
                                payRateTextBox.SelectAll()
                                goodDataBoolean = False
                            End Try
                        End If

                        'Validate numeric text fields
    End Sub

    Private Sub ClearPayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearPayToolStripMenuItem.Click, ClearFormToolStripMenuItem1.Click
        Dim messagestring As String = "Clear this form?"
        Dim returnDialogResult As DialogResult

        returnDialogResult = MessageBox.Show(messagestring, "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If returnDialogResult = DialogResult.Yes Then
            nameTextBox.Text = ""
            salesTextBox.Text = ""
            hoursWorkedTextBox.Text = ""
            payRateTextBox.Text = ""
            basePayLabel.Text = ""
            commissionLabel.Text = ""
            employeePayLabel.Text = ""
            permanentEmployeeRadioButton.Checked = False
            temporaryRadioButton.Checked = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim messagestring As String

        messagestring = "Vintage Tours Payroll" & Environment.NewLine & "-Hayden Webb"
        MessageBox.Show(messagestring, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
