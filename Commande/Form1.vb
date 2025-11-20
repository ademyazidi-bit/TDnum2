Public Class Form1
    Dim prix As Double
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LbBoisson_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbBoisson.SelectedIndexChanged


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LbBoisson.Items.Add("jus d'orange")
        LbBoisson.Items.Add("Cafe")
        LbBoisson.Items.Add("Eau minerale")
        LbBoisson.Items.Add("Citronade")
    End Sub

    Private Sub BtnComm_Click(sender As Object, e As EventArgs) Handles BtnComm.Click
        Dim commande As String

        If RbPizza.Checked Then
            commande = "Pizza"
            prix = 10

        ElseIf RbBurger.Checked Then
            commande = "Burger"
            prix = 8
        Else
            commande = "Pate"
            prix = 15
        End If
        For Each ctrl In GrSupp.Controls
            If ctrl.Checked Then
                commande = commande + " " + ctrl.Text
                If ctrl.Text = "Fromage" Then
                    prix = prix + 2
                ElseIf ctrl.Text = "Frites" Then
                    prix = prix + 2
                ElseIf ctrl.Text = "Dessert" Then
                    prix = prix + 4

                End If
            End If
        Next

        commande = commande & " " & LbBoisson.SelectedItem
        prix = prix + 10
        LblAff.Text = commande & " ,Total : " & prix
    End Sub
End Class
