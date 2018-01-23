'Project:       Switcher
'Programmer:    Hayden Webb
'Date:          1/23/20
'Description:   Allow the user to select a color and turn a light on and off.
Public Class SwitcherForm


    Private Sub BlackRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BlackRadioButton.CheckedChanged
        'Change the text color to black
        MessageLabel.ForeColor = Color.Black
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BlueRadioButton.CheckedChanged
        'Change the text color to blue
        MessageLabel.ForeColor = Color.Blue
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RedRadioButton.CheckedChanged
        'Change the text color to red
        MessageLabel.ForeColor = Color.Red
    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles GreenRadioButton.CheckedChanged
        'Change the text color to green
        MessageLabel.ForeColor = Color.Green
    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click
        'Print the form
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        'Close the form
        Close()
    End Sub

    Private Sub LightOffPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles LightOffPictureBox.Click
        'Change the text and picture
        LightOffPictureBox.Visible = False
        LightOnPictureBox.Visible = True
        MessageLabel.Text = "Turn the Light Off " & NameTextBox.Text
    End Sub

    Private Sub LightOnPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles LightOnPictureBox.Click
        'Change the text and picture
        LightOffPictureBox.Visible = True
        LightOnPictureBox.Visible = False
        MessageLabel.Text = "Turn the Light On " & NameTextBox.Text
    End Sub
End Class
