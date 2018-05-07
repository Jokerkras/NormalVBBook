<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FriendGrid
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
        Me.dvgFriend = New System.Windows.Forms.DataGridView()
        CType(Me.dvgFriend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgFriend
        '
        Me.dvgFriend.AllowUserToAddRows = False
        Me.dvgFriend.AllowUserToDeleteRows = False
        Me.dvgFriend.AllowUserToResizeRows = False
        Me.dvgFriend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgFriend.Location = New System.Drawing.Point(13, 13)
        Me.dvgFriend.Name = "dvgFriend"
        Me.dvgFriend.ReadOnly = True
        Me.dvgFriend.RowTemplate.Height = 24
        Me.dvgFriend.Size = New System.Drawing.Size(705, 430)
        Me.dvgFriend.TabIndex = 0
        '
        'FriendGrid
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(730, 500)
        Me.Controls.Add(Me.dvgFriend)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FriendGrid"
        Me.Text = "FriendGrid"
        CType(Me.dvgFriend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgFriend As DataGridView
End Class
