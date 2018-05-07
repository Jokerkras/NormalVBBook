Public Class AddBook
    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Ph.publishing_house". При необходимости она может быть перемещена или удалена.
        Me.Publishing_houseTableAdapter.Fill(Me.Ph.publishing_house)

    End Sub
End Class