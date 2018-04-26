'Program:  Demonstrate single and nested For Next Loops
Public Class Form1

    Private Sub numSquaredButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numSquaredButton.Click
        Dim square As Integer
        Dim ItemIndex As Integer


        With outputListBox
            .Items.Clear()
            .Items.Add("Number     Square")
            For ItemIndex = 0 To 100 Step 5
                square = ItemIndex ^ 2
                .Items.Add(ItemIndex.ToString("D3") & "            " & square.ToString("D5"))
            Next
        End With
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
