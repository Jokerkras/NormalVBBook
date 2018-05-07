<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateBorrow
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BooksDataSet = New Books.BooksDataSet()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookTableAdapter = New Books.BooksDataSetTableAdapters.bookTableAdapter()
        Me.cbBook = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFriend = New System.Windows.Forms.ComboBox()
        Me.BooksDataSet1 = New Books.BooksDataSet1()
        Me.FriendBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FriendTableAdapter = New Books.BooksDataSet1TableAdapters.friendTableAdapter()
        Me.dtpBorrow = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbLost = New System.Windows.Forms.CheckBox()
        Me.cbDamage = New System.Windows.Forms.CheckBox()
        Me.tbComment = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.BooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FriendBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BooksDataSet
        '
        Me.BooksDataSet.DataSetName = "BooksDataSet"
        Me.BooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "book"
        Me.BookBindingSource.DataSource = Me.BooksDataSet
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'cbBook
        '
        Me.cbBook.DataSource = Me.BookBindingSource
        Me.cbBook.DisplayMember = "name"
        Me.cbBook.FormattingEnabled = True
        Me.cbBook.Location = New System.Drawing.Point(132, 12)
        Me.cbBook.Name = "cbBook"
        Me.cbBook.Size = New System.Drawing.Size(219, 24)
        Me.cbBook.TabIndex = 1
        Me.cbBook.ValueMember = "id_book"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Книга :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Друг :"
        '
        'cbFriend
        '
        Me.cbFriend.DataSource = Me.FriendBindingSource
        Me.cbFriend.DisplayMember = "FIO"
        Me.cbFriend.FormattingEnabled = True
        Me.cbFriend.Location = New System.Drawing.Point(132, 57)
        Me.cbFriend.Name = "cbFriend"
        Me.cbFriend.Size = New System.Drawing.Size(219, 24)
        Me.cbFriend.TabIndex = 4
        Me.cbFriend.ValueMember = "id_friend"
        '
        'BooksDataSet1
        '
        Me.BooksDataSet1.DataSetName = "BooksDataSet1"
        Me.BooksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FriendBindingSource
        '
        Me.FriendBindingSource.DataMember = "friend"
        Me.FriendBindingSource.DataSource = Me.BooksDataSet1
        '
        'FriendTableAdapter
        '
        Me.FriendTableAdapter.ClearBeforeFill = True
        '
        'dtpBorrow
        '
        Me.dtpBorrow.Location = New System.Drawing.Point(132, 102)
        Me.dtpBorrow.Name = "dtpBorrow"
        Me.dtpBorrow.Size = New System.Drawing.Size(219, 22)
        Me.dtpBorrow.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Выдал :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Вернул :"
        '
        'dtpReturn
        '
        Me.dtpReturn.Location = New System.Drawing.Point(132, 143)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(219, 22)
        Me.dtpReturn.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Потерял :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Повредил :"
        '
        'cbLost
        '
        Me.cbLost.AutoSize = True
        Me.cbLost.Location = New System.Drawing.Point(333, 181)
        Me.cbLost.Name = "cbLost"
        Me.cbLost.Size = New System.Drawing.Size(18, 17)
        Me.cbLost.TabIndex = 11
        Me.cbLost.UseVisualStyleBackColor = True
        '
        'cbDamage
        '
        Me.cbDamage.AutoSize = True
        Me.cbDamage.Location = New System.Drawing.Point(333, 214)
        Me.cbDamage.Name = "cbDamage"
        Me.cbDamage.Size = New System.Drawing.Size(18, 17)
        Me.cbDamage.TabIndex = 12
        Me.cbDamage.UseVisualStyleBackColor = True
        '
        'tbComment
        '
        Me.tbComment.Location = New System.Drawing.Point(132, 246)
        Me.tbComment.Multiline = True
        Me.tbComment.Name = "tbComment"
        Me.tbComment.Size = New System.Drawing.Size(219, 154)
        Me.tbComment.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Комментарий :"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(247, 413)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(104, 23)
        Me.btnCreate.TabIndex = 15
        Me.btnCreate.Text = "Добавить"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 413)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CreateBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 448)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbComment)
        Me.Controls.Add(Me.cbDamage)
        Me.Controls.Add(Me.cbLost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpReturn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpBorrow)
        Me.Controls.Add(Me.cbFriend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBook)
        Me.Name = "CreateBorrow"
        Me.Text = "CreateBorrow"
        CType(Me.BooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FriendBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BooksDataSet As BooksDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As BooksDataSetTableAdapters.bookTableAdapter
    Friend WithEvents cbBook As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFriend As ComboBox
    Friend WithEvents BooksDataSet1 As BooksDataSet1
    Friend WithEvents FriendBindingSource As BindingSource
    Friend WithEvents FriendTableAdapter As BooksDataSet1TableAdapters.friendTableAdapter
    Friend WithEvents dtpBorrow As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpReturn As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbLost As CheckBox
    Friend WithEvents cbDamage As CheckBox
    Friend WithEvents tbComment As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
End Class
