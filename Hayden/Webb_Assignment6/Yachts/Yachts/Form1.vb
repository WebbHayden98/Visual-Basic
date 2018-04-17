Public Class Form1
    Private NumberOfChartersInteger As Integer
    Private TotalRevenueDecimal As Decimal
    Private TotalHoursCharteredDecimal As Decimal
    Private CalcualtedBoolean As Boolean

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Programmed by Hayden Webb", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PrintSummaryDocument_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintSummaryDocument.PrintPage
        Dim x_PositionSingle As Single = e.MarginBounds.Left
        Dim y_PositionSingle As Single = e.MarginBounds.Top
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim PrintingFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintingFont.GetHeight + 2
        Dim PrintLineString As String
        Dim FormattedNumberString As String
        Dim EndPosition As Single = 500.0F
        Dim startPosition As Single
        Dim stringSize As New SizeF()

        PrintLineString = "Summary Report"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, x_PositionSingle, y_PositionSingle)
        y_PositionSingle += LineHeightSingle

        PrintLineString = "Hayden Webb"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, x_PositionSingle, y_PositionSingle)
        y_PositionSingle += LineHeightSingle * 2

        PrintLineString = "Number of Charters"
        e.Graphics.DrawString(PrintLineString, PrintingFont, Brushes.Black, x_PositionSingle, y_PositionSingle)
        FormattedNumberString = NumberOfChartersInteger.ToString("N0")
        stringSize = e.Graphics.MeasureString(FormattedNumberString, PrintingFont)
        startPosition = EndPosition - stringSize.Width
        e.Graphics.DrawString(FormattedNumberString, PrintingFont, Brushes.Black, startPosition, y_PositionSingle)
        y_PositionSingle += LineHeightSingle

        PrintLineString = "Total Revenue"
        e.Graphics.DrawString(PrintLineString, PrintingFont, Brushes.Black, x_PositionSingle, y_PositionSingle)
        FormattedNumberString = TotalRevenueDecimal.ToString("C")
        stringSize = e.Graphics.MeasureString(FormattedNumberString, PrintingFont)
        startPosition = EndPosition - stringSize.Width
        e.Graphics.DrawString(FormattedNumberString, PrintingFont, Brushes.Black, startPosition, y_PositionSingle)
        y_PositionSingle += LineHeightSingle

        PrintLineString = "Average Hours Chartered"
        e.Graphics.DrawString(PrintLineString, PrintingFont, Brushes.Black, x_PositionSingle, y_PositionSingle)
        FormattedNumberString = (TotalHoursCharteredDecimal / NumberOfChartersInteger).ToString("N")
        stringSize = e.Graphics.MeasureString(FormattedNumberString, PrintingFont)
        startPosition = EndPosition - stringSize.Width
        e.Graphics.DrawString(FormattedNumberString, PrintingFont, Brushes.Black, startPosition, y_PositionSingle)
    End Sub

    Private Sub PrintYachtTypeDocument_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintYachtTypeDocument.PrintPage
        Dim x_PositionSingle As Single = e.MarginBounds.Left
        Dim y_PositionSingle As Single = e.MarginBounds.Top
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim PrintingFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintingFont.GetHeight + 2
        Dim PrintLineString As String
        Dim stringSize As New SizeF()
        Dim YachtTypeCount As Integer
        Dim LoopIndex As Integer

        PrintLineString = "Yacht Type Report"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, x_PositionSingle, y_PositionSingle)
        y_PositionSingle += LineHeightSingle

        PrintLineString = "Hayden Webb"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, x_PositionSingle, y_PositionSingle)
        y_PositionSingle += LineHeightSingle * 2

        With YachtTypeComboBox
            YachtTypeCount = .Items.Count
            For LoopIndex = 1 To YachtTypeCount Step 1
                .SelectedIndex = LoopIndex - 1
                PrintLineString = .Text
                e.Graphics.DrawString(PrintLineString, PrintingFont, Brushes.Black, x_PositionSingle, y_PositionSingle)
                y_PositionSingle += LineHeightSingle

            Next
        End With
  
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        'Print Summary
        PrintSummaryDocument.Print()
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        'Print Yacht Type
        PrintYachtTypeDocument.Print()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripMenuItem1.Click
        'Print Preview Yacht Type
        PrintPreviewDialog1.Document = PrintYachtTypeDocument
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        'Print Preview Summary
        PrintPreviewDialog1.Document = PrintSummaryDocument
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub OkButton_Click(sender As System.Object, e As System.EventArgs) Handles OkButton.Click
        Dim sizeInteger As Integer
        Dim HourDecimal As Decimal
        Dim HourlyRateDecimal As Decimal
        Dim totalPriceDecimal As Decimal
        Dim goodDataBoolean As Boolean = True

        'validate
        If ResponsiblePartyTextBox.Text = "" Then
            MessageBox.Show("Please enter a responsible party")
            goodDataBoolean = False
            With ResponsiblePartyTextBox
                .SelectAll()
                .Focus()
            End With
        ElseIf YachtSizeListBox.SelectedItem = "" Then
            goodDataBoolean = False
            MessageBox.Show("Please choose a size")
            With YachtSizeListBox
                .Focus()
            End With
        ElseIf YachtTypeComboBox.SelectedItem = "" Then
            goodDataBoolean = False
            MessageBox.Show("Please choose a type")
            With YachtSizeListBox
                .Focus()
            End With
        Else
            Try
                HourDecimal = Decimal.Parse(HoursCharteredTextBox.Text)
                If HourDecimal <= 0 Then

                    'pop up err msg
                    MessageBox.Show("Please enter a positive time value", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    HoursCharteredTextBox.Focus()
                    HoursCharteredTextBox.SelectAll()
                    goodDataBoolean = False
                End If
            Catch hoursEx As FormatException
                MessageBox.Show("Quantity must be a valid chartered hour.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                HoursCharteredTextBox.Focus()
                HoursCharteredTextBox.SelectAll()
                goodDataBoolean = False
            End Try
        End If


        If goodDataBoolean Then
            'when data is good
            'determine size to find hourly rate
            sizeInteger = Integer.Parse(YachtSizeListBox.Text)
            If (sizeInteger = 22) Then
                HourlyRateDecimal = 95
            ElseIf (sizeInteger = 24) Then
                HourlyRateDecimal = 137
            ElseIf (sizeInteger = 30) Then
                HourlyRateDecimal = 160
            ElseIf (sizeInteger = 32) Then
                HourlyRateDecimal = 192
            ElseIf (sizeInteger = 36) Then
                HourlyRateDecimal = 250
            ElseIf (sizeInteger = 38) Then
                HourlyRateDecimal = 400
            ElseIf (sizeInteger = 45) Then
                HourlyRateDecimal = 550
            Else
                MessageBox.Show("invalid size")
            End If
            ' calculate price
            totalPriceDecimal = HourlyRateDecimal * HourDecimal
            'display formatted price
            CharterPriceLabel.Text = totalPriceDecimal.ToString("C")
            'accumulate modular data
            TotalHoursCharteredDecimal += HourDecimal
            TotalRevenueDecimal += totalPriceDecimal
            NumberOfChartersInteger += 1
            CalcualtedBoolean = True
        End If
    End Sub

    Private Sub AddYachtTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddYachtTypeToolStripMenuItem.Click
        Dim itemFoundBoolean As Boolean
        Dim itemIndexInteger As Integer
        With YachtTypeComboBox
            If .Text = "" Then
                MessageBox.Show("Must enter a yacht type", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Do Until itemFoundBoolean = True Or itemIndexInteger = .Items.Count
                    If .Text.ToUpper = .Items(itemIndexInteger).ToString.ToUpper Then
                        itemFoundBoolean = True
                    Else
                        itemIndexInteger += 1
                    End If
                Loop
                If itemFoundBoolean = True Then
                    MessageBox.Show("Cannot add duplicate values", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    .Items.Add(.Text)
                End If
            End If
        End With
    End Sub

    Private Sub RemoveYachtTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveYachtTypeToolStripMenuItem.Click
        With YachtTypeComboBox
            .Items.Remove(YachtTypeComboBox.Text)
        End With
    End Sub

    Private Sub DisplayCountOfYachtTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayCountOfYachtTypesToolStripMenuItem.Click
        Dim itemCountInteger As Integer
        Dim MessageTextString As String
        itemCountInteger = YachtTypeComboBox.Items.Count
        MessageTextString = "Yacht type count: " & itemCountInteger
        MessageBox.Show(MessageTextString, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click, ClearForNextCharterToolStripMenuItem.Click
        Dim MessageTextString As String
        Dim returnDialogResult As DialogResult
        If CalcualtedBoolean Then
            ClearForm()
            CalcualtedBoolean = False
        Else
            MessageTextString = "You have not calculated, are you sure you wish to clear the form?"
            returnDialogResult = MessageBox.Show(MessageTextString, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
            If returnDialogResult = DialogResult.Yes Then
                ClearForm()
            Else
                OkButton.PerformClick()
            End If
        End If
    End Sub
    Private Sub ClearForm()
        ResponsiblePartyTextBox.Text = ""
        HoursCharteredTextBox.Text = ""
        CharterPriceLabel.Text = ""
        YachtTypeComboBox.SelectedIndex = -1
        YachtSizeListBox.SelectedIndex = -1
    End Sub
End Class
