Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim etudiant As Etudiant

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim nom As String
        Dim prenom As String
        Dim note As Integer
        Dim test = True


        nom = TxtNom.Text
        prenom = TxtPrenom.Text
        note = CDbl(TxtNote.Text)
        ErrorProvider1.Clear()
        nom = TxtNom.Text.Trim()
        prenom = TxtPrenom.Text.Trim()
        note = TxtNote.Text.Trim()

        If Existe(nom) Then
            ErrorProvider1.SetError(TxtNom, "veillez indiquer le nom .")
            test = False
            Return


        End If
        If nom = "" Then
            ErrorProvider1.SetError(TxtNom, "veillez indiquer le nom .")
            test = False
            Return
        End If
        If prenom = "" Then
            ErrorProvider1.SetError(TxtPrenom, "veillez indiquer le Prenom .")
            test = False
            Return
        End If
        If Not (0 <= note <= 20) Then
            ErrorProvider1.SetError(TxtNote, "veillez indiquer le note .")
            test = False

            Return

        End If
        If test Then
            etudiant.Nom = nom
            etudiant.Prenom = prenom
            etudiant.Note = note
            Ajouter(etudiant)
        End If





    End Sub

    Private Sub BtnAff_Click(sender As Object, e As EventArgs) Handles BtnAff.Click
        dgvListeEtudians.Rows.Clear()
        If listeEtudiants.Count = 0 Then
            MessageBox.Show("aucun Etudiant entregistre . ", "Information")
            Exit Sub
        End If
        For Each et As Etudiant In listeEtudiants
            dgvListeEtudians.Rows.Add(et.Nom, et.Prenom, et.Note)
        Next
    End Sub

    Private Sub TxtNote_TextChanged(sender As Object, e As EventArgs) Handles TxtNote.TextChanged

    End Sub

    Private Sub TxtNote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNote.KeyPress
        MessageBox.Show("vous avez cliquez " & e.KeyChar)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

            e.Handled = True
        End If
    End Sub

    Private Sub dgvListeEtudians_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListeEtudians.CellContentClick

    End Sub

    Private Sub BtnAnu_Click(sender As Object, e As EventArgs) Handles BtnAnu.Click
        TxtNote.Text = ""
        TxtPrenom.Text = ""
        TxtNom.Text = ""

    End Sub
End Class
