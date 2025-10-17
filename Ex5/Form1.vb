Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Form1

    Public Function Carre(R As Double) As Double
        Return R * R

    End Function





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Double
        If Not Double.TryParse(InputBox("Entrez un nombre :"), X) Then
            MessageBox.Show("Veuillez entrer un nombre valide !")
            Return
        End If
        Dim Res As Double = Carre(X)
        MessageBox.Show("Le carré de " & X & " est : " & Res, "Résultat")

    End Sub
End Class


