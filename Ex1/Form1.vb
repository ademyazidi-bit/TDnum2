Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32.System

Public Class Form1
    Dim N As String
    Dim A As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        N = (InputBox("entrez le nom :  "))
        If String.IsNullOrWhiteSpace(N) Then
            MessageBox.Show("Entrez un nom ! ")
            Return
        End If

        A = CInt(InputBox("entrez l'Age : "))
        If Not Integer.TryParse(InputBox("Entrez l'age"), A) Then
            MessageBox.Show("L'âge doit être un nombre !")
            Return
        End If

        MessageBox.Show("Bonjour " & N & ", vous avez " & A & " ans.", "Message")
            Return


    End Sub
End Class
