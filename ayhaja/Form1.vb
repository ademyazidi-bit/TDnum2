Imports System.DirectoryServices.ActiveDirectory

Public Class Form1
    Private Sub frmAjoutPatient(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today.ToLongDateString()
    End Sub

    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles BtnAjou.Click
        Dim P As New Patient
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
        If String.IsNullOrWhiteSpace(TxtNom.Text) Then
            ErrorProvider.SetError(TxtNom, "Nom Invalide")
            Return
        End If
        If String.IsNullOrWhiteSpace(TxtPrenom.Text) Then
            ErrorProvider.SetError(TxtPrenom, "Nom Invalide")
            Return
        End If
        age = CInt(NumAge.Text)
        P.nom = TxtNom.Text
        P.prenom = TxtPrenom.Text
        P.age = NumAge.Text
        AjouterPAtient(P)
        init()
        MAj_DGV()

    End Sub
    Private Sub init()
        NumAge.ResetText()
        TxtNom.ResetText()
        TxtPrenom.ResetText()
    End Sub
    Private Sub MAj_DGV()
        DataGridView2.Rows.Clear()
        For Each p As Patient In listePatients
            DataGridView2.Rows.Add(p.code, p.nom, p.prenom, p.age)
        Next
    End Sub
End Class
