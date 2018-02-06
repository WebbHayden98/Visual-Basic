'Project:       Ch03--Part A
'Date:          1/25/18
'Programmer:    Hayden Webb
'Description:   This project inputs sales information for books.
'               It calculates the price for each sale 
'               and maintains summary information for all sales

Public Class bookSalesForm
    'Dimension Constants

    Const DISCOUNT_RATE_Decimal As Decimal = 0.15D

    'Dimension Modular Variables

    Private TotalNumBooksInteger As Integer
    Private TotalDiscountGivenDecimal As Decimal
    Private TotalDiscountedAmountDecimal As Decimal
    Private TotalNumsSalesIntegar As Integer
    
    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        'Dimension Local Variables

        Dim QuantityInteger As Integer
        Dim PriceDecimal As Decimal
        Dim ExtendedPriceDecimal As Decimal
        Dim DiscountDecimal As Decimal
        Dim DiscountedPriceDecimal As Decimal
        Dim AverageDiscountDecimal As Decimal

        Try
            'convert quantity to numeric
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)
            Try
                'convert price to numeric
                PriceDecimal = Decimal.Parse(PriceTextBox.Text)
                'calculate values for single sale
                ExtendedPriceDecimal = QuantityInteger * PriceDecimal
                DiscountDecimal = Decimal.Round((ExtendedPriceDecimal * DISCOUNT_RATE_Decimal), 2)
                DiscountedPriceDecimal = ExtendedPriceDecimal - DiscountDecimal

                'accumulate (add to ) summary values
                TotalNumBooksInteger += QuantityInteger
                TotalDiscountGivenDecimal += DiscountDecimal
                TotalNumsSalesIntegar += 1
                AverageDiscountDecimal = TotalDiscountGivenDecimal / TotalNumsSalesIntegar
                TotalDiscountedAmountDecimal += DiscountedPriceDecimal

                'display formatted single sale values
                ExtendedPriceLabel.Text = ExtendedPriceDecimal.ToString("C")
                DiscountLabel.Text = DiscountDecimal.ToString("N")
                DiscountedPriceLabel.Text = DiscountedPriceDecimal.ToString("C")
                TotalNumBooksLabel.Text = TotalNumBooksInteger.ToString("N")

                'display formatted summary values
                TotalDiscountedAmountsLabel.Text = TotalDiscountGivenDecimal.ToString("C")
                TotalDiscountsGivenLabel.Text = DiscountedPriceDecimal.ToString("C")
                AverageDiscountLabel.Text = AverageDiscountDecimal.ToString("C")


            Catch exPrice As FormatException
                MessageBox.Show("Price must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With PriceTextBox
                    .SelectAll()
                    .Focus()
                End With
            End Try

        Catch exQuantity As FormatException
            'Format Exception for quantity conversion
            MessageBox.Show("Quantity must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With QuantityTextBox
                .SelectAll()
                .Focus()
            End With

        Catch anyException As Exception
            'Any other exception
            MessageBox.Show("Error: " & anyException.Message)
        End Try

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ExtendedPriceLabel.Text = ""
        DiscountLabel.Text = ""
        DiscountedPriceLabel.Text = ""
        TotalNumBooksLabel.Text = ""
        TotalDiscountsGivenLabel.Text = ""
        TotalDiscountedAmountsLabel.Text = ""
        TotalNumBooksLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub bookSalesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
