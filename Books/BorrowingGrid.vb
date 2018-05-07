Public Class BorrowingGrid
    Public SQL As New SQLControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT bo.name Книга, fr.FIO Друг, br.borrow_date Дата,
                           br.return_date Возврат, br.comment Комментарий,
                           br.is_lost Потерял, br.is_damaged Испортил
                           FROM borrowing br, book bo, friend fr
                           WHERE br.id_book = bo.id_book AND br.id_friend = fr.id_friend;")
        Else
            SQL.ExecQuery(Query)
        End If

        If SQL.HasException(True) Then Exit Sub

        dgvBorrow.DataSource = SQL.DBDT
    End Sub

    Private Sub BorrowingGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        LoadGrid()
    End Sub

    Private Sub BorrowingGrid_ParentChanged(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        CreateBorrow.Show()
    End Sub
End Class