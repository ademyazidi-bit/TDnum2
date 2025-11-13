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
End Module
