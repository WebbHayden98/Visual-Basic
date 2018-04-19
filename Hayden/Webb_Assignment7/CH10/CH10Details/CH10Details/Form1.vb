Public Class detailsForm

    Private Sub BooksBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._RnrBooks_1_DataSet)

    End Sub


    Private Sub BooksBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._RnrBooks_1_DataSet)

    End Sub

    Private Sub detailsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_RnrBooks_1_DataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me._RnrBooks_1_DataSet.Books)

    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class
