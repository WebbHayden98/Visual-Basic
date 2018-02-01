'Project:
'Date:
'Programmer:
'Description:

Option Strict On
Public Class carRentalForm

    Const RATE_PER_DAY_DECIMAL As Decimal = 15D

    Const RATE_PER_MILE_DECIMAL As Decimal = 0.12D

    Private NumCars As Integer
    Private TotalRevenueGeneratedDecimal As Decimal
    Private TotalMilesDeciaml As Decimal



    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        Dim AverageCostPerMile As Decimal
        Dim AverageCostPerUse As Decimal
        Dim BeginningOdometer As Decimal
        Dim EndingOdometer As Decimal
        Dim MilesDriven As Decimal

        Try
            BeginningOdometer = Decimal.Parse(BeginningOdometerTextBox.Text)

        Catch beginex As FormatException
            MessageBox.Show("Odometer must be numeric.", "Data Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop)
            With BeginningOdometerTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
        Try
            EndingOdometer = Decimal.Parse(EndingOdometerTextBox.Text)

        Catch endex As FormatException
            MessageBox.Show("Odometer must be numeric.", "Data Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop)
            With EndingOdometerTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        DepartmentTextBox.Clear()
        LicenseTextBox.Clear()
        BeginningOdometerTextBox.Clear()
        EndingOdometerTextBox.Clear()

    End Sub

    Private Sub printFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printFormButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
