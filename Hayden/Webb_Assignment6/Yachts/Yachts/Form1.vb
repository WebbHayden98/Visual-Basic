Public Class Form1
    Private NumberOfChartersInteger As Integer
    Private TotalRevenueDecimal As Decimal
    Private TotalHoursCharteredDecimal As Decimal

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
        Dim AverageHoursCharterdDecimal As Decimal
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
        FormattedNumberString = TotalHoursCharteredDecimal.ToString("N")
        stringSize = e.Graphics.MeasureString(FormattedNumberString, PrintingFont)
        startPosition = EndPosition - stringSize.Width
        e.Graphics.DrawString(FormattedNumberString, PrintingFont, Brushes.Black, startPosition, y_PositionSingle)
    End Sub

    Private Sub PrintYachtTypeDocument_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintYachtTypeDocument.PrintPage

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
        Dim sizeInt As Integer
        Dim HourDec As Decimal
        Dim HourlyRateDEC As Decimal
        Dim totalPriceDec As Decimal
        Dim goodData As Boolean = True

        'validate
        If ResponsiblePartyTextBox.Text = "" Then
            MessageBox.Show("Please enter a responsible party")
            goodData = False
            With txtParty
                .SelectAll()
                .Focus()
            End With
        Else
            If (listSize.SelectedItem = False) Then
                goodData = False
                MessageBox.Show("Please choose a size")
                With listSize
                    .Focus()
                End With
            Else
                sizeInt = listSize.SelectedItem
                Try
                    HourDec = Decimal.Parse(txtHours.Text)
                    If (HourDec <= 0) Then
                        MessageBox.Show("Please enter a valid amount of time")
                        goodData = False
                        With txtHours
                            .SelectAll()
                            .Focus()
                        End With
                    Else
                        If CBXYachtType.SelectedItem = "" Then
                            MessageBox.Show("Please choose a yachat type")
                            CBXYachtType.Focus()
                            goodData = False
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("hours must be numeric: ", "Data Entry Error ",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                                )
                    With txtHours
                        .SelectAll()
                        .Focus()
                    End With
                End Try
            End If
        End If
        'when data is good
        'determine size to find hourly rate
        If (sizeInt = 22) Then
            HourlyRateDEC = 95
        ElseIf (sizeInt = 24) Then
            HourlyRateDEC = 137
        ElseIf (sizeInt = 30) Then
            HourlyRateDEC = 160
        ElseIf (sizeInt = 32) Then
            HourlyRateDEC = 192
        ElseIf (sizeInt = 36) Then
            HourlyRateDEC = 250
        ElseIf (sizeInt = 38) Then
            HourlyRateDEC = 400
        ElseIf (sizeInt = 45) Then
            HourlyRateDEC = 550
        Else
            MessageBox.Show("invalid size")
        End If
        ' calculate price
        totalPriceDec = HourlyRateDEC * HourDec
        'display formatted price
        lblPrice.Text = "Your total price is " + totalPriceDec.ToString("C")
        'accumulate modular data
        TotalHoursDec += HourDec
        TotalRevenueDec += TotalRevenueDec
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
End Class
