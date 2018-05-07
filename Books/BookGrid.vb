Public Class BookGrid
    Public SQL As New SQLControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT b.name Название, b.pub_year Год, p.name Издательство,
                           b.translator Переводчик,b.pic_author Иллюстратор,
                           b.comment Примечание, b.author Автор
                           FROM book b, publishing_house p
                           WHERE b.id_pub_house = p.id_pub_house;")
        Else
            SQL.ExecQuery(Query)
        End If

        If SQL.HasException(True) Then Exit Sub

        dgvBooks.DataSource = SQL.DBDT
    End Sub

    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        LoadGrid()
    End Sub

    Private Sub BookGrid_ParentChanged(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class