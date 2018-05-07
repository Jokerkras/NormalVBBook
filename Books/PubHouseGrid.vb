Public Class PubHouseGrid
    Public SQL As New SQLControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT name Название FROM publishing_house;")
        Else
            SQL.ExecQuery(Query)
        End If

        If SQL.HasException(True) Then Exit Sub

        dvgPubHouse.DataSource = SQL.DBDT
    End Sub

    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        LoadGrid()
    End Sub

    Private Sub PubHouseGrid_ParentChanged(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class