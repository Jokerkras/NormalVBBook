Public Class CreateBorrow

    Public SQL As New SQLControl

    Public Sub CreateBorrowElem(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("Insert into borrowing
                           values (
                                '" & dtpBorrow.Value.ToString & "',
                                '" & dtpReturn.Value.ToString & "',
                                '" & tbComment.Text & "',
                                " & cbBook.SelectedValue.ToString() & ",
                                " & cbFriend.SelectedValue.ToString() & ",
                                " & If(cbLost.Checked, "'Да'", "'Нет'") & ",
                                " & If(cbDamage.Checked, "'Да'", "'Нет'") & ");")
        Else
            SQL.ExecQuery(Query)
        End If

        If SQL.HasException(True) Then Exit Sub
    End Sub

    Private Sub CreateBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BooksDataSet1._friend". При необходимости она может быть перемещена или удалена.
        Me.FriendTableAdapter.Fill(Me.BooksDataSet1._friend)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BooksDataSet.book". При необходимости она может быть перемещена или удалена.
        Me.BookTableAdapter.Fill(Me.BooksDataSet.book)

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        CreateBorrowElem()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class