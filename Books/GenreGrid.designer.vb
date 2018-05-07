<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenreGrid
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
        Me.dvgGenre = New System.Windows.Forms.DataGridView()
        CType(Me.dvgGenre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgGenre
        '
        Me.dvgGenre.AllowUserToAddRows = False
        Me.dvgGenre.AllowUserToDeleteRows = False
        Me.dvgGenre.AllowUserToResizeRows = False
        Me.dvgGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgGenre.Location = New System.Drawing.Point(12, 12)
        Me.dvgGenre.Name = "dvgGenre"
        Me.dvgGenre.ReadOnly = True
        Me.dvgGenre.RowTemplate.Height = 24
        Me.dvgGenre.Size = New System.Drawing.Size(705, 430)
        Me.dvgGenre.TabIndex = 0
        '
        'GenreGrid
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(730, 500)
        Me.Controls.Add(Me.dvgGenre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GenreGrid"
        Me.Text = "GenreGrid"
        CType(Me.dvgGenre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgGenre As DataGridView
End Class
