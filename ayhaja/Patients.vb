Module Patients
    Public Structure Patient
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
    End Structure
    Public listePatients As New List(Of Patient)
    Public Sub AjouterPAtient(p As Patient)
        If listePatients Is Nothing Then
            listePatients = New List(Of Patient)
        End If
        listePatients.Add(p)
    End Sub

End Module
