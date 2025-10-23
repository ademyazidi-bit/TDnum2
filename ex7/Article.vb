Module Articles
    Public Structure Article
        Dim code As Integer
        Dim designation As String
        Dim prix As Double
        Dim quantite As Integer
    End Structure

    Public listeArticles As New List(Of article)
    Public Sub ajouteArticle(A As article)
        Dim x As Integer = existe(A)
        If x >= 0 Then
            A.quantite = listeArticles(x).quantite + A.quantite
            listeArticles(x) = A
        Else
            listeArticles.Add(A)

        End If

    End Sub
    Private Function existe(A As Article) As Integer
        For i As Integer = 0 To listeArticles.Count - 1
            If listeArticles(i).code = A.code Then
                Return i
            End If
        Next
        Return -1
    End Function

End Module
