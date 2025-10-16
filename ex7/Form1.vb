Public Class Form1
    Private Sub BtnAjou_click(sender As Object, e As EventArgs) Handles BtnAjou.Click
        Dim code As Integer
        Dim designation As String
        Dim prix As Double
        Dim quantite As Integer
        Dim A As Article
        Dim test As Boolean = True
        If Integer.TryParse(TxtCode.Text, code) Then
            A.code = code
        Else
            MessageBox.Show("Code article erronne !", "Erreur")
            test = False
        End If
        If TxtDes.Text = "" Then
            MessageBox.Show("Code article erronne !", "Erreur")
            test = False
        Else
            A.designation = TxtDes.Text
            Return
        End If
        If Integer.TryParse(TxtQt.Text, quantite) And quantite > 0 Then
            A.quantite = quantite
            A.code = code
        Else
            MessageBox.Show("Code article erronne !", "Erreur")
            test = False
        End If
        If test = True Then ajouteArticle(A)
        MessageBox.Show(" ajouter avec succces")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
