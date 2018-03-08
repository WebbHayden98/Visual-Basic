'Program Name:     Vintage Tours Payroll
'Programmer Name:
'Date:
Public Class payrollForm

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LogoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoToolStripMenuItem.Click
        If LogoToolStripMenuItem.Checked = True Then
            LogoToolStripMenuItem.Checked = False
            logoPictureBox.Visible = False
        Else : LogoToolStripMenuItem.Checked = False
            LogoToolStripMenuItem.Checked = True
            logoPictureBox.Visible = True

        End If
    End Sub
End Class
