Public Class inventoryForm

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeryBoardsDataSet)

    End Sub

    Private Sub inventoryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VeryBoardsDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.VeryBoardsDataSet.Product)

    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class
