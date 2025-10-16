Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Dim A As Double
    Dim B As Double
    Dim S As Double
    Dim D As Double
    Dim P As Double
    Dim Q As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Double.TryParse(InputBox("Entrez le premier nombre :", "Saisie du premier nombre"), A) Then
            MessageBox.Show("Veuillez entrer un nombre valide !!")
            Return
        End If
        If Not Double.TryParse(InputBox("Entrez le deuxième  nombre :", "Saisie du premier nombre"), B) Then
            MessageBox.Show("Veuillez entrer un nombre valide !!")
            Return
        End If
        S = A + B
        D = A - B
        P = A * B
        If B <> 0 Then
            Q = A / B

        Else
            MessageBox.Show("impossible de diviser par zero ! ")
            Return
        End If
        MessageBox.Show("  Somme : " & S & "   différence : " & D & "  produit : " & P & "  quotient : " & Q)

    End Sub
End Class
