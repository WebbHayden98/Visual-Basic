Public Class Ch5Form
    Private Sub DisplayLabelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplayLabelToolStripMenuItem.Click
        If DisplayLabelToolStripMenuItem.Checked = True Then
            'There is a checkmark, remove it
            DisplayLabelToolStripMenuItem.Checked = False
        Else
            'There is not a checkmark, add one
            DisplayLabelToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FontToolStripMenuItem.Click, FontToolStripMenuItem1.Click
        With FontDialog1
            .ShowDialog()
            DisplayLabel.Font = .Font
            QuantityTextBox.Font = .Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .Color = DisplayLabel.BackColor
            .ShowDialog()
            DisplayLabel.BackColor = .Color
            QuantityTextBox.ForeColor = .Color
        End With
    End Sub

    Private Sub ColorToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ColorToolStripMenuItem1.Click
        With ColorDialog1
            .Color = ForeColor
            .ShowDialog()
            ForeColor = .Color
        End With
    End Sub
End Class
