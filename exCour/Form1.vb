Imports System.DirectoryServices.ActiveDirectory

Public Class Form1
    Private Sub frmAjoutPatient(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today.ToLongDateString()
    End Sub

    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged

    End Sub

    Private Sub BtnAjou_click(sender As Object, e As EventArgs) Handles BtnAjou.Click
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
        If Not (0 <= note <= 100) Then
            ErrorProvider1.SetError(TxtNote, "veillez indiquer le note .")
            Return
            age = CInt(NumAge.Text)
            P.nom = TxtNom.Text
            P.prenom = TxtPrenom.Text
            P.age = NumAge.Text
            AjouterPAtient(P)
            init()
            MAj_DGV()

    End Sub
    Private Sub TxtNon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNom.KeyPress
        If Not Char.IsLetter(e.keychar) AndAlso e.KeyChar <> " " Then

            e.Handled = True
        End If
    End Sub
    Private Sub TxtPrenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrenom.KeyPress
        If Not Char.IsLetter(e.keychar) AndAlso e.KeyChar <> " " Then

            e.Handled = True
        End If
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

    Private Sub BtnAnn_Click(sender As Object, e As EventArgs) Handles BtnAnn.Click

    End Sub
End Class
