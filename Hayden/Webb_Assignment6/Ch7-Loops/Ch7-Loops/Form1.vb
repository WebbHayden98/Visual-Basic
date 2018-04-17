'Program:  Demonstrate single and nested For Next Loops
Public Class Form1

    Private Sub numSquaredButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numSquaredButton.Click
        'single for next loop
        Dim loopIndex As Integer
        Dim square As Integer
        outputListBox.Items.Clear()
        outputListBox.Items.Add("Number     Square")
        For loopIndex = 0 To 100 Step 5
            square = loopIndex ^ 2
            outputListBox.Items.Add(loopIndex.ToString("D3") &
                                    "            " &
(square.ToString("D5")))
        Next
    End Sub

    Private Sub upperLeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upperLeftButton.Click
        'nested for next loop

    End Sub

    Private Sub upperRightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upperRightButton.Click
        'nested for next loop

    End Sub

    Private Sub lowerLeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lowerLeftButton.Click
        'nested for next loop

    End Sub

    Private Sub lowerRightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lowerRightButton.Click
        'nested for next loop

    End Sub
End Class
