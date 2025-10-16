Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim etudiant As Etudiant

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim nom As String
        Dim prenom As String
        Dim note As Integer

        nom = TxtNom.Text
        prenom = TxtPrenom.Text
        note = CDbl(TxtNote.Text)
        If nom = "" Then
            MessageBox.Show("veuillez indiquel le nom ")
            Return
        End If
        If prenom = "" Then
            MessageBox.Show("veuillez indiquel le prenom ")
            Return
        End If
        If Not (0 <= note <= 20) Then
            MessageBox.Show("veuillez introduire une note valide ")
            Return

        End If
        Ajouter(etudiant)
        etudiant.Nom = nom
        etudiant.prenom = prenom
        etudiant.note = note




    End Sub
End Class
