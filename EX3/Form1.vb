Public Class Form1
    Dim M As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Double.TryParse(InputBox("Entrez un nombre entre 1 et 20 :", "Saisie du nombre"), M) _
            OrElse M < 0 OrElse M > 20 Then
            MessageBox.Show("Veuillez entrer un nombre valide entre 1 et 20 !")
            Return
        End If
        If M >= 10 Then
            MessageBox.Show("Admis !!")
            Return
        End If
        If M >= 8 AndAlso M <= 10 Then
            MessageBox.Show(“Rattrapage .")
        End If
        MessageBox.Show(“Ajourné ”)

    End Sub
End Class
