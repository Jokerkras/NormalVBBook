Public Class Form1

    Private Sub tsmBooks_Click(sender As Object, e As EventArgs) Handles tsmBooks.Click
        Me.MdiChildren.ToList.ForEach(Sub(f) f.Close())
        Dim bookGrid As New BookGrid
        bookGrid.MdiParent = Me
        bookGrid.Show()
    End Sub

    Private Sub FriendsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FriendsToolStripMenuItem.Click
        Me.MdiChildren.ToList.ForEach(Sub(f) f.Close())
        Dim friendGrid As New FriendGrid
        friendGrid.MdiParent = Me
        friendGrid.Show()
    End Sub

    Private Sub GenreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenreToolStripMenuItem.Click
        Me.MdiChildren.ToList.ForEach(Sub(f) f.Close())
        Dim genreGrid As New GenreGrid
        genreGrid.MdiParent = Me
        GenreGrid.Show()
    End Sub

    Private Sub PubHouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PubHouseToolStripMenuItem.Click
        Me.MdiChildren.ToList.ForEach(Sub(f) f.Close())
        Dim pubHouseGrid As New PubHouseGrid
        pubHouseGrid.MdiParent = Me
        pubHouseGrid.Show()
    End Sub

    Private Sub BorrowingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowingToolStripMenuItem.Click
        Me.MdiChildren.ToList.ForEach(Sub(f) f.Close())
        Dim borrowingGrid As New BorrowingGrid
        borrowingGrid.MdiParent = Me
        borrowingGrid.Show()
    End Sub
End Class
