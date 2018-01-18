'Project:       PtA-RnR
'Programmer:    Hayden Webb
'Date:          1/11/2018
'Description:   This project displays current promotions
'               for each topic and their codes.
Public Class MainForm


    Private Sub BooksButton_Click(sender As System.Object, e As System.EventArgs) Handles BooksButton.Click
        'Display Books promotion
        PromotionLabel.Text = "Buy two, get the second one for half price."
        PromotionCodeLabel.Text = "B608"
    End Sub

    Private Sub MusicButton_Click(sender As System.Object, e As System.EventArgs) Handles MusicButton.Click
        'Display Music promotion
        PromotionLabel.Text = "Get a free MP3 download with purchase of a CD."
        PromotionCodeLabel.Text = "M608"
    End Sub

    Private Sub PeriodicalsButton_Click(sender As System.Object, e As System.EventArgs) Handles PeriodicalsButton.Click
        'Display Periodicals promotion
        PromotionLabel.Text = "Elite members recieve 10% off every purchase."
        PromotionCodeLabel.Text = "P608"
    End Sub

    Private Sub CoffeeBarButton_Click(sender As System.Object, e As System.EventArgs) Handles CoffeeBarButton.Click
        'Display CoffeeBar promotion
        PromotionLabel.Text = "Celebrate the season with 20% off specialty drinks."
        PromotionCodeLabel.Text = "C608"
    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click
        'Print the program
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        'Exit the Program
        Close()
    End Sub
End Class
