'Project:       RnR
'Programmer:    Hayden Webb
'Date:          1/18/20
'Description:   Allow the user to sign in and display sales promotions.
Public Class MainForm

    Private Sub SignInButton_Click(sender As System.Object, e As System.EventArgs) Handles SignInButton.Click
        'Display the department promtotions and welcome message.
        'Hide Sign-in controls
        CheckInGroupBox.Visible = False
        SignInButton.Enabled = False

        'Enable group of radio buttons
        DepartmentGroupBox.Enabled = True

        'Show promotion controls
        PromotionTextBox.Visible = True
        ImageVisibleCheckBox.Visible = True
        WelcomeRichTextBox.Visible = True

        'Display welcome message
        WelcomeRichTextBox.Text = "Welcome Member #" & MemberIDMaskedTextBox.Text &
            Environment.NewLine & NameTextBox.Text
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        'End program
        Close()
    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click
        'Print the form
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ImageVisibleCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ImageVisibleCheckBox.CheckedChanged
        'Set department image to visible
        DepartmentPictureBox.Visible = ImageVisibleCheckBox.Checked
    End Sub

    Private Sub CoffeeBarRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CoffeeBarRadioButton.CheckedChanged
        'Display image and promotion for Coffe Bar
        DepartmentPictureBox.Image = My.Resources.Coffee
        PromotionTextBox.Text = "Celebrate the season with 20% off specialty drinks."
    End Sub

    Private Sub PeriodicalsRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles PeriodicalsRadioButton.CheckedChanged
        'Display image and promotion for Periodicals
        DepartmentPictureBox.Image = My.Resources.Periodicals
        PromotionTextBox.Text = "Elite members recieve 10% off every purchase."
    End Sub

    Private Sub MusicRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles MusicRadioButton.CheckedChanged
        'Display image and promotion for Music
        DepartmentPictureBox.Image = My.Resources.Music
        PromotionTextBox.Text = "Get a free MP3 download with purchase of a CD."
    End Sub

    Private Sub BooksRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BooksRadioButton.CheckedChanged
        'Display image and promotion for Books
        DepartmentPictureBox.Image = My.Resources.Book
        PromotionTextBox.Text = "Buy two, get the second one for half price."
    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class