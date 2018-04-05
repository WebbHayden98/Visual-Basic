Public Class listForm

    Private Sub listForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        schoolsComboBox.Items.Add("Southwestern Oklahoma State University")
        schoolsComboBox.Items.Add("University of Oklahoma")
        ''write code to add OSU to as 2nd item in list
        schoolsComboBox.Items.Insert(1, "Oklahoma State University")
    End Sub

    Private Sub addMajorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addMajorButton.Click
        'Write code to add major user has typed in text box to to majors combo box
        'Make sure user has entered data to be added; otherwise pop up error message
        Dim itemFoundBoolean As Boolean
        Dim itemIndexInteger As Integer
        With majorComboBox
            If .Text = "" Then
                MessageBox.Show("Must enter a major", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Do Until itemFoundBoolean = True Or itemIndexInteger = .Items.Count
                    If .Text.ToUpper = .Items(itemIndexInteger).ToString.ToUpper Then
                        itemFoundBoolean = True
                    Else
                        itemIndexInteger += 1
                    End If
                Loop
                If itemFoundBoolean = True Then
                    MessageBox.Show("Cannot add duplicate values", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    .Items.Add(.Text)
                End If
            End If
        End With
    End Sub

    Private Sub occupationComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles occupationComboBox.SelectedIndexChanged
        Dim itemSelectedIndexInteger As Integer
        Dim itemCountInteger As Integer
        'write code to store the value of Selected Index property in variable itemSelectedIndexInteger
        itemSelectedIndexInteger = occupationComboBox.SelectedIndex
        'write code to store the Item Count property in variable itemCountIntger
        itemCountInteger = occupationComboBox.Items.Count
        occupationLabel.Text = "You selected item " & itemSelectedIndexInteger.ToString &
            " from the list of " & itemCountInteger.ToString & " items."

    End Sub

    Private Sub fruitListBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles fruitListBox.Enter
        fruitLabel.Text = "Strawberries are GREAT!"
    End Sub

    Private Sub fruitListBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles fruitListBox.Leave

        Dim itemCountInteger As Integer
        'write code using the RemoveAt method to delete the currently chosen item
        'fruitListBox.Items.RemoveAt(fruitListBox.SelectedIndex)
        'comment out above line and write code using Remove method to delete currently chosen item
        fruitListBox.Items.Remove(fruitListBox.Text)
        'write code to store the Item Count property in variable itemCountIntger
        itemCountInteger = fruitListBox.Items.Count
        fruitLabel.Text = "You have " & itemCountInteger & " items to choose from"
        'write code to so nothing is selected in the fruitListBox


    End Sub

    Private Sub clearMajorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearMajorButton.Click
        'Write code to remove all items from the majorComboBox
        majorComboBox.Items.Clear()
    End Sub
End Class
