<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detailsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim PublisherLabel As System.Windows.Forms.Label
        Dim Subject_CodeLabel As System.Windows.Forms.Label
        Dim Shelf_LocationLabel As System.Windows.Forms.Label
        Dim FictionLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Me._RnrBooks_1_DataSet = New WindowsApplication1._RnrBooks_1_DataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New WindowsApplication1._RnrBooks_1_DataSetTableAdapters.BooksTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._RnrBooks_1_DataSetTableAdapters.TableAdapterManager()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.Subject_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Shelf_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.FictionCheckBox = New System.Windows.Forms.CheckBox()
        Me.ISBNComboBox = New System.Windows.Forms.ComboBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        TitleLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        PublisherLabel = New System.Windows.Forms.Label()
        Subject_CodeLabel = New System.Windows.Forms.Label()
        Shelf_LocationLabel = New System.Windows.Forms.Label()
        FictionLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        CType(Me._RnrBooks_1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_RnrBooks_1_DataSet
        '
        Me._RnrBooks_1_DataSet.DataSetName = "_RnrBooks_1_DataSet"
        Me._RnrBooks_1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me._RnrBooks_1_DataSet
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._RnrBooks_1_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(49, 80)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 3
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(133, 77)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(141, 20)
        Me.TitleTextBox.TabIndex = 4
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(49, 106)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(41, 13)
        AuthorLabel.TabIndex = 5
        AuthorLabel.Text = "Author:"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Author", True))
        Me.AuthorTextBox.Location = New System.Drawing.Point(133, 103)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(141, 20)
        Me.AuthorTextBox.TabIndex = 6
        '
        'PublisherLabel
        '
        PublisherLabel.AutoSize = True
        PublisherLabel.Location = New System.Drawing.Point(49, 132)
        PublisherLabel.Name = "PublisherLabel"
        PublisherLabel.Size = New System.Drawing.Size(53, 13)
        PublisherLabel.TabIndex = 7
        PublisherLabel.Text = "Publisher:"
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Publisher", True))
        Me.PublisherTextBox.Location = New System.Drawing.Point(133, 129)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(141, 20)
        Me.PublisherTextBox.TabIndex = 8
        '
        'Subject_CodeLabel
        '
        Subject_CodeLabel.AutoSize = True
        Subject_CodeLabel.Location = New System.Drawing.Point(49, 158)
        Subject_CodeLabel.Name = "Subject_CodeLabel"
        Subject_CodeLabel.Size = New System.Drawing.Size(74, 13)
        Subject_CodeLabel.TabIndex = 9
        Subject_CodeLabel.Text = "Subject Code:"
        '
        'Subject_CodeTextBox
        '
        Me.Subject_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Subject_Code", True))
        Me.Subject_CodeTextBox.Location = New System.Drawing.Point(133, 155)
        Me.Subject_CodeTextBox.Name = "Subject_CodeTextBox"
        Me.Subject_CodeTextBox.Size = New System.Drawing.Size(141, 20)
        Me.Subject_CodeTextBox.TabIndex = 10
        '
        'Shelf_LocationLabel
        '
        Shelf_LocationLabel.AutoSize = True
        Shelf_LocationLabel.Location = New System.Drawing.Point(49, 184)
        Shelf_LocationLabel.Name = "Shelf_LocationLabel"
        Shelf_LocationLabel.Size = New System.Drawing.Size(78, 13)
        Shelf_LocationLabel.TabIndex = 11
        Shelf_LocationLabel.Text = "Shelf Location:"
        '
        'Shelf_LocationTextBox
        '
        Me.Shelf_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Shelf_Location", True))
        Me.Shelf_LocationTextBox.Location = New System.Drawing.Point(133, 181)
        Me.Shelf_LocationTextBox.Name = "Shelf_LocationTextBox"
        Me.Shelf_LocationTextBox.Size = New System.Drawing.Size(141, 20)
        Me.Shelf_LocationTextBox.TabIndex = 12
        '
        'FictionLabel
        '
        FictionLabel.AutoSize = True
        FictionLabel.Location = New System.Drawing.Point(49, 212)
        FictionLabel.Name = "FictionLabel"
        FictionLabel.Size = New System.Drawing.Size(41, 13)
        FictionLabel.TabIndex = 13
        FictionLabel.Text = "Fiction:"
        '
        'FictionCheckBox
        '
        Me.FictionCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BooksBindingSource, "Fiction", True))
        Me.FictionCheckBox.Location = New System.Drawing.Point(133, 207)
        Me.FictionCheckBox.Name = "FictionCheckBox"
        Me.FictionCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.FictionCheckBox.TabIndex = 14
        Me.FictionCheckBox.Text = "CheckBox1"
        Me.FictionCheckBox.UseVisualStyleBackColor = True
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(49, 53)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 14
        ISBNLabel.Text = "ISBN:"
        '
        'ISBNComboBox
        '
        Me.ISBNComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "ISBN", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.ISBNComboBox.DataSource = Me.BooksBindingSource
        Me.ISBNComboBox.DisplayMember = "ISBN"
        Me.ISBNComboBox.FormattingEnabled = True
        Me.ISBNComboBox.Location = New System.Drawing.Point(133, 50)
        Me.ISBNComboBox.Name = "ISBNComboBox"
        Me.ISBNComboBox.Size = New System.Drawing.Size(141, 21)
        Me.ISBNComboBox.TabIndex = 15
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(221, 229)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(61, 26)
        Me.ExitButton.TabIndex = 16
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'detailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 259)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(ISBNLabel)
        Me.Controls.Add(Me.ISBNComboBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(PublisherLabel)
        Me.Controls.Add(Me.PublisherTextBox)
        Me.Controls.Add(Subject_CodeLabel)
        Me.Controls.Add(Me.Subject_CodeTextBox)
        Me.Controls.Add(Shelf_LocationLabel)
        Me.Controls.Add(Me.Shelf_LocationTextBox)
        Me.Controls.Add(FictionLabel)
        Me.Controls.Add(Me.FictionCheckBox)
        Me.Name = "detailsForm"
        Me.Text = "R n' R Books Detail View"
        CType(Me._RnrBooks_1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _RnrBooks_1_DataSet As WindowsApplication1._RnrBooks_1_DataSet
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As WindowsApplication1._RnrBooks_1_DataSetTableAdapters.BooksTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._RnrBooks_1_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Subject_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Shelf_LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FictionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ISBNComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
