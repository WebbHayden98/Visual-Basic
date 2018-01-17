Public Class exampleForm

    Private Sub okButton_Click(sender As System.Object, e As System.EventArgs) Handles okButton.Click
        'Display user name and phone number
        messageLabel.Text = "Your name is: " & nameTextBox.Text & " Your phone number is: " & phoneMaskedTextBox.Text
    End Sub

    Private Sub exitButton_Click(sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        'Close program
        Close()
    End Sub

    Private Sub redRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles redRadioButton.CheckedChanged
        'set text color to red
        messageLabel.ForeColor = Color.Red
    End Sub

    Private Sub blackRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles blackRadioButton.CheckedChanged
        'set text color to black
        messageLabel.ForeColor = Color.Black
    End Sub

    Private Sub closePictureBox_Click(sender As System.Object, e As System.EventArgs) Handles closePictureBox.Click
        'Hides closed book and displays open book
        openPictureBox.Visible = True
        closePictureBox.Visible = False
    End Sub

    Private Sub openPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles openPictureBox.Click
        'Hides open book and displays closed book
        openPictureBox.Visible = False
        closePictureBox.Visible = True
    End Sub
End Class
