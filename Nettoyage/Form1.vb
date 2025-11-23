Public Class Form1
    Dim chsupp As String

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RbPan.CheckedChanged
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RbChemise.CheckedChanged
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RbRepa.CheckedChanged
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub BrnAjou_Click(sender As Object, e As EventArgs) Handles BrnAjou.Click
        Dim article As Article
        Dim test As Boolean = False

        For Each ctrl In GroupBoxVet.Controls
            If TypeOf ctrl Is RadioButton AndAlso CType(ctrl, RadioButton).Checked Then
                article.vetement = ctrl.text
                test = True
            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(GroupBoxVet, "veillez choisir un vetemen : ")
            Return
        End If

        test = False
        For Each ctrl In GroupBoxNett.Controls
            If TypeOf ctrl Is RadioButton AndAlso CType(ctrl, RadioButton).Checked Then
                article.typeNettoyage = ctrl.text
                test = True
            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(GroupBoxNett, "veillez choisir un vetement: ")
            Return
        End If

        Dim nb As Integer
        nb = CInt(NumericUpDownArticle.Value)
        If nb = 0 Then
            ErrorProvider1.SetError(GroupBoxNett, "veillez Donner un nombre  > 0  : ")
            Return
        End If

        article.nombre = nb
        article.initArticle()

        If ChDef.Checked Then
            article.supplement(0) = True
        End If
        If ChAnti.Checked Then
            article.supplement(1) = True
        End If

        AjouterArticle(article)
        MAJ_DGV()
    End Sub

    Private Sub MAJ_DGV()
        DataGridView1.Rows.Clear()
        For Each I In listeArticles
            Dim chsupp As String = ""
            If I.supplement(0) = True Then
                chsupp = "Defroissage "
            End If
            If I.supplement(1) = True Then
                chsupp = "Anti Tache"

            End If
            DataGridView1.Rows.Add(I.code, I.vetement, I.typeNettoyage, I.nombre, chsupp)
        Next
    End Sub

    Private Sub ChAnti_CheckedChanged(sender As Object, e As EventArgs) Handles ChAnti.CheckedChanged
    End Sub
End Class
