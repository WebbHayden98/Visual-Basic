Public Class ch5Form

    Private Sub DisplayLabelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayLabelToolStripMenuItem.Click
        If DisplayLabelToolStripMenuItem.Checked Then
            'There is a checkmark,  remove it
            DisplayLabelToolStripMenuItem.Checked = False
            titleLabel.Visible = False
        Else
            'There is not a checkmark, put it there
            DisplayLabelToolStripMenuItem.Checked = True
            titleLabel.Visible = True
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click, FontToolStripMenuItem1.Click
        With FontDialog1
            .Font = averageLabel.Font
            .ShowDialog()
            averageLabel.Font = .Font
            seriesLabel.Font = .Font
            handicapLabel.Font = .Font
            highGameLabel.Font = .Font
            game1TextBox.Font = .Font
            game2TextBox.Font = .Font
            game3TextBox.Font = .Font
            game1TextBox.Focus()
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Dim inputColor As Color
        inputColor = game1TextBox.ForeColor
        With ColorDialog1
            'Call a procedure named SelectColor 
            SelectColor(inputColor)
            game1TextBox.ForeColor = .Color
            game2TextBox.ForeColor = .Color
            game3TextBox.ForeColor = .Color
        End With
    End Sub

    Private Sub ColorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem1.Click
        Dim originalColor As Color
        originalColor = averageLabel.ForeColor
        With ColorDialog1
            'Call a procedure named SelectColor
            SelectColor(originalColor)
            averageLabel.ForeColor = .Color
            seriesLabel.ForeColor = .Color
            handicapLabel.ForeColor = .Color
            highGameLabel.ForeColor = .Color
        End With
    End Sub
    'Create a procedure named SelectColor whose purpose is to pop up the color dialog box
    Private Sub SelectColor(incomingColor As Color)
        With ColorDialog1
            .Color = incomingColor
            .ShowDialog()
        End With
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

  
    Private Sub CalcToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcToolStripMenuItem1.Click
        Dim AverageDecimal, HandicapDecimal As Decimal
        Dim SeriesInteger, Game1Integer, Game2Integer, Game3Integer As Integer
        Dim HighGameString As String = ""

        Try
            Game1Integer = Integer.Parse(game1TextBox.Text)
            Game2Integer = Integer.Parse(game2TextBox.Text)
            Game3Integer = Integer.Parse(game3TextBox.Text)
            'Perform all calculations by calling functions
            AverageDecimal = FindAverage(Game1Integer, Game2Integer, Game3Integer)
            SeriesInteger = FindSeries(Game1Integer, Game2Integer, Game3Integer)
            HighGameString = FindHighGame(Game1Integer, Game2Integer, Game3Integer)
            HandicapDecimal = FindHandicap(Game1Integer, Game2Integer, Game3Integer)

            'Display formatted output
            averageLabel.Text = AverageDecimal.ToString("N1")
            highGameLabel.Text = HighGameString
            seriesLabel.Text = SeriesInteger.ToString("N0")
            handicapLabel.Text = HandicapDecimal.ToString("N1")

        Catch ex As FormatException
            MessageBox.Show("Please enter three numeric scores", "Missing Data", MessageBoxButtons.OK)
        End Try
    End Sub
    'Create a function named FindAverage which will return the average of the three games scores
    Private Function FindAverage(score1 As Integer, score2 As Integer, score3 As Integer) As Decimal
        Return ((score1 + score2 + score3) / 3)
    End Function
    'Create a function named FindSeries which will return the sum of the three game scores
    Private Function FindSeries(score1 As Integer, score2 As Integer, score3 As Integer) As Integer
        Return (score1 + score2 + score3)
    End Function
    'Create a function named FindHighGame which will return the game number as a string of the highest game in the series
    Private Function FindHighGame(game1 As Integer, game2 As Integer, game3 As Integer) As String
        If game1 > game2 And game1 > game3 Then
            Return "1"
        ElseIf game2 > game1 And game2 > game3 Then
            Return "2"
        ElseIf game3 > game1 And game3 > game2 Then
            Return "3"
        Else
            Return "Tie"
        End If
    End Function
    'Create a function named FindHandicap which will return a bowler's handicap.  
    Private Function FindHandicap(game1 As Integer, game2 As Integer, game3 As Integer) As Decimal

        'The handicap is calculated by subtracting the bowler's average from 200 and multiplying by .8
        Return ((200 - FindAverage(game1, game2, game3)) * 0.8)
    End Function

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        game1TextBox.Clear()
        game2TextBox.Clear()
        game3TextBox.Clear()
        averageLabel.Text = String.Empty
        highGameLabel.Text = String.Empty
        seriesLabel.Text = String.Empty
        handicapLabel.Text = String.Empty
    End Sub

End Class
