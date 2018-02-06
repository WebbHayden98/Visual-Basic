'Project:           CarRental-PartB
'Date:              2/6/2018
'Programmer:        Hayden Webb
'Description:       Create a program that will display cost per car rental
'                   and a summary of the daily sales.

Option Strict On
Public Class carRentalForm

    Const RATE_PER_DAY_DECIMAL As Decimal = 15D
    Const RATE_PER_MILE_DECIMAL As Decimal = 0.12D

    Private NumCarsInteger As Integer
    Private TotalRevenueGeneratedDecimal As Decimal
    Private TotalMilesDeciaml As Decimal



    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        Dim AverageCostPerMileDecimal As Decimal
        Dim AverageCostPerUseDecimal As Decimal
        Dim BeginningOdometerDecimal As Decimal
        Dim EndingOdometerDecimal As Decimal
        Dim MilesDrivenDecimal As Decimal
        Dim ChargeDueToBusinessOfficeDecimal As Decimal
        Dim NumDaysInteger As Integer

        Try
            'Convert Beginning Odometer to decimal
            BeginningOdometerDecimal = Decimal.Parse(BeginningOdometerTextBox.Text)
            Try
                'Convert ending Odometer to numeric
                EndingOdometerDecimal = Decimal.Parse(EndingOdometerTextBox.Text)

                'Calculate values for single car rental
                'a.
                MilesDrivenDecimal = EndingOdometerDecimal - BeginningOdometerDecimal
                'b.
                NumDaysInteger = Convert.ToInt32(DateDiff(DateInterval.Day, RentedDateTimePicker.Value, ReturndedDateTimePicker.Value))
                'c.
                ChargeDueToBusinessOfficeDecimal = (NumDaysInteger * RATE_PER_DAY_DECIMAL) + (MilesDrivenDecimal * RATE_PER_MILE_DECIMAL)

                'Display formatted single sale values
                ChargeBusinessOfficeLabel.Text = ChargeDueToBusinessOfficeDecimal.ToString("C")
                MilesDrivenLabel.Text = MilesDrivenDecimal.ToString("N")

                'accumulate summary vlaues
                NumCarsInteger += 1
                TotalRevenueGeneratedDecimal += ChargeDueToBusinessOfficeDecimal
                TotalMilesDeciaml += MilesDrivenDecimal
                AverageCostPerMileDecimal = (TotalRevenueGeneratedDecimal / TotalMilesDeciaml)
                AverageCostPerUseDecimal = (TotalRevenueGeneratedDecimal / NumCarsInteger)

                'display formatted summary values
                NumCarsLabel.Text = NumCarsInteger.ToString("N")
                TotalRevenueLabel.Text = TotalRevenueGeneratedDecimal.ToString("C")
                TotalMilesLabel.Text = TotalMilesDeciaml.ToString("N")
                AverageCostPerMileLabel.Text = AverageCostPerMileDecimal.ToString("C")
                AverageCostPerUseLabel.Text = AverageCostPerUseDecimal.ToString("C")

            Catch endex As FormatException
                MessageBox.Show("Odometer must be numeric.", "Data Entry Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop)
                With EndingOdometerTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try

        Catch beginex As FormatException
            MessageBox.Show("Odometer must be numeric.", "Data Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop)
            With BeginningOdometerTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        'Clear all noncontinuing boxes
        DepartmentTextBox.Clear()
        LicenseTextBox.Clear()
        BeginningOdometerTextBox.Clear()
        EndingOdometerTextBox.Clear()

        MilesDrivenLabel.Text = ""
        ChargeBusinessOfficeLabel.Text = ""
    End Sub

    Private Sub printFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printFormButton.Click
        'Print the form
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Close the form
        Close()
    End Sub
End Class
