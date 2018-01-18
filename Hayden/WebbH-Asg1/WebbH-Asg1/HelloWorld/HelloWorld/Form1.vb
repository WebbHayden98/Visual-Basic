'Project:       Hello World
'Programmer:    Hayden Webb
'Date:          1/9/18
'Description:   This project will display a "Hello World"
'               message in two different languages 
'               and print the form.

Public Class HelloForm

    Private Sub EnglishButton_Click(sender As System.Object, e As System.EventArgs) Handles EnglishButton.Click
        'Display the Hello World Message
        MessageLabel.Text = "Hello World"
        MessageLabel.ForeColor = Color.Chocolate
        MessageLabel.BackColor = Color.Wheat

    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub SpanishButton_Click(sender As System.Object, e As System.EventArgs) Handles SpanishButton.Click
        MessageLabel.Text = "Hola Mundo"
        MessageLabel.ForeColor = Color.Green
        MessageLabel.BackColor = Color.PaleGreen
    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub HelloForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
