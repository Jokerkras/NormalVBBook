<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBook
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
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.mtbpub_year = New System.Windows.Forms.MaskedTextBox()
        Me.cbPubHouse = New System.Windows.Forms.ComboBox()
        Me.Ph = New Books.ph()
        Me.PublishinghouseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Publishing_houseTableAdapter = New Books.phTableAdapters.publishing_houseTableAdapter()
        Me.tbPic = New System.Windows.Forms.TextBox()
        Me.tbTranslator = New System.Windows.Forms.TextBox()
        Me.tbAuthor = New System.Windows.Forms.TextBox()
        Me.tbComment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.Ph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublishinghouseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(142, 13)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(230, 22)
        Me.tbName.TabIndex = 0
        '
        'mtbpub_year
        '
        Me.mtbpub_year.Location = New System.Drawing.Point(142, 55)
        Me.mtbpub_year.Mask = "0000"
        Me.mtbpub_year.Name = "mtbpub_year"
        Me.mtbpub_year.Size = New System.Drawing.Size(230, 22)
        Me.mtbpub_year.TabIndex = 1
        Me.mtbpub_year.ValidatingType = GetType(Integer)
        '
        'cbPubHouse
        '
        Me.cbPubHouse.DataSource = Me.PublishinghouseBindingSource
        Me.cbPubHouse.DisplayMember = "name"
        Me.cbPubHouse.FormattingEnabled = True
        Me.cbPubHouse.Location = New System.Drawing.Point(142, 96)
        Me.cbPubHouse.Name = "cbPubHouse"
        Me.cbPubHouse.Size = New System.Drawing.Size(230, 24)
        Me.cbPubHouse.TabIndex = 2
        Me.cbPubHouse.ValueMember = "id_pub_house"
        '
        'Ph
        '
        Me.Ph.DataSetName = "ph"
        Me.Ph.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PublishinghouseBindingSource
        '
        Me.PublishinghouseBindingSource.DataMember = "publishing_house"
        Me.PublishinghouseBindingSource.DataSource = Me.Ph
        '
        'Publishing_houseTableAdapter
        '
        Me.Publishing_houseTableAdapter.ClearBeforeFill = True
        '
        'tbPic
        '
        Me.tbPic.Location = New System.Drawing.Point(142, 139)
        Me.tbPic.Name = "tbPic"
        Me.tbPic.Size = New System.Drawing.Size(230, 22)
        Me.tbPic.TabIndex = 3
        '
        'tbTranslator
        '
        Me.tbTranslator.Location = New System.Drawing.Point(142, 180)
        Me.tbTranslator.Name = "tbTranslator"
        Me.tbTranslator.Size = New System.Drawing.Size(230, 22)
        Me.tbTranslator.TabIndex = 4
        '
        'tbAuthor
        '
        Me.tbAuthor.Location = New System.Drawing.Point(142, 224)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.Size = New System.Drawing.Size(230, 22)
        Me.tbAuthor.TabIndex = 5
        '
        'tbComment
        '
        Me.tbComment.Location = New System.Drawing.Point(142, 265)
        Me.tbComment.Multiline = True
        Me.tbComment.Name = "tbComment"
        Me.tbComment.Size = New System.Drawing.Size(230, 149)
        Me.tbComment.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Название :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Год публикации :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Издательство :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Иллюстратор :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Переводчик :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Автор :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Примечание :"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(268, 428)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Добавить"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 428)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 463)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbComment)
        Me.Controls.Add(Me.tbAuthor)
        Me.Controls.Add(Me.tbTranslator)
        Me.Controls.Add(Me.tbPic)
        Me.Controls.Add(Me.cbPubHouse)
        Me.Controls.Add(Me.mtbpub_year)
        Me.Controls.Add(Me.tbName)
        Me.Name = "AddBook"
        Me.Text = "AddBook"
        CType(Me.Ph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublishinghouseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbName As TextBox
    Friend WithEvents mtbpub_year As MaskedTextBox
    Friend WithEvents cbPubHouse As ComboBox
    Friend WithEvents Ph As ph
    Friend WithEvents PublishinghouseBindingSource As BindingSource
    Friend WithEvents Publishing_houseTableAdapter As phTableAdapters.publishing_houseTableAdapter
    Friend WithEvents tbPic As TextBox
    Friend WithEvents tbTranslator As TextBox
    Friend WithEvents tbAuthor As TextBox
    Friend WithEvents tbComment As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
End Class
