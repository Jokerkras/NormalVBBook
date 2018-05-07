<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PubHouseGrid
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
        Me.dvgPubHouse = New System.Windows.Forms.DataGridView()
        CType(Me.dvgPubHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgPubHouse
        '
        Me.dvgPubHouse.AllowUserToAddRows = False
        Me.dvgPubHouse.AllowUserToDeleteRows = False
        Me.dvgPubHouse.AllowUserToResizeRows = False
        Me.dvgPubHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgPubHouse.Location = New System.Drawing.Point(13, 13)
        Me.dvgPubHouse.Name = "dvgPubHouse"
        Me.dvgPubHouse.ReadOnly = True
        Me.dvgPubHouse.RowTemplate.Height = 24
        Me.dvgPubHouse.Size = New System.Drawing.Size(705, 430)
        Me.dvgPubHouse.TabIndex = 0
        '
        'PubHouseGrid
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(730, 500)
        Me.Controls.Add(Me.dvgPubHouse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PubHouseGrid"
        Me.Text = "PubHouseGrid"
        CType(Me.dvgPubHouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgPubHouse As DataGridView
End Class
