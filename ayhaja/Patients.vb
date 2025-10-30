Module Patients
    Public Structure Patient
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
    End Structure
    Public listePatients As List(Of Patient)
    Public Function AjouterPAtient(p)
        p.code = listePatients.Count


    End Function
End Module
