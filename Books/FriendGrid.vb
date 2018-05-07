Public Class FriendGrid
    Public SQL As New SQLControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT f.FIO ФИО, f.phone_number Телефон, f.social_number СоцНомер,
                           f.email email, f.comment комментарий
                           FROM friend f;")
        Else
            SQL.ExecQuery(Query)
        End If

        If SQL.HasException(True) Then Exit Sub

        dvgFriend.DataSource = SQL.DBDT
    End Sub

    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        LoadGrid()
    End Sub

    Private Sub FriendGrid_ParentChanged(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub
End Class