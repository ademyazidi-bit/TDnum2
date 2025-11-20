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
            If ctrl.Checked Then
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
            If ctrl.Checked Then
                article.vetement = ctrl.text
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
            GroupBoxSupp = v

        End If
        If ChAnti.Checked Then
            article.supplement(1) = True

        End If
        AjouterArticle(article)
        'init
        MAJ_DGV()
    End Sub
    Private Sub MAJ_DGV()

    End Sub

    Private Sub ChAnti_CheckedChanged(sender As Object, e As EventArgs) Handles ChAnti.CheckedChanged

    End Sub
End Class
