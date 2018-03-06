'Program Name:  MailOrder
'Programmer:    Hayden Webb
'Date:          3/6/18
'Description:   This project validates customer information and item information.
'               It then calculates the price of each item ordered and the total order value,
'               the shipping charge, tax due for CA orders, and total amount due.

Public Class mailOrderForm
    'define constants here
    Const SALES_TAX_RATE_DECIMAL = 0.08
    Const SHIPPING_HANDLING_RATE_DECIMAL = 0.25

    'define modular variables here
    Private OrderAmountDueDeciaml As Decimal
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
        Dim ZipInteger As Integer
        Dim messageString As String = "Do you wish to add additional items?"

        'Validate text fields--see powerpoint slides 33 from files/Lectures/chapter 4
        If NameTextBox.Text = "" Then
            MessageBox.Show("Please enter a customer name", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NameTextBox.Focus()
            NameTextBox.SelectAll()
            goodDataBoolean = False

            'continue checking each text box that will contain characters using elseIfs
        ElseIf DescriptionTextBox.Text = "" Then
            MessageBox.Show("Please enter a description", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DescriptionTextBox.Focus()
            DescriptionTextBox.SelectAll()
            goodDataBoolean = False

        ElseIf AddressTextBox.Text = "" Then
            MessageBox.Show("Please enter an Address", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddressTextBox.Focus()
            AddressTextBox.SelectAll()
            goodDataBoolean = False

        ElseIf CityTextBox.Text = "" Then
            MessageBox.Show("Please enter a City", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CityTextBox.Focus()
            CityTextBox.SelectAll()
            goodDataBoolean = False

        ElseIf StateTextBox.Text = "" Then
            MessageBox.Show("Please enter a state", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            StateTextBox.Focus()
            StateTextBox.SelectAll()
            goodDataBoolean = False

            'all text boxes containing non-numeric characters have been tested
            'Validate numeric fields--see powerpoint slides 33 from files/Lectures/chapter 4
        Else
            Try
                'convert quanity to numeric
                ItemQuantityInteger = Integer.Parse(QuantityTextBox.Text)

                'when quanity not positive
                If ItemQuantityInteger <= 0 Then

                    'pop up err msg
                    MessageBox.Show("Please enter a positive Quantity", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    QuantityTextBox.Focus()
                    QuantityTextBox.SelectAll()
                    goodDataBoolean = False

                Else

                    'nest all try-catches for each number that must be  numeric and greater than zero
                    Try
                        'convert price to numeric
                        ItemPriceDecimal = Decimal.Parse(PriceTextBox.Text)

                        'when price not positive
                        If ItemPriceDecimal <= 0 Then

                            'pop up err msg
                            MessageBox.Show("Please enter a positive Price", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            PriceTextBox.Focus()
                            PriceTextBox.SelectAll()
                            goodDataBoolean = False
                        Else
                            Try

                                'convert weight to numeric
                                ItemWeightDecimal = Integer.Parse(WeightTextBox.Text)

                                'when weight not positive
                                If ItemWeightDecimal <= 0 Then

                                    'pop up err msg
                                    MessageBox.Show("Please enter a positive weight", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    WeightTextBox.Focus()
                                    WeightTextBox.SelectAll()
                                    goodDataBoolean = False
                                Else
                                    Try

                                        'convert Zip code to numeric
                                        ZipInteger = Integer.Parse(ZipCodeTextBox.Text)

                                        'when zip not positive
                                        If ZipInteger <= 0 Then

                                            'pop up err msg
                                            MessageBox.Show("Please enter a valid zip code", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            ZipCodeTextBox.Focus()
                                            ZipCodeTextBox.SelectAll()
                                            goodDataBoolean = False
                                        End If

                                    Catch ZipEx As FormatException
                                        MessageBox.Show("Quantity must be a valid zip code.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        ZipCodeTextBox.Focus()
                                        ZipCodeTextBox.SelectAll()
                                        goodDataBoolean = False
                                    End Try
                                End If

                            Catch WeightEx As FormatException
                                MessageBox.Show("Quantity must be a whole number.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                WeightTextBox.Focus()
                                WeightTextBox.SelectAll()
                                goodDataBoolean = False
                            End Try
                        End If

                    Catch PriceEx As FormatException
                        MessageBox.Show("Price must be a whole number.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        PriceTextBox.Focus()
                        PriceTextBox.SelectAll()
                        goodDataBoolean = False
                    End Try
                End If

            Catch QuantityEx As FormatException
                MessageBox.Show("Quantity must be a whole number.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            OrderWeightDecimal += (ItemWeightDecimal * ItemQuantityInteger)

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
                addItemButton.Enabled = False
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
        ItemAmountLabel.Text = ""
        OrderAmountDueDeciaml = 0
        OrderWeightDecimal = 0

        'disable Update Summary button
        updateSummaryButton.Enabled = False

        'enable Add this Item button
        addItemButton.Enabled = True
    End Sub

    Private Sub updateSummaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateSummaryButton.Click
        'define local variables
        Dim ShippingHandlingDecimal As Decimal
        Dim SalesTaxDecimal As Decimal

        'when order going to California, calculate tax on order amout due
        If StateTextBox.Text = "CA" Then
            SalesTaxDecimal = OrderAmountDueDeciaml * SALES_TAX_RATE_DECIMAL
            OrderAmountDueDeciaml += SalesTaxDecimal
        Else
            SalesTaxDecimal = 0
        End If

        'calculate shipping charge of 25 cents per pound
        ShippingHandlingDecimal = OrderWeightDecimal * SHIPPING_HANDLING_RATE_DECIMAL

        'add one of three handing charges based on weight
        If OrderWeightDecimal < 15 Then
            ShippingHandlingDecimal += 10
        ElseIf OrderWeightDecimal >= 15 And OrderWeightDecimal < 45 Then
            ShippingHandlingDecimal += 15
        ElseIf OrderWeightDecimal >= 45 Then
            ShippingHandlingDecimal += 30
        End If
        OrderAmountDueDeciaml += ShippingHandlingDecimal

        'display formatted values of shipping and handline, sales tax, and total amount due
        TotalAmountDueLabel.Text = OrderAmountDueDeciaml.ToString("C")
        ShippingHandlingLabel.Text = ShippingHandlingDecimal.ToString("C")
        SalesTaxLabel.Text = SalesTaxDecimal.ToString("C")


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
