Imports System.Net.Security

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim Phr As String
    Private Sub TxtPh_TextChanged(sender As Object, e As EventArgs) Handles TxtPh.TextChanged
        Phr = TxtPh.Text

    End Sub

    Private Sub BtnMaj_Click(sender As Object, e As EventArgs) Handles BtnMaj.Click
        If String.IsNullOrEmpty(Phr) Then
            MessageBox.Show("Veillez Entrez Une Phrase Valide ! ")
            Return
        End If
        If TxtPh.Text = TxtPh.Text.ToUpper() Then
            MessageBox.Show("La phrase est déjà en majuscules.")
        Else
            TxtRes.Text = TxtPh.Text.ToUpper()
        End If
    End Sub

    Private Sub TxtRes_TextChanged(sender As Object, e As EventArgs) Handles TxtRes.TextChanged

    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        If String.IsNullOrEmpty(Phr) Then
            MessageBox.Show("Veillez Entrez Une Phrase Valide ! ")
            Return
        End If
        If TxtPh.Text = TxtPh.Text.ToLower() Then
            MessageBox.Show("La phrase est déjà en minuscules.")
        Else
            TxtRes.Text = TxtPh.Text.ToLower()
        End If
    End Sub

    Private Sub BtnLon_Click(sender As Object, e As EventArgs) Handles BtnLon.Click
        If String.IsNullOrEmpty(Phr) Then
            MessageBox.Show("Veillez Entrez Une Phrase Valide ! ")
            Return
        End If
        TxtRes.Text = TxtPh.Text.Length


    End Sub

    Private Sub BtnRem_Click(sender As Object, e As EventArgs) Handles BtnRem.Click
        If String.IsNullOrEmpty(Phr) Then
            MessageBox.Show("Veillez Entrez Une Phrase Valide ! ")
            Return
        End If
        Dim ancien As String = InputBox("Entrer le mot a remplacer : ")
        Dim nouveau As String = InputBox("Entrer le nouveau mot : ")
        TxtRes.Text = TxtPh.Text.Replace(ancien, nouveau)
    End Sub

    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
        If String.IsNullOrEmpty(Phr) Then
            MessageBox.Show("Veillez Entrez Une Valeur Valide ! ")
            Return

        Else
            Dim mots() As String = TxtPh.Text.Split(" "c)
            TxtRes.Text = String.Join(" ", mots)

        End If
    End Sub

    Private Sub BtnRes_Click(sender As Object, e As EventArgs) Handles BtnRes.Click
        TxtPh.Text = ""
        TxtRes.Text = ""
    End Sub
End Class
