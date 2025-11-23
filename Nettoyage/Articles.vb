Module Articles

    Public Structure Article
        Dim code As String
        Dim vetement As String
        Dim typeNettoyage As String
        Dim nombre As Integer
        Public supplement As List(Of Boolean)

        Public Sub initArticle()
            supplement = New List(Of Boolean)({False, False})
        End Sub
    End Structure

    Public listeArticles As New List(Of Article)

    Public Sub AjouterArticle(A As Article)
        If A.vetement.Length >= 3 Then
            A.code = A.vetement.Substring(1, 2) & "_" & listeArticles.Count
        Else
            A.code = A.vetement & "_" & listeArticles.Count
        End If
        listeArticles.Add(A)
    End Sub
End Module
