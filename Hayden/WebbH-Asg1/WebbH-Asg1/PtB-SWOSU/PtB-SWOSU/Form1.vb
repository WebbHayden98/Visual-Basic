'Project:       PtB-SWOSU
'Programmer:    Hayden Webb
'Date:          1/11/2018
'Description:   This project displays information about SWOSU
'               for each topic.
Public Class SchoolForm


    Private Sub SchoolNameButton_Click(sender As System.Object, e As System.EventArgs) Handles SchoolNameButton.Click
        'Displasy school name
        OutputLabel.Text = "Southwestern Oklahoma State University"
        OutputLabel.ForeColor = Color.DarkTurquoise
        OutputLabel.BackColor = Color.PaleTurquoise
    End Sub

    Private Sub DepartmentNameButton_Click(sender As System.Object, e As System.EventArgs) Handles DepartmentNameButton.Click
        'Displasy the department name
        OutputLabel.Text = "Computer Science"
        OutputLabel.ForeColor = Color.Green
        OutputLabel.BackColor = Color.PaleGreen
    End Sub

    Private Sub MascotButton_Click(sender As System.Object, e As System.EventArgs) Handles MascotButton.Click
        'Displasy the school maschot
        OutputLabel.Text = "Duke the Bulldog"
        OutputLabel.ForeColor = Color.CadetBlue
        OutputLabel.BackColor = Color.AliceBlue
    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click
        'Prints the form
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        'Exits the program
        Close()
    End Sub
End Class
