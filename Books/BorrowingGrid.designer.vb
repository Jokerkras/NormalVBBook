<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowingGrid
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
        Me.dgvBorrow = New System.Windows.Forms.DataGridView()
        Me.btnCreate = New System.Windows.Forms.Button()
        CType(Me.dgvBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBorrow
        '
        Me.dgvBorrow.AllowUserToAddRows = False
        Me.dgvBorrow.AllowUserToDeleteRows = False
        Me.dgvBorrow.AllowUserToResizeRows = False
        Me.dgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBorrow.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrow.Location = New System.Drawing.Point(12, 12)
        Me.dgvBorrow.Name = "dgvBorrow"
        Me.dgvBorrow.RowTemplate.Height = 24
        Me.dgvBorrow.Size = New System.Drawing.Size(705, 430)
        Me.dgvBorrow.TabIndex = 0
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(603, 448)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(113, 40)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "Добавить"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'BorrowingGrid
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(730, 500)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.dgvBorrow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BorrowingGrid"
        Me.Text = "BorrowingGrid"
        CType(Me.dgvBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBorrow As DataGridView
    Friend WithEvents btnCreate As Button
End Class
