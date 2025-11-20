Imports System.Runtime.CompilerServices.RuntimeHelpers

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
            MessageBox.Show("Désignation manquante !", "Erreur")
            test = False
        Else
            A.designation = TxtDes.Text
        End If
        If Double.TryParse(TxtPrix.Text, prix) AndAlso prix > 0 Then
            A.prix = prix
        Else
            MessageBox.Show("Prix invalide !")
            test = False
        End If
        If Integer.TryParse(TxtQt.Text, quantite) And quantite > 0 Then
            A.quantite = quantite
            A.code = code
        Else
            MessageBox.Show("Quantité invalide !", "Erreur")
            test = False
        End If
        If test = True Then
            ajouteArticle(A)
            MessageBox.Show(" ajouter avec succces")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAnn_Click(sender As Object, e As EventArgs) Handles BtnAnn.Click
        TxtCode.Text = ""
        TxtDes.Text = ""
        TxtPrix.Text = ""
        TxtQt.Text = ""

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub

    Private Sub BtnAff_Click(sender As Object, e As EventArgs) Handles BtnAff.Click
        Dim A As Article
        DataGridView.Rows.Clear()
        If Nxt = 0 Then
            MessageBox.Show("Aucun article enregistré.", "Information")
            Return
        End If
        Dim Total As Double = CalculerTotal()

        For i As Integer = 0 To Nxt - 1
            Dim et = TabArticle(i)

            DataGridView.Rows.Add(et.code, et.designation, et.prix, et.quantite, et.Somme, Total)
        Next
        Min()


    End Sub

    Private Sub BtnMax_Click(sender As Object, e As EventArgs) Handles BtnMax.Click
        Max()
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Min()
    End Sub
End Class
