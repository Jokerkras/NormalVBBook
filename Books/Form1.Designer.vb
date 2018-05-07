<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriendsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PubHouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmBooks, Me.FriendsToolStripMenuItem, Me.GenreToolStripMenuItem, Me.PubHouseToolStripMenuItem, Me.BorrowingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmBooks
        '
        Me.tsmBooks.Name = "tsmBooks"
        Me.tsmBooks.Size = New System.Drawing.Size(61, 24)
        Me.tsmBooks.Text = "Books"
        '
        'FriendsToolStripMenuItem
        '
        Me.FriendsToolStripMenuItem.Name = "FriendsToolStripMenuItem"
        Me.FriendsToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.FriendsToolStripMenuItem.Text = "Friends"
        '
        'GenreToolStripMenuItem
        '
        Me.GenreToolStripMenuItem.Name = "GenreToolStripMenuItem"
        Me.GenreToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.GenreToolStripMenuItem.Text = "Genre"
        '
        'PubHouseToolStripMenuItem
        '
        Me.PubHouseToolStripMenuItem.Name = "PubHouseToolStripMenuItem"
        Me.PubHouseToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.PubHouseToolStripMenuItem.Text = "Pub. House"
        '
        'BorrowingToolStripMenuItem
        '
        Me.BorrowingToolStripMenuItem.Name = "BorrowingToolStripMenuItem"
        Me.BorrowingToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.BorrowingToolStripMenuItem.Text = "Borrowing"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmBooks As ToolStripMenuItem
    Friend WithEvents FriendsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PubHouseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowingToolStripMenuItem As ToolStripMenuItem
End Class
