Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLigne.SelectedIndexChanged

    End Sub

    Private Sub BtnAjou_Click(sender As Object, e As EventArgs) Handles BtnAjou.Click
        Dim r As Resarvation
        If ComboBoxLigne.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBoxLigne, "veuillez selectionner une ligne .")
        End If
        r.ligne = ComboBoxLigne.Text
        If ComboBoxDepart.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBoxDepart, "veuillez selectionner une ville de depart .")
        End If
        r.villeDepart = ComboBoxDepart.Text
        If ComboBoxArrive.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBoxArrive, "veuillez selectionner une ville d'Arrive .")

        End If
        If ComboBoxArrive.Text = ComboBoxDepart.Text Then
            ErrorProvider1.SetError(ComboBoxArrive, "veuillez selectionner une ville de depart different de la ville d'arivve .")

        End If
        r.villeDepart = ComboBoxArrive.Text

    End Sub
End Class
