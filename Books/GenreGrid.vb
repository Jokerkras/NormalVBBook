Public Class GenreGrid
    Public SQL As New SQLControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT g1.name Название, g2.name Родительский_жанр
                           FROM genre g1, genre g2
                           WHERE g1.id_parent_genre = g2.id_genre;")
        Else
            SQL.ExecQuery(Query)
        End If

        If SQL.HasException(True) Then Exit Sub

        dvgGenre.DataSource = SQL.DBDT
    End Sub

    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        LoadGrid()
    End Sub

    Private Sub GenreGrid_ParentChanged(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub
End Class