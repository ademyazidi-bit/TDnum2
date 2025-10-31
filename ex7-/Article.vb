Imports System.Net.Security
Imports System.Runtime.CompilerServices.RuntimeHelpers

Module Articles
    Public Structure Article
        Dim code As Integer
        Dim designation As String
        Dim prix As Double
        Dim quantite As Integer
        Dim Somme As Double

    End Structure
    Public TabArticle(4) As Article


    Public Nxt As Integer = 0
    Public Sub ajouteArticle(A As Article)
        Dim x As Integer = existe(A)

        If x >= 0 Then
            TabArticle(x).quantite += A.quantite
            TabArticle(x).Somme = TabArticle(x).prix * TabArticle(x).quantite
        Else
            If Nxt < TabArticle.Length Then
                A.Somme = A.prix * A.quantite
                TabArticle(Nxt) = A
                Nxt += 1
                
            Else
                MessageBox.Show("Tableau plein . ")
            End If
        End If
    End Sub

    Private Function existe(A As Article) As Integer
        For i As Integer = 0 To Nxt - 1
            If TabArticle(i).code = A.code Then
                Return i
            End If
        Next
        Return -1
    End Function
    Public Function CalculerTotal() As Double
        Dim Total As Double = 0
        For i As Integer = 0 To Nxt - 1
            Total += TabArticle(i).quantite * TabArticle(i).prix

        Next

        Return Total
    End Function

End Module
