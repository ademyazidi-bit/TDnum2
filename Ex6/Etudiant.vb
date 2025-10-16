Module Etudiants
    Public Structure Etudiant
        Public Nom As String
        Public Prenom As String
        Public Note As Double
    End Structure

    Public listeEtudiants As New List(Of Etudiant)

    Public Sub Ajouter(E As Etudiant)
        listeEtudiants.Add(E)
        MessageBox.Show("Ajouté avec succès ! Nombre total : " & listeEtudiants.Count())
    End Sub

    Public Function Existe(ch As String) As Boolean
        For Each et As Etudiant In listeEtudiants
            If et.Nom = ch Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
