'Program Name:  Ch04 HandsOn
'Programmer:    Hayden Webb 
'Date:          
'Description:   This project calculates the amount due based on the customer
'               selection and accumulates summary data for the day.
Public Class BillingForm
    'Declare module-level constants
    Const TAX_RATE_Decimal As Decimal = 0.08D
    Const CAPPUCCINO_PRICE_Decimal As Decimal = 2D
    Const ESPRESSO_PRICE_Decimal As Decimal = 2.25D
    Const LATTE_PRICE_Decimal As Decimal = 1.75D
    Const ICED_PRICE_Decimal As Decimal = 2.5D

    'Declare module-level variables for summary information
    Private subTotalDecimal As Decimal
    Private orderTotalDecimal As Decimal
    Private numberOfOrdersInteger As Integer
    Private totalSalesDecimal As Decimal
   
    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        'declare local variables
        Dim quantityInteger As Integer
        Dim itemAmountDecimal As Decimal
        Dim taxDecimal As Decimal
        Dim priceDecimal As Decimal
        Try
            'Convert quantity to numeric
            quantityInteger = Integer.Parse(quantityTextBox.Text)

            'when quantity not positive pop up error msg
            If quantityInteger <= 0 Then
                MessageBox.Show("Quantity must be positive", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With quantityTextBox
                    .SelectAll()
                    .Focus()
                End With

            Else 'otherwise

                'determine price
                If CappuccinoRadioButton.Checked = True Then
                    priceDecimal = CAPPUCCINO_PRICE_Decimal

                ElseIf EspressoRadioButton.Checked = True Then
                    priceDecimal = ESPRESSO_PRICE_Decimal

                ElseIf LatteRadioButton.Checked = True Then
                    priceDecimal = LATTE_PRICE_Decimal

                ElseIf IcedLatteRadioButton.Checked = True Or IcedCappuccinoRadioButton.Checked = True Then
                    priceDecimal = ICED_PRICE_Decimal

                End If

                'calc item amount
                itemAmountDecimal = quantityInteger * priceDecimal

                'calc subtotal
                subTotalDecimal += itemAmountDecimal

                'when necessary, calc tax
                If taxCheckBox.Checked = True Then
                    taxDecimal = TAX_RATE_Decimal * subTotalDecimal
                Else
                    taxDecimal = 0
                End If

                'calc order total due
                orderTotalDecimal = (subTotalDecimal + taxDecimal)

                'enable clear for next item button and new order button
                ClearButton.Enabled = True
                newOrderButton.Enabled = True

                'disable takeout button
                taxCheckBox.Enabled = False

                'display formatted output
                TaxLabel.Text = taxDecimal.ToString("C")
                itemAmountLabel.Text = itemAmountDecimal.ToString("C")
                subTotalLabel.Text = subTotalDecimal.ToString("C")
                OrderTotalLabel.Text = orderTotalDecimal.ToString("C")
            End If

            'pop up error msg
        Catch exQuantity As FormatException
            MessageBox.Show("Quantity must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With quantityTextBox
                .SelectAll()
                .Focus()
            End With
        End Try
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'clear quantity and item amount
        quantityTextBox.Text = ""
        itemAmountLabel.Text = ""

        'reset coffee type
        itemAmountLabel.Text = ""
        CappuccinoRadioButton.Checked = True

    End Sub

    Private Sub newOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newOrderButton.Click
        'declare local variables
        Dim messageString As String = "Clear the current order configure?"
        Dim returnDialogResults As DialogResult

        'confirm new order
        returnDialogResults = MessageBox.Show(messageString, "Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If returnDialogResults = DialogResult.Yes Then

            'when confirmed
            'call clear button
            Call ClearButton_Click(sender, e)

            'clear subtotal, tax, and order due
            TaxLabel.Text = ""
            subTotalLabel.Text = ""
            OrderTotalLabel.Text = ""

            'enables and uncheck takeout
            taxCheckBox.Enabled = True
            taxCheckBox.Checked = False

            'disable clear for next item and new order button
            ClearButton.Enabled = False
            newOrderButton.Enabled = False

            'accumulate number of orders and total sales
            If subTotalDecimal <> 0 Then
                numberOfOrdersInteger += 1
                totalSalesDecimal += orderTotalDecimal

                'reset subtotal and order total due for next order to 0
                subTotalDecimal = 0
                orderTotalDecimal = 0
            End If

        End If
    End Sub

    Private Sub summaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles summaryButton.Click
        'declare local variables
        Dim averageSaleDecimal As Decimal
        Dim messageString As String

        'ensure last order is counted
        If orderTotalDecimal <> 0 Then
            Call newOrderButton_Click(sender, e)
        End If

        'when at least one order exist
        If numberOfOrdersInteger > 0 Then

            'calc avg sale
            averageSaleDecimal = (totalSalesDecimal / numberOfOrdersInteger)

            'create summary output string
            messageString = "Number of Orders: " & numberOfOrdersInteger.ToString("N") & Environment.NewLine & Environment.NewLine & "Total Sales: " &
                totalSalesDecimal.ToString("C") & Environment.NewLine & Environment.NewLine & "Average Sales: " & averageSaleDecimal.ToString("C")
            MessageBox.Show(messageString, "Coffee Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'otherwise
        Else

            'pop up error message
            messageString = "No sales Data to summerize"
            MessageBox.Show(messageString, "Coffee Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Close()
    End Sub
End Class
