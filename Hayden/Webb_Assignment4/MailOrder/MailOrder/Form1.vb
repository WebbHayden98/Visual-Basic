'Program Name:  MailOrder
'Programmer:
'Date:
'Description:   This project validates customer information and item information.
'               It then calculates the price of each item ordered and the total order value,
'               the shipping charge, tax due for CA orders, and total amount due.

Public Class mailOrderForm
    'define constants here
    Const SALES_TAX_RATE_DECIMAL = 0.8
    Const SHIPPING_HANDLING_RATE_DECIMAL = 0.25

    'define modular variables here
    Private OrderAmountDueDeciaml As Decimal
    Private ShippingHandlingDecimal As Decimal
    Private OrderWeightDecimal As Decimal

    'NOTE: see psuedocode in addItemButton to help you determine what modular variables you need
    
    Private Sub addItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addItemButton.Click
        'define local variables
        Dim goodDataBoolean As Boolean = True
        Dim ItemAmountDeciaml As Decimal
        Dim ItemPriceDecimal As Decimal
        Dim ItemQuantityInteger As Integer
        Dim ItemWeightDecimal As Decimal
        Dim returnDialogResults As DialogResult
        Dim messageString As String = "Do you wish to add additional items?"

        'Validate text fields--see powerpoint slides 33 from files/Lectures/chapter 4
        If NameTextBox.Text = "" Then
            MessageBox.Show("Please enter a customer name", "Data Missing",
MessageBoxButtons.OK, MessageBoxIcon.Error)
            NameTextBox.Focus()
            NameTextBox.SelectAll()
            goodDataBoolean = False

            'Validate numeric fields--see powerpoint slides 33 from files/Lectures/chapter 4
        ElseIf DescriptionTextBox.Text = "" Then
            MessageBox.Show("Please enter a description", "Data Missing",
MessageBoxButtons.OK, MessageBoxIcon.Error)
            DescriptionTextBox.Focus()
            DescriptionTextBox.SelectAll()
            goodDataBoolean = False

        Else
            Try
                ItemQuantityInteger = Integer.Parse(QuantityTextBox.Text)
                If ItemQuantityInteger <= 0 Then
                    MessageBox.Show("Please enter a positive Quantity", "Data Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    QuantityTextBox.Focus()
                    QuantityTextBox.SelectAll()
                    goodDataBoolean = False
                Else
                    'nest all try-catches for each number that must be numeric and greater than zero
                End If
            Catch quantityErr As FormatException
                MessageBox.Show("Quantity must be a whole number.", "Data Missing",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
                QuantityTextBox.Focus()
                QuantityTextBox.SelectAll()
                goodDataBoolean = False
            End Try
        End If

        'When all data is valid
        If goodDataBoolean = True Then


            'calculate and display item amount
            ItemAmountDeciaml = ItemQuantityInteger * ItemPriceDecimal
            ItemAmountLabel.Text = ItemAmountDeciaml.ToString("C")

            'accumulate and display order amount due
            OrderAmountDueDeciaml += ItemAmountDeciaml
            OrderAmountDueLabel.Text = OrderAmountDueDeciaml.ToString("C")

            'accumulate total order weight (needed in update summary to calculate shipping and handling)
            OrderWeightDecimal += ItemWeightDecimal

            'ask user if there are any more items for this order
            returnDialogResults = MessageBox.Show(messageString, "Item Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If returnDialogResults = DialogResult.Yes Then

                '  when yes, clear output IN Item Information box ONLY and disable Add this Item button
                DescriptionTextBox.Text = ""
                QuantityTextBox.Text = ""
                WeightTextBox.Text = ""
                PriceTextBox.Text = ""
                ItemAmountLabel.Text = ""

            Else
                '  otherwise, enable summary button
                updateSummaryButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub clearCustomerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearCustomerButton.Click
        'clear EVERY control on form
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        DescriptionTextBox.Text = ""
        QuantityTextBox.Text = ""
        WeightTextBox.Text = ""
        PriceTextBox.Text = ""
        OrderAmountDueLabel.Text = ""
        ShippingHandlingLabel.Text = ""
        SalesTaxLabel.Text = ""
        TotalAmountDueLabel.Text = ""

        'disable Update Summary button
        updateSummaryButton.Enabled = False

        'enable Add this Item button
        addItemButton.Enabled = True
    End Sub

    Private Sub updateSummaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateSummaryButton.Click
        'define local variables

        'when order going to California, calculate tax on order amout due
        'calculate shipping charge of 25 cents per pound
        'add one of three handing charges based on weight
        'display formatted values of shipping and handline, sales tax, and total amount due



    End Sub

    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click
        'Print the form
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Close the form
        Close()
    End Sub
End Class
